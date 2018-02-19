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
    public partial class Productos : Form
    {
        string APP_NAME = ConfigurationManager.AppSettings["NombreAplicacion"];
        IList<Entity.ProductoViewModel> productos;
        Entity.ProductoViewModel productoSeleccionado;
        Util.ValidarDato validaDatos = new Util.ValidarDato();
        Util.MetodosGenerales Controles = new Util.MetodosGenerales();

        public Productos()
        {
            InitializeComponent();
            this.Text = "Productos " + APP_NAME;
        }

        private void Productos_Load(object sender, EventArgs e)
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
            int[] ocultar = new int[] { 0 };
            dg_productos.OcultarValores(ocultar);
        }

        private void VerDetalleProducto(object sender, DataGridViewCellEventArgs e)
        {
            var IdProducto = dg_productos.Rows[e.RowIndex].Cells[0].Value;
            productoSeleccionado = productos.Where(x => x.ID == Convert.ToInt32(IdProducto)).FirstOrDefault();
            AsignarValores(productoSeleccionado);
            this.btn_guardar.Enabled = false;
        }

        private void AsignarValores(Entity.ProductoViewModel productoSeleccionado)
        {
            this.tb_marca.Text = productoSeleccionado.Marca;
            this.tb_modelo.Text = productoSeleccionado.Modelo;
            this.tb_costo.Text = productoSeleccionado.CostoImpo.ToString();
            this.tb_stock.Text = productoSeleccionado.Stock.ToString();
            this.tb_minimo.Text = productoSeleccionado.Minimo.ToString();
            this.txt_descripcion.Text = productoSeleccionado.Descripcion;
            this.tb_linea.Text = productoSeleccionado.Linea;
            this.tb_precio1.Text = productoSeleccionado.Precio1.ToString();
            this.tb_precio2.Text = productoSeleccionado.Precio2.ToString();
            this.tb_precio3.Text = productoSeleccionado.Precio3.ToString();
            this.tb_precio4.Text = productoSeleccionado.Precio4.ToString();
            this.tb_comision1.Text = productoSeleccionado.Comision1.ToString();
            this.tb_comision2.Text = productoSeleccionado.Comision2.ToString();
            this.tb_comision3.Text = productoSeleccionado.Comision3.ToString();
            this.tb_comision4.Text = productoSeleccionado.Comision4.ToString();
        }

        private void Filtrar(object sender, EventArgs e)
        {
            try
            {
                IList<Entity.ProductoViewModel> listaProductosFiltro;
                using (var service = new Service.ProductoService())
                {
                    if (this.tb_filtro.Text == "")
                    {
                        listaProductosFiltro = productos;
                    }
                    else
                    {
                        listaProductosFiltro = service.FiltrarProductos(tb_filtro.Text);
                    }
                    dg_productos.CargarGrid(listaProductosFiltro);
                    DecorarGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message + "Inner Exception: " + ex.InnerException,
                            APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Controles.LimpiarControles(this.Controls);
            Controles.DeshabilitarBotones(this.ToolStrip1.Items);
            productoSeleccionado = null;
            btn_guardar.Enabled = true;
            btn_cancelar.Visible = true;
            btn_cancelar.Enabled = true;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            using (var service = new Service.ProductoService())
            {
                try
                {
                    Model.Producto producto = new Model.Producto();
                    validaDatos = ValidarValores(validaDatos);
                    if (validaDatos.EsValido)
                    {
                        producto = ObtenerValores();
                        var IdCliente = service.GuardarProducto(producto);
                        MessageBox.Show("Modelo " + producto.Modelo + " agregado exitosmente",
                               APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Controles.ActivarBotones(this.ToolStrip1.Items);
                        Controles.LimpiarControles(this.Controls);
                        productos = service.ObtenerTodos();
                        dg_productos.CargarGrid(productos);
                        this.btn_cancelar.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show(string.Join(" \n", validaDatos.MensajesDeError), APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrió un error, Por favor intente nuevamente", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private Model.Producto ObtenerValores()
        {
            return new Model.Producto
            {
               Marca =  this.tb_marca.Text,
               Modelo = this.tb_modelo.Text,
               CostoImpo = Convert.ToDouble(this.tb_costo.Text),
               Stock = Convert.ToInt32(this.tb_stock.Text),
               Minimo =  Convert.ToInt32(this.tb_minimo.Text),
               Descripcion = this.txt_descripcion.Text,
               Linea = this.tb_linea.Text,
               Precio1 = Convert.ToDouble(this.tb_precio1.Text),
               Precio2 = Convert.ToDouble(this.tb_precio2.Text),
               Precio3= Convert.ToDouble(this.tb_precio3.Text),
               Precio4 = Convert.ToDouble(this.tb_precio4.Text),
               Comision1 = Convert.ToInt32(this.tb_comision1.Text),
               Comision2 = Convert.ToInt32(this.tb_comision2.Text),
               Comision3 = Convert.ToInt32(this.tb_comision3.Text),
               Comision4 = Convert.ToInt32(this.tb_comision4.Text)
            };
        }

        private ValidarDato ValidarValores(ValidarDato validaDatos)
        {
            validaDatos.MensajesDeError.RemoveRange(0, validaDatos.MensajesDeError.Count());

            if (string.IsNullOrEmpty(this.tb_stock.Text))
            {
                validaDatos.AgregarError("El campo 'Stock' es requerido.");
            }

            if (string.IsNullOrEmpty(this.tb_marca.Text))
            {
                validaDatos.AgregarError("El campo 'Marca' es requerido.");
            }
            if (string.IsNullOrEmpty(this.tb_modelo.Text))
            {
                validaDatos.AgregarError("El campo 'Modelo' es requerido.");
            }
            if (string.IsNullOrEmpty(this.tb_minimo.Text))
            {
                validaDatos.AgregarError("El campo 'Minimo' es requerido.");
            }
            if (string.IsNullOrEmpty(this.tb_costo.Text))
            {
                validaDatos.AgregarError("El campo 'Costo de Importacion' es requerido.");
            }
            if (string.IsNullOrEmpty(this.tb_precio1.Text))
            {
                validaDatos.AgregarError("El campo 'Precio 1' es requerido.");
            }
            if (string.IsNullOrEmpty(this.tb_precio2.Text))
            {
                validaDatos.AgregarError("El campo 'Precio 2' es requerido.");
            }
            if (string.IsNullOrEmpty(this.tb_precio3.Text))
            {
                validaDatos.AgregarError("El campo 'Precio 3' es requerido.");
            }
            if (string.IsNullOrEmpty(this.tb_precio4.Text))
            {
                validaDatos.AgregarError("El campo 'Precio 4' es requerido.");
            }
            if (string.IsNullOrEmpty(this.txt_descripcion.Text))
            {
                validaDatos.AgregarError("El campo 'Descripcion' es requerido.");
            }

            if (validaDatos.MensajesDeError.Count() == 0)
            {
                validaDatos.EsValido = true;
            }

            return validaDatos;
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            using (var service = new Service.ProductoService())
            {
                try
                {
                    Model.Producto producto = new Model.Producto();
                    validaDatos = ValidarValores(validaDatos);
                    if (validaDatos.EsValido)
                    {
                        producto = ObtenerValores();
                        producto.Id_Producto = productoSeleccionado.ID;
                        service.ModificarProducto(producto);
                        MessageBox.Show("Datos del producto " + this.tb_modelo.Text + " modificados exitosamente",
                                APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(string.Join(" \n", validaDatos.MensajesDeError), APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Controles.LimpiarControles(this.Controls);
            Controles.ActivarBotones(this.ToolStrip1.Items);
            btn_cancelar.Visible = false;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            using (var service = new Service.ProductoService())
            {
                try
                {
                    Controles.LimpiarControles(this.Controls);
                    productos = service.ObtenerTodos();
                    dg_productos.CargarGrid(productos);
                    this.btn_cancelar.Visible = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrió un error, Por favor intente nuevamente", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
