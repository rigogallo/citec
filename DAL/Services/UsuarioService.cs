using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity = Citec.Entity;

namespace DAL.Services
{
    public class UsuarioService : IDisposable
    {
        CitecContext context = new CitecContext();

        public IList<Entity.UsuariosViewModel> ObtenerTodos()
        {
            try
            {
                var listaUsuarios = context.Usuarios.
                    Select(x => new Entity.UsuariosViewModel
                    {
                        ID = x.Id_Usuario,
                        Nombre = x.Nombre,
                        Apellido = x.Apellido,
                        Nick = x.Nick,
                        Pass = x.Pass,
                        Cargo = x.Cargo,
                        Permiso = x.Permiso
                    })
                    .ToList();
                return listaUsuarios;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int GuardarUsuario(Models.Usuario usuario)
        {
            context.Entry(usuario).State = EntityState.Added;
            context.SaveChanges();
            return context.Entry(usuario).Entity.Id_Usuario;
        }

        public void ModificarUsuario(Models.Usuario usuario)
        {
            context.Entry(usuario).State = EntityState.Modified;
            context.SaveChanges();
        }

        public Models.Usuario FiltrarPorID(int ID)
        {
            var usuario = context.Usuarios.Find(ID);
            return usuario;
        }

        public bool ComprobarUsuario(string Nick, string Pass) 
        {
            try
            {
                var usuario = context.Usuarios.Where(x => x.Nick.Equals(Nick) && x.Pass.Equals(Pass)).FirstOrDefault();
                if (usuario != null)
                {
                    return true;
                }                
            }
            catch (Exception ex)
            {
                
                throw;
            }
            return false;
        }

        public void Dispose()
        {
            this.context = null;
        }
    }
}
