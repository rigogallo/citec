using System;
using System.Configuration;
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

namespace Citec
{
    public partial class Clientes : Form
    {
        string APP_NAME = ConfigurationManager.AppSettings["NombreAplicacion"];
        IList<Entity.ClienteViewModel> clientes;
        Entity.ClienteViewModel clienteSeleccionado;
        Util.ValidarDato validaDatos = new Util.ValidarDato();
        Util.MetodosGenerales Controles = new Util.MetodosGenerales();

        public Clientes()
        {            
            InitializeComponent();
            this.Text = "Clientes " + APP_NAME;
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            using (var service = new Service.ClienteService())
            {
                var x = "";
                clientes = service.ObtenerTodos();
                dg_clientes.CargarGrid(clientes);
                DecorarGrid();                                    
            }
        }

        private void DecorarGrid()
        {
            dg_clientes.DecorarGrid();
            int[] ocultar = new int[] { 0,3,5,6};
            dg_clientes.OcultarValores(ocultar);
        }

        private void VerDetalleCliente(object sender, DataGridViewCellEventArgs e)
        {
            
            var IdCliente = dg_clientes.Rows[e.RowIndex].Cells[0].Value;
            clienteSeleccionado = clientes.Where(x => x.Id == Convert.ToInt32(IdCliente)).FirstOrDefault();
            AsignarValores(clienteSeleccionado);
            this.btn_guardar.Enabled = false;

        }

        private void AsignarValores(Entity.ClienteViewModel cliente)
        {
            this.tb_nombre.Text = cliente.Nombre;
            this.tb_ciudad.Text = cliente.Ciudad;
            this.tb_direccion.Text = cliente.Direccion;
            this.tb_email.Text = cliente.Email;
            this.tb_personaContacto.Text = cliente.Contacto;
            this.tb_ruc.Text = cliente.RUC;
            this.tb_telefono.Text = cliente.Telefono;
        }

        private void Filtrar(object sender, EventArgs e)
        {
            try
            {
                IList<Entity.ClienteViewModel> listaClientesFiltro;
                using (var service = new Service.ClienteService())
                {
                    if (this.tb_filtro.Text == "")
                    {
                        listaClientesFiltro = clientes;
                    }
                    else
                    {
                        listaClientesFiltro = service.FiltrarClientes(tb_filtro.Text);                     
                    }
                    dg_clientes.CargarGrid(listaClientesFiltro);
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
            clienteSeleccionado = null;            
            btn_guardar.Enabled = true;
            btn_cancelar.Visible = true;
            btn_cancelar.Enabled = true;
        }                   

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            using (var service =  new Service.ClienteService())
            {
                try
                {
                    Model.Cliente cliente = new Model.Cliente();
                    validaDatos = ValidarValores(validaDatos);
                    if (validaDatos.EsValido)
                    {
                        cliente = ObtenerValores();
                        var IdCliente = service.GuardarCliente(cliente);
                        MessageBox.Show("Cliente " + cliente.Nombre + " agregado exitosmente",
                               APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Controles.ActivarBotones(this.ToolStrip1.Items);
                        Controles.LimpiarControles(this.Controls);
                        clientes = service.ObtenerTodos();
                        dg_clientes.CargarGrid(clientes);
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

        private Util.ValidarDato ValidarValores(Util.ValidarDato validaDato)
        {
            validaDatos.MensajesDeError.RemoveRange(0, validaDatos.MensajesDeError.Count());

            if (string.IsNullOrEmpty(this.tb_nombre.Text))
            {
                validaDato.AgregarError("El campo 'Nombre' es requerido.");
            }

            if (validaDato.MensajesDeError.Count() == 0)
            {
                validaDato.EsValido = true;
            }

            return validaDato;
        }

        private Model.Cliente ObtenerValores()
        {
            return new Model.Cliente
            {
                Nombre = this.tb_nombre.Text,
                Direccion = this.tb_direccion.Text,
                Telefono = this.tb_telefono.Text,
                Ciudad = this.tb_ciudad.Text,
                Persona_contacto = this.tb_personaContacto.Text,
                Email = this.tb_email.Text,
                RUC = this.tb_ruc.Text
            };
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Controles.LimpiarControles(this.Controls);
            Controles.ActivarBotones(this.ToolStrip1.Items);
            btn_cancelar.Visible = false;
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            using (var service = new Service.ClienteService())
            {
                try
                {
                    Model.Cliente cliente = new Model.Cliente();
                    validaDatos = ValidarValores(validaDatos);
                    if (validaDatos.EsValido)
                    {
                        cliente = ObtenerValores();
                        cliente.Id_Cliente = clienteSeleccionado.Id;
                        service.ModificarCliente(cliente);
                        MessageBox.Show("Datos del cliente " + this.tb_nombre.Text + " modificados exitosamente",
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

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            using (var service = new Service.ClienteService())
            {
                try
                {
                    Controles.LimpiarControles(this.Controls);
                    clientes = service.ObtenerTodos();
                    dg_clientes.CargarGrid(clientes);
                    this.btn_cancelar.Visible = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrió un error, Por favor intente nuevamente", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}
