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

namespace Citec.Catalogos.Regalias
{
    public partial class Regalias : Form
    {
        string APP_NAME = ConfigurationManager.AppSettings["NombreAplicacion"];
        IList<Entity.ProductoViewModel> productos;
        Entity.ProductoViewModel productoSeleccionado = null;
        Util.ValidarDato validaDatos = new Util.ValidarDato();
        Util.MetodosGenerales Controles = new Util.MetodosGenerales();

        public Regalias()
        {
            InitializeComponent();
            this.Text = "Regalias - " + APP_NAME;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Regalias_Load(object sender, EventArgs e)
        {
            Iniciar();
        }

        private void Iniciar()
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
            int[] ocultar = new int[] { 0, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            dg_productos.OcultarValores(ocultar);
        }

       

        private void SeleccionarProducto(object sender, DataGridViewCellEventArgs e)
        {
            var IdProducto = dg_productos.Rows[e.RowIndex].Cells[0].Value;
            productoSeleccionado = productos.Where(x => x.ID == Convert.ToInt32(IdProducto)).FirstOrDefault();
            AsignarValores(productoSeleccionado);
            this.btn_cancelar.Visible = true;
        }

        private void AsignarValores(Entity.ProductoViewModel productoSeleccionado)
        {
            this.tb_modelo.Text = productoSeleccionado.Modelo;
        }

        private void tb_filtro_TextChanged(object sender, EventArgs e)
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

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Controles.LimpiarControles(this.Controls);
            Controles.ActivarBotones(this.ToolStrip1.Items);
            btn_cancelar.Visible = false;
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            Controles.LimpiarControles(this.Controls);
            Controles.ActivarBotones(this.ToolStrip1.Items);
            btn_cancelar.Visible = false;
            Iniciar(); 
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            using (var service = new Service.RegaliasService())
            {
                try
                {
                    
                    validaDatos = ValidarValores(validaDatos);
                    if (validaDatos.EsValido)
                    {
                        Model.Producto producto = new Model.Producto{
                            Id_Producto = productoSeleccionado.ID,
                            Marca = productoSeleccionado.Marca,
                            Modelo = productoSeleccionado.Modelo,
                            Stock = productoSeleccionado.Stock - Convert.ToInt32(this.tb_cantidad.Text),
                            CostoImpo = productoSeleccionado.CostoImpo
                        };

                        Model.Regalias regalia = new Model.Regalias { 
                            Id_Producto = productoSeleccionado.ID,
                            Cantidad = Convert.ToInt32(this.tb_cantidad.Text),
                            Descripcion = this.txt_descripcion.Text,
                            Fecha = this.dt_fecha.Value
                        };

                        service.IngresarRegalia(producto, regalia);
                        
                        MessageBox.Show("Producto: " + producto.Modelo + " ingresado como regalia exitosmente",
                               APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Controles.ActivarBotones(this.ToolStrip1.Items);
                        Controles.LimpiarControles(this.Controls);

                        Iniciar();
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

        private ValidarDato ValidarValores(ValidarDato validaDatos)
        {
            validaDatos.MensajesDeError.RemoveRange(0, validaDatos.MensajesDeError.Count());

            if (string.IsNullOrEmpty(this.tb_modelo.Text))
            {
                validaDatos.AgregarError("El campo 'Modelo' es requerido.");
            }

            if (string.IsNullOrEmpty(this.tb_cantidad.Text))
            {
                validaDatos.AgregarError("Debe ingresar una cantidad.");
            }

            if ((productoSeleccionado.Stock - Convert.ToInt32(this.tb_cantidad.Text)) < 0)
            {
                validaDatos.AgregarError("No puede dar mas regalias que el inventario existente");
            }

            if (validaDatos.MensajesDeError.Count() == 0)
            {
                validaDatos.EsValido = true;
            }

            return validaDatos;
        }
    }
}
