namespace ZpOptimizerUI
{
    partial class ZpOptimizerUI
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.gameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.sizeColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.sizeOnDiskColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pathColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.sizeOnDiskTitleLabel = new System.Windows.Forms.Label();
            this.buttonAddDir = new System.Windows.Forms.Button();
            this.sizeOnDiskLabel = new System.Windows.Forms.Label();
            this.buttonApplySelected = new System.Windows.Forms.Button();
            this.sizeTitleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sizeValueLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButtonOptimized = new System.Windows.Forms.RadioButton();
            this.radioButtonMaxComp = new System.Windows.Forms.RadioButton();
            this.radioButtonUncompressed = new System.Windows.Forms.RadioButton();
            this.fileProgressBar = new System.Windows.Forms.ProgressBar();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.folderProgressBar = new System.Windows.Forms.ProgressBar();
            this.labelResult = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Ratio = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(795, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 455);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(795, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Ready";
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.CausesValidation = false;
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.IsSplitterFixed = true;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 24);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.objectListView1);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.sizeOnDiskTitleLabel);
            this.splitContainerMain.Panel2.Controls.Add(this.buttonAddDir);
            this.splitContainerMain.Panel2.Controls.Add(this.sizeOnDiskLabel);
            this.splitContainerMain.Panel2.Controls.Add(this.buttonApplySelected);
            this.splitContainerMain.Panel2.Controls.Add(this.sizeTitleLabel);
            this.splitContainerMain.Panel2.Controls.Add(this.label1);
            this.splitContainerMain.Panel2.Controls.Add(this.sizeValueLabel);
            this.splitContainerMain.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainerMain.Panel2.Controls.Add(this.fileProgressBar);
            this.splitContainerMain.Panel2.Controls.Add(this.buttonCancel);
            this.splitContainerMain.Panel2.Controls.Add(this.folderProgressBar);
            this.splitContainerMain.Panel2.Controls.Add(this.labelResult);
            this.splitContainerMain.Size = new System.Drawing.Size(795, 431);
            this.splitContainerMain.SplitterDistance = 271;
            this.splitContainerMain.SplitterWidth = 1;
            this.splitContainerMain.TabIndex = 2;
            // 
            // objectListView1
            // 
            this.objectListView1.AllColumns.Add(this.gameColumn);
            this.objectListView1.AllColumns.Add(this.sizeColumn);
            this.objectListView1.AllColumns.Add(this.sizeOnDiskColumn);
            this.objectListView1.AllColumns.Add(this.Ratio);
            this.objectListView1.AllColumns.Add(this.pathColumn);
            this.objectListView1.CellEditUseWholeCell = false;
            this.objectListView1.CheckBoxes = true;
            this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.gameColumn,
            this.sizeColumn,
            this.sizeOnDiskColumn,
            this.Ratio,
            this.pathColumn});
            this.objectListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectListView1.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.objectListView1.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.objectListView1.Location = new System.Drawing.Point(0, 0);
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.ShowGroups = false;
            this.objectListView1.Size = new System.Drawing.Size(795, 271);
            this.objectListView1.TabIndex = 0;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            // 
            // gameColumn
            // 
            this.gameColumn.AspectName = "Name";
            this.gameColumn.HeaderCheckBox = true;
            this.gameColumn.Text = "Game";
            this.gameColumn.Width = 200;
            // 
            // sizeColumn
            // 
            this.sizeColumn.AspectName = "SizeMB";
            this.sizeColumn.Text = "Size (MB)";
            this.sizeColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sizeColumn.Width = 71;
            // 
            // sizeOnDiskColumn
            // 
            this.sizeOnDiskColumn.AspectName = "SizeOnDiskMB";
            this.sizeOnDiskColumn.Text = "Size On Disk (MB)";
            this.sizeOnDiskColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sizeOnDiskColumn.Width = 100;
            // 
            // pathColumn
            // 
            this.pathColumn.AspectName = "Path";
            this.pathColumn.Text = "Path";
            this.pathColumn.Width = 385;
            // 
            // sizeOnDiskTitleLabel
            // 
            this.sizeOnDiskTitleLabel.AutoSize = true;
            this.sizeOnDiskTitleLabel.Location = new System.Drawing.Point(498, 157);
            this.sizeOnDiskTitleLabel.Name = "sizeOnDiskTitleLabel";
            this.sizeOnDiskTitleLabel.Size = new System.Drawing.Size(66, 13);
            this.sizeOnDiskTitleLabel.TabIndex = 3;
            this.sizeOnDiskTitleLabel.Text = "Size on Disk";
            // 
            // buttonAddDir
            // 
            this.buttonAddDir.Location = new System.Drawing.Point(358, 5);
            this.buttonAddDir.Name = "buttonAddDir";
            this.buttonAddDir.Size = new System.Drawing.Size(75, 23);
            this.buttonAddDir.TabIndex = 1;
            this.buttonAddDir.Text = "Add";
            this.buttonAddDir.UseVisualStyleBackColor = true;
            this.buttonAddDir.Click += new System.EventHandler(this.buttonAddDir_Click);
            // 
            // sizeOnDiskLabel
            // 
            this.sizeOnDiskLabel.AutoSize = true;
            this.sizeOnDiskLabel.Location = new System.Drawing.Point(498, 174);
            this.sizeOnDiskLabel.Name = "sizeOnDiskLabel";
            this.sizeOnDiskLabel.Size = new System.Drawing.Size(43, 13);
            this.sizeOnDiskLabel.TabIndex = 2;
            this.sizeOnDiskLabel.Text = "            ";
            // 
            // buttonApplySelected
            // 
            this.buttonApplySelected.Location = new System.Drawing.Point(450, 102);
            this.buttonApplySelected.Name = "buttonApplySelected";
            this.buttonApplySelected.Size = new System.Drawing.Size(108, 34);
            this.buttonApplySelected.TabIndex = 1;
            this.buttonApplySelected.Text = "Apply Selected";
            this.buttonApplySelected.UseVisualStyleBackColor = true;
            this.buttonApplySelected.Click += new System.EventHandler(this.buttonApplySelected_Click);
            // 
            // sizeTitleLabel
            // 
            this.sizeTitleLabel.AutoSize = true;
            this.sizeTitleLabel.Location = new System.Drawing.Point(421, 157);
            this.sizeTitleLabel.Name = "sizeTitleLabel";
            this.sizeTitleLabel.Size = new System.Drawing.Size(27, 13);
            this.sizeTitleLabel.TabIndex = 1;
            this.sizeTitleLabel.Text = "Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // sizeValueLabel
            // 
            this.sizeValueLabel.AutoSize = true;
            this.sizeValueLabel.Location = new System.Drawing.Point(421, 174);
            this.sizeValueLabel.Name = "sizeValueLabel";
            this.sizeValueLabel.Size = new System.Drawing.Size(43, 13);
            this.sizeValueLabel.TabIndex = 0;
            this.sizeValueLabel.Text = "            ";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.radioButtonOptimized);
            this.flowLayoutPanel1.Controls.Add(this.radioButtonMaxComp);
            this.flowLayoutPanel1.Controls.Add(this.radioButtonUncompressed);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(439, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(119, 77);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // radioButtonOptimized
            // 
            this.radioButtonOptimized.AutoSize = true;
            this.radioButtonOptimized.Checked = true;
            this.radioButtonOptimized.Location = new System.Drawing.Point(3, 3);
            this.radioButtonOptimized.Name = "radioButtonOptimized";
            this.radioButtonOptimized.Size = new System.Drawing.Size(71, 17);
            this.radioButtonOptimized.TabIndex = 0;
            this.radioButtonOptimized.TabStop = true;
            this.radioButtonOptimized.Text = "Optimized";
            this.radioButtonOptimized.UseVisualStyleBackColor = true;
            this.radioButtonOptimized.CheckedChanged += new System.EventHandler(this.radioButtonOptimized_CheckedChanged);
            // 
            // radioButtonMaxComp
            // 
            this.radioButtonMaxComp.AutoSize = true;
            this.radioButtonMaxComp.Location = new System.Drawing.Point(3, 26);
            this.radioButtonMaxComp.Name = "radioButtonMaxComp";
            this.radioButtonMaxComp.Size = new System.Drawing.Size(108, 17);
            this.radioButtonMaxComp.TabIndex = 1;
            this.radioButtonMaxComp.Text = "Max Compression";
            this.radioButtonMaxComp.UseVisualStyleBackColor = true;
            this.radioButtonMaxComp.CheckedChanged += new System.EventHandler(this.radioButtonMaxComp_CheckedChanged);
            // 
            // radioButtonUncompressed
            // 
            this.radioButtonUncompressed.AutoSize = true;
            this.radioButtonUncompressed.Location = new System.Drawing.Point(3, 49);
            this.radioButtonUncompressed.Name = "radioButtonUncompressed";
            this.radioButtonUncompressed.Size = new System.Drawing.Size(96, 17);
            this.radioButtonUncompressed.TabIndex = 2;
            this.radioButtonUncompressed.Text = "Uncompressed";
            this.radioButtonUncompressed.UseVisualStyleBackColor = true;
            // 
            // fileProgressBar
            // 
            this.fileProgressBar.Location = new System.Drawing.Point(4, 60);
            this.fileProgressBar.Name = "fileProgressBar";
            this.fileProgressBar.Size = new System.Drawing.Size(429, 23);
            this.fileProgressBar.TabIndex = 5;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(3, 118);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // folderProgressBar
            // 
            this.folderProgressBar.Location = new System.Drawing.Point(4, 89);
            this.folderProgressBar.Name = "folderProgressBar";
            this.folderProgressBar.Size = new System.Drawing.Size(429, 23);
            this.folderProgressBar.TabIndex = 3;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(84, 123);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(35, 13);
            this.labelResult.TabIndex = 2;
            this.labelResult.Text = "label1";
            // 
            // Ratio
            // 
            this.Ratio.AspectName = "Ratio";
            this.Ratio.Text = "Ratio";
            // 
            // ZpOptimizerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 477);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "ZpOptimizerUI";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "ZP Optimizer (Prototype)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ZpOptimizerUI_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            this.splitContainerMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ProgressBar folderProgressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar fileProgressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sizeOnDiskTitleLabel;
        private System.Windows.Forms.Button buttonAddDir;
        private System.Windows.Forms.Label sizeOnDiskLabel;
        private System.Windows.Forms.Button buttonApplySelected;
        private System.Windows.Forms.Label sizeTitleLabel;
        private System.Windows.Forms.Label sizeValueLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton radioButtonOptimized;
        private System.Windows.Forms.RadioButton radioButtonMaxComp;
        private System.Windows.Forms.RadioButton radioButtonUncompressed;
        private BrightIdeasSoftware.ObjectListView objectListView1;
        private BrightIdeasSoftware.OLVColumn gameColumn;
        private BrightIdeasSoftware.OLVColumn sizeColumn;
        private BrightIdeasSoftware.OLVColumn sizeOnDiskColumn;
        private BrightIdeasSoftware.OLVColumn pathColumn;
        private BrightIdeasSoftware.OLVColumn Ratio;
    }
}

