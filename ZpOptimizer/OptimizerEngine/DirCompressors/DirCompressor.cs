using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OptimizerEngine.FileSystem;
using OptimizerEngine.Helpers;

namespace OptimizerEngine.DirCompressors {

    public abstract class DirCompressor {

        #region Private Properties

        protected ZpDirectory rootDir;  // Root folder where compression starts
        protected Logger logger;  // Logs stuff

        #endregion

        #region Constructors

        public DirCompressor(string dir) {

            // Initialize directory
            rootDir = new ZpDirectory(dir);

            // Initialize logger
            logger = new Logger();
            logger.CreateNewLogFile(rootDir.Name + " " + DateTime.Now.ToFileTime() + ".txt");


        }

        #endregion

        #region Public Properties

        #endregion

        #region Public Methods

        public abstract void Execute();

        #endregion

        #region Private Methods

        #endregion
    }
}
