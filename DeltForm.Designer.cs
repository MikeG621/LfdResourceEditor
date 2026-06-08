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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.numHeight = new System.Windows.Forms.NumericUpDown();
			this.numWidth = new System.Windows.Forms.NumericUpDown();
			this.numTop = new System.Windows.Forms.NumericUpDown();
			this.numLeft = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.chkEdit = new System.Windows.Forms.CheckBox();
			this.lstPltts = new System.Windows.Forms.ListBox();
			this.btnUp = new System.Windows.Forms.Button();
			this.btnDown = new System.Windows.Forms.Button();
			this.btnReload = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.lstApplied = new System.Windows.Forms.ListBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnRemove = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pctImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numTop)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numLeft)).BeginInit();
			this.SuspendLayout();
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(12, 469);
			this.btnUpdate.TabIndex = 20;
			// 
			// pctImage
			// 
			this.pctImage.Location = new System.Drawing.Point(150, 12);
			this.pctImage.Name = "pctImage";
			this.pctImage.Size = new System.Drawing.Size(640, 480);
			this.pctImage.TabIndex = 1;
			this.pctImage.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(28, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Left:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Top:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 50);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Width:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(11, 70);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Height:";
			// 
			// numHeight
			// 
			this.numHeight.Enabled = false;
			this.numHeight.Location = new System.Drawing.Point(58, 68);
			this.numHeight.Maximum = new decimal(new int[] {
            480,
            0,
            0,
            0});
			this.numHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numHeight.Name = "numHeight";
			this.numHeight.Size = new System.Drawing.Size(42, 20);
			this.numHeight.TabIndex = 4;
			this.numHeight.Value = new decimal(new int[] {
            480,
            0,
            0,
            0});
			// 
			// numWidth
			// 
			this.numWidth.Enabled = false;
			this.numWidth.Location = new System.Drawing.Point(58, 48);
			this.numWidth.Maximum = new decimal(new int[] {
            640,
            0,
            0,
            0});
			this.numWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numWidth.Name = "numWidth";
			this.numWidth.Size = new System.Drawing.Size(42, 20);
			this.numWidth.TabIndex = 3;
			this.numWidth.Value = new decimal(new int[] {
            640,
            0,
            0,
            0});
			// 
			// numTop
			// 
			this.numTop.Enabled = false;
			this.numTop.Location = new System.Drawing.Point(58, 28);
			this.numTop.Maximum = new decimal(new int[] {
            479,
            0,
            0,
            0});
			this.numTop.Name = "numTop";
			this.numTop.Size = new System.Drawing.Size(42, 20);
			this.numTop.TabIndex = 2;
			// 
			// numLeft
			// 
			this.numLeft.Enabled = false;
			this.numLeft.Location = new System.Drawing.Point(58, 8);
			this.numLeft.Maximum = new decimal(new int[] {
            639,
            0,
            0,
            0});
			this.numLeft.Name = "numLeft";
			this.numLeft.Size = new System.Drawing.Size(42, 20);
			this.numLeft.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(9, 114);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 13);
			this.label5.TabIndex = 21;
			this.label5.Text = "Available PLTTs:";
			// 
			// chkEdit
			// 
			this.chkEdit.AutoSize = true;
			this.chkEdit.Location = new System.Drawing.Point(33, 94);
			this.chkEdit.Name = "chkEdit";
			this.chkEdit.Size = new System.Drawing.Size(44, 17);
			this.chkEdit.TabIndex = 5;
			this.chkEdit.Text = "Edit";
			this.chkEdit.UseVisualStyleBackColor = true;
			// 
			// lstPltts
			// 
			this.lstPltts.FormattingEnabled = true;
			this.lstPltts.Location = new System.Drawing.Point(12, 130);
			this.lstPltts.Name = "lstPltts";
			this.lstPltts.Size = new System.Drawing.Size(120, 160);
			this.lstPltts.TabIndex = 6;
			this.lstPltts.DoubleClick += new System.EventHandler(this.lstPltts_DoubleClick);
			// 
			// btnUp
			// 
			this.btnUp.Location = new System.Drawing.Point(12, 413);
			this.btnUp.Name = "btnUp";
			this.btnUp.Size = new System.Drawing.Size(54, 23);
			this.btnUp.TabIndex = 10;
			this.btnUp.Text = "U&p";
			this.btnUp.UseVisualStyleBackColor = true;
			this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
			// 
			// btnDown
			// 
			this.btnDown.Location = new System.Drawing.Point(78, 413);
			this.btnDown.Name = "btnDown";
			this.btnDown.Size = new System.Drawing.Size(54, 23);
			this.btnDown.TabIndex = 11;
			this.btnDown.Text = "&Down";
			this.btnDown.UseVisualStyleBackColor = true;
			this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
			// 
			// btnReload
			// 
			this.btnReload.Location = new System.Drawing.Point(57, 296);
			this.btnReload.Name = "btnReload";
			this.btnReload.Size = new System.Drawing.Size(75, 23);
			this.btnReload.TabIndex = 8;
			this.btnReload.Text = "&Reload";
			this.btnReload.UseVisualStyleBackColor = true;
			this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(12, 296);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(40, 23);
			this.btnAdd.TabIndex = 7;
			this.btnAdd.Text = "&Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// lstApplied
			// 
			this.lstApplied.FormattingEnabled = true;
			this.lstApplied.Location = new System.Drawing.Point(12, 338);
			this.lstApplied.Name = "lstApplied";
			this.lstApplied.Size = new System.Drawing.Size(120, 69);
			this.lstApplied.TabIndex = 22;
			this.lstApplied.DoubleClick += new System.EventHandler(this.lstApplied_DoubleClick);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(11, 322);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 13);
			this.label6.TabIndex = 23;
			this.label6.Text = "Applied PLTTs:";
			// 
			// btnRemove
			// 
			this.btnRemove.Location = new System.Drawing.Point(57, 440);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(75, 23);
			this.btnRemove.TabIndex = 8;
			this.btnRemove.Text = "Remo&ve";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// DeltForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(802, 499);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.lstApplied);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.btnReload);
			this.Controls.Add(this.btnDown);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnUp);
			this.Controls.Add(this.lstPltts);
			this.Controls.Add(this.chkEdit);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.numLeft);
			this.Controls.Add(this.numTop);
			this.Controls.Add(this.numWidth);
			this.Controls.Add(this.numHeight);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pctImage);
			this.Name = "DeltForm";
			this.Controls.SetChildIndex(this.btnUpdate, 0);
			this.Controls.SetChildIndex(this.pctImage, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.label3, 0);
			this.Controls.SetChildIndex(this.label4, 0);
			this.Controls.SetChildIndex(this.numHeight, 0);
			this.Controls.SetChildIndex(this.numWidth, 0);
			this.Controls.SetChildIndex(this.numTop, 0);
			this.Controls.SetChildIndex(this.numLeft, 0);
			this.Controls.SetChildIndex(this.label5, 0);
			this.Controls.SetChildIndex(this.chkEdit, 0);
			this.Controls.SetChildIndex(this.lstPltts, 0);
			this.Controls.SetChildIndex(this.btnUp, 0);
			this.Controls.SetChildIndex(this.btnAdd, 0);
			this.Controls.SetChildIndex(this.btnDown, 0);
			this.Controls.SetChildIndex(this.btnReload, 0);
			this.Controls.SetChildIndex(this.btnRemove, 0);
			this.Controls.SetChildIndex(this.lstApplied, 0);
			this.Controls.SetChildIndex(this.label6, 0);
			((System.ComponentModel.ISupportInitialize)(this.pctImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numTop)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numLeft)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pctImage;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown numHeight;
		private System.Windows.Forms.NumericUpDown numWidth;
		private System.Windows.Forms.NumericUpDown numTop;
		private System.Windows.Forms.NumericUpDown numLeft;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox chkEdit;
		private System.Windows.Forms.ListBox lstPltts;
		private System.Windows.Forms.Button btnUp;
		private System.Windows.Forms.Button btnDown;
		private System.Windows.Forms.Button btnReload;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.ListBox lstApplied;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnRemove;
	}
}
