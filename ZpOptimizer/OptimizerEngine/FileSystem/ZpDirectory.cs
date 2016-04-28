using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OptimizerEngine.FileSystem;
using OptimizerEngine.Helpers;

namespace OptimizerEngine.FileSystem {

    [Serializable()]
    public class ZpDirectory {

        #region Private Properties

        private DirectoryInfo directoryInfo;
        //private List<ZpFile> allFiles;
        //private int fileCount;
        private long dirSize;
        private long dirSizeOnDisk;
        private double ratio;

        #endregion

        #region Constructors

        public ZpDirectory(string path) {

            // Initialize necessary properties
            directoryInfo = new DirectoryInfo(path);
            //allFiles = GetAllFiles();
            //fileCount = allFiles.Count;
            //dirSize = GetSize();
            //dirSizeOnDisk = GetSizeOnDisk();

        }

        #endregion

        #region Public Properties

        public string Path {
            get {
                return directoryInfo.FullName;
            }
        }

        public string Name {
            get {
                return directoryInfo.Name;
            }
        }

        public long Size {
            get {
                if (this.dirSize == 0) { this.dirSize = GetSize(); }
                return dirSize;
            }
        }

        public long SizeMB {
            get {
                if (this.dirSize == 0) { this.dirSize = GetSize(); }
                return dirSize / 1024 / 1024;
            }
        }

        public long SizeOnDisk {
            get {
                if (this.dirSizeOnDisk == 0) { this.dirSizeOnDisk = GetSizeOnDisk(); }
                return dirSizeOnDisk;
            }
        }

        public long SizeOnDiskMB {
            get {
                if (this.dirSizeOnDisk == 0) { this.dirSizeOnDisk = GetSizeOnDisk(); }
                return dirSizeOnDisk / 1024 / 1024;
            }
        }

        public double Ratio {
            get {
                if (this.ratio == 0) { this.ratio = GetRatio(); }
                ratio = Math.Round(ratio, 2);
                return ratio;
            }
        }



        //public int FileCount
        // {
        //    get { return fileCount; }
        // }

        //public List<ZpFile> AllFiles
        // {
        //    get { return allFiles; }
        //}

        #endregion

        #region Public Methods

        public void UpdateSize() {

            this.dirSize = this.GetSize();
        }


        public void UpdateSizeOnDisk() {

            this.dirSizeOnDisk = this.GetSizeOnDisk();
        }



        #endregion

        #region Private Methods
        //TODO: Make these private and test 
        // Gets the total size (in bytes) of all files in the directory
        public long GetSize() {
            long size = 0;

            //if (this.allFiles == null) { this.allFiles = GetAllFiles(); }

            foreach (ZpFile file in this.GetAllFiles()) {
                size += file.Size;
            }

            return size;
        }

        //overload to get in specific unit
        public long GetSize(string mag) {
            long size = 0;

            // if (this.allFiles == null) { this.allFiles = GetAllFiles(); }

            foreach (ZpFile file in this.GetAllFiles()) {
                size += file.Size;
            }

            if (mag == "KB")
                return size / 1024;
            if (mag == "MB")
                return size / 1024 / 1024;
            if (mag == "GB")
                return size / 1024 / 1024 / 1024;
            else
                return size;
        }

        // Gets the total size on disk of all files in the directory
        public long GetSizeOnDisk() {
            long size = 0;

            //if (this.allFiles == null) { this.allFiles = GetAllFiles(); }

            foreach (ZpFile file in this.GetAllFiles()) {
                size += file.SizeOnDisk;
            }

            return size;
        }

        //overload to get in specific unit
        public long GetSizeOnDisk(string mag) {
            long size = 0;

            //if (this.allFiles == null) { this.allFiles = GetAllFiles(); }

            foreach (ZpFile file in this.GetAllFiles()) {
                size += file.SizeOnDisk;
            }

            if (mag == "KB")
                return size / 1024;
            if (mag == "MB")
                return size / 1024 / 1024;
            if (mag == "GB")
                return size / 1024 / 1024 / 1024;
            else
                return size;
        }

        private double GetRatio() {
            double ratio = 0;
            //TODO: Make it always show two decimal places
            //TODO: Replace NaN with something less strange looking
            ratio = Convert.ToDouble(this.SizeOnDisk) / Convert.ToDouble(this.Size);

            return ratio;
        }

        public List<ZpFile> GetAllFiles() {
            List<ZpFile> files = new List<ZpFile>();
            try {
                foreach (FileInfo fileInfo in directoryInfo.EnumerateFiles("*", SearchOption.AllDirectories)) {
                    files.Add(new ZpFile(fileInfo));
                }
            }
            catch (Exception e) {
                Console.WriteLine("{0} Exception caught.", e);
                //throw;
            }

            return files;
        }
        #endregion
    }
}
