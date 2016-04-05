using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizerEngine.DirCompressors {

    public class OptimalDirCompressor : DirCompressor {
        private string[] highCompressible;
        private string[] nonCompressible;
        private string[] perfSensitive;
        private string[] nonPerfSensitive;
        private string logsDir;

        public OptimalDirCompressor(string dir) : base(dir) {

            // Initialize resources
            highCompressible = Resources.HighCompressible.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            nonCompressible = Resources.NonCompressible.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            perfSensitive = Resources.PerfSensitive.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            nonPerfSensitive = Resources.NonPerfSensitive.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            // Initialize logs folder
            logsDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\ZpOptimizer\Logs\";
            System.IO.Directory.CreateDirectory(logsDir);
        }

        public override void Execute() {
            throw new NotImplementedException();
        }
    }
}
