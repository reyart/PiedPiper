using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizerEngine {
    public class Directory {

        #region Private Properties

        private string folderPath;
        private string name;
        private int fileCount;
        private int folderSize;

        #endregion Private Properties

        #region Constructors

        public Directory(string path) {
            this.folderPath = path;
            this.name = GetFolderName();
        }

        #endregion

        #region Public Properties

        // File path of Directory
        public string Path {
            get { return this.folderPath; }
        }

        // Folder name
        public string Name {
            get { return this.name; }
        }


        #endregion Public Properties

        #region Methods

        // Identifies the folder name based on the Path
        private string GetFolderName() {
            return "UNFINISHED";
        }

        #endregion Methods

    }
}
