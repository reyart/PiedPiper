using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ZpOptimizerUI {
    public partial class OptionsForm : Form {
        public OptionsForm() {
            InitializeComponent();

            foreach (string str in Settings1.Default.locationList) {
                listBoxFolderList.Items.Add(str);
            }
        }

       

        private void buttonAddFolder_Click(object sender, EventArgs e) {
            FolderBrowserDialog folderBrowserDialog1;
            folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            folderBrowserDialog1.Description = "Select Steam Folder";
            folderBrowserDialog1.ShowNewFolderButton = false;
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK) {
                //Add to the list
                listBoxFolderList.Items.Add(folderBrowserDialog1.SelectedPath.ToString());

                //Add to settings file and save
                Settings1.Default.locationList.Add(folderBrowserDialog1.SelectedPath.ToString());
                Settings1.Default.Save();
            }
        }

        //UNUSED
        private void labelFolderListCaption_Click(object sender, EventArgs e) {  }
    }
}
