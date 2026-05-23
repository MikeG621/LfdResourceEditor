/*
 * LfdResourceEditor, All-in-one editor for the Lucasarts .LFD resource file format
 * Copyright (C) 2026 Michael Gaisser (mjgaisser@gmail.com)
 * Licensed under the MPL v2.0 or later.
 * 
 * Full notice in Program.cs
 * Version: 0.1+
 */

/* CHANGELOG
 * [UPD] Added working copy, Update now for pushing to LFD
 * v0.1, 260517
 * - created
 */

using Idmr.LfdReader;
using System;
using System.Windows.Forms;

namespace LfdResourceEditor
{
	public partial class TextForm : Form, IResourceForm
	{
		bool _isLoading;
		readonly bool _isReadOnly;
		readonly LfdFile _lfd;
		readonly Text _text;
		readonly Text _wrk = new Text();

		string _string = "";
		int _activeIndex = -1;

		public TextForm(LfdFile lfd, Text text, bool readOnly = false)
		{
			InitializeComponent();
			_lfd = lfd;
			_text = text;
			_wrk.DecodeResource(_text.RawData, false);
			if (readOnly) txtString.Enabled = false;
			Text = $"{_lfd.FileName} : {_text}";
			if (readOnly) Text += " (Read only)";
			foreach (string s in _wrk.Strings) lstStrings.Items.Add(s.Length > 12 ? s.Substring(0, 12) + "..." : s);
			_isReadOnly = readOnly;
		}

		void markDirty()
		{
			if (_isDirty) return;

			Text += "*";
			_wrk.Dirty();
		}

		private void TextForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!_isDirty) return;

			var response = MessageBox.Show($"Push updates to {_lfd.FileName}?", "Unsaved changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
			if (response == DialogResult.Cancel) e.Cancel = true;
			else if (response == DialogResult.Yes) cmdUpdate_Click("closing", new EventArgs());
		}

		private void cmdUpdate_Click(object sender, EventArgs e)
		{
			if (lblNewLength.Visible)
			{
				lblNewLength.Visible = false;
				lblOriginalLength.Text = $"Original length: {_string.Length}";
			}
			_wrk.EncodeResource();
			Text = Text.TrimEnd('*');
			_text.DecodeResource(_wrk.RawData, false);
			_text.Dirty();
			_parent.MarkDirty();
		}

		private void lstStrings_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lstStrings.SelectedIndex == -1 || _isLoading) return;

			_isLoading = true;
			_activeIndex = lstStrings.SelectedIndex;
			_string = _wrk.Strings[_activeIndex];
			txtString.Text = _string.Replace("\n\0", "\r\n").Replace("\0", "\r\n");
			lblOriginalLength.Text = $"Original length: {_text.Strings[_activeIndex].Length}";
			lblNewLength.Text = $"New length: {_string.Length}";
			lblNewLength.Visible = (_string != _text.Strings[_activeIndex]);
			_isLoading = false;
		}

		private void txtString_TextChanged(object sender, EventArgs e)
		{
			if (_isLoading || _activeIndex == -1 || _isReadOnly) return;

			_string = txtString.Text.Replace("\r\n", "\0").Replace("\0\0", "\0\n\0");
			lblNewLength.Text = $"New length: {_string.Length}";
			lblNewLength.Visible = true;
			_wrk.Strings[_activeIndex] = _string;
			markDirty();
		}

		#region IResourceForm members
		public void ForceClose()
		{
			Text = Text.TrimEnd('*');
			Close();
		}

		public LfdFile ParentLfd => _lfd;

		public Resource Resource => _text;
		#endregion

		MainForm _parent => MdiParent as MainForm;
		bool _isDirty => Text.EndsWith("*");
	}
}
