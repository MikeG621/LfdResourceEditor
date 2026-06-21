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
		int _activeIndex = -1;
		Text _wrk => (Text)_working;
		Text _text => (Text)_resource;

		public TextForm(LfdFile lfd, Text text, bool readOnly = false) : base(lfd, text, readOnly)
		{
			InitializeComponent();
			_working = new Text();
			_wrk.DecodeResource(_text.RawData, false);
			txtString.ReadOnly = _isReadOnly;
			foreach (var s in _wrk.Strings) lstStrings.Items.Add(s.Value.Length > 12 ? s.Value.Substring(0, 12) + "..." : s.Value);
		}

		/// <summary>Clean up any resources being used.</summary>
		/// <param name="disposing"><see langword="true"/> if managed resources should be disposed; otherwise, <see langword="false"/>.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				components?.Dispose();
				_wrk.Dispose();
			}
			_working = null;
			base.Dispose(disposing);
		}

		protected override void updateLfd()
		{
			if (lblNewLength.Visible)
			{
				lblNewLength.Visible = false;
				lblOriginalLength.Text = $"Original length: {_activeString.Length}";
			}
			_wrk.EncodeResource();
			_text.DecodeResource(_wrk.RawData, false);
		}

		private void lstStrings_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lstStrings.SelectedIndex == -1 || _isLoading) return;

			_isLoading = true;
			_activeIndex = lstStrings.SelectedIndex;
			txtString.Text = _activeString.FormattedValue;
			lblOriginalLength.Text = $"Original length: {_text.Strings[_activeIndex].Length}";
			lblNewLength.Text = $"New length: {_activeString.Length}";
			lblNewLength.Visible = !_text.Strings[_activeIndex].Value.Equals(_activeString.Value, StringComparison.Ordinal);
			_isLoading = false;
		}

		private void txtString_TextChanged(object sender, EventArgs e)
		{
			if (_isLoading || _activeIndex == -1) return;

			_activeString.FormattedValue = txtString.Text;
			lblNewLength.Text = $"New length: {_activeString.Length}";
			lblNewLength.Visible = true;
			markDirty();
		}

		Text.TextString _activeString => _wrk.Strings[_activeIndex];
	}
}
