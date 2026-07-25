namespace Idmr.LfdResourceEditor
{
	partial class ImageForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pctImage = new System.Windows.Forms.PictureBox();
			this.label8 = new System.Windows.Forms.Label();
			this.optZoom4 = new System.Windows.Forms.RadioButton();
			this.optZoom2 = new System.Windows.Forms.RadioButton();
			this.optZoom1 = new System.Windows.Forms.RadioButton();
			this.cboTransparent = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lstApplied = new System.Windows.Forms.ListBox();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnReload = new System.Windows.Forms.Button();
			this.btnDown = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnUp = new System.Windows.Forms.Button();
			this.lstPltts = new System.Windows.Forms.ListBox();
			this.chkEdit = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.numLeft = new System.Windows.Forms.NumericUpDown();
			this.numTop = new System.Windows.Forms.NumericUpDown();
			this.numWidth = new System.Windows.Forms.NumericUpDown();
			this.numHeight = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnImport = new System.Windows.Forms.Button();
			this.btnExport = new System.Windows.Forms.Button();
			this.opnImage = new System.Windows.Forms.OpenFileDialog();
			this.savImage = new System.Windows.Forms.SaveFileDialog();
			this.numFrameHeight = new System.Windows.Forms.NumericUpDown();
			this.numFrameWidth = new System.Windows.Forms.NumericUpDown();
			this.numFrameTop = new System.Windows.Forms.NumericUpDown();
			this.numFrameLeft = new System.Windows.Forms.NumericUpDown();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.chkRelative = new System.Windows.Forms.CheckBox();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnPrev = new System.Windows.Forms.Button();
			this.lblFrame = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pctImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numLeft)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numTop)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numFrameHeight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numFrameWidth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numFrameTop)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numFrameLeft)).BeginInit();
			this.SuspendLayout();
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(715, 498);
			// 
			// pctImage
			// 
			this.pctImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pctImage.Location = new System.Drawing.Point(150, 12);
			this.pctImage.Name = "pctImage";
			this.pctImage.Size = new System.Drawing.Size(640, 480);
			this.pctImage.TabIndex = 1;
			this.pctImage.TabStop = false;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(329, 503);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(37, 13);
			this.label8.TabIndex = 33;
			this.label8.Text = "Zoom:";
			// 
			// optZoom4
			// 
			this.optZoom4.AutoSize = true;
			this.optZoom4.Location = new System.Drawing.Point(456, 501);
			this.optZoom4.Name = "optZoom4";
			this.optZoom4.Size = new System.Drawing.Size(36, 17);
			this.optZoom4.TabIndex = 31;
			this.optZoom4.Text = "4x";
			this.optZoom4.UseVisualStyleBackColor = true;
			this.optZoom4.CheckedChanged += new System.EventHandler(this.optZoom_CheckedChanged);
			// 
			// optZoom2
			// 
			this.optZoom2.AutoSize = true;
			this.optZoom2.Location = new System.Drawing.Point(414, 501);
			this.optZoom2.Name = "optZoom2";
			this.optZoom2.Size = new System.Drawing.Size(36, 17);
			this.optZoom2.TabIndex = 30;
			this.optZoom2.Text = "2x";
			this.optZoom2.UseVisualStyleBackColor = true;
			this.optZoom2.CheckedChanged += new System.EventHandler(this.optZoom_CheckedChanged);
			// 
			// optZoom1
			// 
			this.optZoom1.AutoSize = true;
			this.optZoom1.Checked = true;
			this.optZoom1.Location = new System.Drawing.Point(372, 501);
			this.optZoom1.Name = "optZoom1";
			this.optZoom1.Size = new System.Drawing.Size(36, 17);
			this.optZoom1.TabIndex = 29;
			this.optZoom1.TabStop = true;
			this.optZoom1.Text = "1x";
			this.optZoom1.UseVisualStyleBackColor = true;
			this.optZoom1.CheckedChanged += new System.EventHandler(this.optZoom_CheckedChanged);
			// 
			// cboTransparent
			// 
			this.cboTransparent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboTransparent.FormattingEnabled = true;
			this.cboTransparent.Items.AddRange(new object[] {
            "Hide",
            "Show",
            "Show Fuschia",
            "Show Blue"});
			this.cboTransparent.Location = new System.Drawing.Point(228, 500);
			this.cboTransparent.Name = "cboTransparent";
			this.cboTransparent.Size = new System.Drawing.Size(95, 21);
			this.cboTransparent.TabIndex = 28;
			this.cboTransparent.SelectedIndexChanged += new System.EventHandler(this.cboTransparent_SelectedIndexChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(147, 503);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(75, 13);
			this.label7.TabIndex = 32;
			this.label7.Text = "Transparency:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 380);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 13);
			this.label6.TabIndex = 51;
			this.label6.Text = "Applied PLTTs:";
			// 
			// lstApplied
			// 
			this.lstApplied.FormattingEnabled = true;
			this.lstApplied.Location = new System.Drawing.Point(11, 396);
			this.lstApplied.Name = "lstApplied";
			this.lstApplied.Size = new System.Drawing.Size(120, 69);
			this.lstApplied.TabIndex = 46;
			this.lstApplied.DoubleClick += new System.EventHandler(this.lstApplied_DoubleClick);
			// 
			// btnRemove
			// 
			this.btnRemove.Location = new System.Drawing.Point(58, 498);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(75, 23);
			this.btnRemove.TabIndex = 49;
			this.btnRemove.Text = "Remo&ve";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// btnReload
			// 
			this.btnReload.Location = new System.Drawing.Point(58, 354);
			this.btnReload.Name = "btnReload";
			this.btnReload.Size = new System.Drawing.Size(75, 23);
			this.btnReload.TabIndex = 45;
			this.btnReload.Text = "&Reload";
			this.btnReload.UseVisualStyleBackColor = true;
			this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
			// 
			// btnDown
			// 
			this.btnDown.Location = new System.Drawing.Point(79, 471);
			this.btnDown.Name = "btnDown";
			this.btnDown.Size = new System.Drawing.Size(54, 23);
			this.btnDown.TabIndex = 48;
			this.btnDown.Text = "&Down";
			this.btnDown.UseVisualStyleBackColor = true;
			this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(13, 354);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(40, 23);
			this.btnAdd.TabIndex = 44;
			this.btnAdd.Text = "&Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnUp
			// 
			this.btnUp.Location = new System.Drawing.Point(13, 471);
			this.btnUp.Name = "btnUp";
			this.btnUp.Size = new System.Drawing.Size(54, 23);
			this.btnUp.TabIndex = 47;
			this.btnUp.Text = "U&p";
			this.btnUp.UseVisualStyleBackColor = true;
			this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
			// 
			// lstPltts
			// 
			this.lstPltts.FormattingEnabled = true;
			this.lstPltts.Location = new System.Drawing.Point(12, 188);
			this.lstPltts.Name = "lstPltts";
			this.lstPltts.Size = new System.Drawing.Size(120, 160);
			this.lstPltts.TabIndex = 43;
			this.lstPltts.DoubleClick += new System.EventHandler(this.lstPltts_DoubleClick);
			// 
			// chkEdit
			// 
			this.chkEdit.AutoSize = true;
			this.chkEdit.Location = new System.Drawing.Point(23, 107);
			this.chkEdit.Name = "chkEdit";
			this.chkEdit.Size = new System.Drawing.Size(44, 17);
			this.chkEdit.TabIndex = 42;
			this.chkEdit.Text = "&Edit";
			this.chkEdit.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 172);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 13);
			this.label5.TabIndex = 50;
			this.label5.Text = "Available PLTTs:";
			// 
			// numLeft
			// 
			this.numLeft.Enabled = false;
			this.numLeft.Location = new System.Drawing.Point(55, 21);
			this.numLeft.Maximum = new decimal(new int[] {
            639,
            0,
            0,
            0});
			this.numLeft.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			this.numLeft.Name = "numLeft";
			this.numLeft.Size = new System.Drawing.Size(42, 20);
			this.numLeft.TabIndex = 34;
			// 
			// numTop
			// 
			this.numTop.Enabled = false;
			this.numTop.Location = new System.Drawing.Point(55, 41);
			this.numTop.Maximum = new decimal(new int[] {
            479,
            0,
            0,
            0});
			this.numTop.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			this.numTop.Name = "numTop";
			this.numTop.Size = new System.Drawing.Size(42, 20);
			this.numTop.TabIndex = 38;
			// 
			// numWidth
			// 
			this.numWidth.Enabled = false;
			this.numWidth.Location = new System.Drawing.Point(55, 61);
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
			this.numWidth.TabIndex = 40;
			this.numWidth.Value = new decimal(new int[] {
            640,
            0,
            0,
            0});
			// 
			// numHeight
			// 
			this.numHeight.Enabled = false;
			this.numHeight.Location = new System.Drawing.Point(55, 81);
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
			this.numHeight.TabIndex = 41;
			this.numHeight.Value = new decimal(new int[] {
            480,
            0,
            0,
            0});
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(8, 83);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 13);
			this.label4.TabIndex = 37;
			this.label4.Text = "Height:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 63);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 36;
			this.label3.Text = "Width:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 13);
			this.label2.TabIndex = 39;
			this.label2.Text = "Top:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(28, 13);
			this.label1.TabIndex = 35;
			this.label1.Text = "Left:";
			// 
			// btnImport
			// 
			this.btnImport.Location = new System.Drawing.Point(553, 498);
			this.btnImport.Name = "btnImport";
			this.btnImport.Size = new System.Drawing.Size(75, 23);
			this.btnImport.TabIndex = 52;
			this.btnImport.Text = "&Import";
			this.btnImport.UseVisualStyleBackColor = true;
			// 
			// btnExport
			// 
			this.btnExport.Location = new System.Drawing.Point(634, 498);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(75, 23);
			this.btnExport.TabIndex = 53;
			this.btnExport.Text = "E&xport";
			this.btnExport.UseVisualStyleBackColor = true;
			// 
			// opnImage
			// 
			this.opnImage.DefaultExt = "bmp";
			this.opnImage.Filter = "Bitmaps|*.bmp|All files|*.*";
			// 
			// savImage
			// 
			this.savImage.DefaultExt = "bmp";
			this.savImage.Filter = "Bitmaps|*.bmp|All files|*.*";
			// 
			// numFrameHeight
			// 
			this.numFrameHeight.Enabled = false;
			this.numFrameHeight.Location = new System.Drawing.Point(101, 81);
			this.numFrameHeight.Maximum = new decimal(new int[] {
            480,
            0,
            0,
            0});
			this.numFrameHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numFrameHeight.Name = "numFrameHeight";
			this.numFrameHeight.Size = new System.Drawing.Size(42, 20);
			this.numFrameHeight.TabIndex = 41;
			this.numFrameHeight.Value = new decimal(new int[] {
            480,
            0,
            0,
            0});
			// 
			// numFrameWidth
			// 
			this.numFrameWidth.Enabled = false;
			this.numFrameWidth.Location = new System.Drawing.Point(101, 61);
			this.numFrameWidth.Maximum = new decimal(new int[] {
            640,
            0,
            0,
            0});
			this.numFrameWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numFrameWidth.Name = "numFrameWidth";
			this.numFrameWidth.Size = new System.Drawing.Size(42, 20);
			this.numFrameWidth.TabIndex = 40;
			this.numFrameWidth.Value = new decimal(new int[] {
            640,
            0,
            0,
            0});
			// 
			// numFrameTop
			// 
			this.numFrameTop.Enabled = false;
			this.numFrameTop.Location = new System.Drawing.Point(101, 41);
			this.numFrameTop.Maximum = new decimal(new int[] {
            479,
            0,
            0,
            0});
			this.numFrameTop.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			this.numFrameTop.Name = "numFrameTop";
			this.numFrameTop.Size = new System.Drawing.Size(42, 20);
			this.numFrameTop.TabIndex = 38;
			// 
			// numFrameLeft
			// 
			this.numFrameLeft.Enabled = false;
			this.numFrameLeft.Location = new System.Drawing.Point(101, 21);
			this.numFrameLeft.Maximum = new decimal(new int[] {
            639,
            0,
            0,
            0});
			this.numFrameLeft.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			this.numFrameLeft.Name = "numFrameLeft";
			this.numFrameLeft.Size = new System.Drawing.Size(42, 20);
			this.numFrameLeft.TabIndex = 34;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(52, 5);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(30, 13);
			this.label9.TabIndex = 54;
			this.label9.Text = "Anim";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(98, 5);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(36, 13);
			this.label10.TabIndex = 54;
			this.label10.Text = "Frame";
			// 
			// chkRelative
			// 
			this.chkRelative.AutoSize = true;
			this.chkRelative.Location = new System.Drawing.Point(73, 107);
			this.chkRelative.Name = "chkRelative";
			this.chkRelative.Size = new System.Drawing.Size(65, 17);
			this.chkRelative.TabIndex = 55;
			this.chkRelative.Text = "Relative";
			this.chkRelative.UseVisualStyleBackColor = true;
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(79, 146);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(60, 23);
			this.btnNext.TabIndex = 56;
			this.btnNext.Text = "Next";
			this.btnNext.UseVisualStyleBackColor = true;
			// 
			// btnPrev
			// 
			this.btnPrev.Location = new System.Drawing.Point(11, 146);
			this.btnPrev.Name = "btnPrev";
			this.btnPrev.Size = new System.Drawing.Size(60, 23);
			this.btnPrev.TabIndex = 56;
			this.btnPrev.Text = "Prev";
			this.btnPrev.UseVisualStyleBackColor = true;
			// 
			// lblFrame
			// 
			this.lblFrame.AutoSize = true;
			this.lblFrame.Location = new System.Drawing.Point(42, 127);
			this.lblFrame.Name = "lblFrame";
			this.lblFrame.Size = new System.Drawing.Size(68, 13);
			this.lblFrame.TabIndex = 57;
			this.lblFrame.Text = "Frame X of Y";
			// 
			// AnimForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(802, 529);
			this.Controls.Add(this.lblFrame);
			this.Controls.Add(this.btnPrev);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.chkRelative);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.btnImport);
			this.Controls.Add(this.btnExport);
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
			this.Controls.Add(this.numFrameLeft);
			this.Controls.Add(this.numLeft);
			this.Controls.Add(this.numFrameTop);
			this.Controls.Add(this.numTop);
			this.Controls.Add(this.numFrameWidth);
			this.Controls.Add(this.numWidth);
			this.Controls.Add(this.numFrameHeight);
			this.Controls.Add(this.numHeight);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.optZoom4);
			this.Controls.Add(this.optZoom2);
			this.Controls.Add(this.optZoom1);
			this.Controls.Add(this.cboTransparent);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.pctImage);
			this.Name = "AnimForm";
			this.Controls.SetChildIndex(this.btnUpdate, 0);
			this.Controls.SetChildIndex(this.pctImage, 0);
			this.Controls.SetChildIndex(this.label7, 0);
			this.Controls.SetChildIndex(this.cboTransparent, 0);
			this.Controls.SetChildIndex(this.optZoom1, 0);
			this.Controls.SetChildIndex(this.optZoom2, 0);
			this.Controls.SetChildIndex(this.optZoom4, 0);
			this.Controls.SetChildIndex(this.label8, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.label3, 0);
			this.Controls.SetChildIndex(this.label4, 0);
			this.Controls.SetChildIndex(this.numHeight, 0);
			this.Controls.SetChildIndex(this.numFrameHeight, 0);
			this.Controls.SetChildIndex(this.numWidth, 0);
			this.Controls.SetChildIndex(this.numFrameWidth, 0);
			this.Controls.SetChildIndex(this.numTop, 0);
			this.Controls.SetChildIndex(this.numFrameTop, 0);
			this.Controls.SetChildIndex(this.numLeft, 0);
			this.Controls.SetChildIndex(this.numFrameLeft, 0);
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
			this.Controls.SetChildIndex(this.btnExport, 0);
			this.Controls.SetChildIndex(this.btnImport, 0);
			this.Controls.SetChildIndex(this.label9, 0);
			this.Controls.SetChildIndex(this.label10, 0);
			this.Controls.SetChildIndex(this.chkRelative, 0);
			this.Controls.SetChildIndex(this.btnNext, 0);
			this.Controls.SetChildIndex(this.btnPrev, 0);
			this.Controls.SetChildIndex(this.lblFrame, 0);
			((System.ComponentModel.ISupportInitialize)(this.pctImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numLeft)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numTop)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numFrameHeight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numFrameWidth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numFrameTop)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numFrameLeft)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		protected System.Windows.Forms.PictureBox pctImage;
		private System.Windows.Forms.Label label8;
		protected System.Windows.Forms.RadioButton optZoom4;
		protected System.Windows.Forms.RadioButton optZoom2;
		private System.Windows.Forms.RadioButton optZoom1;
		protected System.Windows.Forms.ComboBox cboTransparent;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		protected System.Windows.Forms.ListBox lstApplied;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Button btnReload;
		private System.Windows.Forms.Button btnDown;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnUp;
		private System.Windows.Forms.ListBox lstPltts;
		private System.Windows.Forms.CheckBox chkEdit;
		private System.Windows.Forms.Label label5;
		protected System.Windows.Forms.NumericUpDown numLeft;
		protected System.Windows.Forms.NumericUpDown numTop;
		protected System.Windows.Forms.NumericUpDown numWidth;
		protected System.Windows.Forms.NumericUpDown numHeight;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		protected System.Windows.Forms.Button btnImport;
		protected System.Windows.Forms.Button btnExport;
		protected System.Windows.Forms.OpenFileDialog opnImage;
		protected System.Windows.Forms.SaveFileDialog savImage;
		protected System.Windows.Forms.NumericUpDown numFrameHeight;
		protected System.Windows.Forms.NumericUpDown numFrameWidth;
		protected System.Windows.Forms.NumericUpDown numFrameTop;
		protected System.Windows.Forms.NumericUpDown numFrameLeft;
		protected System.Windows.Forms.Label label9;
		protected System.Windows.Forms.Label label10;
		protected System.Windows.Forms.CheckBox chkRelative;
		protected System.Windows.Forms.Button btnNext;
		protected System.Windows.Forms.Button btnPrev;
		protected System.Windows.Forms.Label lblFrame;
	}
}
