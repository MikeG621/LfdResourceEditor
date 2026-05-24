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
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Idmr.LfdResourceEditor
{
	public partial class BlasForm : ResourceForm
	{
		Blas _wrk => (Blas)_working;
		Blas _blas => (Blas)_resource;

		public BlasForm(LfdFile lfd, Blas blas, bool readOnly = false) : base(lfd, blas, readOnly)
		{
			InitializeComponent();
			_working = new Blas();
			_wrk.DecodeResource(_blas.RawData, false);
			updateLabels();
			cmdImport.Enabled = !readOnly;
		}

		// this gets us the required function to play .WAV
		[DllImport("winmm.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi)]
		static extern bool PlaySound(byte[] b_ary, IntPtr ptr, SoundFlags sf);      // from memory
		[Flags]
		public enum SoundFlags : int
		{
			//SND_SYNC = 0x0000,  // play synchronously (default) 
			SND_ASYNC = 0x0001,  // play asynchronously 
			//SND_NODEFAULT = 0x0002,  // silence (!default) if sound not found 
			SND_MEMORY = 0x0004,  // pszSound points to a memory file
			//SND_LOOP = 0x0008,  // loop the sound until next sndPlaySound 
			//SND_NOSTOP = 0x0010,  // don't stop any currently playing sound 
			//SND_NOWAIT = 0x00002000, // don't wait if the driver is busy 
			//SND_ALIAS = 0x00010000, // name is a registry alias 
			//SND_ALIAS_ID = 0x00110000, // alias is a predefined ID
			SND_FILENAME = 0x00020000, // name is file name 
			//SND_RESOURCE = 0x00040004  // name is resource name or atom 
		}

		void updateLabels()
		{
			lblFreq.Text = "Frequency (Hz): " + _wrk.Frequency;
			lblDuration0.Text = $"Duration: {Math.Round((decimal)_wrk.SoundBlocks[0].Data.Length / _wrk.Frequency, 2)}" + (_wrk.SoundBlocks[0].NumberOfRepeats > -1 ? $" (x{_wrk.SoundBlocks[0].NumberOfRepeats})" : "");
			lblRepeat0.Text = "Repeats: " + _wrk.SoundBlocks[0].NumberOfRepeats;
			if (_wrk.SoundBlocks[1].Data != null)
			{
				lblDuration1.Text = $"Duration: {Math.Round((decimal)_wrk.SoundBlocks[1].Data.Length / _wrk.Frequency, 2)}" + (_wrk.SoundBlocks[1].NumberOfRepeats > -1 ? $" (x{_wrk.SoundBlocks[1].NumberOfRepeats})" : "");
				lblRepeat1.Text = "Repeats: " + _wrk.SoundBlocks[1].NumberOfRepeats.ToString();
			}
			lblSdb1.Visible = lblDuration1.Visible = lblRepeat1.Visible = _wrk.SoundBlocks[1].Data != null;
		}

		protected override void updateLfd()
		{
			_wrk.EncodeResource();
			_blas.DecodeResource(_wrk.RawData, false);
		}

		void vocToWav(Stream s)
		{
			var bytes = _wrk.GetWavBytes();
			s.Write(bytes, 0, bytes.Length);
		}

		private void cmdPlay_Click(object sender, EventArgs e)
		{
			MemoryStream mem = new MemoryStream();
			vocToWav(mem);
			byte[] soundBytes = new byte[mem.Length];
			mem.Position = 0;
			mem.Read(soundBytes, 0, soundBytes.Length);
			PlaySound(soundBytes, IntPtr.Zero, SoundFlags.SND_MEMORY | SoundFlags.SND_ASYNC);
			mem.Close();
		}

		private void cmdExport_Click(object sender, EventArgs e)
		{
			var response = savWav.ShowDialog();
			if (response != DialogResult.OK) return;

			FileStream fs = null;
			try
			{
				fs = File.OpenWrite(savWav.FileName);
				fs.SetLength(1);
				vocToWav(fs);
			}
			catch (Exception x) { MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
			finally { fs?.Close(); }
		}

		private void cmdImport_Click(object sender, EventArgs e)
		{
			var response = opnWav.ShowDialog();
			if (response != DialogResult.OK) return;

			var backup = _wrk.RawData;
			// TODO: should probably roll this routine into LfdReader at some point
			FileStream fs = null;
			try
			{
				fs = File.OpenRead(opnWav.FileName);
				BinaryReader br = new BinaryReader(fs);
				long fmt_pos, data_pos = 0, data_length, data2_pos = 0, data2_length;
				#region validation
				// 10-12 kHz, mono, 8bit, uncompressed, max 2 data chunks
				if (br.ReadInt32() != 0x46464952 /* "RIFF" */) throw new InvalidDataException("Invalid file type");
				fs.Position += 4;
				if (br.ReadInt32() != 0x45564157 /* "WAVE" */) throw new InvalidDataException("Invalid file type");
				for (; ; )
				{
					if (br.ReadInt32() == 0x20746D66) // "fmt "
					{
						fmt_pos = fs.Position - 4;
						break;
					}
					if ((fs.Position + 20) >= fs.Length) throw new InvalidDataException("fmt chunk missing, invalid WAV file");
					fs.Position -= 3;
				}
				fs.Position = 12;
				for (; fs.Position + 8 < fs.Length; fs.Position -= 3)
				{
					if (br.ReadInt32() == 0x61746164) // "data"
					{
						if (data_pos == 0) data_pos = fs.Position - 4;
						else
						{
							data2_pos = fs.Position - 4;
							break;
						}
					}
				}
				if (data_pos == 0) throw new InvalidDataException("data chunk missing, invalid WAV file");
				fs.Position = fmt_pos + 8;
				if (br.ReadUInt16() != 1) throw new InvalidDataException("Incorrect format, WAV must be uncompressed PCM");
				if (br.ReadUInt16() != 1) throw new InvalidDataException("Incorrect format, WAV must be mono");
				int freq = br.ReadInt32();
				if (freq < 10000 || freq > 12000) throw new InvalidDataException("Incorrect format, WAV must be between 10-12 kHz");
				fs.Position += 6;
				if (br.ReadUInt16() != 8) throw new InvalidDataException("Incorrect format, WAV must be 8-bit");
				#endregion
				fs.Position = data_pos + 4;
				data_length = br.ReadUInt32();
				_wrk.SoundBlocks[0].Data = br.ReadBytes((int)data_length);
				if (data2_pos != 0)
				{
					fs.Position = data2_pos + 4;
					data2_length = br.ReadUInt32();
					_wrk.SoundBlocks[1].Data = br.ReadBytes((int)data2_length);
				}
				_wrk.Frequency = freq;
				markDirty();
			}
			catch (InvalidDataException x) { MessageBox.Show("WAV File error!\r\n" + x.Message, "WAV Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
			catch (Exception x)
			{
				MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				_wrk.DecodeResource(backup, false);
			}
			finally { fs?.Close(); }
		}
	}
}
