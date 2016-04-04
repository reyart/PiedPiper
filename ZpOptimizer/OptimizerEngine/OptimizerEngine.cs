using OptimizerEngine.DirCompressors;
using OptimizerEngine.Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizerEngine
{
    public class OptimizerEngine{

        #region Private Properties

        private List<string> allDirs;
        private List<string> selectedDirs;

        #endregion

        #region Constructors

        public OptimizerEngine() {
        }

        #endregion

        #region Public Properties

        #endregion

        #region Public Methods

        // Apply compression on all the selected directories
        public void CompressAll(int compressionType) {
            foreach (string dir in this.allDirs) {
                ApplyCompression(compressionType, dir);
            }
        }

        // Apply compression on only the selected directories
        public void CompressSelected(int compressionType) {
            foreach (string dir in this.selectedDirs) {
                ApplyCompression(compressionType, dir);
            }
        }

        #endregion

        #region Private Methods

        private void ApplyCompression(int compressionType, string dir) {
            DirCompressor compressor;

            // Determine the type of directory compression
            switch (compressionType) {
                case CompressionType.OPTIMAL:
                    compressor = new OptimalDirCompressor(dir);
                    break;
                case CompressionType.MAXIMUM:
                    compressor = new MaximumDirCompressor(dir);
                    break;
                case CompressionType.UNCOMPRESS:
                    compressor = new UncompressDirCompressor(dir);
                    break;
                default:
                    throw new Exception("Invalid CompressionType.");
            }

            // Execute the directory compression
            compressor.Execute();
        }

        #endregion
    }
}
