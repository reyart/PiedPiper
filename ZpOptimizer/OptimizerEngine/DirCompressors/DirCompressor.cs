using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizerEngine.DirCompressors {

    public abstract class DirCompressor {

        #region Private Properties

        #endregion

        #region Constructors

        public DirCompressor(string dir) {
        }

        #endregion

        #region Public Properties

        #endregion

        #region Public Methods

        public abstract void Execute();

        #endregion

        #region Private Methods

        #endregion
    }
}
