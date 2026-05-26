namespace Idmr.LfdResourceEditor
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
			this.lblOriginalLength = new System.Windows.Forms.Label();
			this.lblNewLength = new System.Windows.Forms.Label();
			this.txtString = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lstStrings = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(364, 202);
			// 
			// lblOriginalLength
			// 
			this.lblOriginalLength.AutoSize = true;
			this.lblOriginalLength.Location = new System.Drawing.Point(135, 207);
			this.lblOriginalLength.Name = "lblOriginalLength";
			this.lblOriginalLength.Size = new System.Drawing.Size(77, 13);
			this.lblOriginalLength.TabIndex = 9;
			this.lblOriginalLength.Text = "Original length:";
			// 
			// lblNewLength
			// 
			this.lblNewLength.AutoSize = true;
			this.lblNewLength.Location = new System.Drawing.Point(264, 207);
			this.lblNewLength.Name = "lblNewLength";
			this.lblNewLength.Size = new System.Drawing.Size(64, 13);
			this.lblNewLength.TabIndex = 8;
			this.lblNewLength.Text = "New length:";
			this.lblNewLength.Visible = false;
			// 
			// txtString
			// 
			this.txtString.Location = new System.Drawing.Point(138, 25);
			this.txtString.Multiline = true;
			this.txtString.Name = "txtString";
			this.txtString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtString.Size = new System.Drawing.Size(301, 173);
			this.txtString.TabIndex = 7;
			this.txtString.WordWrap = false;
			this.txtString.TextChanged += new System.EventHandler(this.txtString_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Strings:";
			// 
			// lstStrings
			// 
			this.lstStrings.FormattingEnabled = true;
			this.lstStrings.Location = new System.Drawing.Point(12, 25);
			this.lstStrings.Name = "lstStrings";
			this.lstStrings.ScrollAlwaysVisible = true;
			this.lstStrings.Size = new System.Drawing.Size(120, 173);
			this.lstStrings.TabIndex = 5;
			this.lstStrings.SelectedIndexChanged += new System.EventHandler(this.lstStrings_SelectedIndexChanged);
			// 
			// NewTextForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(447, 233);
			this.Controls.Add(this.lblOriginalLength);
			this.Controls.Add(this.lblNewLength);
			this.Controls.Add(this.txtString);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lstStrings);
			this.Name = "NewTextForm";
			this.Controls.SetChildIndex(this.btnUpdate, 0);
			this.Controls.SetChildIndex(this.lstStrings, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.txtString, 0);
			this.Controls.SetChildIndex(this.lblNewLength, 0);
			this.Controls.SetChildIndex(this.lblOriginalLength, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblOriginalLength;
		private System.Windows.Forms.Label lblNewLength;
		private System.Windows.Forms.TextBox txtString;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox lstStrings;
	}
}
