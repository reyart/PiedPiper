using OptimizerEngine.DirCompressors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OptimizerEngine.Helpers.Globals;
using System.ComponentModel;
using OptimizerEngine.FileSystem;

namespace OptimizerEngine {
    public class OptimizerEngine {


        #region Private Properties

        //private List<string> allDirs;
        //private List<string> selectedDirs;
        private ZpDirectory activeZpDir;
        private BackgroundWorker activeBackgroundWorker;

        #endregion



        #region Constructors

        public OptimizerEngine(ZpDirectory dir, BackgroundWorker bw) {
            activeZpDir = dir;
            activeBackgroundWorker = bw;
        }

        /* OLD
        public OptimizerEngine(string dir)
        {         
            selectedDirs = new List<string>();
            selectedDirs.Add(dir); // FOR TESTING ONLY
        }

        public OptimizerEngine(string[] dir)
        {
            selectedDirs = new List<string>();
            selectedDirs.AddRange(dir);
        }

        public OptimizerEngine(string dir, BackgroundWorker bw)
        {
            selectedDirs = new List<string>();
            selectedDirs.Add(dir);
            activeBackgroundWorker = bw;
        }
        */
        #endregion



        #region Public Properties

        #endregion



        #region Public Methods

        // Apply compression on only the selected directories
        /* OLD
        public void CompressSelected(DirCompressionTypes compressionType) {
            foreach (string dir in this.selectedDirs) {
                ApplyCompression(compressionType, dir);
            }
        }
        */

        public void CompressActiveDir(ZpDirectory activeDir, DirCompressionTypes compressionType) {
            ApplyCompression(compressionType, activeDir);

        }

        #endregion



        #region Private Methods

        // Apply compression
        /* OLD
        private void ApplyCompression(DirCompressionTypes compressionType, string dir) {
            DirCompressor compressor;
            

            // Determine the type of directory compression
            switch (compressionType) {
                case DirCompressionTypes.OPTIMAL:
                    compressor = new OptimalDirCompressor(dir);
                    break;
                case DirCompressionTypes.MAXIMUM:
                    compressor = new MaximumDirCompressor(dir);
                    break;
                case DirCompressionTypes.UNCOMPRESS:
                    compressor = new UncompressDirCompressor(dir);
                    break;
                default:
                    throw new Exception("Invalid CompressionType");
            }

            // Execute the directory compression
            compressor.Execute(activeBackgroundWorker);
        }
        */


        private void ApplyCompression(DirCompressionTypes compressionType, ZpDirectory activeDir) {
            DirCompressor compressor;


            // Determine the type of directory compression
            switch (compressionType) {
                case DirCompressionTypes.OPTIMAL:
                    compressor = new OptimalDirCompressor(activeDir);
                    break;
                case DirCompressionTypes.MAXIMUM:
                    compressor = new MaximumDirCompressor(activeDir);
                    break;
                case DirCompressionTypes.UNCOMPRESS:
                    compressor = new UncompressDirCompressor(activeDir);
                    break;
                default:
                    throw new Exception("Invalid CompressionType");
            }

            // Execute the directory compression
            compressor.Execute(activeBackgroundWorker);
        }

        #endregion

    }
}
