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


namespace Citec.Catalogos.Clientes
{
	public partial class BusquedaClientes : Form
	{
		string APP_NAME = ConfigurationManager.AppSettings["NombreAplicacion"];
		IList<Entity.ClienteViewModel> clientes;
		Entity.ClienteViewModel clienteSeleccionado;
		Util.ValidarDato validaDatos = new Util.ValidarDato();
		Util.MetodosGenerales Controles = new Util.MetodosGenerales();
		public BusquedaClientes()
		{
			InitializeComponent();
		}

		private void BusquedaClientes_Load(object sender, EventArgs e)
		{
			using (var service = new Service.ClienteService())
			{
				clientes = service.ObtenerTodos();
				dg_clientes.CargarGrid(clientes);
				DecorarGrid();
			}
		}

		private void DecorarGrid()
		{
			dg_clientes.DecorarGrid();
			int[] ocultar = new int[] { 0, 3, 5, 6 };
			dg_clientes.OcultarValores(ocultar);
		}
	}
}
