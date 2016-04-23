using OptimizerEngine.DirCompressors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OptimizerEngine.Helpers.Globals;
using System.ComponentModel;

namespace OptimizerEngine
{
    public class OptimizerEngine{


        #region Private Properties

        private List<string> allDirs;
        private List<string> selectedDirs;
        private BackgroundWorker bgw;

        #endregion



        #region Constructors

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
            bgw = bw;
        }

        #endregion



        #region Public Properties

        #endregion



        #region Public Methods

        // Apply compression on only the selected directories
        public void CompressSelected(DirCompressionTypes compressionType) {
            foreach (string dir in this.selectedDirs) {
                ApplyCompression(compressionType, dir);
            }
        }

        #endregion



        #region Private Methods

        // Apply compression
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
            compressor.Execute(bgw);
        }

        #endregion

    }
}
