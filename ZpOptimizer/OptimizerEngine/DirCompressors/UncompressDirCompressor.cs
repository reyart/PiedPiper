using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OptimizerEngine.FileSystem;
using OptimizerEngine.Helpers;
using System.ComponentModel;

namespace OptimizerEngine.DirCompressors {
    public class UncompressDirCompressor : DirCompressor {

        public UncompressDirCompressor(string dir) : base(dir) {
        }

        public override void Execute(BackgroundWorker bgw) {

            var fileList = rootDir.GetAllFiles();
            double percentToIncrement = 100.0 / Convert.ToDouble(fileList.Count);
            double percentComplete = percentToIncrement;
            bgw.ReportProgress(0);

            // Loop through all files in folders and subfolders
            foreach (ZpFile file in fileList)
            {
                int percentCompleteInt = Convert.ToInt32(percentComplete);
                bgw.ReportProgress(percentCompleteInt);
                percentComplete += percentToIncrement;

                if (!file.IsTooSmall || !file.IsNonCompressible)                                                   
                    file.Uncompress();

                file.AddArchiveAttribute();
            }
        }
    }
}
