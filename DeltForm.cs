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

using Idmr.Common;
using Idmr.LfdReader;
using Idmr.LfdResourceEditor.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Resources;
using System.Text;
using System.Windows.Forms;

namespace Idmr.LfdResourceEditor
{
	public partial class DeltForm : ResourceForm
	{
		ColorPalette _palette;
		Delt _wrk => (Delt)_working;
		Delt _delt => (Delt)_resource;

		public DeltForm(LfdFile lfd, Delt delt, bool readOnly = false) : base(lfd, delt, readOnly)
		{
			InitializeComponent();
			_working = new Delt();
			_wrk.DecodeResource(_delt.RawData, false);
			_isLoading = true;
			// do stuff
			_palette = new Bitmap(1, 1, PixelFormat.Format8bppIndexed).Palette;
			_palette.Entries[0] = Color.Fuchsia;
			var temp = new Pltt();
			temp.DecodeResource(Resources.standard, false);
			applyPltt(temp);
			// address a couple special cases just in case
			if (_lfd.FileName.StartsWith("BATTLE", StringComparison.InvariantCultureIgnoreCase))
			{
				temp.DecodeResource(Resources.toddesk, false);
				applyPltt(temp);
			}
			else if (_lfd.FileName.StartsWith("SHIP", StringComparison.InvariantCultureIgnoreCase))
			{
				temp.DecodeResource(Resources.launch, false);
				applyPltt(temp);
				temp.DecodeResource(Resources.l_bg_bay, false);
				applyPltt(temp);
			}
			_wrk.Palette = _palette;
			pctImage.Image = _wrk.Image;
			_isLoading = false;
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
	}
}
