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
            this.splitContainerTop = new System.Windows.Forms.SplitContainer();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Game = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SizeOnDisk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDeleteDir = new System.Windows.Forms.Button();
            this.buttonAddDir = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.sizeOnDiskTitleLabel = new System.Windows.Forms.Label();
            this.sizeOnDiskLabel = new System.Windows.Forms.Label();
            this.sizeTitleLabel = new System.Windows.Forms.Label();
            this.sizeValueLabel = new System.Windows.Forms.Label();
            this.buttonApplySelected = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButtonOptimized = new System.Windows.Forms.RadioButton();
            this.radioButtonMaxComp = new System.Windows.Forms.RadioButton();
            this.radioButtonUncompressed = new System.Windows.Forms.RadioButton();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.fileProgressBar = new System.Windows.Forms.ProgressBar();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.folderProgressBar = new System.Windows.Forms.ProgressBar();
            this.labelResult = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTop)).BeginInit();
            this.splitContainerTop.Panel1.SuspendLayout();
            this.splitContainerTop.Panel2.SuspendLayout();
            this.splitContainerTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1276, 24);
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
            this.statusStrip.Location = new System.Drawing.Point(0, 587);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1276, 22);
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
            // splitContainerTop
            // 
            this.splitContainerTop.CausesValidation = false;
            this.splitContainerTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTop.IsSplitterFixed = true;
            this.splitContainerTop.Location = new System.Drawing.Point(0, 0);
            this.splitContainerTop.Name = "splitContainerTop";
            // 
            // splitContainerTop.Panel1
            // 
            this.splitContainerTop.Panel1.Controls.Add(this.listView1);
            this.splitContainerTop.Panel1.Controls.Add(this.buttonDeleteDir);
            this.splitContainerTop.Panel1.Controls.Add(this.buttonAddDir);
            // 
            // splitContainerTop.Panel2
            // 
            this.splitContainerTop.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainerTop.Size = new System.Drawing.Size(1276, 355);
            this.splitContainerTop.SplitterDistance = 635;
            this.splitContainerTop.SplitterWidth = 1;
            this.splitContainerTop.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Game,
            this.Size,
            this.SizeOnDisk,
            this.Path});
            this.listView1.Location = new System.Drawing.Point(4, 7);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(630, 216);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Game
            // 
            this.Game.Text = "Game";
            this.Game.Width = 180;
            // 
            // Size
            // 
            this.Size.Text = "Size";
            // 
            // SizeOnDisk
            // 
            this.SizeOnDisk.Text = "Size On Disk";
            // 
            // Path
            // 
            this.Path.Text = "Path";
            this.Path.Width = 229;
            // 
            // buttonDeleteDir
            // 
            this.buttonDeleteDir.Location = new System.Drawing.Point(85, 222);
            this.buttonDeleteDir.Name = "buttonDeleteDir";
            this.buttonDeleteDir.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteDir.TabIndex = 2;
            this.buttonDeleteDir.Text = "Delete";
            this.buttonDeleteDir.UseVisualStyleBackColor = true;
            // 
            // buttonAddDir
            // 
            this.buttonAddDir.Location = new System.Drawing.Point(4, 222);
            this.buttonAddDir.Name = "buttonAddDir";
            this.buttonAddDir.Size = new System.Drawing.Size(75, 23);
            this.buttonAddDir.TabIndex = 1;
            this.buttonAddDir.Text = "Add";
            this.buttonAddDir.UseVisualStyleBackColor = true;
            this.buttonAddDir.Click += new System.EventHandler(this.buttonAddDir_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(640, 355);
            this.splitContainer1.SplitterDistance = 238;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.sizeOnDiskTitleLabel);
            this.splitContainer2.Panel1.Controls.Add(this.sizeOnDiskLabel);
            this.splitContainer2.Panel1.Controls.Add(this.sizeTitleLabel);
            this.splitContainer2.Panel1.Controls.Add(this.sizeValueLabel);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.buttonApplySelected);
            this.splitContainer2.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer2.Size = new System.Drawing.Size(640, 238);
            this.splitContainer2.SplitterDistance = 372;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 0;
            // 
            // sizeOnDiskTitleLabel
            // 
            this.sizeOnDiskTitleLabel.AutoSize = true;
            this.sizeOnDiskTitleLabel.Location = new System.Drawing.Point(81, 26);
            this.sizeOnDiskTitleLabel.Name = "sizeOnDiskTitleLabel";
            this.sizeOnDiskTitleLabel.Size = new System.Drawing.Size(66, 13);
            this.sizeOnDiskTitleLabel.TabIndex = 3;
            this.sizeOnDiskTitleLabel.Text = "Size on Disk";
            // 
            // sizeOnDiskLabel
            // 
            this.sizeOnDiskLabel.AutoSize = true;
            this.sizeOnDiskLabel.Location = new System.Drawing.Point(81, 43);
            this.sizeOnDiskLabel.Name = "sizeOnDiskLabel";
            this.sizeOnDiskLabel.Size = new System.Drawing.Size(43, 13);
            this.sizeOnDiskLabel.TabIndex = 2;
            this.sizeOnDiskLabel.Text = "            ";
            // 
            // sizeTitleLabel
            // 
            this.sizeTitleLabel.AutoSize = true;
            this.sizeTitleLabel.Location = new System.Drawing.Point(4, 26);
            this.sizeTitleLabel.Name = "sizeTitleLabel";
            this.sizeTitleLabel.Size = new System.Drawing.Size(27, 13);
            this.sizeTitleLabel.TabIndex = 1;
            this.sizeTitleLabel.Text = "Size";
            // 
            // sizeValueLabel
            // 
            this.sizeValueLabel.AutoSize = true;
            this.sizeValueLabel.Location = new System.Drawing.Point(4, 43);
            this.sizeValueLabel.Name = "sizeValueLabel";
            this.sizeValueLabel.Size = new System.Drawing.Size(43, 13);
            this.sizeValueLabel.TabIndex = 0;
            this.sizeValueLabel.Text = "            ";
            // 
            // buttonApplySelected
            // 
            this.buttonApplySelected.Location = new System.Drawing.Point(6, 87);
            this.buttonApplySelected.Name = "buttonApplySelected";
            this.buttonApplySelected.Size = new System.Drawing.Size(108, 34);
            this.buttonApplySelected.TabIndex = 1;
            this.buttonApplySelected.Text = "Apply Selected";
            this.buttonApplySelected.UseVisualStyleBackColor = true;
            this.buttonApplySelected.Click += new System.EventHandler(this.buttonApplySelected_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.radioButtonOptimized);
            this.flowLayoutPanel1.Controls.Add(this.radioButtonMaxComp);
            this.flowLayoutPanel1.Controls.Add(this.radioButtonUncompressed);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 4);
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
            this.splitContainerMain.Panel1.Controls.Add(this.splitContainerTop);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.label1);
            this.splitContainerMain.Panel2.Controls.Add(this.fileProgressBar);
            this.splitContainerMain.Panel2.Controls.Add(this.buttonCancel);
            this.splitContainerMain.Panel2.Controls.Add(this.folderProgressBar);
            this.splitContainerMain.Panel2.Controls.Add(this.labelResult);
            this.splitContainerMain.Size = new System.Drawing.Size(1276, 563);
            this.splitContainerMain.SplitterDistance = 355;
            this.splitContainerMain.SplitterWidth = 1;
            this.splitContainerMain.TabIndex = 2;
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
            // ZpOptimizerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1276, 609);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
            this.splitContainerTop.Panel1.ResumeLayout(false);
            this.splitContainerTop.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTop)).EndInit();
            this.splitContainerTop.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            this.splitContainerMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
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
        private System.Windows.Forms.SplitContainer splitContainerTop;
        private System.Windows.Forms.Button buttonDeleteDir;
        private System.Windows.Forms.Button buttonAddDir;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button buttonApplySelected;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton radioButtonOptimized;
        private System.Windows.Forms.RadioButton radioButtonMaxComp;
        private System.Windows.Forms.RadioButton radioButtonUncompressed;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ProgressBar folderProgressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar fileProgressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Game;
        private System.Windows.Forms.ColumnHeader Path;
        private System.Windows.Forms.Label sizeValueLabel;
        private System.Windows.Forms.Label sizeTitleLabel;
        private System.Windows.Forms.Label sizeOnDiskTitleLabel;
        private System.Windows.Forms.Label sizeOnDiskLabel;
        private System.Windows.Forms.ColumnHeader Size;
        private System.Windows.Forms.ColumnHeader SizeOnDisk;
    }
}

