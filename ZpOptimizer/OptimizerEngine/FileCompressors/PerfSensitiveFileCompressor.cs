using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizerEngine.FileCompressors {

    public class PerfSensitiveFileCompressor : FileCompressor {

        public PerfSensitiveFileCompressor(string file) : base(file) {
        }

        public override void Execute() {
            throw new NotImplementedException();
        }
    }
}
