using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizerEngine.FileCompressors {

    public class UnrecognizedFileCompressor : FileCompressor {

        public UnrecognizedFileCompressor(string file) : base(file) {
        }

        public override void Execute() {
            throw new NotImplementedException();
        }
    }
}
