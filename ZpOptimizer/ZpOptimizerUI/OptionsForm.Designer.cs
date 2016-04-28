namespace ZpOptimizerUI {
    partial class OptionsForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.listBoxFolderList = new System.Windows.Forms.ListBox();
            this.buttonAddFolder = new System.Windows.Forms.Button();
            this.buttonRemoveFolder = new System.Windows.Forms.Button();
            this.labelFolderListTitle = new System.Windows.Forms.Label();
            this.labelFolderListCaption1 = new System.Windows.Forms.Label();
            this.labelFolderListCaption2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxFolderList
            // 
            this.listBoxFolderList.FormattingEnabled = true;
            this.listBoxFolderList.Location = new System.Drawing.Point(12, 36);
            this.listBoxFolderList.Name = "listBoxFolderList";
            this.listBoxFolderList.Size = new System.Drawing.Size(354, 160);
            this.listBoxFolderList.TabIndex = 0;
            // 
            // buttonAddFolder
            // 
            this.buttonAddFolder.Location = new System.Drawing.Point(372, 36);
            this.buttonAddFolder.Name = "buttonAddFolder";
            this.buttonAddFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonAddFolder.TabIndex = 1;
            this.buttonAddFolder.Text = "Add";
            this.buttonAddFolder.UseVisualStyleBackColor = true;
            this.buttonAddFolder.Click += new System.EventHandler(this.buttonAddFolder_Click);
            // 
            // buttonRemoveFolder
            // 
            this.buttonRemoveFolder.Location = new System.Drawing.Point(372, 65);
            this.buttonRemoveFolder.Name = "buttonRemoveFolder";
            this.buttonRemoveFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveFolder.TabIndex = 2;
            this.buttonRemoveFolder.Text = "Remove";
            this.buttonRemoveFolder.UseVisualStyleBackColor = true;
            // 
            // labelFolderListTitle
            // 
            this.labelFolderListTitle.AutoSize = true;
            this.labelFolderListTitle.Location = new System.Drawing.Point(9, 20);
            this.labelFolderListTitle.Name = "labelFolderListTitle";
            this.labelFolderListTitle.Size = new System.Drawing.Size(56, 13);
            this.labelFolderListTitle.TabIndex = 3;
            this.labelFolderListTitle.Text = "Locations:";
            // 
            // labelFolderListCaption1
            // 
            this.labelFolderListCaption1.AutoSize = true;
            this.labelFolderListCaption1.Location = new System.Drawing.Point(12, 203);
            this.labelFolderListCaption1.Name = "labelFolderListCaption1";
            this.labelFolderListCaption1.Size = new System.Drawing.Size(167, 13);
            this.labelFolderListCaption1.TabIndex = 4;
            this.labelFolderListCaption1.Text = "Select folders to search for games";
            this.labelFolderListCaption1.Click += new System.EventHandler(this.labelFolderListCaption_Click);
            // 
            // labelFolderListCaption2
            // 
            this.labelFolderListCaption2.AutoSize = true;
            this.labelFolderListCaption2.Location = new System.Drawing.Point(12, 218);
            this.labelFolderListCaption2.Name = "labelFolderListCaption2";
            this.labelFolderListCaption2.Size = new System.Drawing.Size(243, 13);
            this.labelFolderListCaption2.TabIndex = 5;
            this.labelFolderListCaption2.Text = "(Ex: C:\\Program Files (x86)\\Steamapps\\common\\)";
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 261);
            this.Controls.Add(this.labelFolderListCaption2);
            this.Controls.Add(this.labelFolderListCaption1);
            this.Controls.Add(this.labelFolderListTitle);
            this.Controls.Add(this.buttonRemoveFolder);
            this.Controls.Add(this.buttonAddFolder);
            this.Controls.Add(this.listBoxFolderList);
            this.Name = "OptionsForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFolderList;
        private System.Windows.Forms.Button buttonAddFolder;
        private System.Windows.Forms.Button buttonRemoveFolder;
        private System.Windows.Forms.Label labelFolderListTitle;
        private System.Windows.Forms.Label labelFolderListCaption1;
        private System.Windows.Forms.Label labelFolderListCaption2;
    }
}