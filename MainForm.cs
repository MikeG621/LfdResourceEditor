/*
 * LfdResourceEditor, All-in-one editor for the Lucasarts .LFD resource file format
 * Copyright (C) 2026 Michael Gaisser (mjgaisser@gmail.com)
 * Licensed under the MPL v2.0 or later.
 * 
 * Full notice in Program.cs
 * Version: 0.1+
 */

/* CHANGELOG
 * [NEW] resource export
 * v0.1, 260517
 * - created
 */

using Idmr.LfdReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace Idmr.LfdResourceEditor
{
	public partial class MainForm : Form
	{
		bool _isLoading;
		LfdFile _lfd;
		readonly List<LfdFile> _files = new List<LfdFile>();

		public MainForm()
		{
			InitializeComponent();
		}

		void clearDirty() => miFileSave.Enabled = miFileSaveAll.Enabled = false;

		void closeLfd(LfdFile lfd)
		{
			int index;
			for (index = 0; index < _files.Count; index++) if (_files[index] == lfd) break;
			if (index == _files.Count) return;

			foreach(ResourceForm frm in MdiChildren)
				if (frm.ParentLfd == _files[index]) frm.ForceClose();
			_files.RemoveAt(index);
			cboOpenedLfds.Items.RemoveAt(index);
			if (index < _files.Count) cboOpenedLfds.SelectedIndex = index;
			else if (_files.Count > 0) cboOpenedLfds.SelectedIndex = _files.Count - 1;
			else reset();
		}

		void loadLfd(string path)
		{
			string fileName = Path.GetFileName(path);
			for (int i = 0; i < cboOpenedLfds.Items.Count; i++)
				if (cboOpenedLfds.Items[i].ToString().TrimEnd('*') == fileName)
				{
					cboOpenedLfds.SelectedIndex = i;
					return;
				}

			loadLfd(new LfdFile(path));
			_files.Add(_lfd);
			cboOpenedLfds.Items.Add(_lfd.FileName);
			cboOpenedLfds.SelectedIndex = _files.Count - 1;
		}
		void loadLfd(LfdFile lfd)
		{
			clearDirty();
			_lfd = lfd;
			lstResources.Items.Clear();
			foreach (Resource r in _lfd.Resources) lstResources.Items.Add(r.ToString());
			if (ActiveMdiChild != null && (ActiveMdiChild as ResourceForm).ParentLfd != _lfd)
				foreach (ResourceForm frm in MdiChildren)
					if (frm.ParentLfd == _lfd)
					{
						frm.Select(); // just switch to the first one
						break;
					}
			Text = $"LFD Resource Editor - {_lfd.FileName}";
			if (_lfd.IsModified) MarkDirty();
		}

		void reset()
		{
			_files.Clear();
			cboOpenedLfds.Items.Clear();
			foreach (ResourceForm frm in MdiChildren) frm.ForceClose();
			_lfd = null;
			miFileSave.Enabled = false;
			lstResources.Items.Clear();
			Text = "LFD Resource Editor";
			clearDirty();
		}

		internal void MarkDirty()
		{
			miFileSave.Enabled = miFileSaveAll.Enabled = true;
			if (!Text.EndsWith("*")) Text += "*";
			_isLoading = true;
			for (int i = 0; i < _files.Count; i++)
				if (_files[i] == _lfd) cboOpenedLfds.Items[i] = _lfd.FileName + "*";
			_isLoading = false;
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!_isDirty) return;

			var response = MessageBox.Show("Opened LFDs have unsaved changes. Save to disk?", "Unsaved changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
			if (response == DialogResult.Cancel) e.Cancel = true;
			else if (response == DialogResult.Yes) miFileSaveAll_Click("Closing", new EventArgs());
		}
		private void MainForm_MdiChildActivate(object sender, EventArgs e)
		{
			if (ActiveMdiChild == null) return;

			loadLfd((ActiveMdiChild as ResourceForm).ParentLfd);
		}

		private void cboOpenedLfds_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (_isLoading || cboOpenedLfds.SelectedIndex == -1) return;

			loadLfd(_files[cboOpenedLfds.SelectedIndex]);
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0220:Add explicit cast", Justification = "implicit is fine")]
		private void lstResources_DoubleClick(object sender, EventArgs e)
		{
			if (lstResources.SelectedIndex == -1) return;

			var res = _lfd.Resources[lstResources.SelectedIndex];

			foreach (ResourceForm frm in MdiChildren)
				if (frm.Resource == res)
				{
					frm.Select();
					return;
				}

			Form resFrm;
			switch (res.Type)
			{
				case Resource.ResourceType.Anim:
					// TODO: ANIM
					break;
				case Resource.ResourceType.Blas:
				case Resource.ResourceType.Voic:
					resFrm = new BlasForm(_lfd, (Blas)res) { MdiParent = this };
					resFrm.Show();
					break;
				case Resource.ResourceType.Delt:
					resFrm = new DeltForm(_lfd, (Delt)res) { MdiParent = this };
					resFrm.Show();
					break;
				case Resource.ResourceType.Font:
					resFrm = new FontForm(_lfd, (LfdReader.Font)res) { MdiParent = this };
					resFrm.Show();
					break;
				case Resource.ResourceType.Pltt:
					resFrm = new PlttForm(_lfd, (Pltt)res) { MdiParent = this };
					resFrm.Show();
					break;
				case Resource.ResourceType.Text:
					resFrm = new TextForm(_lfd, (Text)res) { MdiParent = this };
					resFrm.Show();
					break;
			}
		}
		private void lstResources_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lstResources.SelectedIndex == -1) return;

			var res = _lfd.Resources[lstResources.SelectedIndex];

			foreach (ResourceForm frm in MdiChildren)
				if (frm.Resource == res) frm.Select();
		}

		private void miFileOpen_Click(object sender, EventArgs e) => opnLfd.ShowDialog();
		private void miFileSave_Click(object sender, EventArgs e)
		{
			if (!_lfd.IsModified) return;

			_isLoading = true;
			_lfd.Write();
			cboOpenedLfds.Items[cboOpenedLfds.SelectedIndex] = _lfd.FileName;
			foreach (ResourceForm frm in MdiChildren)
				if (frm.ParentLfd == _lfd) frm.Text = frm.Text.TrimEnd('*');
			Text = Text.TrimEnd('*');
			_isLoading = false;

		}
		private void miFileSaveAll_Click(object sender, EventArgs e)
		{
			if (!_isDirty) return;

			_isLoading = true;
			for (int i = 0; i < _files.Count; i++)
			{
				if (!_files[i].IsModified) continue;

				cboOpenedLfds.Items[i] = _files[i].FileName;
				_files[i].Write();
			}
			foreach (Form frm in MdiChildren) frm.Text = frm.Text.TrimEnd('*');
			Text = Text.TrimEnd('*');
			_isLoading = false;
		}
		private void miFileQuit_Click(object sender, EventArgs e) => Close();

		private void miResourceClose_Click(object sender, EventArgs e) => ActiveMdiChild.Close();
		private void miResourceExport_Click(object sender, EventArgs e)
		{
			if (ActiveMdiChild == null) return;

			var res = (ActiveMdiChild as ResourceForm).Resource;
			savResource.DefaultExt = res.Type.ToString().ToLower();
			savResource.FileName = $"{Path.GetFileNameWithoutExtension(_lfd.FileName)}-{res.Name}";
			var response = savResource.ShowDialog();
			if (response != DialogResult.OK) return;

			using ( FileStream fs = File.OpenWrite(savResource.FileName) )
			{
				BinaryWriter bw = new BinaryWriter(fs);
				bw.Write(res.RawData);
				fs.Close();
			}
		}

		private void miLfdClose_Click(object sender, EventArgs e)
		{
			if (cboOpenedLfds.SelectedIndex == -1) return;

			if (_lfd.IsModified)
			{
				var response = MessageBox.Show(_lfd.FileName + " has unsaved changes. Save to disk?", "Unsaved changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
				if (response == DialogResult.Cancel) return;

				if (response == DialogResult.Yes) miFileSave_Click("Close", new EventArgs());
			}

			closeLfd(_lfd);
		}
		private void miLfdCloseAll_Click(object sender, EventArgs e)
		{
			if (_files.Count == 0) return;

			if (_isDirty)
			{
				var response = MessageBox.Show("Opened LFDs have unsaved changes. Save to disk?", "Unsaved changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
				if (response == DialogResult.Cancel) return;

				if (response == DialogResult.Yes) miFileSaveAll_Click("CloseAll", new EventArgs());
			}

			reset();
		}

		private void opnLfd_FileOk(object sender, CancelEventArgs e)
		{
			loadLfd(opnLfd.FileName); // TODO: read-only functionality
		}

		bool _isDirty
		{
			get
			{
				bool dirty = false;
				foreach (LfdFile lfd in _files) dirty |= lfd.IsModified;
				return dirty;
			}
		}

		/// <summary>Gets an array of all currently opened LFDs.</summary>
		public LfdFile[] OpenedLfds => _files.ToArray();
	}
}
