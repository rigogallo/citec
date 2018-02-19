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


namespace Citec.Catalogos.Productos
{
    public partial class InventarioProductos : Form
    {
        string APP_NAME = ConfigurationManager.AppSettings["NombreAplicacion"];
        IList<Entity.ProductoViewModel> productos;        
        Util.ValidarDato validaDatos = new Util.ValidarDato();
        Util.MetodosGenerales Controles = new Util.MetodosGenerales();

        public InventarioProductos()
        {
            InitializeComponent();
            this.Text = "Productos " + APP_NAME;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Filtrar(object sender, EventArgs e)
        {
            try
            {
                Iniciar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message + "Inner Exception: " + ex.InnerException,
                            APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Iniciar()
        {
            IList<Entity.ProductoViewModel> listaProductosFiltro;
            using (var service = new Service.ProductoService())
            {
                if (this.tb_modelo.Text == "")
                {
                    listaProductosFiltro = productos;
                }
                else
                {
                    listaProductosFiltro = service.FiltrarProductos(tb_modelo.Text);
                }
                dg_productos.CargarGrid(listaProductosFiltro);
                DecorarGrid();
            }
        }

        private void InventarioProductos_Load(object sender, EventArgs e)
        {
            using (var service = new Service.ProductoService())
            {
                productos = service.ObtenerTodos();
                dg_productos.CargarGrid(productos);
                DecorarGrid();
            }
        }

        private void DecorarGrid()
        {
            dg_productos.DecorarGrid();
            int[] ocultar = new int[] { 0, 4, 5,6,7,8,9,10,11,12,13 };
            dg_productos.OcultarValores(ocultar);
        }

        private void btn_actulizar_Click(object sender, EventArgs e)
        {
            this.tb_modelo.Text = "";
            Iniciar();
        }
    }
}
