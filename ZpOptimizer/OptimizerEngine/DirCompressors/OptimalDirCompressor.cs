using OptimizerEngine.FileSystem;
using OptimizerEngine.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizerEngine.DirCompressors {

    public class OptimalDirCompressor : DirCompressor {

        #region Private Properties

        private ZpDirectory rootDir;  // Root folder where compression starts
        private Logger logger;  // Logs stuff

        #endregion

        #region Constructors

        public OptimalDirCompressor(string dir) : base(dir) {
            // Initialize logger
            logger = new Logger();

            // Initialize directory
            rootDir = new ZpDirectory(dir);
        }

        #endregion

        #region Public Properties
        #endregion

        #region Public Methods

        // Where the magic happens
        public override void Execute() {

            // Get the size of the folder before compressing
            long folderSizeBefore = rootDir.GetSize();
            double folderSizeBeforeGB = (double)folderSizeBefore / 1024 / 1024 / 1024;
            logger.WriteLine("Compressing " + rootDir.Name + " Size = " + Math.Round(folderSizeBeforeGB, 3) + "GB");
            logger.WriteLine("");

            // Loop through all files in folders and subfolders
            foreach (ZpFile file in rootDir.GetAllFiles()) {
                file.Uncompress(); //Uncompress now, because you're going to have to anyway, and this gets you the correct size.
                long sizeBefore = (file.GetSize()); //Establish size before compressing

                if (file.IsTooSmall) { //Skip Small Files
                    logger.WriteLine("Too Small," + file.Name + "," + file.Extension + "," + sizeBefore + "," + sizeBefore + ",1.0,Skipped");
                    continue;
                }
                else if (file.IsNonCompressible) { //Skip incompressible files
                    logger.WriteLine("Incompressible," + file.Name + "," + file.Extension + "," + sizeBefore + "," + sizeBefore + ",1.0,Skipped");
                    continue;
                }
                else if (file.IsPerfSensitive) { //Filter out perf sensitive files
                    logger.WriteLine("PerfSensitive," + file.Name + "," + file.Extension + ",");
                    double compRatio = file.Compress("XPRESS16K");

                    if (compRatio < 1.1) { // Decompress if it doesn't compress well at all
                        file.Uncompress();
                        logger.WriteLine(sizeBefore + "," + file.GetSizeOnDisk() + "," + Math.Round(compRatio, 2) + ",Decompressed,Downgraded");
                    }
                    else if (compRatio < 1.3) { // Lower compression if it compresses poorly
                        compRatio = file.Compress("XPRESS8K"); // QUESTION: Mark, do we want compRatio updated here? It wasn't updated in your original code but I'm thinking maybe it should be?
                        logger.WriteLine(sizeBefore + "," + file.GetSizeOnDisk() + "," + Math.Round(compRatio, 2) + ",XPRESS8K,Downgraded");
                    }
                    else {
                        logger.WriteLine(sizeBefore + "," + file.GetSizeOnDisk() + "," + Math.Round(compRatio, 2) + ",XPRESS16K");
                    }

                    continue;
                }
                else if (file.IsNonPerfSensitive) { //Filter out perf sensitive files
                    logger.WriteLine("NonPerfSensitive," + file.Name + "," + file.Extension + ",");
                    double compRatio = file.Compress("LZX");

                    if (compRatio < 1.1) { // Decompress if it doesn't compress well at all
                        file.Uncompress();
                        logger.WriteLine(sizeBefore + "," + file.GetSizeOnDisk() + "," + Math.Round(compRatio, 2) + ",Decompressed,Downgraded");
                    }
                    else if (compRatio < 1.3) { // Lower compression if it compresses poorly
                        compRatio = file.Compress("XPRESS16K"); // QUESTION: Mark, do we want compRatio updated here? It wasn't updated in your original code but I'm thinking maybe it should be?
                        logger.WriteLine(sizeBefore + "," + file.GetSizeOnDisk() + "," + Math.Round(compRatio, 2) + ",XPRESS16K,Downgraded");
                    }
                    else {
                        logger.WriteLine(sizeBefore + "," + file.GetSizeOnDisk() + "," + Math.Round(compRatio, 2) + ",LZX");
                    }

                    continue;
                }
                else {
                    logger.WriteLine("Unrecognized," + file.Name + "," + file.Extension + ",");
                    double compRatio = file.Compress("XPRESS16K");

                    if (compRatio < 1.1) {
                        file.Uncompress();
                        logger.WriteLine(sizeBefore + "," + file.GetSizeOnDisk() + "," + Math.Round(compRatio, 2) + ",Decompressed,Downgraded");
                    }
                    else if (compRatio < 1.3) { // Lower compression if it compresses poorly
                        compRatio = file.Compress("XPRESS8K");
                        logger.WriteLine(sizeBefore + "," + file.GetSizeOnDisk() + "," + Math.Round(compRatio, 2) + ",XPRESS8K,Downgraded");
                    }
                    else if (compRatio > 3.0) {
                        compRatio = file.Compress("LZX");
                        logger.WriteLine(sizeBefore + "," + file.GetSizeOnDisk() + "," + Math.Round(compRatio, 2) + ",LZX,Upgraded");
                    }
                    else {
                        logger.WriteLine(sizeBefore + "," + file.GetSizeOnDisk() + "," + Math.Round(compRatio, 2) + ",XPRESS16K");
                    }
                }
            }

            long folderSizeAfter = rootDir.GetSize();
            double folderSizeAfterGB = (double)folderSizeAfter / 1024 / 1024 / 1024;
            logger.WriteLine("");
            logger.WriteLine("Compressed " + rootDir.Name + " Size = " + Math.Round(folderSizeAfterGB, 3) + "GB. Ratio = " + Math.Round(folderSizeBeforeGB / folderSizeAfterGB, 3) + " to 1");
            logger.WriteLine("");
        }

        #endregion

        #region Private Methods
        #endregion
    }
}
