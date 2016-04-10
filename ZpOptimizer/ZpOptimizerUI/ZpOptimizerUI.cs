using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OptimizerEngine.Helpers.Globals;

namespace ZpOptimizerUI
{
    public partial class ZpOptimizerUI : Form
    {
        private OptimizerEngine.OptimizerEngine engine;

        private CompressionTypes compressionType;

        public ZpOptimizerUI()
        {
            InitializeComponent();

            engine = new OptimizerEngine.OptimizerEngine();

            compressionType = CompressionTypes.OPTIMAL; // FOR TESTING ONLY
        }

        private void buttonApplySelected_Click(object sender, EventArgs e) {
            engine.CompressSelected(compressionType);
        }
    }
}
