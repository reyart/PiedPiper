using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OptimizerEngine.Helpers.Globals;

namespace ZpOptimizerUI
{
    public partial class ZpOptimizerUI : Form
    {
        private OptimizerEngine.OptimizerEngine engine;

        private CompressionTypes compressionType;

        public ZpOptimizerUI()
        {
            InitializeComponent();

            //engine = new OptimizerEngine.OptimizerEngine();

            compressionType = CompressionTypes.OPTIMAL; // FOR TESTING ONLY
        }

        private void buttonApplySelected_Click(object sender, EventArgs e) {
            engine.CompressSelected(compressionType);
        }

        private void listBoxFolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            engine = new OptimizerEngine.OptimizerEngine(listBoxFolders.SelectedItem.ToString());
        }

        private void buttonAddDir_Click(object sender, EventArgs e)
        {
            // Open the dialog to select the steam folder
            FolderBrowserDialog folderBrowserDialog1;
            folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            folderBrowserDialog1.Description = "Select Steam Folder";
            folderBrowserDialog1.ShowNewFolderButton = false;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {

                string[] dirList = System.IO.Directory.GetDirectories(folderBrowserDialog1.SelectedPath.ToString());

                foreach (string dir in dirList)
                    listBoxFolders.Items.Add(dir);
            }            
        }
    }
}
