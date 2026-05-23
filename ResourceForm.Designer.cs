namespace Idmr.LfdResourceEditor
{
	partial class ResourceForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResourceForm));
			this.cmdUpdate = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cmdUpdate
			// 
			this.cmdUpdate.Location = new System.Drawing.Point(37, 320);
			this.cmdUpdate.Name = "cmdUpdate";
			this.cmdUpdate.Size = new System.Drawing.Size(75, 23);
			this.cmdUpdate.TabIndex = 0;
			this.cmdUpdate.Text = "&Update LFD";
			this.cmdUpdate.UseVisualStyleBackColor = true;
			this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
			// 
			// ResourceForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cmdUpdate);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "ResourceForm";
			this.Text = "ResourceForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ResourceForm_FormClosing);
			this.ResumeLayout(false);

		}

		#endregion

		protected System.Windows.Forms.Button cmdUpdate;
	}
}

