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
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Idmr.LfdResourceEditor
{
	public partial class FontForm : ResourceForm
	{
		int _index = 0;
		readonly Bitmap _charMap = null;
		readonly Bitmap _glyph = null;
		int _glyphLeft, _glyphTop;
		LfdReader.Font _wrk => (LfdReader.Font)_working;
		LfdReader.Font _font => (LfdReader.Font)_resource;

		public FontForm(LfdFile lfd, LfdReader.Font font, bool readOnly = false) : base(lfd, font, readOnly)
		{
			InitializeComponent();
			_working = new LfdReader.Font(1, 1);	// dummy ctor, 1 char, 1px
			_wrk.DecodeResource(_font.RawData, false);
			_charMap = new Bitmap(pnlCharMap.Width, pnlCharMap.Height);
			_glyph = new Bitmap(pctGlyph.Width, pctGlyph.Height);
			_isLoading = true;
			lblStarting.Text += $"    {_wrk.StartingChar}";
			numCount.Value = _wrk.NumberOfGlyphs;
			numMaxWidth.Value = _wrk.BitsPerScanLine;
			numHeight.Value = _wrk.Height;
			numBaseLine.Value = _wrk.BaseLine;
			_isLoading = false;
			numBaseLine.ReadOnly = numMaxWidth.ReadOnly = _isReadOnly;
			if (_isReadOnly) numBaseLine.Increment = numMaxWidth.Increment = 0;
			chkEdit.Enabled = !_isReadOnly;
			setVsbEnabled();
			paintGlyphs();
			updateGlyph();
		}

		void paintGlyphs()
		{
			Graphics g = Graphics.FromImage(_charMap);
			g.Clear(SystemColors.ControlDark);
			for (int index = 0, y = 0; ; y++)
			{
				for (int x = 0; x < _charMap.Width / (_wrk.BitsPerScanLine + 1); index++, x++)
				{
					if (index >= _wrk.NumberOfGlyphs) break;
					g.DrawImageUnscaled(_wrk.Glyphs[index], x * (_wrk.BitsPerScanLine + 1), y * (_wrk.Height + 1) - vsbCharMap.Value);
				}
				if (index >= _wrk.NumberOfGlyphs) break;
			}
			pnlCharMap.Invalidate();
			g.Dispose();
		}

		void refreshGlyph()
		{
			Graphics g = Graphics.FromImage(_glyph);
			g.Clear(SystemColors.Control);
			g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
			g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
			var gl = _wrk.Glyphs[_index];
			_glyphLeft = (pctGlyph.Width - gl.Width * 5) / 2;
			_glyphTop = (pctGlyph.Height - gl.Height * 5) / 2;
			g.DrawImage(gl, _glyphLeft, _glyphTop, gl.Width * 5, gl.Height * 5);
			Pen baseLine = new Pen(Color.Blue);
			int y = _glyphTop + (_wrk.BaseLine + 1) * 5;
			g.DrawLine(baseLine, _glyphLeft - 5, y, _glyphLeft + (gl.Width + 1) * 5, y);
			pctGlyph.Invalidate();
			int glyphsPerRow;
			glyphsPerRow = pnlCharMap.Width / (_wrk.BitsPerScanLine + 1);
			g = Graphics.FromImage(_charMap);
			g.DrawImageUnscaled(gl, _index % glyphsPerRow * (_wrk.BitsPerScanLine + 1), _index / glyphsPerRow * (_wrk.Height + 1) - vsbCharMap.Value);
			g.Dispose();
			pnlCharMap.Invalidate();
		}

		void setVsbEnabled()
		{
			int numRows = (int)Math.Ceiling((double)_wrk.NumberOfGlyphs / pnlCharMap.Width * (_wrk.BitsPerScanLine + 1));  // rows of glyphs in pnlImages
			vsbCharMap.Enabled = (numRows * (_wrk.Height + 1) > pnlCharMap.Height);
			vsbCharMap.Value = 0;
			if (vsbCharMap.Enabled) vsbCharMap.Maximum = numRows * (_wrk.Height + 2) - pnlCharMap.Height;
		}

		void updateGlyph()
		{
			refreshGlyph();
			_isLoading = true;
			lblGlyph.Text = $"Glyph #{_index + 1}";
			numWidth.Value = _wrk.Glyphs[_index].Width;
			int value = _wrk.StartingChar + _index;
			lblAscii.Text = $"ASCII: {value}";
			lblChar.Text = $"Char: {(char)value}";
			if (value == 38) lblChar.Text = "Char: &&";
			if (value == 126 || value == 127)
			{
				lblShownAs.Text = "NOTE: glyph used is normally " + (value == 126 ? "^ or TM" : "~");
				lblShownAs.Visible = true;
			}
			else lblShownAs.Visible = false;
			_isLoading = false;
		}
		/// <summary>Push the working copy to <see cref="ResourceForm.Resource"/>.</summary>
		protected override void updateLfd()
		{
			_wrk.EncodeResource();
			_font.DecodeResource(_wrk.RawData, false);
		}

		private void btnExport_Click(object sender, EventArgs e)
		{
			savFont.FileName = $"{Path.GetFileNameWithoutExtension(_lfd.FileName)}-{_font.Name}";
			var response = savFont.ShowDialog();
			if (response != DialogResult.OK) return;

			FileStream fs = null;
			try
			{
				fs = File.OpenWrite(savFont.FileName);
				BinaryWriter bw = new BinaryWriter(fs);
				bw.Write(_font.ToString().ToCharArray());
				bw.Write((long)0);
				fs.Position = Resource.LengthOffset;
				bw.Write(_wrk.Length);
				bw.Write(_wrk.RawData);
				fs.SetLength(fs.Position);
			}
			catch (Exception x) { MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
			finally { fs?.Close(); }
		}
		private void btnImport_Click(object sender, EventArgs e)
		{
			var response = opnFont.ShowDialog();
			if (response != DialogResult.OK) return;

			try
			{
				var newFont = new LfdReader.Font(opnFont.FileName, 0);
				if (newFont.Name != _font.Name)
				{
					response = MessageBox.Show($"Selected FONT ({newFont.Name}) does not match existing ({_font.Name}). Continue?", "Name mismatch", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (response != DialogResult.Yes) return;
				}
				_wrk.DecodeResource(newFont.RawData, false);
				markDirty();
				paintGlyphs();
			}
			catch (Exception x) { MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
		}
		private void btnNext_Click(object sender, EventArgs e)
		{
			if (_index == (_wrk.NumberOfGlyphs - 1)) return;

			_index++;
			updateGlyph();
		}
		private void btnPrev_Click(object sender, EventArgs e)
		{
			if (_index == 0) return;

			_index--;
			updateGlyph();
		}

		private void chkEdit_CheckedChanged(object sender, EventArgs e)
		{
			numWidth.ReadOnly = !chkEdit.Checked;
			numWidth.Increment = (chkEdit.Checked ? 1 : 0);
			lblEdit.Visible = chkEdit.Checked;
		}

		private void numBaseLine_ValueChanged(object sender, EventArgs e)
		{
			if (_isLoading) return;

			_wrk.BaseLine = (short)numBaseLine.Value;
			refreshGlyph();
			markDirty();
		}
		private void numCount_ValueChanged(object sender, EventArgs e)
		{
			if (_isLoading) return;
			// The MaxValue is set assuming 32 as the starting char, maximum index of 255

			_wrk.NumberOfGlyphs = (short)numCount.Value;
			paintGlyphs();
			markDirty();
		}
		private void numHeight_ValueChanged(object sender, EventArgs e)
		{
			numBaseLine.Maximum = numHeight.Value;
			if (_isLoading) return;

			if (_wrk.Height > numHeight.Value)
			{
				var response = MessageBox.Show("New value is smaller than existing height.\r\nAre you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (response != DialogResult.Yes)
				{
					_isLoading = true;
					numHeight.Value = _wrk.Height;
					_isLoading = false;
					return;
				}
			}

			_wrk.Height = (short)numHeight.Value;
			refreshGlyph();
			paintGlyphs();
			markDirty();
		}
		private void numMaxWidth_ValueChanged(object sender, EventArgs e)
		{
			numMaxWidth.Value = (int)(numMaxWidth.Value / 8) * 8;
			if (_isLoading) return;

			for (int i = 0; i < _wrk.NumberOfGlyphs; i++)
			{
				if (_wrk.Glyphs[i].Width > numMaxWidth.Value)
				{
					var response = MessageBox.Show("New value is smaller than existing glyph widths.\r\nAre you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
					if (response != DialogResult.Yes)
					{
						_isLoading = true;
						numMaxWidth.Value = _wrk.BitsPerScanLine;
						_isLoading = false;
						return;
					}

					int width = (int)numMaxWidth.Value;
					for (int j = i; j < _wrk.NumberOfGlyphs; j++)
						if (_wrk.Glyphs[j].Width > numMaxWidth.Value)
						{
							Bitmap newGlyph = new Bitmap(width, _wrk.Height);
							Graphics g = Graphics.FromImage(newGlyph);
							g.DrawImageUnscaled(_wrk.Glyphs[j], 0, 0);
							g.Dispose();
							_wrk.Glyphs[j] = newGlyph;
						}
					break;
				}
			}
			_wrk.BitsPerScanLine = (short)numMaxWidth.Value;
			_isLoading = true;
			numWidth.Maximum = numMaxWidth.Value;
			_isLoading = false;
			setVsbEnabled();
			paintGlyphs();
			refreshGlyph();
			markDirty();
		}
		private void numWidth_ValueChanged(object sender, EventArgs e)
		{
			if (_isLoading) return;

			if (!chkEdit.Checked)
			{
				numWidth.Value = _wrk.Glyphs[_index].Width;
				return;
			}

			bool isShrinking = _wrk.Glyphs[_index].Width > numWidth.Value;
			if (isShrinking)
			{
				var response = MessageBox.Show("New value is smaller than existing width.\r\nAre you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (response != DialogResult.Yes)
				{
					_isLoading = true;
					numWidth.Value = _wrk.Glyphs[_index].Width;
					_isLoading = false;
					return;
				}
			}

			Bitmap newGlyph = new Bitmap((int)numWidth.Value, _wrk.Height);
			Graphics g = Graphics.FromImage(newGlyph);
			g.Clear(Color.Black);
			g.DrawImageUnscaled(_wrk.Glyphs[_index], 0, 0);
			g.Dispose();
			_wrk.Glyphs[_index] = newGlyph;
			refreshGlyph();
			if (isShrinking) paintGlyphs();
			markDirty();
		}

		private void pctGlyph_MouseClick(object sender, MouseEventArgs e)
		{
			if (!chkEdit.Checked) return;

			int x = (e.X - _glyphLeft) / 5;
			int y = (e.Y - _glyphTop) / 5;
			var bd = GraphicsFunctions.GetBitmapData(_wrk.Glyphs[_index]);
			byte[] bytes = new byte[bd.Stride * bd.Height];
			GraphicsFunctions.CopyImageToBytes(bd, bytes);
			bytes[y * bd.Stride + x / 8] ^= (byte)(1 << (7 - x % 8));
			GraphicsFunctions.CopyBytesToImage(bytes, bd);
			_wrk.Glyphs[_index].UnlockBits(bd);
			refreshGlyph();
			markDirty();
		}
		private void pctGlyph_Paint(object sender, PaintEventArgs e) => e.Graphics.DrawImageUnscaled(_glyph, 0, 0);

		private void pnlCharMap_MouseClick(object sender, MouseEventArgs e)
		{
			int x, y, glyphsPerRow, rows;
			glyphsPerRow = pnlCharMap.Width / (_wrk.BitsPerScanLine + 1);
			rows = (int)Math.Ceiling((double)_wrk.NumberOfGlyphs / glyphsPerRow);
			x = e.X / (_wrk.BitsPerScanLine + 1);
			if ((x + 1) * (_wrk.BitsPerScanLine + 1) > pnlCharMap.Width) x--;
			y = (e.Y + vsbCharMap.Value) / (_wrk.Height + 1);
			if ((y + 1) * (_wrk.Height + 1) > rows * (_wrk.Height + 1)) y--;
			_index = glyphsPerRow * y + x;
			if (_index > _wrk.NumberOfGlyphs) _index = _wrk.NumberOfGlyphs - 1;
			updateGlyph();
		}
		private void pnlCharMap_Paint(object sender, PaintEventArgs e) => e.Graphics.DrawImageUnscaled(_charMap, 0, 0);

		private void vsbCharMap_ValueChanged(object sender, EventArgs e) => paintGlyphs();
	}
}
