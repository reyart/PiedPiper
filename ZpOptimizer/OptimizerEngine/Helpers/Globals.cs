using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizerEngine.Helpers {
    public static class Globals {

        public const int OPTIMAL = 1;
        public const int MAXIMUM = 2;
        public const int UNCOMPRESS = 3;
    }

    //[Flags]
    public enum CompressionTypes {
        OPTIMAL = 0,
        MAXIMUM = 1,
        UNCOMPRESS = 2
    }
}
