/*
 * LfdResourceEditor, All-in-one editor for the Lucasarts .LFD resource file format
 * Copyright (C) 2026 Michael Gaisser (mjgaisser@gmail.com)
 * Licensed under the MPL v2.0 or later.
 * 
 * Full notice in Program.cs
 * Version: 0.2
 */

/* CHANGELOG
 * v0.2, 260801
 * - created
 */

using Idmr.LfdReader;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Idmr.LfdResourceEditor
{
	public partial class DeltForm : ImageForm
	{
		Delt _wrk => (Delt)_working;
		Delt _delt => (Delt)_resource;

		public DeltForm(LfdFile lfd, Delt delt, MainForm mdiParent, bool readOnly = false) : base(lfd, delt, mdiParent, readOnly)
		{
			InitializeComponent();
			btnNext.Visible = false;
			btnPrev.Visible = false;
			lblFrame.Visible = false;
			chkRelative.Visible = false;
			numFrameHeight.Visible = false;
			numFrameWidth.Visible = false;
			numFrameLeft.Visible = false;
			numFrameTop.Visible = false;
			label9.Visible = false;
			label10.Visible = false;
			_working = new Delt();
			_wrk.DecodeResource(_delt.RawData, false);
			_isLoading = true;
			_wrk.Palette = _palette;
			numLeft.Value = _wrk.Left;
			numTop.Value = _wrk.Top;
			numWidth.Value = _wrk.Width;
			numHeight.Value = _wrk.Height;
			_isLoading = false;
			if (_wrk.Width > 160 || _wrk.Height > 120) optZoom4.Enabled = false;
			if (_wrk.Width > 320 || _wrk.Height > 240) optZoom2.Enabled = false;
			loadPltts();
			refresh();
		}

		/// <summary>Clean up any resources being used.</summary>
		/// <param name="disposing"><see langword="true"/> if managed resources should be disposed; otherwise, <see langword="false"/>.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				components?.Dispose();
				_pltts.Clear();
				_wrk.Dispose();
			}
			_working = null;
			base.Dispose(disposing);
		}

		/// <summary>Push the working copy to <see cref="ResourceForm.Resource"/>.</summary>
		protected override void updateLfd()
		{
			_wrk.EncodeResource();
			_delt.DecodeResource(_wrk.RawData, false);
		}

		protected override void refresh()
		{
			if (_isLoading) return;

			_origPalette.Entries.CopyTo(_palette.Entries, 0);
			foreach (PlttEntry item in lstApplied.Items) for (int i = item.Pltt.StartIndex; i < item.Pltt.EndIndex; i++) _palette.Entries[i] = item.Pltt.Entries[i];
			if (cboTransparent.SelectedIndex == 0) _palette.Entries[0] = Color.Transparent;
			else if (cboTransparent.SelectedIndex == 2) _palette.Entries[0] = Color.Fuchsia;
			else if (cboTransparent.SelectedIndex == 3) _palette.Entries[0] = Color.Blue;
			_wrk.Palette = _palette;
			pctImage.Invalidate();
		}

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

			try
			{
				_wrk.Image = new Bitmap(opnImage.FileName) { Palette = _palette };
				numWidth.Value = _wrk.Image.Width;
				numHeight.Value = _wrk.Image.Height;
				pctImage.Invalidate();
			}
			catch (Exception x) { MessageBox.Show("Import Error", x.Message, MessageBoxButtons.OK, MessageBoxIcon.Error); }
		}

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
