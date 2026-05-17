namespace LfdResourceEditor
{
	partial class TextForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextForm));
			this.lstStrings = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtString = new System.Windows.Forms.TextBox();
			this.lblNewLength = new System.Windows.Forms.Label();
			this.lblOriginalLength = new System.Windows.Forms.Label();
			this.cmdUpdate = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lstStrings
			// 
			this.lstStrings.FormattingEnabled = true;
			this.lstStrings.Location = new System.Drawing.Point(12, 25);
			this.lstStrings.Name = "lstStrings";
			this.lstStrings.ScrollAlwaysVisible = true;
			this.lstStrings.Size = new System.Drawing.Size(120, 173);
			this.lstStrings.TabIndex = 0;
			this.lstStrings.SelectedIndexChanged += new System.EventHandler(this.lstStrings_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Strings:";
			// 
			// txtString
			// 
			this.txtString.Location = new System.Drawing.Point(138, 25);
			this.txtString.Multiline = true;
			this.txtString.Name = "txtString";
			this.txtString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtString.Size = new System.Drawing.Size(301, 173);
			this.txtString.TabIndex = 2;
			this.txtString.WordWrap = false;
			this.txtString.TextChanged += new System.EventHandler(this.txtString_TextChanged);
			// 
			// lblNewLength
			// 
			this.lblNewLength.AutoSize = true;
			this.lblNewLength.Location = new System.Drawing.Point(264, 207);
			this.lblNewLength.Name = "lblNewLength";
			this.lblNewLength.Size = new System.Drawing.Size(64, 13);
			this.lblNewLength.TabIndex = 3;
			this.lblNewLength.Text = "New length:";
			this.lblNewLength.Visible = false;
			// 
			// lblOriginalLength
			// 
			this.lblOriginalLength.AutoSize = true;
			this.lblOriginalLength.Location = new System.Drawing.Point(135, 207);
			this.lblOriginalLength.Name = "lblOriginalLength";
			this.lblOriginalLength.Size = new System.Drawing.Size(77, 13);
			this.lblOriginalLength.TabIndex = 4;
			this.lblOriginalLength.Text = "Original length:";
			// 
			// cmdUpdate
			// 
			this.cmdUpdate.Location = new System.Drawing.Point(379, 201);
			this.cmdUpdate.Name = "cmdUpdate";
			this.cmdUpdate.Size = new System.Drawing.Size(56, 25);
			this.cmdUpdate.TabIndex = 5;
			this.cmdUpdate.Text = "&Update";
			this.cmdUpdate.UseVisualStyleBackColor = true;
			this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
			// 
			// TextForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(447, 233);
			this.Controls.Add(this.cmdUpdate);
			this.Controls.Add(this.lblOriginalLength);
			this.Controls.Add(this.lblNewLength);
			this.Controls.Add(this.txtString);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lstStrings);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "TextForm";
			this.Text = "TextForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TextForm_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lstStrings;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtString;
		private System.Windows.Forms.Label lblNewLength;
		private System.Windows.Forms.Label lblOriginalLength;
		private System.Windows.Forms.Button cmdUpdate;
	}
}