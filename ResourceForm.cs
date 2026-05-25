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
	/// <summary>Represents the base Form used for all resources.</summary>
	public partial class ResourceForm : Form
	{
		/// <summary>Loading flag to skip UI changes.</summary>
		protected bool _isLoading;
		/// <summary>Flag to prevent making changes.</summary>
		protected readonly bool _isReadOnly;
		protected readonly LfdFile _lfd;
		/// <summary>Original resource, inherited forms should define a cast accessor.</summary>
		protected readonly Resource _resource;
		/// <summary>Working copy of the original, inherited forms should define a cast accessor.</summary>
		protected Resource _working = null;
		bool _isDirty => Text.EndsWith("*");
		MainForm _parent => MdiParent as MainForm;

		/// <summary>COMPILER USE ONLY</summary>
		protected ResourceForm() => InitializeComponent();
		/// <summary>Performs the common initialization.</summary>
		/// <param name="lfd">The parent LFD.</param>
		/// <param name="resource">The resource to load.</param>
		/// <param name="readOnly">If editing is prevented.</param>
		public ResourceForm(LfdFile lfd, Resource resource, bool readOnly = false)
		{
			InitializeComponent();
			_lfd = lfd;
			_resource = resource;
			_isReadOnly = readOnly;
			Text = $"{_lfd.FileName} : {_resource}";
			if (readOnly) Text += " (Read only)";
		}

		/// <summary>Allows the form to close bypassing the dirty check.</summary>
		public void ForceClose()
		{
			Text = Text.TrimEnd('*');
			Close();
		}

		/// <summary>Marks the form dirty, and ensures the working resource is dirtied.</summary>
		protected void markDirty()
		{
			if (_isDirty) return;

			Text += "*";
			_working.Dirty();
		}

		/// <summary>MUST OVERRIDE. Use to push the working copy to the original resource.</summary>
		/// <exception cref="NotImplementedException"></exception>
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

		/// <summary>Gets a reference to the source LFD.</summary>
		public LfdFile ParentLfd => _lfd;
		
		/// <summary>Gets a reference to the original resource.</summary>
		public Resource Resource => _resource;
	}
}
