using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizerEngine.FileSystem {

    public class Directory {

        #region Private Properties

        private DirectoryInfo directoryInfo;
        private string folderPath;
        private string name;
        private int fileCount;
        private int folderSize;

        #endregion

        #region Constructors

        public Directory(string path) {
            // Initialize private properties
            directoryInfo = new DirectoryInfo(path);
            folderPath = path;
            name = directoryInfo.Name;
        }

        #endregion

        #region Public Properties

        // Full path of Directory
        public string Path {
            get { return this.folderPath; }
        }

        // Folder name
        public string Name {
            get { return this.name; }
        }


        #endregion

        #region Public Methods

        #endregion

        #region Private Methods

        #endregion

    }
}
