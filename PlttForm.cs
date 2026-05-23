/*
 * LfdResourceEditor, All-in-one editor for the Lucasarts .LFD resource file format
 * Copyright (C) 2026 Michael Gaisser (mjgaisser@gmail.com)
 * Licensed under the MPL v2.0 or later.
 * 
 * Full notice in Program.cs
 * Version: 0.1+
 */

/* CHANGELOG
 * v0.2, XXXXXX
 * - created
 */

using Idmr.LfdReader;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LfdResourceEditor
{
	// currently only allows editing of the colors, cannot change the pltt size or limits.
	public partial class PlttForm : Form, IResourceForm
	{
		bool _isLoading;
		readonly bool _isReadOnly;
		readonly LfdFile _lfd;
		readonly Pltt _pltt;
		readonly Pltt _wrk = new Pltt();

		readonly Panel[] pnlColors = new Panel[256];
		int _rotFrame;

		public PlttForm(LfdFile lfd, Pltt pltt, bool readOnly = false)
		{
			InitializeComponent();
			_lfd = lfd;
			_pltt = pltt;
			_wrk.DecodeResource(_pltt.RawData, false);
			#region create swatches
			pnlColors[0] = pnlClr0;
			pnlColors[0].Size = new Size(16, 16);
			pnlColors[0].Tag = 0;
			for (int i = 1; i < pnlColors.Length; i++)
			{
				pnlColors[i] = new Panel
				{
					Size = pnlClr0.Size,
					Left = pnlClr0.Left + (i % 16) * 16,
					Top = pnlClr0.Top + (i / 16) * 16,
					Tag = i
				};
				pnlColors[i].Click += pnlColors_Click;
				pnlColors[i].MouseEnter += pnlColors_MouseEnter;
				Controls.Add(pnlColors[i]);
			}
			for (int i = _wrk.StartIndex; i <= _wrk.EndIndex; i++) pnlColors[i].BackColor = _wrk.Entries[i];
			#endregion
			Text = $"{_lfd.FileName} : {_pltt}";
			if (readOnly) Text += " (Read only)";
			_isLoading = true;
			numStartIndex.Value = _wrk.StartIndex;
			numEndIndex.Value = _wrk.EndIndex;
			numRotators.Value = _wrk.RotatorCount;
			numRotatorStart.Maximum = numRotatorEnd.Maximum = numEndIndex.Value;
			numRotatorStart.Minimum = numRotatorEnd.Minimum = numStartIndex.Value;
			_isLoading = false;
			_isReadOnly = readOnly;
		}

		void markDirty()
		{
			if (_isDirty) return;

			Text += "*";
			_wrk.Dirty();
		}

		#region IResourceForm members
		public LfdFile ParentLfd => _lfd;

		public Resource Resource => _pltt;

		public void ForceClose()
		{
			Text = Text.TrimEnd('*');
			Close();
		}
		#endregion

		MainForm _parent => MdiParent as MainForm;
		bool _isDirty => Text.EndsWith("*");
		int _currentRotator => (int)numRotatorIndex.Value;

		private void cmdPlay_Click(object sender, EventArgs e)
		{
			if (tmrRotator.Enabled)
			{
				tmrRotator.Enabled = false;
				cmdPlay.Text = "&Play";
				var rot = _wrk.Rotators[_currentRotator];
				for (int i = 0; i < rot.RotatedColors.Length; i++)
					pnlColors[rot.StartIndex + i].BackColor = _wrk.Entries[rot.StartIndex + i];
			}
			else
			{
				tmrRotator.Enabled = true;
				_rotFrame = 0;
				cmdPlay.Text = "&Stop";
			}
		}

		private void numRotators_ValueChanged(object sender, EventArgs e)
		{
			grpRotators.Enabled = numRotators.Value > 0;
			numRotatorIndex.Maximum = numRotators.Value - 1;
		}

		private void grpRotators_EnabledChanged(object sender, EventArgs e)
		{
			if (!grpRotators.Enabled) return;

			numRotatorIndex_ValueChanged("grpRotators", new EventArgs());
		}

		private void numRotatorIndex_ValueChanged(object sender, EventArgs e)
		{
			if (numRotators.Value == 0) return;

			if (tmrRotator.Enabled) cmdPlay_Click("numRotatorIndex", new EventArgs());
			bool btemp = _isLoading;
			_isLoading = true;
			numRotatorStart.Value = _wrk.Rotators[_currentRotator].StartIndex;
			numRotatorEnd.Value = _wrk.Rotators[_currentRotator].EndIndex;
			numFrameDivider.Value = _wrk.Rotators[_currentRotator].FrameDivider;
			_isLoading = btemp;
		}

		private void numFrameDivider_ValueChanged(object sender, EventArgs e)
		{
			lblFrames.Text = $"= {_wrk.Rotators[_currentRotator].CycleFrequency} Frames";
		}

		private void pnlColors_Click(object sender, EventArgs e)
		{
			if (!(sender is Panel)) return;

			var pnl = sender as Panel;
			int i = (int)pnl.Tag;
			if (i < _wrk.StartIndex || i > _wrk.EndIndex) return;

			clrDlg.Color = _wrk.Entries[i];
			var response = clrDlg.ShowDialog();
			if (response != DialogResult.OK || _isReadOnly) return;

			_wrk.Entries[i] = clrDlg.Color;
			pnlColors[i].BackColor = clrDlg.Color;
			markDirty();
		}
		private void pnlColors_MouseEnter(object sender, EventArgs e)
		{
			if (!(sender is Panel)) return;

			var pnl = sender as Panel;
			int i = (int)pnl.Tag;
			if (i < _wrk.StartIndex || i > _wrk.EndIndex) return;

			lblColor.Text = $"Index: {i}, R: {_wrk.Entries[i].R}, G: {_wrk.Entries[i].G}, B: {_wrk.Entries[i].B}";
		}

		private void tmrRotator_Tick(object sender, EventArgs e)
		{
			_rotFrame++;
			var rot = _wrk.Rotators[_currentRotator];
			if (_rotFrame != rot.CycleFrequency) return;
			
			_rotFrame = 0;
			rot.RotateColors();
			for (int i = 0; i < rot.RotatedColors.Length; i++)
				pnlColors[rot.StartIndex + i].BackColor = rot.RotatedColors[i];
		}

		private void PlttForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!_isDirty) return;
			
			var response = MessageBox.Show($"Push updates to {_lfd.FileName}?", "Unsaved changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
			if (response == DialogResult.Cancel) e.Cancel = true;
			else if (response == DialogResult.Yes) cmdUpdate_Click("closing", new EventArgs());
		}

		private void cmdUpdate_Click(object sender, EventArgs e)
		{
			_wrk.EncodeResource();
			Text = Text.TrimEnd('*');
			_pltt.DecodeResource(_wrk.RawData, false);
			_pltt.Dirty();
			_parent.MarkDirty();
		}
	}
}
