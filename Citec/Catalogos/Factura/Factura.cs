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
    public partial class Factura : Form
    {
        string APP_NAME = ConfigurationManager.AppSettings["NombreAplicacion"];
        IList<Entity.ProductoViewModel> productos;
        IList<Entity.ProductoViewModel> productosEnFactura;
        Entity.ProductoViewModel productoSeleccionado;
        Util.ValidarDato validaDatos = new Util.ValidarDato();
        Util.MetodosGenerales Controles = new Util.MetodosGenerales();

        public Factura()
        {
            InitializeComponent();
        }
        
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            dg_orden.EndEdit();
            validaDatos = ValidarValores(validaDatos);

            if (validaDatos.EsValido)
            {
                using (var service = new Service.FacturaService())
                {
                    var esFacturaDuplicada = service.EsFacturaDuplicada(Convert.ToInt32(this.tb_numFactura.Text));

                    if (!esFacturaDuplicada)
                    {
                        Model.Factura factura = new Model.Factura();
                        factura.Id_Usuario = 1;
                        factura.Num_Factura = Convert.ToInt32(this.tb_numFactura.Text);
                        factura.Fecha = this.fecha_fac.Value;
                        factura.IVA = Convert.ToDouble(this.tb_IVA.Text);
                        factura.Monto = Convert.ToDouble(this.tb_total.Text);
                        factura.Tcambio = Convert.ToDouble(this.tb_tipoCambio.Text);
                        factura.Credito = this.rb_credito.Checked;
                        factura.nRUC = this.tb_ruc.Text;
                        factura.Nombre_Cliente = this.tb_nombre.Text;
                        factura.Fecha_Venc = this.fecha_venc.Value;     
                   
                        foreach (DataGridViewRow articulo in dg_orden.Rows)
                        {
                            Model.FacturaDetalle detalle = new Model.FacturaDetalle();
                            detalle.Cantidad = Convert.ToInt32(articulo.Cells[2].Value);
                            detalle.Porcentaje = ObtenerPorcentajeComision(articulo);
                            detalle.Precio = Convert.ToDouble(articulo.Cells[3].Value);
                            detalle.Id_Producto = Convert.ToInt32(articulo.Cells[0].Value);
                            factura.FacturaDetalle.Add(detalle);                            
                        }
                        if (service.CrearFactura(factura))
                        {
                            MessageBox.Show("Factura creada!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Controles.LimpiarControles(this.Controls);
                            this.dg_orden.Rows.Clear();
                            ObtenerProductos();
                            DecorarGrid();
                        }
                        else
                        {
                            MessageBox.Show("Ocurrio un error al guardar la factura", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Factura duplicada", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            
        }

        private int? ObtenerPorcentajeComision(DataGridViewRow articulo)
        {
            double precioVenta = Convert.ToDouble(articulo.Cells[3].Value) / Convert.ToDouble(this.tb_tipoCambio.Text);
            double Precio1 = Convert.ToDouble(articulo.Cells[8].Value);
            double Precio2 = Convert.ToDouble(articulo.Cells[9].Value);
            double Precio3 = Convert.ToDouble(articulo.Cells[10].Value);
            double Precio4 = Convert.ToDouble(articulo.Cells[11].Value);
            int Comision1 = Convert.ToInt32(articulo.Cells[4].Value);
            int Comision2 = Convert.ToInt32(articulo.Cells[5].Value);
            int Comision3 = Convert.ToInt32(articulo.Cells[6].Value);
            int Comision4 = Convert.ToInt32(articulo.Cells[7].Value);
            
            int PorcentajeFinal = Comision1;

            if (precioVenta >= Precio2 && precioVenta < Precio3)
            {
                PorcentajeFinal = Comision2;
            }

            if (precioVenta >= Precio3 && precioVenta < Precio4)
            {
                PorcentajeFinal = Comision3;
            }

            if (precioVenta >= Precio4)
            {
                PorcentajeFinal = Comision4;
            }

            return PorcentajeFinal;
        }

        private ValidarDato ValidarValores(ValidarDato validaDatos)
        {
            validaDatos.MensajesDeError.RemoveRange(0, validaDatos.MensajesDeError.Count());

            if (string.IsNullOrEmpty(this.tb_numFactura.Text))
            {
                validaDatos.AgregarError("Debe ingresar el número de factura.");
            }

            if (dg_orden.Rows.Count <= 0)
            {
                validaDatos.AgregarError("Aún no ingresa productos a la factura");
            }

            if (string.IsNullOrEmpty(this.tb_nombre.Text))
            {
                validaDatos.AgregarError("Debe ingresar un cliente");
            }

           
            if (validaDatos.MensajesDeError.Count() == 0)
            {
                validaDatos.EsValido = true;
            }

            return validaDatos;
        }
        
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            ObtenerProductos();
            DecorarGrid();
        }

        private void ObtenerProductos()
        {
            using (var service = new Service.ProductoService())
            {
                productos = service.ObtenerTodos();
                dg_productos.CargarGrid(productos);
            }
        }

        private void DecorarGrid()
        {
            dg_productos.DecorarGrid();
            int[] ocultar = new int[] { 0, 1, 4, 5, 10, 11, 12, 13 };
            dg_productos.OcultarValores(ocultar);
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

        private void AgregarProducto(object sender, DataGridViewCellEventArgs e)
        {
            if (!String.IsNullOrEmpty(this.tb_tipoCambio.Text))
            {
                var IdProducto = dg_productos.Rows[e.RowIndex].Cells[0].Value;
                productoSeleccionado = productos.Where(x => x.ID == Convert.ToInt32(IdProducto)).FirstOrDefault();

                bool productoEnFactura = false;
                if (productoSeleccionado.Stock > 0)
                {                    
                    if (!ComprobarProductoEnFactura(productoEnFactura))
                    {
                        dg_orden.Rows.Add(productoSeleccionado.ID, productoSeleccionado.Modelo, "0", "0", productoSeleccionado.Comision1,
                                            productoSeleccionado.Comision2, productoSeleccionado.Comision3, productoSeleccionado.Comision4,
                                            productoSeleccionado.Precio1, productoSeleccionado.Precio2, productoSeleccionado.Precio3, productoSeleccionado.Precio4, "0");
                        this.tb_filtro.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("El producto ya se encuentra en factura", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("El producto " + productoSeleccionado.Modelo + " se agotó en Inventario", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Aún no ingresa la tasa de cambio", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ComprobarProductoEnFactura(bool productoEnFactura)
        {
            foreach (DataGridViewRow producto in dg_orden.Rows)
            {
                if (Convert.ToInt32(producto.Cells[0].Value) == productoSeleccionado.ID)
                {
                    productoEnFactura = true;
                }
            }
            return productoEnFactura;
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dg_orden.EndEdit();
        }

        private void ValidarMaximos(object sender, DataGridViewCellEventArgs e)
        {
            double tipoCambio = Convert.ToDouble(this.tb_tipoCambio.Text);
            int idProducto = Convert.ToInt32(dg_orden.Rows[e.RowIndex].Cells[0].Value);
            double precioEnFactura = Convert.ToDouble(dg_orden.Rows[e.RowIndex].Cells[3].Value);
            int cantidadEnFactura = Convert.ToInt32(dg_orden.Rows[e.RowIndex].Cells[2].Value);
            using (var service = new Service.ProductoService())
            {
                var producto = service.FiltrarPorID(idProducto);
                if (cantidadEnFactura > producto.Stock)
                {
                    MessageBox.Show("No hay suficiente inventario del producto: " + producto.Modelo, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dg_orden.Rows[e.RowIndex].Cells[2].Value = producto.Stock;
                    dg_orden.Rows[e.RowIndex].Cells[12].Value = producto.Stock * precioEnFactura;
                    dg_orden.EndEdit();
                }
                else
                {
                    dg_orden.Rows[e.RowIndex].Cells[3].Value = precioEnFactura * tipoCambio;
                    dg_orden.Rows[e.RowIndex].Cells[12].Value = cantidadEnFactura * precioEnFactura * tipoCambio;

                    double total = 0;
                    foreach (DataGridViewRow articulo in dg_orden.Rows)
                    {
                        var subtotal = Convert.ToDouble(articulo.Cells[12].Value);
                        total = total + subtotal;
                    }

                    this.tb_total.Text = total.ToString();
                }
            }
        }

        private void CambioDeSubtotal(object sender, EventArgs e)
        {
            double IVA = 0;
            if (!String.IsNullOrEmpty(this.tb_total.Text))
            {
                IVA = Convert.ToDouble(this.tb_total.Text) * 0.15;
                this.tb_IVA.Text = IVA.ToString();
                this.tb_totalgeneral.Text = Convert.ToString(Convert.ToDouble(this.tb_total.Text) + IVA);
            }
            else
            {
                IVA = 0;
            }
        }

        private void RemoverProducto(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            double total = 0;
            foreach (DataGridViewRow articulo in dg_orden.Rows)
            {
                var subtotal = Convert.ToDouble(articulo.Cells[4].Value);
                total = +subtotal;
            }
            this.tb_total.Text = total.ToString();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            this.dg_orden.Rows.Clear();
            Controles.LimpiarControles(this.Controls);
            ObtenerProductos();
            DecorarGrid();
        }
    }
}
