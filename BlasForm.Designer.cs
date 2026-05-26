namespace Idmr.LfdResourceEditor
{
	partial class BlasForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnPlay = new System.Windows.Forms.Button();
			this.lblFreq = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lblDuration0 = new System.Windows.Forms.Label();
			this.lblRepeat0 = new System.Windows.Forms.Label();
			this.lblSdb1 = new System.Windows.Forms.Label();
			this.lblDuration1 = new System.Windows.Forms.Label();
			this.lblRepeat1 = new System.Windows.Forms.Label();
			this.btnExport = new System.Windows.Forms.Button();
			this.btnImport = new System.Windows.Forms.Button();
			this.opnWav = new System.Windows.Forms.OpenFileDialog();
			this.savWav = new System.Windows.Forms.SaveFileDialog();
			this.SuspendLayout();
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(199, 81);
			// 
			// btnPlay
			// 
			this.btnPlay.Location = new System.Drawing.Point(158, 4);
			this.btnPlay.Name = "btnPlay";
			this.btnPlay.Size = new System.Drawing.Size(75, 23);
			this.btnPlay.TabIndex = 1;
			this.btnPlay.Text = "&Play";
			this.btnPlay.UseVisualStyleBackColor = true;
			this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
			// 
			// lblFreq
			// 
			this.lblFreq.AutoSize = true;
			this.lblFreq.Location = new System.Drawing.Point(12, 9);
			this.lblFreq.Name = "lblFreq";
			this.lblFreq.Size = new System.Drawing.Size(60, 13);
			this.lblFreq.TabIndex = 2;
			this.lblFreq.Text = "Frequency:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Sound Block 1";
			// 
			// lblDuration0
			// 
			this.lblDuration0.AutoSize = true;
			this.lblDuration0.Location = new System.Drawing.Point(22, 35);
			this.lblDuration0.Name = "lblDuration0";
			this.lblDuration0.Size = new System.Drawing.Size(50, 13);
			this.lblDuration0.TabIndex = 4;
			this.lblDuration0.Text = "Duration:";
			// 
			// lblRepeat0
			// 
			this.lblRepeat0.AutoSize = true;
			this.lblRepeat0.Location = new System.Drawing.Point(22, 48);
			this.lblRepeat0.Name = "lblRepeat0";
			this.lblRepeat0.Size = new System.Drawing.Size(50, 13);
			this.lblRepeat0.TabIndex = 5;
			this.lblRepeat0.Text = "Repeats:";
			// 
			// lblSdb1
			// 
			this.lblSdb1.AutoSize = true;
			this.lblSdb1.Location = new System.Drawing.Point(12, 65);
			this.lblSdb1.Name = "lblSdb1";
			this.lblSdb1.Size = new System.Drawing.Size(77, 13);
			this.lblSdb1.TabIndex = 3;
			this.lblSdb1.Text = "Sound Block 2";
			// 
			// lblDuration1
			// 
			this.lblDuration1.AutoSize = true;
			this.lblDuration1.Location = new System.Drawing.Point(22, 78);
			this.lblDuration1.Name = "lblDuration1";
			this.lblDuration1.Size = new System.Drawing.Size(50, 13);
			this.lblDuration1.TabIndex = 4;
			this.lblDuration1.Text = "Duration:";
			// 
			// lblRepeat1
			// 
			this.lblRepeat1.AutoSize = true;
			this.lblRepeat1.Location = new System.Drawing.Point(22, 91);
			this.lblRepeat1.Name = "lblRepeat1";
			this.lblRepeat1.Size = new System.Drawing.Size(50, 13);
			this.lblRepeat1.TabIndex = 5;
			this.lblRepeat1.Text = "Repeats:";
			// 
			// btnExport
			// 
			this.btnExport.Location = new System.Drawing.Point(118, 33);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(75, 23);
			this.btnExport.TabIndex = 6;
			this.btnExport.Text = "&Export";
			this.btnExport.UseVisualStyleBackColor = true;
			this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
			// 
			// btnImport
			// 
			this.btnImport.Location = new System.Drawing.Point(199, 33);
			this.btnImport.Name = "btnImport";
			this.btnImport.Size = new System.Drawing.Size(75, 23);
			this.btnImport.TabIndex = 7;
			this.btnImport.Text = "&Import .wav";
			this.btnImport.UseVisualStyleBackColor = true;
			this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
			// 
			// opnWav
			// 
			this.opnWav.DefaultExt = "wav";
			this.opnWav.Filter = "Wav files|*.wav|All files|*.*";
			// 
			// savWav
			// 
			this.savWav.DefaultExt = "wav";
			this.savWav.Filter = "Wav files|*.wav|All files|*.*";
			// 
			// BlasForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(286, 118);
			this.Controls.Add(this.btnImport);
			this.Controls.Add(this.btnExport);
			this.Controls.Add(this.lblRepeat1);
			this.Controls.Add(this.lblRepeat0);
			this.Controls.Add(this.lblDuration1);
			this.Controls.Add(this.lblDuration0);
			this.Controls.Add(this.lblSdb1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblFreq);
			this.Controls.Add(this.btnPlay);
			this.Name = "BlasForm";
			this.Controls.SetChildIndex(this.btnUpdate, 0);
			this.Controls.SetChildIndex(this.btnPlay, 0);
			this.Controls.SetChildIndex(this.lblFreq, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.lblSdb1, 0);
			this.Controls.SetChildIndex(this.lblDuration0, 0);
			this.Controls.SetChildIndex(this.lblDuration1, 0);
			this.Controls.SetChildIndex(this.lblRepeat0, 0);
			this.Controls.SetChildIndex(this.lblRepeat1, 0);
			this.Controls.SetChildIndex(this.btnExport, 0);
			this.Controls.SetChildIndex(this.btnImport, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnPlay;
		private System.Windows.Forms.Label lblFreq;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblDuration0;
		private System.Windows.Forms.Label lblRepeat0;
		private System.Windows.Forms.Label lblSdb1;
		private System.Windows.Forms.Label lblDuration1;
		private System.Windows.Forms.Label lblRepeat1;
		private System.Windows.Forms.Button btnExport;
		private System.Windows.Forms.Button btnImport;
		private System.Windows.Forms.OpenFileDialog opnWav;
		private System.Windows.Forms.SaveFileDialog savWav;
	}
}
