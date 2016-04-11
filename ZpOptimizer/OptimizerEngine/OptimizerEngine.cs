using OptimizerEngine.DirCompressors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OptimizerEngine.Helpers.Globals;

namespace OptimizerEngine
{
    public class OptimizerEngine{

        #region Private Properties

        private List<string> allDirs;
        private List<string> selectedDirs;

        #endregion

        #region Constructors

        /*
        public OptimizerEngine() {
            allDirs = new List<string>();
            selectedDirs = new List<string>();

            selectedDirs.Add("Y:\\test"); // FOR TESTING ONLY
        }
        */

        public OptimizerEngine(string dir)
        {
            allDirs = new List<string>();
            selectedDirs = new List<string>();

           selectedDirs.Add(dir); // FOR TESTING ONLY
        }


        #endregion

        #region Public Properties

        #endregion

        #region Public Methods

        // Apply compression on all the selected directories
        public void CompressAll(CompressionTypes compressionType) {
            foreach (string dir in this.allDirs) {
                ApplyCompression(compressionType, dir);
            }
        }

        // Apply compression on only the selected directories
        public void CompressSelected(CompressionTypes compressionType) {
            foreach (string dir in this.selectedDirs) {
                ApplyCompression(compressionType, dir);
            }
        }

        #endregion

        #region Private Methods

        // Apply compression
        private void ApplyCompression(CompressionTypes compressionType, string dir) {
            DirCompressor compressor;

            // Determine the type of directory compression
            switch (compressionType) {
                case CompressionTypes.OPTIMAL:
                    compressor = new OptimalDirCompressor(dir);
                    break;
                case CompressionTypes.MAXIMUM:
                    compressor = new MaximumDirCompressor(dir);
                    break;
                case CompressionTypes.UNCOMPRESS:
                    compressor = new UncompressDirCompressor(dir);
                    break;
                default:
                    throw new Exception("Invalid CompressionType");
            }

            // Execute the directory compression
            compressor.Execute();
        }

        #endregion
    }
}
