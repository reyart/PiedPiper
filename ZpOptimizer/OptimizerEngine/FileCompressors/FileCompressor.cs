using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizerEngine.FileCompressors {
    public abstract class FileCompressor {

        public FileCompressor(string file) {
        }

        public abstract void Execute();
    }
}
