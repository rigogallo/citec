using Citec.Catalogos.Factura;
using Citec.Catalogos.Productos;
using Citec.Catalogos.Regalias;
using Citec.Catalogos.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Citec
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes formClientes = new Clientes();
            CargarFormulario(formClientes);
        }

        private void CargarFormulario(Form formulario)
        {
            formulario.StartPosition = FormStartPosition.CenterScreen;
            formulario.MdiParent = this;
            formulario.Show();
            formulario.Focus();
        }

        private void InventarioDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventarioProductos formInventarioProductos = new InventarioProductos();
            CargarFormulario(formInventarioProductos);
        }

        private void PermisosYUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios formUsuarios = new Usuarios();
            CargarFormulario(formUsuarios);
        }

        private void LibrosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Productos formProductos = new Productos();
            CargarFormulario(formProductos);
        }

        private void IngresarRegaliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Regalias formRegalias = new Regalias();
            CargarFormulario(formRegalias);
        }

        private void CrearFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Factura formFactura = new Factura();
            CargarFormulario(formFactura);
        }

        private void FacturasEnCréditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacturasPendientes formFacturasPendientes = new FacturasPendientes();
            CargarFormulario(formFacturasPendientes);
        }

        private void AnularFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnularFacturas formAnularFacturas = new AnularFacturas();
            CargarFormulario(formAnularFacturas);
        }
    }
}
