using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OptimizerEngine.FileSystem;
using OptimizerEngine.Helpers;

namespace OptimizerEngine.DirCompressors {
    public class UncompressDirCompressor : DirCompressor {

        public UncompressDirCompressor(string dir) : base(dir) {
        }

        public override void Execute() {
           // Get the size of the folder before compressing
            long folderSizeBefore = rootDir.GetSize();
            double folderSizeBeforeGB = (double)folderSizeBefore / 1024 / 1024 / 1024;

            logger.WriteLine("Decompressing " + rootDir.Name + " Size = " + Math.Round(folderSizeBeforeGB, 3) + "GB");
            
            // Loop through all files in folders and subfolders
            foreach (ZpFile file in rootDir.GetAllFiles())
            {
                long sizeBefore = (file.GetSize()); //Establish size before compressing

                if (file.IsTooSmall)
                { //Skip Small Files
                    logger.WriteLine("Too Small," + file.Name + "," + file.Extension + "," + sizeBefore + "," + sizeBefore + "," + "1.0" + ",Skipped");
                    continue;
                }
                else
                {
                    logger.Write("Decompress," + file.Name + "," + file.Extension + ",");
                    file.Uncompress();
                    logger.WriteLine(file.GetSize() + "," + file.GetSizeOnDisk() + "," + "1.0" + ",Decompressed");
                }
            }

            long folderSizeAfter = rootDir.GetSizeOnDisk();
            double folderSizeAfterGB = (double)folderSizeAfter / 1024 / 1024 / 1024;
            logger.WriteLine("");
            logger.WriteLine("Decompressed " + rootDir.Name + " Size = " + Math.Round(folderSizeAfterGB, 3) + "GB. Ratio = 1.0 to 1");
            logger.WriteLine("");

        }
    }
}
