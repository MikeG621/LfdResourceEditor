/*
 * LfdResourceEditor, All-in-one editor for the Lucasarts .LFD resource file format
 * Copyright (C) 2026 Michael Gaisser (mjgaisser@gmail.com)
 * Licensed under the MPL v2.0 or later.
 * 
 * Full notice in Program.cs
 * Version: 0.1+
 */

/* CHANGELOG
 * [UPD] Refactored to ResourceForm
 * [UPD] Added working copy, Update now for pushing to LFD
 * v0.1, 260517
 * - created
 */

using Idmr.LfdReader;
using System;

namespace Idmr.LfdResourceEditor
{
	public partial class TextForm : ResourceForm
	{
		string _string = "";
		int _activeIndex = -1;
		Text _wrk => (Text)_working;
		Text _text => (Text)_resource;

		public TextForm(LfdFile lfd, Text text, bool readOnly = false) : base(lfd, text, readOnly)
		{
			InitializeComponent();
			_working = new Text();
			_wrk.DecodeResource(_text.RawData, false);
			txtString.ReadOnly = _isReadOnly;
			foreach (string s in _wrk.Strings) lstStrings.Items.Add(s.Length > 12 ? s.Substring(0, 12) + "..." : s);
		}

		protected override void updateLfd()
		{
			if (lblNewLength.Visible)
			{
				lblNewLength.Visible = false;
				lblOriginalLength.Text = $"Original length: {_string.Length}";
			}
			_wrk.EncodeResource();
			_text.DecodeResource(_wrk.RawData, false);
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
			if (_isLoading || _activeIndex == -1) return;

			_string = txtString.Text.Replace("\r\n", "\0").Replace("\0\0", "\0\n\0");
			lblNewLength.Text = $"New length: {_string.Length}";
			lblNewLength.Visible = true;
			_wrk.Strings[_activeIndex] = _string;
			markDirty();
		}
	}
}
