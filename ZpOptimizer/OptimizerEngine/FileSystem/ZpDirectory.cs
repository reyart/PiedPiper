using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OptimizerEngine.FileSystem;
using OptimizerEngine.Helpers;

namespace OptimizerEngine.FileSystem {

    public class ZpDirectory {

        #region Private Properties

        private int fileCount;
        private int folderSize;
        private DirectoryInfo directoryInfo;
        private List<ZpFile> allFiles;

        #endregion

        #region Constructors

        public ZpDirectory(string path) {

            // Initialize necessary properties
            directoryInfo = new DirectoryInfo(path);
            allFiles = GetAllFiles();
        }

        #endregion

        #region Public Properties

        // Full path of Directory
        public string Path {
            get { return directoryInfo.FullName; }
        }

        // Folder name
        public string Name {
            get { return directoryInfo.Name; }
        }

        #endregion

        #region Public Methods

        // Gets the total size (in bytes) of all files in the directory
        public long GetSize() {
            long size = 0;

            foreach (ZpFile file in this.allFiles) {
                size += file.GetSize();
            }
            
            return size;
        }

        // Gets the total size on disk of all files in the directory
        public long GetSizeOnDisk() {
            long size = 0;

            foreach (ZpFile file in this.allFiles) {
                size += file.GetSizeOnDisk();
            }

            return size;
        }

        // Gets a list of all files in the directory
        public List<ZpFile> GetAllFiles() {
            List<ZpFile> files = new List<ZpFile>();
            try
            {
                foreach (FileInfo fileInfo in directoryInfo.EnumerateFiles("*", SearchOption.AllDirectories))
                {
                    files.Add(new ZpFile(fileInfo));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                //throw;
            }



            return files;
        }

        #endregion

        #region Private Methods

        #endregion

    }
}
