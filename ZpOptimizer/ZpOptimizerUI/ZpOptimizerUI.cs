using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using OptimizerEngine.FileSystem;
using static OptimizerEngine.Helpers.Globals;
using ZpOptimizerUI.Helpers;
using System.Runtime.Serialization.Formatters.Binary;


namespace ZpOptimizerUI
{
    public partial class ZpOptimizerUI : Form
    {
        private OptimizerEngine.OptimizerEngine engine;
        private DirCompressionTypes compressionType;
        public List<string> selectedDirList;
        public List<ZpDirectory> masterDirList;
        public List<ZpDirectory> selectedObjectList;

        public ObjectStorage objectStorage;


        #region constructors

        public ZpOptimizerUI()
        {
            //Initialize disk reader/writer object
            objectStorage = new ObjectStorage();

            //Initialize main list of games
            masterDirList = new List<ZpDirectory>();
            selectedObjectList = new List<ZpDirectory>();
            masterDirList = InitializeMasterDirList();


            //Initialize other components
            InitializeComponent();
            InitializeBackgroundWorker();            
            InitializeObjectListView();  
        }
        
        #endregion



        #region Initializers

        //Retrieve and update master list of games
        private List<ZpDirectory> InitializeMasterDirList()
        {
            //Retrieve the saved list from disk
            masterDirList = objectStorage.RetrievezpDirList("data.bin");

            //Get the current folders
            string[] rootDir = Directory.GetDirectories(Settings1.Default.defaultFolder);

            //Remove folders from the list that are no longer present
            List<ZpDirectory> dirsToRemove = new List<ZpDirectory> { };

            foreach (ZpDirectory dir in masterDirList)
            {                
                if (rootDir.Contains(dir.Path) == false) { dirsToRemove.Add(dir); }              
            }

            foreach (ZpDirectory dir in dirsToRemove)
            {
                masterDirList.Remove(dir);
            }

            //Check for matches with previous list before adding new folders
            foreach (string path in rootDir)
            {             
                bool alreadyListed = false;               
                foreach (ZpDirectory dir in masterDirList)
                {
                    if (dir.Path == path)
                    {
                        alreadyListed = true;
                        break;
                    }                                     
                }
                if (alreadyListed == false) { masterDirList.Add(new ZpDirectory(path)); }
            }

            //Save the list to disk after all operations complete
            objectStorage.SaveZpDirList("data.bin", masterDirList);
                                            
            return masterDirList;                               
        }

        //Populate listview with data from directory list   
        private void InitializeObjectListView()
        {
            objectListView1.SetObjects(masterDirList);
            objectListView1.Sort(gameColumn);
               
        }

        //Set essential properties for background worker
        private void InitializeBackgroundWorker()
        {
            
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true; //Allow for the process to be cancelled

        }

        #endregion



        #region EVENTS

        private void objectListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        //Add new folders to the list
        void buttonAddDir_Click(object sender, EventArgs e)
        {
            // Open the dialog to select the steam folder
            FolderBrowserDialog folderBrowserDialog1;
            folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            folderBrowserDialog1.Description = "Select Steam Folder";
            folderBrowserDialog1.ShowNewFolderButton = false;          
            DialogResult result = folderBrowserDialog1.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                string[] dirList = Directory.GetDirectories(folderBrowserDialog1.SelectedPath.ToString());

                foreach (string dir in dirList)
                {
                    //Get just the folder name
                    int slashIndex = dir.LastIndexOf(@"\") + 1;
                    string dirName = dir.Substring(slashIndex);

                    //Add them to listview
                    string[] row1 = { dir };
                    objectListView1.Items.Add(dirName).SubItems.AddRange(row1);
                }
            }
        }

        //Apply compression on selected items
        private void buttonApplySelected_Click(object sender, EventArgs e) {

            /* OLD
            string[] selectedDirArray = new string[objectListView1.CheckedItems.Count];
      
            int i = 0;
            foreach (ListViewItem Item in objectListView1.CheckedItems)
            {            
                //Pull paths from 4th column of listview
                selectedDirArray.SetValue(objectListView1.CheckedItems[i].SubItems[3].Text, i);
                i++;
                
            }
            
            //Create a list from the array
            selectedDirList = selectedDirArray.ToList();
            */

            // -------New Method

            //Create a list of the checked objects
            //List<ZpDirectory> selectedObjectList = new List<ZpDirectory> { };

            selectedObjectList.Clear();

            foreach (ZpDirectory ob in objectListView1.CheckedObjects)
            {
                selectedObjectList.Add(ob);
            }
                    

            //Start compression job in background
            if (backgroundWorker1.IsBusy == false)
                backgroundWorker1.RunWorkerAsync("Selected");
            else
                MessageBox.Show("Chill, let me finish.");  //Havent implemeneted a queue yet                    
        }

        //Cancel compression, only works per game right now
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //Check if background worker is doing anything and send a cancellation if it is
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
        }

        //Save master game list when closing program
        private void ZpOptimizerUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            objectStorage.SaveZpDirList("data.bin", masterDirList);
        }

        //Unused
        private void radioButtonOptimized_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButtonUncompressed_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButtonMaxComp_CheckedChanged(object sender, EventArgs e)
        {

        }
        void UpdateGUI(object userData)
        {

        }

        #endregion



        #region BackgroundWorker

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            if (radioButtonOptimized.Checked == true)
            {
                compressionType = DirCompressionTypes.OPTIMAL;
            }
            else if (radioButtonMaxComp.Checked == true)
            {
                compressionType = DirCompressionTypes.MAXIMUM;
            }
            else if (radioButtonUncompressed.Checked == true)
            {
                compressionType = DirCompressionTypes.UNCOMPRESS;
            }

            //double percentToIncrement = 100.0 / Convert.ToDouble(selectedDirList.Count);
            double percentToIncrement = 100.0 / Convert.ToDouble(selectedObjectList.Count);
            double percentComplete = percentToIncrement;
            folderProgressBar.BeginInvoke((MethodInvoker)delegate { folderProgressBar.Value = 0; });


            //foreach (string dir in selectedDirList)
            foreach (ZpDirectory activeDir in selectedObjectList)
            {

                //Check if there is a request to cancel the process
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    backgroundWorker1.ReportProgress(0);
                    return;
                }

                engine = new OptimizerEngine.OptimizerEngine(activeDir, backgroundWorker1);
                //engine.CompressSelected(compressionType); OLD
                engine.CompressActiveDir(activeDir, compressionType);

                int percentCompleteInt = Convert.ToInt32(percentComplete);

                folderProgressBar.BeginInvoke((MethodInvoker)delegate { folderProgressBar.Value = percentCompleteInt; });
                
                percentComplete += percentToIncrement;
            }


            //backgroundWorker1.ReportProgress(1);

            //If the process exits the loop, ensure that progress is set to 100%
            //folderProgressBar.Value = 100;
            //backgroundWorker1.ReportProgress(100);

            objectListView1.RefreshObjects(masterDirList);

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

        #endregion

        private void buttonSelectAll_Click(object sender, EventArgs e)
        {
            objectListView1.CheckAll();
        }

        private void buttonSelectNone_Click(object sender, EventArgs e)
        {
            objectListView1.UncheckAll();
        }
    }
}
