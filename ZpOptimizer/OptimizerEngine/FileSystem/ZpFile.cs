using OptimizerEngine.Helpers;
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
        public FileAttributes attributes;


        #endregion

        #region Constructors

        public ZpFile(string fileName) {

            // Initialize necessary properties
            fileInfo = new FileInfo(fileName);
            FileAttributes attributes = File.GetAttributes(fileInfo.FullName);
        }

        public ZpFile(FileInfo fi) {

            // Initialize necessary properties
            fileInfo = fi;            
        }

        #endregion

        #region Public Properties

        // Name of the file
        public string Name
        {
            get { return fileInfo.Name; }
        }

        // Full path of file
        public string FullName
        {
            get { return fileInfo.FullName; }
        }

        public string Extension
        {
            get { return fileInfo.Extension; }
        }

        public FileAttributes Attributes
        {
            get { return fileInfo.Attributes; }
        }


        // File is too small
        public bool IsTooSmall
        {
            get { return this.GetSize() < 4096; }
        }

        // File is not compressible
        public bool IsNonCompressible
        {
            get { return Globals.NonCompressibleFiles.Contains(this.Extension.ToLower()); }
        }

        // File is performance sensitive
        public bool IsPerfSensitive
        {
            get { return Globals.PerfSensitiveFiles.Contains(this.Extension.ToLower()); }
        }

        // File is not performance sensitive
        public bool IsNonPerfSensitive
        {
            get { return Globals.NonPerfSensitiveFiles.Contains(this.Extension.ToLower()); }
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

        // Compress file. Returns compression ratio
        public double Compress(string compressionType) {
            Process p = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/C compact /C /F /EXE:" + compressionType + " " + '"' + this.FullName + '"';
            p.Start();

            StreamReader reader = p.StandardOutput;
            string output = reader.ReadLine();
            p.WaitForExit();

            double ratio = (double)this.GetSize() / (double)this.GetSizeOnDisk();
            return ratio;
        }

        public void RemoveArchiveAttribute()
        {
            //FileAttributes attributes = File.GetAttributes(FullName);
            attributes = RemoveAttribute(attributes, FileAttributes.Archive);
            File.SetAttributes(FullName, attributes);
        }

        public void AddArchiveAttribute()
        {
            //FileAttributes attributes = File.GetAttributes(FullName);
            //attributes = RemoveAttribute(attributes, FileAttributes.Archive);
            //File.SetAttributes(FullName, attributes);

            File.SetAttributes(FullName, File.GetAttributes(FullName) | FileAttributes.Archive);
        }


        #endregion

        #region Private Methods

        private static FileAttributes RemoveAttribute(FileAttributes attributes, FileAttributes attributesToRemove)
        {
            return attributes & ~attributesToRemove;
        }

        



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
