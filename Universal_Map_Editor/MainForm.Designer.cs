namespace Universal_Map_Editor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMapAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapFileSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMapDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveMapDialog = new System.Windows.Forms.SaveFileDialog();
            this.informationBar = new System.Windows.Forms.StatusStrip();
            this.currentLoadedFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.brushToolMode = new System.Windows.Forms.ToolStripButton();
            this.fillToolMode = new System.Windows.Forms.ToolStripButton();
            this.mapDefLabel = new System.Windows.Forms.ToolStripLabel();
            this.mapDefDropDown = new System.Windows.Forms.ToolStripComboBox();
            this.tileSizeLabel = new System.Windows.Forms.ToolStripLabel();
            this.tileSizeDropDown = new System.Windows.Forms.ToolStripComboBox();
            this.tileListBox = new System.Windows.Forms.ListBox();
            this.tilesPopupMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openTileFolderButton = new System.Windows.Forms.ToolStripMenuItem();
            this.imageListLabel = new System.Windows.Forms.Label();
            this.displayPanel = new System.Windows.Forms.Panel();
            this.mapScrollBar = new System.Windows.Forms.HScrollBar();
            this.mapDivider = new System.Windows.Forms.SplitContainer();
            this.repopTileListButton = new System.Windows.Forms.Button();
            this.mainMenuStrip.SuspendLayout();
            this.informationBar.SuspendLayout();
            this.mainToolStrip.SuspendLayout();
            this.tilesPopupMenu.SuspendLayout();
            this.displayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapDivider)).BeginInit();
            this.mapDivider.Panel1.SuspendLayout();
            this.mapDivider.Panel2.SuspendLayout();
            this.mapDivider.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsMenuToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainMenuStrip.Size = new System.Drawing.Size(1022, 24);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMapToolStripMenuItem,
            this.loadMapToolStripMenuItem,
            this.saveMapAsToolStripMenuItem,
            this.saveMapToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newMapToolStripMenuItem
            // 
            this.newMapToolStripMenuItem.Name = "newMapToolStripMenuItem";
            this.newMapToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.newMapToolStripMenuItem.Text = "New Map";
            this.newMapToolStripMenuItem.Click += new System.EventHandler(this.newMapToolStripMenuItem_Click);
            // 
            // loadMapToolStripMenuItem
            // 
            this.loadMapToolStripMenuItem.Name = "loadMapToolStripMenuItem";
            this.loadMapToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.loadMapToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.loadMapToolStripMenuItem.Text = "Load";
            this.loadMapToolStripMenuItem.Click += new System.EventHandler(this.loadMapToolStripMenuItem_Click);
            // 
            // saveMapAsToolStripMenuItem
            // 
            this.saveMapAsToolStripMenuItem.Name = "saveMapAsToolStripMenuItem";
            this.saveMapAsToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.saveMapAsToolStripMenuItem.Text = "Save as..";
            this.saveMapAsToolStripMenuItem.Click += new System.EventHandler(this.saveMapAsToolStripMenuItem_Click);
            // 
            // saveMapToolStripMenuItem
            // 
            this.saveMapToolStripMenuItem.Name = "saveMapToolStripMenuItem";
            this.saveMapToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.saveMapToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveMapToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.saveMapToolStripMenuItem.Text = "Save";
            this.saveMapToolStripMenuItem.Click += new System.EventHandler(this.saveMapToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsMenuToolStripMenuItem
            // 
            this.optionsMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mapFileSettingsToolStripMenuItem});
            this.optionsMenuToolStripMenuItem.Name = "optionsMenuToolStripMenuItem";
            this.optionsMenuToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsMenuToolStripMenuItem.Text = "Options";
            // 
            // mapFileSettingsToolStripMenuItem
            // 
            this.mapFileSettingsToolStripMenuItem.Name = "mapFileSettingsToolStripMenuItem";
            this.mapFileSettingsToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.mapFileSettingsToolStripMenuItem.Text = "Add Map Definition";
            this.mapFileSettingsToolStripMenuItem.Click += new System.EventHandler(this.mapFileSettingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionInformationToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // versionInformationToolStripMenuItem
            // 
            this.versionInformationToolStripMenuItem.Name = "versionInformationToolStripMenuItem";
            this.versionInformationToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.versionInformationToolStripMenuItem.Text = "Version Information";
            this.versionInformationToolStripMenuItem.Click += new System.EventHandler(this.versionInformationToolStripMenuItem_Click);
            // 
            // loadMapDialog
            // 
            this.loadMapDialog.Filter = "Hunter Map Files|*.txt";
            this.loadMapDialog.Title = "Choose a map file.";
            // 
            // saveMapDialog
            // 
            this.saveMapDialog.Filter = "Hunter Map Files|*.txt";
            this.saveMapDialog.Title = "Choose a location to save your map.";
            // 
            // informationBar
            // 
            this.informationBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentLoadedFile});
            this.informationBar.Location = new System.Drawing.Point(0, 552);
            this.informationBar.Name = "informationBar";
            this.informationBar.Size = new System.Drawing.Size(1022, 22);
            this.informationBar.SizingGrip = false;
            this.informationBar.TabIndex = 3;
            // 
            // currentLoadedFile
            // 
            this.currentLoadedFile.Name = "currentLoadedFile";
            this.currentLoadedFile.Size = new System.Drawing.Size(102, 17);
            this.currentLoadedFile.Text = "File: None Loaded";
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brushToolMode,
            this.fillToolMode,
            this.mapDefLabel,
            this.mapDefDropDown,
            this.tileSizeLabel,
            this.tileSizeDropDown});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 24);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mainToolStrip.Size = new System.Drawing.Size(1022, 25);
            this.mainToolStrip.TabIndex = 1;
            this.mainToolStrip.Text = "toolStrip1";
            // 
            // brushToolMode
            // 
            this.brushToolMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.brushToolMode.Image = global::Universal_Map_Editor.Properties.Resources.brush;
            this.brushToolMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.brushToolMode.Name = "brushToolMode";
            this.brushToolMode.Size = new System.Drawing.Size(23, 22);
            this.brushToolMode.Text = "Brush Mode";
            this.brushToolMode.Click += new System.EventHandler(this.brushToolMode_Click);
            // 
            // fillToolMode
            // 
            this.fillToolMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fillToolMode.Image = global::Universal_Map_Editor.Properties.Resources.paint;
            this.fillToolMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fillToolMode.Name = "fillToolMode";
            this.fillToolMode.Size = new System.Drawing.Size(23, 22);
            this.fillToolMode.Text = "Fill Mode";
            this.fillToolMode.Click += new System.EventHandler(this.fillToolMode_Click);
            // 
            // mapDefLabel
            // 
            this.mapDefLabel.Name = "mapDefLabel";
            this.mapDefLabel.Size = new System.Drawing.Size(89, 22);
            this.mapDefLabel.Text = "Map Definition:";
            // 
            // mapDefDropDown
            // 
            this.mapDefDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mapDefDropDown.Name = "mapDefDropDown";
            this.mapDefDropDown.Size = new System.Drawing.Size(121, 25);
            // 
            // tileSizeLabel
            // 
            this.tileSizeLabel.Name = "tileSizeLabel";
            this.tileSizeLabel.Size = new System.Drawing.Size(52, 22);
            this.tileSizeLabel.Text = "Tile Size:";
            // 
            // tileSizeDropDown
            // 
            this.tileSizeDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tileSizeDropDown.DropDownWidth = 75;
            this.tileSizeDropDown.Items.AddRange(new object[] {
            "12px",
            "16px",
            "24px",
            "32px",
            "48px",
            "64px"});
            this.tileSizeDropDown.Name = "tileSizeDropDown";
            this.tileSizeDropDown.Size = new System.Drawing.Size(75, 25);
            this.tileSizeDropDown.SelectedIndexChanged += new System.EventHandler(this.tileSizeComboBox_SelectedIndexChanged);
            // 
            // tileListBox
            // 
            this.tileListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tileListBox.ContextMenuStrip = this.tilesPopupMenu;
            this.tileListBox.FormattingEnabled = true;
            this.tileListBox.Location = new System.Drawing.Point(0, 31);
            this.tileListBox.Name = "tileListBox";
            this.tileListBox.Size = new System.Drawing.Size(208, 472);
            this.tileListBox.TabIndex = 4;
            this.tileListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tilesPopupMenu
            // 
            this.tilesPopupMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTileFolderButton});
            this.tilesPopupMenu.Name = "tilesPopupMenu";
            this.tilesPopupMenu.Size = new System.Drawing.Size(160, 26);
            // 
            // openTileFolderButton
            // 
            this.openTileFolderButton.Name = "openTileFolderButton";
            this.openTileFolderButton.Size = new System.Drawing.Size(159, 22);
            this.openTileFolderButton.Text = "Open tile folder.";
            this.openTileFolderButton.Click += new System.EventHandler(this.openTileFolderButton_Click);
            // 
            // imageListLabel
            // 
            this.imageListLabel.AutoSize = true;
            this.imageListLabel.Location = new System.Drawing.Point(2, 8);
            this.imageListLabel.Name = "imageListLabel";
            this.imageListLabel.Size = new System.Drawing.Size(78, 13);
            this.imageListLabel.TabIndex = 5;
            this.imageListLabel.Text = "Available Tiles:";
            // 
            // displayPanel
            // 
            this.displayPanel.AutoScroll = true;
            this.displayPanel.AutoSize = true;
            this.displayPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.displayPanel.Controls.Add(this.mapScrollBar);
            this.displayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayPanel.Location = new System.Drawing.Point(0, 0);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size(810, 503);
            this.displayPanel.TabIndex = 0;
            this.displayPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.displayPanel_MouseDown);
            this.displayPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.displayPanel_MouseMove);
            this.displayPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.displayPanel_MouseUp);
            this.displayPanel.Resize += new System.EventHandler(this.displayPanel_Resize);
            // 
            // mapScrollBar
            // 
            this.mapScrollBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mapScrollBar.Location = new System.Drawing.Point(0, 486);
            this.mapScrollBar.Maximum = 59;
            this.mapScrollBar.Name = "mapScrollBar";
            this.mapScrollBar.Size = new System.Drawing.Size(810, 17);
            this.mapScrollBar.TabIndex = 0;
            this.mapScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.mapScrollBar_Scroll);
            // 
            // mapDivider
            // 
            this.mapDivider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapDivider.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.mapDivider.Location = new System.Drawing.Point(0, 49);
            this.mapDivider.Name = "mapDivider";
            // 
            // mapDivider.Panel1
            // 
            this.mapDivider.Panel1.Controls.Add(this.displayPanel);
            // 
            // mapDivider.Panel2
            // 
            this.mapDivider.Panel2.Controls.Add(this.tileListBox);
            this.mapDivider.Panel2.Controls.Add(this.repopTileListButton);
            this.mapDivider.Panel2.Controls.Add(this.imageListLabel);
            this.mapDivider.Size = new System.Drawing.Size(1022, 503);
            this.mapDivider.SplitterDistance = 810;
            this.mapDivider.TabIndex = 1;
            // 
            // repopTileListButton
            // 
            this.repopTileListButton.Image = global::Universal_Map_Editor.Properties.Resources.Repopulate;
            this.repopTileListButton.Location = new System.Drawing.Point(133, 3);
            this.repopTileListButton.Name = "repopTileListButton";
            this.repopTileListButton.Size = new System.Drawing.Size(72, 23);
            this.repopTileListButton.TabIndex = 6;
            this.repopTileListButton.Text = "Refresh";
            this.repopTileListButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.repopTileListButton.UseVisualStyleBackColor = true;
            this.repopTileListButton.Click += new System.EventHandler(this.repopTileListButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 574);
            this.Controls.Add(this.mapDivider);
            this.Controls.Add(this.mainToolStrip);
            this.Controls.Add(this.informationBar);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Universal 2D Map Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.informationBar.ResumeLayout(false);
            this.informationBar.PerformLayout();
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.tilesPopupMenu.ResumeLayout(false);
            this.displayPanel.ResumeLayout(false);
            this.mapDivider.Panel1.ResumeLayout(false);
            this.mapDivider.Panel1.PerformLayout();
            this.mapDivider.Panel2.ResumeLayout(false);
            this.mapDivider.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapDivider)).EndInit();
            this.mapDivider.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog loadMapDialog;
        private System.Windows.Forms.SaveFileDialog saveMapDialog;
        private System.Windows.Forms.StatusStrip informationBar;
        private System.Windows.Forms.ToolStripStatusLabel currentLoadedFile;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripMenuItem saveMapAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapFileSettingsToolStripMenuItem;
        private System.Windows.Forms.ListBox tileListBox;
        private System.Windows.Forms.Label imageListLabel;
        private System.Windows.Forms.Button repopTileListButton;
        private System.Windows.Forms.ToolStripComboBox tileSizeDropDown;
        private System.Windows.Forms.ToolStripComboBox mapDefDropDown;
        private System.Windows.Forms.ToolStripLabel mapDefLabel;
        private System.Windows.Forms.ToolStripLabel tileSizeLabel;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionInformationToolStripMenuItem;
        private System.Windows.Forms.Panel displayPanel;
        private System.Windows.Forms.HScrollBar mapScrollBar;
        private System.Windows.Forms.SplitContainer mapDivider;
        private System.Windows.Forms.ToolStripButton brushToolMode;
        private System.Windows.Forms.ContextMenuStrip tilesPopupMenu;
        private System.Windows.Forms.ToolStripMenuItem openTileFolderButton;
        private System.Windows.Forms.ToolStripButton fillToolMode;
    }
}

