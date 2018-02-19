using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service = DAL.Services;
using Model = DAL.Models;
using Citec.Util;
using System.Configuration;

namespace Citec.Catalogos.Factura
{
    public partial class FacturasPendientes : Form
    {
        string APP_NAME = ConfigurationManager.AppSettings["NombreAplicacion"];
        IList<Entity.FacturasPendientesViewModel> facturas;        
        Util.ValidarDato validaDatos = new Util.ValidarDato();
        Util.MetodosGenerales Controles = new Util.MetodosGenerales();

        public FacturasPendientes()
        {
            InitializeComponent();
            this.Text = "Facturas Pendientes - " + APP_NAME;
        }

        private void FacturasPendientes_Load(object sender, EventArgs e)
        {
            using (var service = new Service.FacturaService())
            {
                facturas = service.ObtenerFacturasPendientes();
                dg_facturasPendientes.CargarGrid(facturas);
                DecorarGrid();
            }
        }

        private void DecorarGrid()
        {
            dg_facturasPendientes.DecorarGrid();
            int[] ocultar = new int[] { 0 };
            dg_facturasPendientes.OcultarValores(ocultar);
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
