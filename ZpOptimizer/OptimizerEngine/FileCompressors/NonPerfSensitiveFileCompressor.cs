using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizerEngine.FileCompressors {
    public class NonPerfSensitiveFileCompressor : FileCompressor {

        public NonPerfSensitiveFileCompressor(string file) : base(file) {
        }

        public override void Execute() {
            throw new NotImplementedException();
        }
    }
}
