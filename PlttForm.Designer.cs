namespace LfdResourceEditor
{
	partial class PlttForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlttForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.numStartIndex = new System.Windows.Forms.NumericUpDown();
			this.numEndIndex = new System.Windows.Forms.NumericUpDown();
			this.pnlClr0 = new System.Windows.Forms.Panel();
			this.lblColor = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.numRotators = new System.Windows.Forms.NumericUpDown();
			this.clrDlg = new System.Windows.Forms.ColorDialog();
			this.grpRotators = new System.Windows.Forms.GroupBox();
			this.cmdPlay = new System.Windows.Forms.Button();
			this.lblFrames = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.numFrameDivider = new System.Windows.Forms.NumericUpDown();
			this.numRotatorEnd = new System.Windows.Forms.NumericUpDown();
			this.numRotatorStart = new System.Windows.Forms.NumericUpDown();
			this.numRotatorIndex = new System.Windows.Forms.NumericUpDown();
			this.tmrRotator = new System.Windows.Forms.Timer(this.components);
			this.cmdUpdate = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numStartIndex)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numEndIndex)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numRotators)).BeginInit();
			this.grpRotators.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numFrameDivider)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numRotatorEnd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numRotatorStart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numRotatorIndex)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Start Index:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "End Index:";
			// 
			// numStartIndex
			// 
			this.numStartIndex.Location = new System.Drawing.Point(79, 12);
			this.numStartIndex.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.numStartIndex.Name = "numStartIndex";
			this.numStartIndex.ReadOnly = true;
			this.numStartIndex.Size = new System.Drawing.Size(41, 20);
			this.numStartIndex.TabIndex = 6;
			// 
			// numEndIndex
			// 
			this.numEndIndex.Location = new System.Drawing.Point(79, 38);
			this.numEndIndex.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.numEndIndex.Name = "numEndIndex";
			this.numEndIndex.ReadOnly = true;
			this.numEndIndex.Size = new System.Drawing.Size(41, 20);
			this.numEndIndex.TabIndex = 6;
			// 
			// pnlClr0
			// 
			this.pnlClr0.Location = new System.Drawing.Point(166, 14);
			this.pnlClr0.Name = "pnlClr0";
			this.pnlClr0.Size = new System.Drawing.Size(256, 256);
			this.pnlClr0.TabIndex = 7;
			this.pnlClr0.Click += new System.EventHandler(this.pnlColors_Click);
			this.pnlClr0.MouseEnter += new System.EventHandler(this.pnlColors_MouseEnter);
			// 
			// lblColor
			// 
			this.lblColor.AutoSize = true;
			this.lblColor.Location = new System.Drawing.Point(164, 283);
			this.lblColor.Name = "lblColor";
			this.lblColor.Size = new System.Drawing.Size(86, 13);
			this.lblColor.TabIndex = 8;
			this.lblColor.Text = "Index:, R:, G:, B:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 66);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(102, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Number of Rotators:";
			// 
			// numRotators
			// 
			this.numRotators.Location = new System.Drawing.Point(120, 64);
			this.numRotators.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.numRotators.Name = "numRotators";
			this.numRotators.ReadOnly = true;
			this.numRotators.Size = new System.Drawing.Size(41, 20);
			this.numRotators.TabIndex = 6;
			this.numRotators.ValueChanged += new System.EventHandler(this.numRotators_ValueChanged);
			// 
			// clrDlg
			// 
			this.clrDlg.SolidColorOnly = true;
			// 
			// grpRotators
			// 
			this.grpRotators.Controls.Add(this.cmdPlay);
			this.grpRotators.Controls.Add(this.lblFrames);
			this.grpRotators.Controls.Add(this.label8);
			this.grpRotators.Controls.Add(this.label7);
			this.grpRotators.Controls.Add(this.label6);
			this.grpRotators.Controls.Add(this.label5);
			this.grpRotators.Controls.Add(this.numFrameDivider);
			this.grpRotators.Controls.Add(this.numRotatorEnd);
			this.grpRotators.Controls.Add(this.numRotatorStart);
			this.grpRotators.Controls.Add(this.numRotatorIndex);
			this.grpRotators.Enabled = false;
			this.grpRotators.Location = new System.Drawing.Point(12, 90);
			this.grpRotators.Name = "grpRotators";
			this.grpRotators.Size = new System.Drawing.Size(149, 162);
			this.grpRotators.TabIndex = 10;
			this.grpRotators.TabStop = false;
			this.grpRotators.Text = "Rotators";
			this.grpRotators.EnabledChanged += new System.EventHandler(this.grpRotators_EnabledChanged);
			// 
			// cmdPlay
			// 
			this.cmdPlay.Location = new System.Drawing.Point(52, 131);
			this.cmdPlay.Name = "cmdPlay";
			this.cmdPlay.Size = new System.Drawing.Size(48, 23);
			this.cmdPlay.TabIndex = 11;
			this.cmdPlay.Text = "&Play";
			this.cmdPlay.UseVisualStyleBackColor = true;
			this.cmdPlay.Click += new System.EventHandler(this.cmdPlay_Click);
			// 
			// lblFrames
			// 
			this.lblFrames.AutoSize = true;
			this.lblFrames.Location = new System.Drawing.Point(71, 115);
			this.lblFrames.Name = "lblFrames";
			this.lblFrames.Size = new System.Drawing.Size(57, 13);
			this.lblFrames.TabIndex = 11;
			this.lblFrames.Text = "= X frames";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 94);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(75, 13);
			this.label8.TabIndex = 11;
			this.label8.Text = "Frame Divider:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 68);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(58, 13);
			this.label7.TabIndex = 11;
			this.label7.Text = "End Index:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 42);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(61, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "Start Index:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Number:";
			// 
			// numFrameDivider
			// 
			this.numFrameDivider.Enabled = false;
			this.numFrameDivider.Location = new System.Drawing.Point(87, 92);
			this.numFrameDivider.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.numFrameDivider.Name = "numFrameDivider";
			this.numFrameDivider.Size = new System.Drawing.Size(61, 20);
			this.numFrameDivider.TabIndex = 6;
			this.numFrameDivider.ValueChanged += new System.EventHandler(this.numFrameDivider_ValueChanged);
			// 
			// numRotatorEnd
			// 
			this.numRotatorEnd.Location = new System.Drawing.Point(73, 66);
			this.numRotatorEnd.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.numRotatorEnd.Name = "numRotatorEnd";
			this.numRotatorEnd.ReadOnly = true;
			this.numRotatorEnd.Size = new System.Drawing.Size(41, 20);
			this.numRotatorEnd.TabIndex = 6;
			// 
			// numRotatorStart
			// 
			this.numRotatorStart.Location = new System.Drawing.Point(73, 40);
			this.numRotatorStart.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.numRotatorStart.Name = "numRotatorStart";
			this.numRotatorStart.ReadOnly = true;
			this.numRotatorStart.Size = new System.Drawing.Size(41, 20);
			this.numRotatorStart.TabIndex = 6;
			// 
			// numRotatorIndex
			// 
			this.numRotatorIndex.Location = new System.Drawing.Point(59, 14);
			this.numRotatorIndex.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.numRotatorIndex.Name = "numRotatorIndex";
			this.numRotatorIndex.Size = new System.Drawing.Size(41, 20);
			this.numRotatorIndex.TabIndex = 6;
			this.numRotatorIndex.ValueChanged += new System.EventHandler(this.numRotatorIndex_ValueChanged);
			// 
			// tmrRotator
			// 
			this.tmrRotator.Interval = 80;
			this.tmrRotator.Tick += new System.EventHandler(this.tmrRotator_Tick);
			// 
			// cmdUpdate
			// 
			this.cmdUpdate.Location = new System.Drawing.Point(21, 272);
			this.cmdUpdate.Name = "cmdUpdate";
			this.cmdUpdate.Size = new System.Drawing.Size(75, 23);
			this.cmdUpdate.TabIndex = 11;
			this.cmdUpdate.Text = "&Update";
			this.cmdUpdate.UseVisualStyleBackColor = true;
			this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
			// 
			// PlttForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(436, 307);
			this.Controls.Add(this.cmdUpdate);
			this.Controls.Add(this.grpRotators);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblColor);
			this.Controls.Add(this.pnlClr0);
			this.Controls.Add(this.numRotators);
			this.Controls.Add(this.numEndIndex);
			this.Controls.Add(this.numStartIndex);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "PlttForm";
			this.Text = "PlttForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlttForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.numStartIndex)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numEndIndex)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numRotators)).EndInit();
			this.grpRotators.ResumeLayout(false);
			this.grpRotators.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numFrameDivider)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numRotatorEnd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numRotatorStart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numRotatorIndex)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numStartIndex;
		private System.Windows.Forms.NumericUpDown numEndIndex;
		private System.Windows.Forms.Panel pnlClr0;
		private System.Windows.Forms.Label lblColor;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown numRotators;
		private System.Windows.Forms.ColorDialog clrDlg;
		private System.Windows.Forms.GroupBox grpRotators;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown numFrameDivider;
		private System.Windows.Forms.NumericUpDown numRotatorEnd;
		private System.Windows.Forms.NumericUpDown numRotatorStart;
		private System.Windows.Forms.NumericUpDown numRotatorIndex;
		private System.Windows.Forms.Button cmdPlay;
		private System.Windows.Forms.Label lblFrames;
		private System.Windows.Forms.Timer tmrRotator;
		private System.Windows.Forms.Button cmdUpdate;
	}
}