using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OptimizerEngine.FileSystem {

    public class ZpFile {

        #region Private Properties

        private FileInfo fileInfo;

        #endregion

        #region Constructors

        public ZpFile(string fileName) {

            // Initialize necessary properties
            fileInfo = new FileInfo(fileName);
        }

        public ZpFile(FileInfo fi) {

            // Initialize necessary properties
            fileInfo = fi;
        }

        #endregion

        #region Public Properties

        // Name of the file
        public string Name {
            get { return fileInfo.Name; }
        }

        // Full path of file
        public string FullName {
            get { return fileInfo.FullName; }
        }

        #endregion

        #region Public Methods

        // Get the Size (in bytes) of the file
        public long GetSize() {
            return fileInfo.Length;
        }

        // Get the Size on Disk (in bytes) of the file
        public long GetSizeOnDisk() {
            uint dummy, sectorsPerCluster, bytesPerSector;

            int result = GetDiskFreeSpaceW(fileInfo.Directory.Root.FullName, out sectorsPerCluster, out bytesPerSector, out dummy, out dummy);
            if (result == 0) throw new Win32Exception();
            uint clusterSize = sectorsPerCluster * bytesPerSector;
            uint hosize;
            uint losize = GetCompressedFileSizeW(this.FullName, out hosize);
            long size;
            size = (long)hosize << 32 | losize;
            return ((size + clusterSize - 1) / clusterSize) * clusterSize;
        }

        // Uncompress file
        public void Uncompress() {
            Process p = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C compact /U /F " + this.FullName;
            p.StartInfo = startInfo;
            p.Start();
            p.WaitForExit();
        }

        #endregion

        #region Private Methods

        [DllImport("kernel32.dll")]
        private static extern uint GetCompressedFileSizeW([In, MarshalAs(UnmanagedType.LPWStr)] string lpFileName,
           [Out, MarshalAs(UnmanagedType.U4)] out uint lpFileSizeHigh);

        [DllImport("kernel32.dll", SetLastError = true, PreserveSig = true)]
        private static extern int GetDiskFreeSpaceW([In, MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName,
           out uint lpSectorsPerCluster, out uint lpBytesPerSector, out uint lpNumberOfFreeClusters,
           out uint lpTotalNumberOfClusters);

        #endregion
    }
}
