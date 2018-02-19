using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citec.Catalogos.Factura
{
    public partial class ImprimirFactura : Form
    {
        public int IdFactura { get; set; }

        public ImprimirFactura()
        {
            InitializeComponent();
        }

        private void ImprimirFactura_Load(object sender, EventArgs e)
        {

        }
    }
}
