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

        // Holds file extensions used for evaluating compression behavior
        private string[] highCompressible;
        private string[] nonCompressible;
        private string[] perfSensitive;
        private string[] nonPerfSensitive;

        private Logger logger;  // Logs stuff

        #endregion

        #region Constructors

        public OptimalDirCompressor(string dir) : base(dir) {
            // Initialize logger
            logger = new Logger();

            // Initialize resources
            highCompressible = Resources.HighCompressible.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            nonCompressible = Resources.NonCompressible.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            perfSensitive = Resources.PerfSensitive.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            nonPerfSensitive = Resources.NonPerfSensitive.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

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
            }
        }

        #endregion

        #region Private Methods
        #endregion
    }
}
