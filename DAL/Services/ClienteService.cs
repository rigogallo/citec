using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity = Citec.Entity;

namespace DAL.Services
{
    public class ClienteService : IDisposable
    {
        CitecContext context = new CitecContext();

        public IList<Entity.ClienteViewModel> ObtenerTodos()
        {
            try
            {
                var listaClientes = context.Clientes.
                    Select(x => new Entity.ClienteViewModel
                    {
                        Id = x.Id_Cliente,
                        Nombre = x.Nombre,
                        Ciudad = x.Ciudad,
                        Direccion = x.Direccion,
                        Telefono = x.Telefono,
                        Email = x.Email,
                        RUC = x.RUC,
                        Contacto = x.Persona_contacto

                    })
                    .ToList();
                return listaClientes;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public IList<Entity.ClienteViewModel> FiltrarClientes(string filtro) 
        {
            var listaClientes = context.Clientes.Where(x => x.Nombre.Contains(filtro))
                .Select(x => new Entity.ClienteViewModel
                {
                    Id = x.Id_Cliente,
                    Nombre = x.Nombre,
                    Telefono = x.Telefono,
                    Direccion = x.Direccion,
                    Ciudad = x.Ciudad,
                    Contacto = x.Persona_contacto,
                    RUC = x.RUC

                }).ToList();
            return listaClientes;
        }

        public int GuardarCliente(Models.Cliente cliente)
        {
            context.Entry(cliente).State = EntityState.Added;
            context.SaveChanges();
            return context.Entry(cliente).Entity.Id_Cliente;
        }

        public void ModificarCliente(Models.Cliente cliente)
        {
            context.Entry(cliente).State = EntityState.Modified;
            context.SaveChanges();
        }

        public Models.Cliente FiltrarPorID(int ID)
        {
            var cliente = context.Clientes.Find(ID);
            return cliente;
        }

        public void Dispose()
        {
            this.context = null;
        }
    }
}
