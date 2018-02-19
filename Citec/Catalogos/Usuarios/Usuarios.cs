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

namespace Citec.Catalogos.Usuarios
{
    public partial class Usuarios : Form
    {
        string APP_NAME = ConfigurationManager.AppSettings["NombreAplicacion"];
        IList<Entity.UsuariosViewModel> usuarios;
        Entity.UsuariosViewModel usuarioSeleccionado;
        Util.ValidarDato validaDatos = new Util.ValidarDato();
        Util.MetodosGenerales Controles = new Util.MetodosGenerales();

        public Usuarios()
        {
            InitializeComponent();
            this.Text = "Usuarios" + APP_NAME;
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            using (var service = new Service.UsuarioService())
            {
                usuarios = service.ObtenerTodos();
                dg_usuarios.CargarGrid(usuarios);
                DecorarGrid();
                cb_permiso.Items.Add("ADMIN");
                cb_permiso.Items.Add("VENTA");
            }
        }

        private void DecorarGrid()
        {
            dg_usuarios.DecorarGrid();
            int[] ocultar = new int[] { 0 };
            dg_usuarios.OcultarValores(ocultar);
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Controles.LimpiarControles(this.Controls);
            Controles.DeshabilitarBotones(this.ToolStrip1.Items);
            usuarioSeleccionado = null;
            btn_guardar.Enabled = true;
            btn_cancelar.Visible = true;
            btn_cancelar.Enabled = true;
        }

        private void VerDetalle(object sender, DataGridViewCellEventArgs e)
        {
            var IdUsuario = dg_usuarios.Rows[e.RowIndex].Cells[0].Value;
            usuarioSeleccionado = usuarios.Where(x => x.ID == Convert.ToInt32(IdUsuario)).FirstOrDefault();
            AsignarValores(usuarioSeleccionado);
            this.btn_guardar.Enabled = false;
        }

        private void AsignarValores(Entity.UsuariosViewModel usuario)
        {
            this.tb_nombre.Text = usuario.Nombre;
            this.tb_apellido.Text = usuario.Apellido;
            this.tb_nick.Text = usuario.Nick;
            this.tb_pass.Text = usuario.Pass;
            this.tb_cargo.Text = usuario.Cargo;
            this.cb_permiso.Text = usuario.Permiso;
            
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            using (var service = new Service.UsuarioService())
            {
                try
                {
                    Model.Usuario usuario = new Model.Usuario();
                    validaDatos = ValidarValores(validaDatos);
                    if (validaDatos.EsValido)
                    {
                        usuario = ObtenerValores();
                        var IdUsuario = service.GuardarUsuario(usuario);
                        MessageBox.Show("Usuario " + usuario.Nombre + " agregado exitosmente",
                               APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Controles.ActivarBotones(this.ToolStrip1.Items);
                        Controles.LimpiarControles(this.Controls);
                        usuarios = service.ObtenerTodos();
                        dg_usuarios.CargarGrid(usuarios);
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

        private Model.Usuario ObtenerValores()
        {
            return new Model.Usuario
            {
                Nombre = this.tb_nombre.Text,
                Apellido = this.tb_apellido.Text,
                Nick = this.tb_nick.Text,
                Pass = this.tb_pass.Text,
                Cargo = this.tb_cargo.Text,
                Permiso = this.cb_permiso.Text
            };
        }

        private ValidarDato ValidarValores(ValidarDato validaDatos)
        {
            validaDatos.MensajesDeError.RemoveRange(0, validaDatos.MensajesDeError.Count());

            if (string.IsNullOrEmpty(this.tb_nombre.Text))
            {
                validaDatos.AgregarError("El campo 'Nombre' es requerido.");
            }
            if (string.IsNullOrEmpty(this.tb_apellido.Text))
            {
                validaDatos.AgregarError("El campo 'Apellido' es requerido.");
            }
            if (string.IsNullOrEmpty(this.tb_nick.Text))
            {
                validaDatos.AgregarError("El campo 'Nick' es requerido.");
            }
            if (string.IsNullOrEmpty(this.tb_pass.Text))
            {
                validaDatos.AgregarError("El campo 'Pass' es requerido.");
            }

            if (validaDatos.MensajesDeError.Count() == 0)
            {
                validaDatos.EsValido = true;
            }

            return validaDatos;
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            using (var service = new Service.UsuarioService())
            {
                try
                {
                    Model.Usuario usuario = new Model.Usuario();
                    validaDatos = ValidarValores(validaDatos);
                    if (validaDatos.EsValido)
                    {
                        usuario = ObtenerValores();
                        usuario.Id_Usuario = usuarioSeleccionado.ID;
                        service.ModificarUsuario(usuario);
                        MessageBox.Show("Datos del usuario " + this.tb_nombre.Text + " modificados exitosamente",
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

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            using (var service = new Service.UsuarioService())
            {
                try
                {
                    Controles.LimpiarControles(this.Controls);
                    usuarios = service.ObtenerTodos();
                    dg_usuarios.CargarGrid(usuarios);
                    this.btn_cancelar.Visible = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrió un error, Por favor intente nuevamente", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Controles.LimpiarControles(this.Controls);
            Controles.ActivarBotones(this.ToolStrip1.Items);
            btn_cancelar.Visible = false;
        }
    }
}
