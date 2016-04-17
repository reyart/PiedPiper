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
        //private string[] selectedDirArray;
        private List<string> selectedDirList;

        public ZpOptimizerUI()
        {
            InitializeComponent();
            InitializeBackgroundWorker();       
    
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
            
        }

        private void buttonApplySelected_Click(object sender, EventArgs e)
        {
            string[] selectedDirArray = new string[listBoxFolders.SelectedItems.Count];
            listBoxFolders.SelectedItems.CopyTo(selectedDirArray, 0);
            //List<string> selectedDirList = new List<string>(selectedDirArray);

            selectedDirList = selectedDirArray.ToList();
            //statusStrip.Text = "Compressing " + selectedDirList.Count + "folders";
            //statusStrip.Update();

            if (backgroundWorker1.IsBusy == false)
                backgroundWorker1.RunWorkerAsync("Selected");
            else
                MessageBox.Show("Chill, let me finish.");
            
        }

        #endregion

        


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
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

            double percentToIncrement = 100.0 / Convert.ToDouble(selectedDirList.Count);
            double percentComplete = percentToIncrement;
            //folderProgressBar.Value = 0;
            folderProgressBar.BeginInvoke((MethodInvoker)delegate { folderProgressBar.Value = 0; });
            //backgroundWorker1.ReportProgress(0);
            foreach (string dir in selectedDirList)
            {

                //Check if there is a request to cancel the process
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    backgroundWorker1.ReportProgress(0);
                    return;
                }

                engine = new OptimizerEngine.OptimizerEngine(dir, backgroundWorker1);
                engine.CompressSelected(compressionType);
                //engine = new OptimizerEngine.OptimizerEngine(dir);

               
                int percentCompleteInt = Convert.ToInt32(percentComplete);
                //folderProgressBar.Value = percentCompleteInt;
                folderProgressBar.BeginInvoke((MethodInvoker)delegate { folderProgressBar.Value = percentCompleteInt; });
                percentComplete += percentToIncrement;
            }

                //backgroundWorker1.ReportProgress(1);

                //If the process exits the loop, ensure that progress is set to 100%
                //folderProgressBar.Value = 100;
                //backgroundWorker1.ReportProgress(100);

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
             fileProgressBar.Value = e.ProgressPercentage;
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

        private void InitializeBackgroundWorker()
        {
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true; //Allow for the process to be cancelled

        }
    }
}
