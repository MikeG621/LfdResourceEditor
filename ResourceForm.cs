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
using System.Windows.Forms;

namespace Idmr.LfdResourceEditor
{
	public partial class ResourceForm : Form
	{
		protected bool _isLoading;
		protected readonly bool _isReadOnly;
		protected readonly LfdFile _lfd;
		protected readonly Resource _resource;
		protected Resource _working = null;
		bool _isDirty => Text.EndsWith("*");
		MainForm _parent => MdiParent as MainForm;

		protected ResourceForm() => InitializeComponent();
		public ResourceForm(LfdFile lfd, Resource resource, bool readOnly = false)
		{
			InitializeComponent();
			_lfd = lfd;
			_resource = resource;
			_isReadOnly = readOnly;
			Text = $"{_lfd.FileName} : {_resource}";
			if (readOnly) Text += " (Read only)";
		}

		protected void markDirty()
		{
			if (_isDirty) return;

			Text += "*";
			_working.Dirty();
		}

		protected virtual void updateLfd() => throw new NotImplementedException();

		private void ResourceForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!_isDirty) return;

			var response = MessageBox.Show($"Push updates to {_lfd.FileName}?", "Unsaved changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
			if (response == DialogResult.Cancel) e.Cancel = true;
			else if (response == DialogResult.Yes) cmdUpdate_Click("closing", new EventArgs());
		}

		private void cmdUpdate_Click(object sender, EventArgs e)
		{
			updateLfd();
			_resource.Dirty();
			_parent.MarkDirty();
			Text = Text.TrimEnd('*');
		}

		#region IResourceForm members
		public void ForceClose()
		{
			Text = Text.TrimEnd('*');
			Close();
		}

		public LfdFile ParentLfd => _lfd;

		public Resource Resource => _resource;
		#endregion
	}
}
