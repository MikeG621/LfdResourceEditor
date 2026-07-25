/*
 * LfdResourceEditor, All-in-one editor for the Lucasarts .LFD resource file format
 * Copyright (C) 2026 Michael Gaisser (mjgaisser@gmail.com)
 * Licensed under the MPL v2.0 or later.
 * 
 * Full notice in Program.cs
 * Version: 0.1+
 */

/* CHANGELOG
 * v0.2, xxxxxx
 * - created
 */

using Idmr.LfdReader;
using Idmr.LfdResourceEditor.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;

namespace Idmr.LfdResourceEditor
{
	/// <summary>Represents the base form for ANIM and DELT.</summary>
	public partial class ImageForm : ResourceForm
	{
		protected readonly ColorPalette _palette;
		protected readonly ColorPalette _origPalette;
		protected readonly List<PlttEntry> _pltts = new List<PlttEntry>();

		/// <summary>COMPILER USE ONLY</summary>
		protected ImageForm() => InitializeComponent();
		public ImageForm(LfdFile lfd, Anim anim, MainForm mdiParent, bool readOnly = false) : base(lfd, anim, readOnly)
		{
			InitializeComponent();
			MdiParent = mdiParent;
			_isLoading = true;
			_palette = new Bitmap(1, 1, PixelFormat.Format8bppIndexed).Palette;
			_origPalette = new Bitmap(1, 1, PixelFormat.Format8bppIndexed).Palette;
			chkEdit.Enabled = !readOnly;
			cboTransparent.SelectedIndex = 0;
			loadPltts();
			_isLoading = false;
		}
		public ImageForm(LfdFile lfd, Delt delt, MainForm mdiParent, bool readOnly = false) : base(lfd, delt, readOnly)
		{
			InitializeComponent();
			MdiParent = mdiParent;
			_isLoading = true;
			_palette = new Bitmap(1, 1, PixelFormat.Format8bppIndexed).Palette;
			_origPalette = new Bitmap(1, 1, PixelFormat.Format8bppIndexed).Palette;
			chkEdit.Enabled = !readOnly;
			cboTransparent.SelectedIndex = 0;
			loadPltts();
			_isLoading = false;
		}

		protected void loadPltts()
		{
			bool needsEmpire = true;
			bool needsTourdesk = _lfd.FileName.StartsWith("BATTLE", StringComparison.InvariantCultureIgnoreCase); // look into BATTLE for XW
			bool needsLaunch = _lfd.FileName.StartsWith("SHIP", StringComparison.InvariantCultureIgnoreCase); // look into SHIPS for XW
			bool loading = _isLoading;
			_isLoading = true;
			lstPltts.DataSource = null;
			_pltts.Clear();
			foreach (var lfd in (MdiParent as MainForm).OpenedLfds)
			{
				foreach (var res in lfd.Resources)
					if (res.Type == Resource.ResourceType.Pltt) _pltts.Add(new PlttEntry(lfd, (Pltt)res));
				if (lfd.Name.Equals("EMPIRE", StringComparison.InvariantCultureIgnoreCase)) needsEmpire = false;
				if (lfd.Name.Equals("TOURDESK", StringComparison.InvariantCultureIgnoreCase)) needsTourdesk = false;
				if (lfd.Name.Equals("LAUNCH", StringComparison.InvariantCultureIgnoreCase)) needsLaunch = false;
			}
			if (needsEmpire)
			{
				var temp = new Pltt();
				temp.DecodeResource(Resources.standard, false);
				_pltts.Add(new PlttEntry(null, temp, "*EMPIRE:standard"));
			}
			if (needsTourdesk)
			{
				var temp = new Pltt();
				temp.DecodeResource(Resources.toddesk, false);
				_pltts.Add(new PlttEntry(null, temp, "*TOURDESK:toddesk"));
			}
			if (needsLaunch)
			{
				var temp = new Pltt();
				temp.DecodeResource(Resources.ls1_red1, false);
				_pltts.Add(new PlttEntry(null, temp, "*LAUNCH:ls1-red1"));
				temp = new Pltt();
				temp.DecodeResource(Resources.launch, false);
				_pltts.Add(new PlttEntry(null, temp, "*LAUNCH:launch"));
				temp = new Pltt();
				temp.DecodeResource(Resources.ls1_gry0, false);
				_pltts.Add(new PlttEntry(null, temp, "*LAUNCH:ls1-gry0"));
				temp = new Pltt();
				temp.DecodeResource(Resources.l_bg_bay, false);
				_pltts.Add(new PlttEntry(null, temp, "*LAUNCH:l-bg-bay"));
			}
			lstPltts.DataSource = _pltts;
			lstPltts.DisplayMember = "Display";
			lstPltts.ValueMember = "Pltt";
			_isLoading = loading;
		}

		/// <summary>MUST OVERRIDE. Reset palette and repaint the view.</summary>
		/// <exception cref="NotImplementedException"></exception>
		protected virtual void refresh() => throw new NotImplementedException();

		void shiftApplied(int direction)
		{
			int ind = lstApplied.SelectedIndex;
			(lstApplied.Items[ind], lstApplied.Items[ind + direction]) = (lstApplied.Items[ind + direction], lstApplied.Items[ind]);
			lstApplied.SelectedIndex = ind + direction;
			refresh();
		}

		protected readonly struct PlttEntry
		{
			public PlttEntry(LfdFile lfd, Pltt pltt) : this(lfd, pltt, $"{lfd.Name}:{pltt.Name}") { }
			public PlttEntry(LfdFile lfd, Pltt pltt, string displayOverride)
			{
				Lfd = lfd;
				Pltt = pltt;
				Display = displayOverride;
			}

			public LfdFile Lfd { get; }
			public Pltt Pltt { get; }
			public string Display { get; }

			public override string ToString() => Display;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (lstPltts.SelectedIndex == -1) return;

			lstApplied.Items.Add(lstPltts.SelectedItem);
			refresh();
		}
		private void btnDown_Click(object sender, EventArgs e) { if (lstApplied.SelectedIndex < lstApplied.Items.Count - 1) shiftApplied(1); }
		private void btnReload_Click(object sender, EventArgs e) => loadPltts();
		private void btnRemove_Click(object sender, EventArgs e)
		{
			if (lstApplied.SelectedIndex == -1) return;

			lstApplied.Items.Remove(lstApplied.SelectedItem);
			refresh();
		}
		private void btnUp_Click(object sender, EventArgs e) { if (lstApplied.SelectedIndex > 0) shiftApplied(-1); }

		private void cboTransparent_SelectedIndexChanged(object sender, EventArgs e) => refresh();

		private void lstApplied_DoubleClick(object sender, EventArgs e) => btnRemove_Click(sender, e);
		private void lstPltts_DoubleClick(object sender, EventArgs e) => btnAdd_Click(sender, e);

		private void optZoom_CheckedChanged(object sender, EventArgs e) => pctImage.Invalidate();
	}
}
