namespace Idmr.LfdResourceEditor
{
	partial class DeltForm
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
			this.pctImage = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pctImage)).BeginInit();
			this.SuspendLayout();
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(37, 583);
			// 
			// pctImage
			// 
			this.pctImage.Location = new System.Drawing.Point(155, 12);
			this.pctImage.Name = "pctImage";
			this.pctImage.Size = new System.Drawing.Size(800, 600);
			this.pctImage.TabIndex = 1;
			this.pctImage.TabStop = false;
			// 
			// DeltForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(959, 618);
			this.Controls.Add(this.pctImage);
			this.Name = "DeltForm";
			this.Controls.SetChildIndex(this.btnUpdate, 0);
			this.Controls.SetChildIndex(this.pctImage, 0);
			((System.ComponentModel.ISupportInitialize)(this.pctImage)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pctImage;
	}
}
