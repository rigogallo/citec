using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service = DAL.Services;
using Model = DAL.Models;
using Citec.Util;

namespace Citec.Catalogos.Factura
{
    public partial class BuscarFactura : Form
    {
        string APP_NAME = ConfigurationManager.AppSettings["NombreAplicacion"];
        //IList<Entity.ProductoViewModel> productos;
        //IList<Entity.ProductoViewModel> productosEnFactura;
        //Entity.FacturaViewModel productoSeleccionado;
        Util.ValidarDato validaDatos = new Util.ValidarDato();
        Util.MetodosGenerales Controles = new Util.MetodosGenerales();

        public BuscarFactura()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (var service = new Service.FacturaService())
            {
                var factura = service.FiltrarPorID(Convert.ToInt32(this.tb_numfactura.Text));

            }
        }
    }
}
