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
            //compressionType = CompressionTypes.OPTIMAL; // FOR TESTING ONLY

            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;  //Tell the user how the process went
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true; //Allow for the process to be cancelled
       
    }

        #region EVENTS

        void buttonAddDir_Click(object sender, EventArgs e)
        {
            // Open the dialog to select the steam folder
            FolderBrowserDialog folderBrowserDialog1;
            folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            folderBrowserDialog1.Description = "Select Steam Folder";
            folderBrowserDialog1.ShowNewFolderButton = false;
            folderBrowserDialog1.SelectedPath = @"G:\Steam\steamapps\common\";
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {

                string[] dirList = Directory.GetDirectories(folderBrowserDialog1.SelectedPath.ToString());

                foreach (string dir in dirList)
                    listBoxFolders.Items.Add(dir);                    
            }
        }

        private void listBoxFolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            engine = new OptimizerEngine.OptimizerEngine(listBoxFolders.SelectedItem.ToString());
        }

        private void buttonApplySelected_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync("Selected");                     
        }

        private void buttonApplyAll_Click(object sender, EventArgs e)
        {

            string[] dirList = new string[listBoxFolders.Items.Count];
            listBoxFolders.Items.CopyTo(dirList, 0);            
            engine = new OptimizerEngine.OptimizerEngine(dirList);
            backgroundWorker1.RunWorkerAsync("All");
        }

        #endregion

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (radioButtonOptimized.Checked == true)
            {
                compressionType = CompressionTypes.OPTIMAL;
            }
            else if (radioButtonMaxComp.Checked == true)
            {
                compressionType = CompressionTypes.MAXIMUM;
            }
            else if (radioButtonUncompressed.Checked == true)
            {
                compressionType = CompressionTypes.UNCOMPRESS;
            }
            
            if (e.Argument.ToString() == "Selected") 
                engine.CompressSelected(compressionType);
            if (e.Argument.ToString() == "All")
                engine.CompressAll(compressionType);

            labelResult.Text = "Compressing " + listBoxFolders.SelectedItem.ToString();
            backgroundWorker1.ReportProgress(1);
     
            //Check if there is a request to cancel the process
            if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    backgroundWorker1.ReportProgress(0);
                    return;
                }          
            //If the process exits the loop, ensure that progress is set to 100%
            //Remember in the loop we set i < 100 so in theory the process will complete at 99%
            backgroundWorker1.ReportProgress(100);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            compProgressBar.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                labelResult.Text = "Process was cancelled";
            }
            else if (e.Error != null)
            {
                labelResult.Text = "There was an error running the process. The thread aborted";
            }
            else
            {
                labelResult.Text = "Process was completed";
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //Check if background worker is doing anything and send a cancellation if it is
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
        }

        private void radioButtonOptimized_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButtonUncompressed_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButtonMaxComp_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        
    }
}
