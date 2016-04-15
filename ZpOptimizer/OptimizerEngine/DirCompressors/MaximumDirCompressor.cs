using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OptimizerEngine.FileSystem;
using OptimizerEngine.Helpers;

namespace OptimizerEngine.DirCompressors {

    public class MaximumDirCompressor : DirCompressor {

        public MaximumDirCompressor(string dir) : base(dir) {
        }

        public override void Execute() {

            // Get the size of the folder before compressing
            long folderSizeBefore = rootDir.GetSize();
            double folderSizeBeforeGB = (double)folderSizeBefore / 1024 / 1024 / 1024;
            logger.WriteLine("Compressing " + rootDir.Name + " Size = " + Math.Round(folderSizeBeforeGB, 3) + "GB");
            logger.WriteLine("");

            // Loop through all files in folders and subfolders
            foreach (ZpFile file in rootDir.GetAllFiles())
            {

                //file.Uncompress(); //Uncompress now, because you're going to have to anyway, and this gets you the correct size.
                long sizeBefore = (file.GetSize()); //Establish size before compressing

                if (file.IsTooSmall)
                { //Skip Small Files
                    logger.WriteLine("Too Small," + file.Name + "," + file.Extension + "," + sizeBefore + "," + sizeBefore + "," + "1.0" + ",Skipped");
                    continue;
                }
                else if (file.IsNonCompressible)
                { //Skip incompressible files
                    logger.WriteLine("Incompressible," + file.Name + "," + file.Extension + "," + sizeBefore + "," + sizeBefore + "," + "1.0" + ",Skipped");
                    continue;
                }
                else 
                { 
                    logger.Write("Maximum," + file.Name + "," + file.Extension + ",");
                    double compRatio = file.Compress("LZX");
                    logger.WriteLine(sizeBefore + "," + file.GetSizeOnDisk() + "," + Math.Round(compRatio, 2) + ",LZX");                    
                    continue;
                }

                
            }

            long folderSizeAfter = rootDir.GetSizeOnDisk();
            double folderSizeAfterGB = (double)folderSizeAfter / 1024 / 1024 / 1024;
            logger.WriteLine("");
            logger.WriteLine("Compressed " + rootDir.Name + " Size = " + Math.Round(folderSizeAfterGB, 3) + "GB. Ratio = " + Math.Round(folderSizeBeforeGB / folderSizeAfterGB, 3) + " to 1");
            logger.WriteLine("");

        }
    }
}
