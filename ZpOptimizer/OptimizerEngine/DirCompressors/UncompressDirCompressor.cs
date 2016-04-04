using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizerEngine.DirCompressors {
    public class UncompressDirCompressor : DirCompressor {

        public UncompressDirCompressor(string dir) : base(dir) {
        }

        public override void Execute() {
            throw new NotImplementedException();
        }
    }
}
