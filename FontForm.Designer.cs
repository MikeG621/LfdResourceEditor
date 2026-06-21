namespace Idmr.LfdResourceEditor
{
	partial class FontForm
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
			this.pnlCharMap = new System.Windows.Forms.Panel();
			this.pctGlyph = new System.Windows.Forms.PictureBox();
			this.lblStarting = new System.Windows.Forms.Label();
			this.lblCount = new System.Windows.Forms.Label();
			this.lblBits = new System.Windows.Forms.Label();
			this.lblHeight = new System.Windows.Forms.Label();
			this.lblBaseLine = new System.Windows.Forms.Label();
			this.numCount = new System.Windows.Forms.NumericUpDown();
			this.numMaxWidth = new System.Windows.Forms.NumericUpDown();
			this.numHeight = new System.Windows.Forms.NumericUpDown();
			this.numBaseLine = new System.Windows.Forms.NumericUpDown();
			this.btnPrev = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.lblGlyph = new System.Windows.Forms.Label();
			this.lblWidth = new System.Windows.Forms.Label();
			this.lblAscii = new System.Windows.Forms.Label();
			this.lblChar = new System.Windows.Forms.Label();
			this.btnImport = new System.Windows.Forms.Button();
			this.opnFont = new System.Windows.Forms.OpenFileDialog();
			this.chkEdit = new System.Windows.Forms.CheckBox();
			this.vsbCharMap = new System.Windows.Forms.VScrollBar();
			this.label1 = new System.Windows.Forms.Label();
			this.numWidth = new System.Windows.Forms.NumericUpDown();
			this.lblShownAs = new System.Windows.Forms.Label();
			this.lblEdit = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pctGlyph)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numMaxWidth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numBaseLine)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
			this.SuspendLayout();
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(5, 177);
			// 
			// pnlCharMap
			// 
			this.pnlCharMap.BackColor = System.Drawing.SystemColors.ControlDark;
			this.pnlCharMap.Location = new System.Drawing.Point(356, 10);
			this.pnlCharMap.Name = "pnlCharMap";
			this.pnlCharMap.Size = new System.Drawing.Size(346, 161);
			this.pnlCharMap.TabIndex = 1;
			this.pnlCharMap.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCharMap_Paint);
			this.pnlCharMap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlCharMap_MouseClick);
			// 
			// pctGlyph
			// 
			this.pctGlyph.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pctGlyph.Location = new System.Drawing.Point(154, 12);
			this.pctGlyph.Name = "pctGlyph";
			this.pctGlyph.Size = new System.Drawing.Size(122, 102);
			this.pctGlyph.TabIndex = 2;
			this.pctGlyph.TabStop = false;
			this.pctGlyph.Paint += new System.Windows.Forms.PaintEventHandler(this.pctGlyph_Paint);
			this.pctGlyph.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pctGlyph_MouseClick);
			// 
			// lblStarting
			// 
			this.lblStarting.AutoSize = true;
			this.lblStarting.Location = new System.Drawing.Point(12, 12);
			this.lblStarting.Name = "lblStarting";
			this.lblStarting.Size = new System.Drawing.Size(68, 13);
			this.lblStarting.TabIndex = 3;
			this.lblStarting.Text = "StartingChar:";
			// 
			// lblCount
			// 
			this.lblCount.AutoSize = true;
			this.lblCount.Location = new System.Drawing.Point(12, 38);
			this.lblCount.Name = "lblCount";
			this.lblCount.Size = new System.Drawing.Size(38, 13);
			this.lblCount.TabIndex = 4;
			this.lblCount.Text = "Count:";
			// 
			// lblBits
			// 
			this.lblBits.AutoSize = true;
			this.lblBits.Location = new System.Drawing.Point(12, 64);
			this.lblBits.Name = "lblBits";
			this.lblBits.Size = new System.Drawing.Size(50, 13);
			this.lblBits.TabIndex = 5;
			this.lblBits.Text = "Bit width:";
			// 
			// lblHeight
			// 
			this.lblHeight.AutoSize = true;
			this.lblHeight.Location = new System.Drawing.Point(12, 90);
			this.lblHeight.Name = "lblHeight";
			this.lblHeight.Size = new System.Drawing.Size(41, 13);
			this.lblHeight.TabIndex = 6;
			this.lblHeight.Text = "Height:";
			// 
			// lblBaseLine
			// 
			this.lblBaseLine.AutoSize = true;
			this.lblBaseLine.Location = new System.Drawing.Point(12, 116);
			this.lblBaseLine.Name = "lblBaseLine";
			this.lblBaseLine.Size = new System.Drawing.Size(54, 13);
			this.lblBaseLine.TabIndex = 7;
			this.lblBaseLine.Text = "BaseLine:";
			// 
			// numCount
			// 
			this.numCount.Location = new System.Drawing.Point(86, 36);
			this.numCount.Maximum = new decimal(new int[] {
            224,
            0,
            0,
            0});
			this.numCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numCount.Name = "numCount";
			this.numCount.Size = new System.Drawing.Size(46, 20);
			this.numCount.TabIndex = 8;
			this.numCount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numCount.ValueChanged += new System.EventHandler(this.numCount_ValueChanged);
			// 
			// numMaxWidth
			// 
			this.numMaxWidth.Increment = new decimal(new int[] {
            8,
            0,
            0,
            0});
			this.numMaxWidth.Location = new System.Drawing.Point(86, 62);
			this.numMaxWidth.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
			this.numMaxWidth.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
			this.numMaxWidth.Name = "numMaxWidth";
			this.numMaxWidth.Size = new System.Drawing.Size(46, 20);
			this.numMaxWidth.TabIndex = 8;
			this.numMaxWidth.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
			this.numMaxWidth.ValueChanged += new System.EventHandler(this.numMaxWidth_ValueChanged);
			// 
			// numHeight
			// 
			this.numHeight.Location = new System.Drawing.Point(86, 88);
			this.numHeight.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.numHeight.Name = "numHeight";
			this.numHeight.Size = new System.Drawing.Size(46, 20);
			this.numHeight.TabIndex = 8;
			this.numHeight.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.numHeight.ValueChanged += new System.EventHandler(this.numHeight_ValueChanged);
			// 
			// numBaseLine
			// 
			this.numBaseLine.Location = new System.Drawing.Point(86, 114);
			this.numBaseLine.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
			this.numBaseLine.Name = "numBaseLine";
			this.numBaseLine.Size = new System.Drawing.Size(46, 20);
			this.numBaseLine.TabIndex = 8;
			this.numBaseLine.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.numBaseLine.ValueChanged += new System.EventHandler(this.numBaseLine_ValueChanged);
			// 
			// btnPrev
			// 
			this.btnPrev.Location = new System.Drawing.Point(154, 118);
			this.btnPrev.Name = "btnPrev";
			this.btnPrev.Size = new System.Drawing.Size(32, 24);
			this.btnPrev.TabIndex = 9;
			this.btnPrev.Text = "<";
			this.btnPrev.UseVisualStyleBackColor = true;
			this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(218, 118);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(32, 24);
			this.btnNext.TabIndex = 9;
			this.btnNext.Text = ">";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// lblGlyph
			// 
			this.lblGlyph.AutoSize = true;
			this.lblGlyph.Location = new System.Drawing.Point(280, 12);
			this.lblGlyph.Name = "lblGlyph";
			this.lblGlyph.Size = new System.Drawing.Size(37, 13);
			this.lblGlyph.TabIndex = 10;
			this.lblGlyph.Text = "Glyph:";
			// 
			// lblWidth
			// 
			this.lblWidth.AutoSize = true;
			this.lblWidth.Location = new System.Drawing.Point(279, 38);
			this.lblWidth.Name = "lblWidth";
			this.lblWidth.Size = new System.Drawing.Size(38, 13);
			this.lblWidth.TabIndex = 11;
			this.lblWidth.Text = "Width:";
			// 
			// lblAscii
			// 
			this.lblAscii.AutoSize = true;
			this.lblAscii.Location = new System.Drawing.Point(280, 64);
			this.lblAscii.Name = "lblAscii";
			this.lblAscii.Size = new System.Drawing.Size(37, 13);
			this.lblAscii.TabIndex = 12;
			this.lblAscii.Text = "ASCII:";
			// 
			// lblChar
			// 
			this.lblChar.AutoSize = true;
			this.lblChar.Location = new System.Drawing.Point(280, 90);
			this.lblChar.Name = "lblChar";
			this.lblChar.Size = new System.Drawing.Size(32, 13);
			this.lblChar.TabIndex = 13;
			this.lblChar.Text = "Char:";
			// 
			// btnImport
			// 
			this.btnImport.Location = new System.Drawing.Point(356, 177);
			this.btnImport.Name = "btnImport";
			this.btnImport.Size = new System.Drawing.Size(86, 23);
			this.btnImport.TabIndex = 14;
			this.btnImport.Text = "&Import FONT";
			this.btnImport.UseVisualStyleBackColor = true;
			this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
			// 
			// opnFont
			// 
			this.opnFont.DefaultExt = "font";
			this.opnFont.Filter = "LFD FONT files|*.font|All files|*.*";
			this.opnFont.Title = "Import FONT file";
			// 
			// chkEdit
			// 
			this.chkEdit.AutoSize = true;
			this.chkEdit.Location = new System.Drawing.Point(165, 148);
			this.chkEdit.Name = "chkEdit";
			this.chkEdit.Size = new System.Drawing.Size(74, 17);
			this.chkEdit.TabIndex = 15;
			this.chkEdit.Text = "Edit Mode";
			this.chkEdit.UseVisualStyleBackColor = true;
			this.chkEdit.CheckedChanged += new System.EventHandler(this.chkEdit_CheckedChanged);
			// 
			// vsbCharMap
			// 
			this.vsbCharMap.Location = new System.Drawing.Point(705, 12);
			this.vsbCharMap.Name = "vsbCharMap";
			this.vsbCharMap.Size = new System.Drawing.Size(16, 159);
			this.vsbCharMap.TabIndex = 16;
			this.vsbCharMap.ValueChanged += new System.EventHandler(this.vsbCharMap_ValueChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(448, 174);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(178, 28);
			this.label1.TabIndex = 17;
			this.label1.Text = "For entire LFD Resource, *not* regular .ttf/.otf files.";
			// 
			// numWidth
			// 
			this.numWidth.Location = new System.Drawing.Point(314, 36);
			this.numWidth.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
			this.numWidth.Name = "numWidth";
			this.numWidth.ReadOnly = true;
			this.numWidth.Size = new System.Drawing.Size(38, 20);
			this.numWidth.TabIndex = 18;
			this.numWidth.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
			this.numWidth.ValueChanged += new System.EventHandler(this.numWidth_ValueChanged);
			// 
			// lblShownAs
			// 
			this.lblShownAs.Location = new System.Drawing.Point(282, 114);
			this.lblShownAs.Name = "lblShownAs";
			this.lblShownAs.Size = new System.Drawing.Size(68, 57);
			this.lblShownAs.TabIndex = 19;
			this.lblShownAs.Text = "NOTE: this is usually shown as";
			this.lblShownAs.Visible = false;
			// 
			// lblEdit
			// 
			this.lblEdit.AutoSize = true;
			this.lblEdit.Location = new System.Drawing.Point(151, 168);
			this.lblEdit.Name = "lblEdit";
			this.lblEdit.Size = new System.Drawing.Size(98, 13);
			this.lblEdit.TabIndex = 20;
			this.lblEdit.Text = "Click pixel to toggle";
			this.lblEdit.Visible = false;
			// 
			// FontForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(728, 210);
			this.Controls.Add(this.lblEdit);
			this.Controls.Add(this.lblShownAs);
			this.Controls.Add(this.numWidth);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.vsbCharMap);
			this.Controls.Add(this.chkEdit);
			this.Controls.Add(this.btnImport);
			this.Controls.Add(this.lblChar);
			this.Controls.Add(this.lblAscii);
			this.Controls.Add(this.lblWidth);
			this.Controls.Add(this.lblGlyph);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.btnPrev);
			this.Controls.Add(this.numBaseLine);
			this.Controls.Add(this.numHeight);
			this.Controls.Add(this.numMaxWidth);
			this.Controls.Add(this.numCount);
			this.Controls.Add(this.lblBaseLine);
			this.Controls.Add(this.lblHeight);
			this.Controls.Add(this.lblBits);
			this.Controls.Add(this.lblCount);
			this.Controls.Add(this.lblStarting);
			this.Controls.Add(this.pctGlyph);
			this.Controls.Add(this.pnlCharMap);
			this.Name = "FontForm";
			this.Controls.SetChildIndex(this.btnUpdate, 0);
			this.Controls.SetChildIndex(this.pnlCharMap, 0);
			this.Controls.SetChildIndex(this.pctGlyph, 0);
			this.Controls.SetChildIndex(this.lblStarting, 0);
			this.Controls.SetChildIndex(this.lblCount, 0);
			this.Controls.SetChildIndex(this.lblBits, 0);
			this.Controls.SetChildIndex(this.lblHeight, 0);
			this.Controls.SetChildIndex(this.lblBaseLine, 0);
			this.Controls.SetChildIndex(this.numCount, 0);
			this.Controls.SetChildIndex(this.numMaxWidth, 0);
			this.Controls.SetChildIndex(this.numHeight, 0);
			this.Controls.SetChildIndex(this.numBaseLine, 0);
			this.Controls.SetChildIndex(this.btnPrev, 0);
			this.Controls.SetChildIndex(this.btnNext, 0);
			this.Controls.SetChildIndex(this.lblGlyph, 0);
			this.Controls.SetChildIndex(this.lblWidth, 0);
			this.Controls.SetChildIndex(this.lblAscii, 0);
			this.Controls.SetChildIndex(this.lblChar, 0);
			this.Controls.SetChildIndex(this.btnImport, 0);
			this.Controls.SetChildIndex(this.chkEdit, 0);
			this.Controls.SetChildIndex(this.vsbCharMap, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.numWidth, 0);
			this.Controls.SetChildIndex(this.lblShownAs, 0);
			this.Controls.SetChildIndex(this.lblEdit, 0);
			((System.ComponentModel.ISupportInitialize)(this.pctGlyph)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numMaxWidth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numBaseLine)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel pnlCharMap;
		private System.Windows.Forms.PictureBox pctGlyph;
		private System.Windows.Forms.Label lblStarting;
		private System.Windows.Forms.Label lblCount;
		private System.Windows.Forms.Label lblBits;
		private System.Windows.Forms.Label lblHeight;
		private System.Windows.Forms.Label lblBaseLine;
		private System.Windows.Forms.NumericUpDown numCount;
		private System.Windows.Forms.NumericUpDown numMaxWidth;
		private System.Windows.Forms.NumericUpDown numHeight;
		private System.Windows.Forms.NumericUpDown numBaseLine;
		private System.Windows.Forms.Button btnPrev;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Label lblGlyph;
		private System.Windows.Forms.Label lblWidth;
		private System.Windows.Forms.Label lblAscii;
		private System.Windows.Forms.Label lblChar;
		private System.Windows.Forms.Button btnImport;
		private System.Windows.Forms.OpenFileDialog opnFont;
		private System.Windows.Forms.CheckBox chkEdit;
		private System.Windows.Forms.VScrollBar vsbCharMap;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numWidth;
		private System.Windows.Forms.Label lblShownAs;
		private System.Windows.Forms.Label lblEdit;
	}
}
