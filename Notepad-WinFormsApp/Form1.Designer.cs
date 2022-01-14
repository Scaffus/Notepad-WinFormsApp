
namespace Notepad_WinFormsApp
{
    partial class NotesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotesForm));
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullscreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtxtbContent = new System.Windows.Forms.RichTextBox();
            this.ofdialOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.sfdialSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.fdialFont = new System.Windows.Forms.FontDialog();
            this.cdialColor = new System.Windows.Forms.ColorDialog();
            this.process = new System.Diagnostics.Process();
            this.btnClose = new System.Windows.Forms.Button();
            this.panlInfos = new System.Windows.Forms.Panel();
            this.lablEncoding = new System.Windows.Forms.Label();
            this.lablZoom = new System.Windows.Forms.Label();
            this.lablWords = new System.Windows.Forms.Label();
            this.lablColumnLigns = new System.Windows.Forms.Label();
            this.panlTabLeft = new System.Windows.Forms.Panel();
            this.panlTabTop = new System.Windows.Forms.Panel();
            this.nupFontSize = new System.Windows.Forms.NumericUpDown();
            this.panlTools = new System.Windows.Forms.Panel();
            this.gbDisplay = new System.Windows.Forms.GroupBox();
            this.cbFullscreen = new System.Windows.Forms.CheckBox();
            this.nupZoom = new System.Windows.Forms.NumericUpDown();
            this.lablDisplayZoom_Tools = new System.Windows.Forms.Label();
            this.gpFontSize = new System.Windows.Forms.GroupBox();
            this.btnFontFamily_Tools = new System.Windows.Forms.Button();
            this.lablFontFamily_Tools = new System.Windows.Forms.Label();
            this.btnFontColor = new System.Windows.Forms.Button();
            this.lablFontColor_Tools = new System.Windows.Forms.Label();
            this.lablFontSize_Tools = new System.Windows.Forms.Label();
            this.msMenu.SuspendLayout();
            this.panlInfos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupFontSize)).BeginInit();
            this.panlTools.SuspendLayout();
            this.gbDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupZoom)).BeginInit();
            this.gpFontSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.msMenu.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.displayToolStripMenuItem,
            this.windowsToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(800, 29);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 25);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.selectAllToolStripMenuItem,
            this.dateTimeToolStripMenuItem});
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(48, 25);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // dateTimeToolStripMenuItem
            // 
            this.dateTimeToolStripMenuItem.Name = "dateTimeToolStripMenuItem";
            this.dateTimeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.dateTimeToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.dateTimeToolStripMenuItem.Text = "Date/Time";
            this.dateTimeToolStripMenuItem.Click += new System.EventHandler(this.dateTimeToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.formatToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(72, 25);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F)));
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullscreenToolStripMenuItem,
            this.zoomToolStripMenuItem,
            this.zoomToolStripMenuItem1});
            this.displayToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(73, 25);
            this.displayToolStripMenuItem.Text = "Display";
            // 
            // fullscreenToolStripMenuItem
            // 
            this.fullscreenToolStripMenuItem.Name = "fullscreenToolStripMenuItem";
            this.fullscreenToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.fullscreenToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.fullscreenToolStripMenuItem.Text = "Fullscreen";
            this.fullscreenToolStripMenuItem.Click += new System.EventHandler(this.fullscreenToolStripMenuItem_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.zoomToolStripMenuItem.Text = "Zoom -";
            this.zoomToolStripMenuItem.Click += new System.EventHandler(this.zoomToolStripMenuItem_Click);
            // 
            // zoomToolStripMenuItem1
            // 
            this.zoomToolStripMenuItem1.Name = "zoomToolStripMenuItem1";
            this.zoomToolStripMenuItem1.Size = new System.Drawing.Size(186, 26);
            this.zoomToolStripMenuItem1.Text = "Zoom +";
            this.zoomToolStripMenuItem1.Click += new System.EventHandler(this.zoomToolStripMenuItem1_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbarToolStripMenuItem});
            this.windowsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(87, 25);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // toolbarToolStripMenuItem
            // 
            this.toolbarToolStripMenuItem.Name = "toolbarToolStripMenuItem";
            this.toolbarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.toolbarToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.toolbarToolStripMenuItem.Text = "Toolbar";
            this.toolbarToolStripMenuItem.Click += new System.EventHandler(this.toolbarToolStripMenuItem_Click);
            // 
            // rtxtbContent
            // 
            this.rtxtbContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.rtxtbContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtbContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtbContent.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtbContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.rtxtbContent.Location = new System.Drawing.Point(5, 34);
            this.rtxtbContent.Name = "rtxtbContent";
            this.rtxtbContent.Size = new System.Drawing.Size(795, 392);
            this.rtxtbContent.TabIndex = 1;
            this.rtxtbContent.Text = "";
            this.rtxtbContent.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtxtbContent_LinkClicked);
            this.rtxtbContent.SelectionChanged += new System.EventHandler(this.rtxtbContent_SelectionChanged);
            this.rtxtbContent.TextChanged += new System.EventHandler(this.rtxtbContent_TextChanged);
            this.rtxtbContent.MouseHover += new System.EventHandler(this.rtxtbContent_ClientSizeChanged);
            // 
            // ofdialOpenFile
            // 
            this.ofdialOpenFile.FileName = "note.txt";
            // 
            // sfdialSaveFile
            // 
            this.sfdialSaveFile.FileName = "note";
            // 
            // process
            // 
            this.process.StartInfo.Domain = "";
            this.process.StartInfo.LoadUserProfile = false;
            this.process.StartInfo.Password = null;
            this.process.StartInfo.StandardErrorEncoding = null;
            this.process.StartInfo.StandardOutputEncoding = null;
            this.process.StartInfo.UserName = "";
            this.process.SynchronizingObject = this;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(734, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(66, 29);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "✖";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panlInfos
            // 
            this.panlInfos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.panlInfos.Controls.Add(this.lablEncoding);
            this.panlInfos.Controls.Add(this.lablZoom);
            this.panlInfos.Controls.Add(this.lablWords);
            this.panlInfos.Controls.Add(this.lablColumnLigns);
            this.panlInfos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panlInfos.Location = new System.Drawing.Point(0, 426);
            this.panlInfos.Name = "panlInfos";
            this.panlInfos.Size = new System.Drawing.Size(800, 24);
            this.panlInfos.TabIndex = 3;
            // 
            // lablEncoding
            // 
            this.lablEncoding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lablEncoding.AutoSize = true;
            this.lablEncoding.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablEncoding.Location = new System.Drawing.Point(72, 3);
            this.lablEncoding.Name = "lablEncoding";
            this.lablEncoding.Size = new System.Drawing.Size(41, 15);
            this.lablEncoding.TabIndex = 3;
            this.lablEncoding.Text = "UTF-8";
            // 
            // lablZoom
            // 
            this.lablZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lablZoom.AutoSize = true;
            this.lablZoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablZoom.Location = new System.Drawing.Point(656, 3);
            this.lablZoom.Name = "lablZoom";
            this.lablZoom.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.lablZoom.Size = new System.Drawing.Size(89, 15);
            this.lablZoom.TabIndex = 2;
            this.lablZoom.Text = "Zoom 100%";
            // 
            // lablWords
            // 
            this.lablWords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lablWords.AutoSize = true;
            this.lablWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablWords.Location = new System.Drawing.Point(745, 3);
            this.lablWords.Name = "lablWords";
            this.lablWords.Size = new System.Drawing.Size(52, 15);
            this.lablWords.TabIndex = 1;
            this.lablWords.Text = "Words 0";
            // 
            // lablColumnLigns
            // 
            this.lablColumnLigns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lablColumnLigns.AutoSize = true;
            this.lablColumnLigns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablColumnLigns.Location = new System.Drawing.Point(1, 3);
            this.lablColumnLigns.Name = "lablColumnLigns";
            this.lablColumnLigns.Size = new System.Drawing.Size(65, 15);
            this.lablColumnLigns.TabIndex = 0;
            this.lablColumnLigns.Text = "Col 1, Ln 1";
            // 
            // panlTabLeft
            // 
            this.panlTabLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panlTabLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panlTabLeft.Location = new System.Drawing.Point(0, 29);
            this.panlTabLeft.Name = "panlTabLeft";
            this.panlTabLeft.Size = new System.Drawing.Size(5, 397);
            this.panlTabLeft.TabIndex = 4;
            // 
            // panlTabTop
            // 
            this.panlTabTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panlTabTop.Location = new System.Drawing.Point(5, 29);
            this.panlTabTop.Name = "panlTabTop";
            this.panlTabTop.Size = new System.Drawing.Size(795, 5);
            this.panlTabTop.TabIndex = 5;
            // 
            // nupFontSize
            // 
            this.nupFontSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nupFontSize.AutoSize = true;
            this.nupFontSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.nupFontSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nupFontSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupFontSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.nupFontSize.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nupFontSize.Location = new System.Drawing.Point(148, 17);
            this.nupFontSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupFontSize.Name = "nupFontSize";
            this.nupFontSize.Size = new System.Drawing.Size(52, 22);
            this.nupFontSize.TabIndex = 6;
            this.nupFontSize.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nupFontSize.ValueChanged += new System.EventHandler(this.nupFontSize_ValueChanged);
            // 
            // panlTools
            // 
            this.panlTools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panlTools.AutoSize = true;
            this.panlTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.panlTools.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panlTools.Controls.Add(this.gbDisplay);
            this.panlTools.Controls.Add(this.gpFontSize);
            this.panlTools.Location = new System.Drawing.Point(564, 40);
            this.panlTools.Name = "panlTools";
            this.panlTools.Padding = new System.Windows.Forms.Padding(8);
            this.panlTools.Size = new System.Drawing.Size(224, 209);
            this.panlTools.TabIndex = 7;
            // 
            // gbDisplay
            // 
            this.gbDisplay.Controls.Add(this.cbFullscreen);
            this.gbDisplay.Controls.Add(this.nupZoom);
            this.gbDisplay.Controls.Add(this.lablDisplayZoom_Tools);
            this.gbDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.gbDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.gbDisplay.Location = new System.Drawing.Point(8, 123);
            this.gbDisplay.Name = "gbDisplay";
            this.gbDisplay.Size = new System.Drawing.Size(206, 76);
            this.gbDisplay.TabIndex = 9;
            this.gbDisplay.TabStop = false;
            this.gbDisplay.Text = "Display";
            // 
            // cbFullscreen
            // 
            this.cbFullscreen.AutoSize = true;
            this.cbFullscreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFullscreen.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.cbFullscreen.Location = new System.Drawing.Point(10, 45);
            this.cbFullscreen.Name = "cbFullscreen";
            this.cbFullscreen.Size = new System.Drawing.Size(96, 25);
            this.cbFullscreen.TabIndex = 13;
            this.cbFullscreen.Text = "Fullscreen";
            this.cbFullscreen.UseVisualStyleBackColor = true;
            this.cbFullscreen.CheckedChanged += new System.EventHandler(this.cbFullscreen_CheckedChanged);
            // 
            // nupZoom
            // 
            this.nupZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nupZoom.AutoSize = true;
            this.nupZoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.nupZoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nupZoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupZoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.nupZoom.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nupZoom.Location = new System.Drawing.Point(148, 19);
            this.nupZoom.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nupZoom.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nupZoom.Name = "nupZoom";
            this.nupZoom.Size = new System.Drawing.Size(52, 22);
            this.nupZoom.TabIndex = 12;
            this.nupZoom.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nupZoom.ValueChanged += new System.EventHandler(this.nupZoom_ValueChanged);
            // 
            // lablDisplayZoom_Tools
            // 
            this.lablDisplayZoom_Tools.AutoSize = true;
            this.lablDisplayZoom_Tools.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablDisplayZoom_Tools.Location = new System.Drawing.Point(6, 17);
            this.lablDisplayZoom_Tools.Name = "lablDisplayZoom_Tools";
            this.lablDisplayZoom_Tools.Size = new System.Drawing.Size(51, 21);
            this.lablDisplayZoom_Tools.TabIndex = 12;
            this.lablDisplayZoom_Tools.Text = "Zoom";
            // 
            // gpFontSize
            // 
            this.gpFontSize.Controls.Add(this.btnFontFamily_Tools);
            this.gpFontSize.Controls.Add(this.lablFontFamily_Tools);
            this.gpFontSize.Controls.Add(this.btnFontColor);
            this.gpFontSize.Controls.Add(this.lablFontColor_Tools);
            this.gpFontSize.Controls.Add(this.lablFontSize_Tools);
            this.gpFontSize.Controls.Add(this.nupFontSize);
            this.gpFontSize.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpFontSize.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpFontSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.gpFontSize.Location = new System.Drawing.Point(8, 8);
            this.gpFontSize.Name = "gpFontSize";
            this.gpFontSize.Size = new System.Drawing.Size(206, 115);
            this.gpFontSize.TabIndex = 8;
            this.gpFontSize.TabStop = false;
            this.gpFontSize.Text = "Font";
            // 
            // btnFontFamily_Tools
            // 
            this.btnFontFamily_Tools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFontFamily_Tools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFontFamily_Tools.Font = new System.Drawing.Font("Nirmala UI", 8F);
            this.btnFontFamily_Tools.Location = new System.Drawing.Point(78, 72);
            this.btnFontFamily_Tools.Name = "btnFontFamily_Tools";
            this.btnFontFamily_Tools.Size = new System.Drawing.Size(122, 26);
            this.btnFontFamily_Tools.TabIndex = 13;
            this.btnFontFamily_Tools.Text = "Arial";
            this.btnFontFamily_Tools.UseVisualStyleBackColor = true;
            this.btnFontFamily_Tools.Click += new System.EventHandler(this.btnFontFamily_Tools_Click);
            // 
            // lablFontFamily_Tools
            // 
            this.lablFontFamily_Tools.AutoSize = true;
            this.lablFontFamily_Tools.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablFontFamily_Tools.Location = new System.Drawing.Point(6, 73);
            this.lablFontFamily_Tools.Name = "lablFontFamily_Tools";
            this.lablFontFamily_Tools.Size = new System.Drawing.Size(55, 21);
            this.lablFontFamily_Tools.TabIndex = 12;
            this.lablFontFamily_Tools.Text = "Family";
            // 
            // btnFontColor
            // 
            this.btnFontColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFontColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFontColor.Location = new System.Drawing.Point(180, 44);
            this.btnFontColor.Name = "btnFontColor";
            this.btnFontColor.Size = new System.Drawing.Size(20, 20);
            this.btnFontColor.TabIndex = 11;
            this.btnFontColor.UseVisualStyleBackColor = true;
            this.btnFontColor.Click += new System.EventHandler(this.btnFontColor_Click);
            // 
            // lablFontColor_Tools
            // 
            this.lablFontColor_Tools.AutoSize = true;
            this.lablFontColor_Tools.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablFontColor_Tools.Location = new System.Drawing.Point(6, 44);
            this.lablFontColor_Tools.Name = "lablFontColor_Tools";
            this.lablFontColor_Tools.Size = new System.Drawing.Size(48, 21);
            this.lablFontColor_Tools.TabIndex = 9;
            this.lablFontColor_Tools.Text = "Color";
            // 
            // lablFontSize_Tools
            // 
            this.lablFontSize_Tools.AutoSize = true;
            this.lablFontSize_Tools.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablFontSize_Tools.Location = new System.Drawing.Point(6, 18);
            this.lablFontSize_Tools.Name = "lablFontSize_Tools";
            this.lablFontSize_Tools.Size = new System.Drawing.Size(38, 21);
            this.lablFontSize_Tools.TabIndex = 7;
            this.lablFontSize_Tools.Text = "Size";
            // 
            // NotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panlTools);
            this.Controls.Add(this.rtxtbContent);
            this.Controls.Add(this.panlTabTop);
            this.Controls.Add(this.panlTabLeft);
            this.Controls.Add(this.panlInfos);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.msMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu;
            this.Name = "NotesForm";
            this.Text = "Notes";
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.panlInfos.ResumeLayout(false);
            this.panlInfos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupFontSize)).EndInit();
            this.panlTools.ResumeLayout(false);
            this.gbDisplay.ResumeLayout(false);
            this.gbDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupZoom)).EndInit();
            this.gpFontSize.ResumeLayout(false);
            this.gpFontSize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtxtbContent;
        private System.Windows.Forms.OpenFileDialog ofdialOpenFile;
        private System.Windows.Forms.SaveFileDialog sfdialSaveFile;
        private System.Windows.Forms.FontDialog fdialFont;
        private System.Windows.Forms.ColorDialog cdialColor;
        private System.Diagnostics.Process process;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panlInfos;
        private System.Windows.Forms.Label lablColumnLigns;
        private System.Windows.Forms.Label lablWords;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullscreenToolStripMenuItem;
        private System.Windows.Forms.Label lablZoom;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem1;
        private System.Windows.Forms.Panel panlTabLeft;
        private System.Windows.Forms.Panel panlTabTop;
        private System.Windows.Forms.Label lablEncoding;
        private System.Windows.Forms.NumericUpDown nupFontSize;
        private System.Windows.Forms.Panel panlTools;
        private System.Windows.Forms.Label lablFontSize_Tools;
        private System.Windows.Forms.GroupBox gpFontSize;
        private System.Windows.Forms.Label lablFontColor_Tools;
        private System.Windows.Forms.GroupBox gbDisplay;
        private System.Windows.Forms.Button btnFontColor;
        private System.Windows.Forms.NumericUpDown nupZoom;
        private System.Windows.Forms.Label lablDisplayZoom_Tools;
        private System.Windows.Forms.CheckBox cbFullscreen;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolbarToolStripMenuItem;
        private System.Windows.Forms.Button btnFontFamily_Tools;
        private System.Windows.Forms.Label lablFontFamily_Tools;
    }
}

