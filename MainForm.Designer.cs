namespace Idmr.LfdResourceEditor
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuMain = new System.Windows.Forms.MenuStrip();
			this.miFile = new System.Windows.Forms.ToolStripMenuItem();
			this.miFileOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.miFileSave = new System.Windows.Forms.ToolStripMenuItem();
			this.miFileSaveAll = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.miFileQuit = new System.Windows.Forms.ToolStripMenuItem();
			this.miResource = new System.Windows.Forms.ToolStripMenuItem();
			this.miResourceClose = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.miLfd = new System.Windows.Forms.ToolStripMenuItem();
			this.miLfdClose = new System.Windows.Forms.ToolStripMenuItem();
			this.miLfdCloseAll = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.cboOpenedLfds = new System.Windows.Forms.ToolStripComboBox();
			this.opnLfd = new System.Windows.Forms.OpenFileDialog();
			this.lstResources = new System.Windows.Forms.ListBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.miResourceExport = new System.Windows.Forms.ToolStripMenuItem();
			this.savResource = new System.Windows.Forms.SaveFileDialog();
			this.menuMain.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuMain
			// 
			this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.miResource,
            this.miLfd});
			this.menuMain.Location = new System.Drawing.Point(0, 0);
			this.menuMain.MdiWindowListItem = this.miResource;
			this.menuMain.Name = "menuMain";
			this.menuMain.Size = new System.Drawing.Size(1064, 24);
			this.menuMain.TabIndex = 0;
			this.menuMain.Text = "menuStrip1";
			// 
			// miFile
			// 
			this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFileOpen,
            this.miFileSave,
            this.miFileSaveAll,
            this.toolStripSeparator1,
            this.miFileQuit});
			this.miFile.Name = "miFile";
			this.miFile.Size = new System.Drawing.Size(37, 20);
			this.miFile.Text = "&File";
			// 
			// miFileOpen
			// 
			this.miFileOpen.Name = "miFileOpen";
			this.miFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.miFileOpen.Size = new System.Drawing.Size(180, 22);
			this.miFileOpen.Text = "&Open";
			this.miFileOpen.Click += new System.EventHandler(this.miFileOpen_Click);
			// 
			// miFileSave
			// 
			this.miFileSave.Enabled = false;
			this.miFileSave.Name = "miFileSave";
			this.miFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.miFileSave.Size = new System.Drawing.Size(180, 22);
			this.miFileSave.Text = "&Save";
			this.miFileSave.Click += new System.EventHandler(this.miFileSave_Click);
			// 
			// miFileSaveAll
			// 
			this.miFileSaveAll.Enabled = false;
			this.miFileSaveAll.Name = "miFileSaveAll";
			this.miFileSaveAll.Size = new System.Drawing.Size(180, 22);
			this.miFileSaveAll.Text = "Save &All";
			this.miFileSaveAll.Click += new System.EventHandler(this.miFileSaveAll_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
			// 
			// miFileQuit
			// 
			this.miFileQuit.Name = "miFileQuit";
			this.miFileQuit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
			this.miFileQuit.Size = new System.Drawing.Size(180, 22);
			this.miFileQuit.Text = "&Quit";
			this.miFileQuit.Click += new System.EventHandler(this.miFileQuit_Click);
			// 
			// miResource
			// 
			this.miResource.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miResourceExport,
            this.miResourceClose,
            this.toolStripSeparator2});
			this.miResource.Name = "miResource";
			this.miResource.Size = new System.Drawing.Size(67, 20);
			this.miResource.Text = "&Resource";
			// 
			// miResourceClose
			// 
			this.miResourceClose.Name = "miResourceClose";
			this.miResourceClose.Size = new System.Drawing.Size(180, 22);
			this.miResourceClose.Text = "&Close";
			this.miResourceClose.Click += new System.EventHandler(this.miResourceClose_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
			// 
			// miLfd
			// 
			this.miLfd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miLfdClose,
            this.miLfdCloseAll,
            this.toolStripSeparator3,
            this.cboOpenedLfds});
			this.miLfd.Name = "miLfd";
			this.miLfd.Size = new System.Drawing.Size(36, 20);
			this.miLfd.Text = "&Lfd";
			// 
			// miLfdClose
			// 
			this.miLfdClose.Name = "miLfdClose";
			this.miLfdClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
			this.miLfdClose.Size = new System.Drawing.Size(181, 22);
			this.miLfdClose.Text = "&Close";
			this.miLfdClose.Click += new System.EventHandler(this.miLfdClose_Click);
			// 
			// miLfdCloseAll
			// 
			this.miLfdCloseAll.Name = "miLfdCloseAll";
			this.miLfdCloseAll.Size = new System.Drawing.Size(181, 22);
			this.miLfdCloseAll.Text = "Close &All";
			this.miLfdCloseAll.Click += new System.EventHandler(this.miLfdCloseAll_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(178, 6);
			// 
			// cboOpenedLfds
			// 
			this.cboOpenedLfds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboOpenedLfds.Name = "cboOpenedLfds";
			this.cboOpenedLfds.Size = new System.Drawing.Size(121, 23);
			this.cboOpenedLfds.SelectedIndexChanged += new System.EventHandler(this.cboOpenedLfds_SelectedIndexChanged);
			// 
			// opnLfd
			// 
			this.opnLfd.DefaultExt = "lfd";
			this.opnLfd.Filter = "LFD Files|*.lfd|All files|*.*";
			this.opnLfd.FileOk += new System.ComponentModel.CancelEventHandler(this.opnLfd_FileOk);
			// 
			// lstResources
			// 
			this.lstResources.FormattingEnabled = true;
			this.lstResources.Location = new System.Drawing.Point(3, 3);
			this.lstResources.Name = "lstResources";
			this.lstResources.ScrollAlwaysVisible = true;
			this.lstResources.Size = new System.Drawing.Size(114, 407);
			this.lstResources.TabIndex = 6;
			this.lstResources.SelectedIndexChanged += new System.EventHandler(this.lstResources_SelectedIndexChanged);
			this.lstResources.DoubleClick += new System.EventHandler(this.lstResources_DoubleClick);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lstResources);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 24);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(120, 594);
			this.panel1.TabIndex = 8;
			// 
			// miResourceExport
			// 
			this.miResourceExport.Name = "miResourceExport";
			this.miResourceExport.Size = new System.Drawing.Size(180, 22);
			this.miResourceExport.Text = "&Export";
			this.miResourceExport.Click += new System.EventHandler(this.miResourceExport_Click);
			// 
			// savResource
			// 
			this.savResource.Title = "Export Resource";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1064, 618);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuMain;
			this.Name = "MainForm";
			this.Text = "LFD Resource Editor";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.MdiChildActivate += new System.EventHandler(this.MainForm_MdiChildActivate);
			this.menuMain.ResumeLayout(false);
			this.menuMain.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuMain;
		private System.Windows.Forms.ToolStripMenuItem miFile;
		private System.Windows.Forms.ToolStripMenuItem miFileOpen;
		private System.Windows.Forms.ToolStripMenuItem miFileSave;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem miFileQuit;
		private System.Windows.Forms.OpenFileDialog opnLfd;
		private System.Windows.Forms.ToolStripMenuItem miResource;
		private System.Windows.Forms.ToolStripMenuItem miLfd;
		private System.Windows.Forms.ListBox lstResources;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ToolStripMenuItem miResourceClose;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem miLfdClose;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripComboBox cboOpenedLfds;
		private System.Windows.Forms.ToolStripMenuItem miLfdCloseAll;
		private System.Windows.Forms.ToolStripMenuItem miFileSaveAll;
		private System.Windows.Forms.ToolStripMenuItem miResourceExport;
		private System.Windows.Forms.SaveFileDialog savResource;
	}
}

