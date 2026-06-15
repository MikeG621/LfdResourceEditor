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
using System.IO;
using System.Windows.Forms;

namespace Idmr.LfdResourceEditor
{
	public partial class DeltForm : ResourceForm
	{
		readonly ColorPalette _palette;
		readonly ColorPalette _origPalette;
		readonly List<PlttEntry> _pltts = new List<PlttEntry>();
		Delt _wrk => (Delt)_working;
		Delt _delt => (Delt)_resource;

		public DeltForm(LfdFile lfd, Delt delt, MainForm mdiParent, bool readOnly = false) : base(lfd, delt, readOnly)
		{
			InitializeComponent();
			MdiParent = mdiParent;
			_working = new Delt();
			_wrk.DecodeResource(_delt.RawData, false);
			_isLoading = true;
			_palette = new Bitmap(1, 1, PixelFormat.Format8bppIndexed).Palette;
			_origPalette = new Bitmap(1, 1, PixelFormat.Format8bppIndexed).Palette;
			_wrk.Palette = _palette;
			numLeft.Value = _wrk.Left;
			numTop.Value = _wrk.Top;
			numWidth.Value = _wrk.Width;
			numHeight.Value = _wrk.Height;
			chkEdit.Enabled = !readOnly;
			cboTransparent.SelectedIndex = 0;
			if (_wrk.Width > 160 || _wrk.Height > 120) optZoom4.Enabled = false;
			if (_wrk.Width > 320 || _wrk.Height > 240) optZoom2.Enabled = false;
			loadPltts();
			_isLoading = false;
		}

		/// <summary>Clean up any resources being used.</summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			// TODO: Lfds should be disposable.
			if (disposing)
			{
				components?.Dispose();
				_pltts.Clear();
				_wrk.Image.Dispose();
			}
			//_wrk.Image = null;
			base.Dispose(disposing);
		}

		/// <summary>Push the working copy to <see cref="ResourceForm.Resource"/>.</summary>
		protected override void updateLfd()
		{
			_wrk.EncodeResource();
			_delt.DecodeResource(_wrk.RawData, false);
		}

		void applyPltt(Pltt pltt)
		{
			// NOTE: there are PLTTs that use FF00FF and 0000FF as either placeholders or "skip" markers, not sure.
			// if that gets figured out, will need to add that filtering here.
			for (int i = pltt.StartIndex; i < pltt.EndIndex; i++) _palette.Entries[i] = pltt.Entries[i];
		}

		void loadPltts()
		{
			bool needsEmpire = true;
			bool needsTourdesk = _lfd.FileName.StartsWith("BATTLE", StringComparison.InvariantCultureIgnoreCase); // look into BATTLE for XW
			bool needsLaunch = _lfd.FileName.StartsWith("SHIP", StringComparison.InvariantCultureIgnoreCase); // look into SHIPS for XW
			bool loading = _isLoading;
			_isLoading = true;
			lstPltts.DataSource = null;
			_pltts.Clear();
			foreach (LfdFile lfd in (MdiParent as MainForm).OpenedLfds)
			{
				foreach (Resource res in lfd.Resources)
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

		void refresh()
		{
			_origPalette.Entries.CopyTo(_palette.Entries, 0);
			foreach (PlttEntry item in lstApplied.Items) applyPltt(item.Pltt);
			if (cboTransparent.SelectedIndex == 0) _palette.Entries[0] = Color.Transparent;
			else if (cboTransparent.SelectedIndex == 2) _palette.Entries[0] = Color.Fuchsia;
			else if (cboTransparent.SelectedIndex == 3) _palette.Entries[0] = Color.Blue;
			_wrk.Palette = _palette;
			pctImage.Invalidate();
		}

		void shiftApplied(int direction)
		{
			int ind = lstApplied.SelectedIndex;
			(lstApplied.Items[ind], lstApplied.Items[ind + direction]) = (lstApplied.Items[ind + direction], lstApplied.Items[ind]);
			lstApplied.SelectedIndex = ind + direction;
			refresh();
		}

		readonly struct PlttEntry
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
		private void btnExport_Click(object sender, EventArgs e)
		{
			savImage.FileName = $"{Path.GetFileNameWithoutExtension(_lfd.FileName)}-{_wrk.Name}";
			var response = savImage.ShowDialog();
			if (response != DialogResult.OK) return;

			_wrk.Image.Save(savImage.FileName, ImageFormat.Bmp);
			// Reminder: the exported palette may not match exactly
		}
		private void btnImport_Click(object sender, EventArgs e)
		{
			var response = opnImage.ShowDialog();
			if (response != DialogResult.OK) return;


		}
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

		private void pctImage_Paint(object sender, PaintEventArgs e)
		{
			var g = e.Graphics;
			g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
			g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
			int scale = 1;
			if (optZoom2.Checked) scale = 2;
			else if (optZoom4.Checked) scale = 4;
			int left = (pctImage.Width - _wrk.Width * scale) / 2;
			int top = (pctImage.Height - _wrk.Height * scale) / 2;
			g.DrawImage(_wrk.Image, left, top, _wrk.Width * scale, _wrk.Height * scale);
		}
	}
}
