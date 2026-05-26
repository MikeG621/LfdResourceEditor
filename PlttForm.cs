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

namespace Idmr.LfdResourceEditor
{
	public partial class PlttForm : ResourceForm
	{
		readonly Panel[] pnlColors = new Panel[256];
		int _rotFrame;
		Pltt _wrk => (Pltt)_working;
		Pltt _pltt => (Pltt)_resource;
		int _currentRotator => (int)numRotatorIndex.Value;

		public PlttForm(LfdFile lfd, Pltt pltt, bool readOnly = false) : base(lfd, pltt, readOnly)
		{
			InitializeComponent();
			_working = new Pltt();
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
			_isLoading = true;
			numStartIndex.Value = _wrk.StartIndex;
			numEndIndex.Value = _wrk.EndIndex;
			numRotators.Value = _wrk.RotatorCount;
			numRotatorStart.Maximum = numRotatorEnd.Maximum = numEndIndex.Value;
			numRotatorStart.Minimum = numRotatorEnd.Minimum = numStartIndex.Value;
			_isLoading = false;
		}

		protected override void updateLfd()
		{
			_wrk.EncodeResource();
			_pltt.DecodeResource(_wrk.RawData, false);
		}

		private void btnPlay_Click(object sender, System.EventArgs e)
		{
			if (tmrRotator.Enabled)
			{
				tmrRotator.Enabled = false;
				btnPlay.Text = "&Play";
				var rot = _wrk.Rotators[_currentRotator];
				for (int i = 0; i < rot.RotatedColors.Length; i++)
					pnlColors[rot.StartIndex + i].BackColor = _wrk.Entries[rot.StartIndex + i];
			}
			else
			{
				tmrRotator.Enabled = true;
				_rotFrame = 0;
				btnPlay.Text = "&Stop";
			}
		}

		private void grpRotators_EnabledChanged(object sender, System.EventArgs e)
		{
			if (!grpRotators.Enabled) return;

			numRotatorIndex_ValueChanged("grpRotators", new EventArgs());
		}
		private void numFrameDivider_ValueChanged(object sender, EventArgs e)
		{
			lblFrames.Text = $"= {_wrk.Rotators[_currentRotator].CycleFrequency} Frames";
		}
		private void numRotators_ValueChanged(object sender, System.EventArgs e)
		{
			grpRotators.Enabled = numRotators.Value > 0;
			numRotatorIndex.Maximum = numRotators.Value - 1;
		}
		private void numRotatorIndex_ValueChanged(object sender, EventArgs e)
		{
			if (numRotators.Value == 0) return;

			if (tmrRotator.Enabled) btnPlay_Click("numRotatorIndex", new EventArgs());
			bool btemp = _isLoading;
			_isLoading = true;
			numRotatorStart.Value = _wrk.Rotators[_currentRotator].StartIndex;
			numRotatorEnd.Value = _wrk.Rotators[_currentRotator].EndIndex;
			numFrameDivider.Value = _wrk.Rotators[_currentRotator].FrameDivider;
			_isLoading = btemp;
		}

		private void pnlColors_Click(object sender, System.EventArgs e)
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
		private void pnlColors_MouseEnter(object sender, System.EventArgs e)
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
	}
}
