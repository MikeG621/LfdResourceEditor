/*
 * LfdResourceEditor, All-in-one editor for the Lucasarts .LFD resource file format
 * Copyright (C) 2026 Michael Gaisser (mjgaisser@gmail.com)
 * Licensed under the MPL v2.0 or later.
 * 
 * Full notice in Program.cs
 * Version: 0.1
 */

/* CHANGELOG
 * v0.1, YYMMDD
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
		readonly LfdFile _lfd;
		readonly Text _text;
		string _string = "";
		int _activeIndex = -1;

		public TextForm(LfdFile lfd, Text text)
		{
			InitializeComponent();
			_lfd = lfd;
			_text = text;
			Text = $"{_lfd.FileName} : {_text}";
			foreach (string s in _text.Strings) lstStrings.Items.Add(s.Length > 12 ? s.Substring(0, 12) + "..." : s);
		}

		void markDirty()
		{
			lblOriginalLength.Text = $"Original length: {_string.Length}";
			lblNewLength.Visible = false;
			if (_isDirty) return;

			Text += "*";
			_text.Dirty();
			_parent.MarkDirty();
		}

		private void TextForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!lblNewLength.Visible) return;
			
			var response = MessageBox.Show("Update with modified text?", "Unsaved changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
			if (response == DialogResult.Cancel) e.Cancel = true;
			else if (response == DialogResult.Yes) cmdUpdate_Click("lstStrings", new EventArgs());
		}

		private void cmdUpdate_Click(object sender, EventArgs e)
		{
			if (!lblNewLength.Visible || _activeIndex == -1) return;

			markDirty();
			_text.Strings[_activeIndex] = _string;
		}

		private void lstStrings_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lstStrings.SelectedIndex == -1 || _isLoading) return;

			if (lblNewLength.Visible)
			{
				var response = MessageBox.Show("Update with modified text?", "Unsaved changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
				if (response == DialogResult.Cancel)
				{
					_isLoading = true;
					lstStrings.SelectedIndex = _activeIndex;
					_isLoading = false;
					return;
				}
				if (response == DialogResult.Yes) cmdUpdate_Click("lstStrings", new EventArgs());
			}

			_isLoading = true;
			_activeIndex = lstStrings.SelectedIndex;
			_string = _text.Strings[_activeIndex];
			txtString.Text = _string.Replace("\n\0", "\r\n").Replace("\0", "\r\n");
			lblOriginalLength.Text = $"Original length: {_string.Length}";
			lblNewLength.Visible = false;
			_isLoading = false;
		}

		private void txtString_TextChanged(object sender, EventArgs e)
		{
			if (_isLoading || _activeIndex == -1) return;

			string str = txtString.Text.Replace("\r\n", "\0").Replace("\0\0", "\0\n\0");
			_string = str;
			lblNewLength.Visible = true;
			lblNewLength.Text = $"New length: {str.Length}";
		}

		#region IResourceForm members
		public void ForceClose()
		{
			lblNewLength.Visible = false;
			Close();
		}

		public LfdFile ParentLfd => _lfd;

		public Resource Resource => _text;

		#endregion

		MainForm _parent => MdiParent as MainForm;
		bool _isDirty => Text.EndsWith("*");
	}
}
