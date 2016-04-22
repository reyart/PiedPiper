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
        private List<ZpFile> allFiles;
        private int fileCount;
        private long dirSize;
        private long dirSizeOnDisk;

        #endregion

        #region Constructors

        public ZpDirectory(string path) {

            // Initialize necessary properties
            directoryInfo = new DirectoryInfo(path);
            allFiles = GetAllFiles();
            fileCount = allFiles.Count;
            dirSize = GetSize();
            dirSizeOnDisk = GetSizeOnDisk();

        }

        #endregion

        #region Public Properties
    
        public string Path
        {
            get { return directoryInfo.FullName; }
        }
    
        public string Name
        {
            get { return directoryInfo.Name; }
        }

        public long Size
        {
            get { return dirSize; }
        }

        public long SizeMB
        {
            get { return dirSize / 1024 / 1024; }
        }


        public long SizeOnDisk
        {
            get { return dirSizeOnDisk; }
        }

        public long SizeOnDiskMB
        {
            get { return dirSizeOnDisk / 1024 / 1024; }
        }

        public int FileCount
        {
            get { return fileCount; }
        }

        public List<ZpFile> AllFiles
        {
            get { return allFiles; }
        }
        #endregion

        #region Public Methods


        #endregion

        #region Private Methods

        // Gets the total size (in bytes) of all files in the directory
        private long GetSize()
        {
            long size = 0;

            foreach (ZpFile file in this.allFiles)
            {
                size += file.Size;
            }

            return size;
        }

        //overload to get in specific unit
        private long GetSize(string mag)
        {
            long size = 0;

            foreach (ZpFile file in this.allFiles)
            {
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
        private long GetSizeOnDisk()
        {
            long size = 0;

            foreach (ZpFile file in this.allFiles)
            {
                size += file.SizeOnDisk;
            }

            return size;
        }

        //overload to get in specific unit
        private long GetSizeOnDisk(string mag)
        {
            long size = 0;

            foreach (ZpFile file in this.allFiles)
            {
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


        private List<ZpFile> GetAllFiles()
        {
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

    }
}
