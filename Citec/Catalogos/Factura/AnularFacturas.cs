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
    public partial class AnularFacturas : Form
    {
        string APP_NAME = ConfigurationManager.AppSettings["NombreAplicacion"];
        IList<Entity.FacturasPendientesViewModel> facturas;
        Util.ValidarDato validaDatos = new Util.ValidarDato();
        Util.MetodosGenerales Controles = new Util.MetodosGenerales();

        public AnularFacturas()
        {
            InitializeComponent();
            this.Text = "Anular Facturas - " + APP_NAME;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AnularFacturas_Load(object sender, EventArgs e)
        {
            using (var service = new Service.FacturaService())
            {
                facturas = service.ObtenerFacturasNoAnuladas();
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

        private void AnularFactura(object sender, DataGridViewCellEventArgs e)
        {
            using (var service = new Service.FacturaService())
            {
                int IdFactura = Convert.ToInt32(dg_facturasPendientes.Rows[e.RowIndex].Cells[0].Value);
                var factura = service.FiltrarPorID(IdFactura);

                if (MessageBox.Show("¿Desea anular la factura " + factura.Num_Factura + "?", APP_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (service.AnularFactura(IdFactura))
                    {
                        dg_facturasPendientes.CargarGrid(facturas);
                        DecorarGrid();
                    }
                    MessageBox.Show("Ocurrio un error",
                            APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
        }
    }
}
