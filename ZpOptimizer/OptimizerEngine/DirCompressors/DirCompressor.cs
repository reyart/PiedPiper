using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OptimizerEngine.FileSystem;
using OptimizerEngine.Helpers;

using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Windows.Forms;
using System.IO;

namespace OptimizerEngine.DirCompressors {

    public abstract class DirCompressor {

        #region Private Properties

        protected ZpDirectory rootDir;  // Root folder where compression starts
        protected Logger logger;  // Logs stuff
        protected bool loggingStarted;

        public delegate void ProgressUpdate(int value);
        public event ProgressUpdate OnProgressUpdate;
        
        #endregion

        #region Constructors

        public DirCompressor(string dir) {

            // Initialize directory
            rootDir = new ZpDirectory(dir);

            // Initialize logger
            logger = new Logger();
            
            loggingStarted = false;



        }

        #endregion

        #region Public Properties

        #endregion

        #region Public Methods

        public abstract void Execute(BackgroundWorker bw);

        

        #endregion

        #region Private Methods

        #endregion
    }
}
