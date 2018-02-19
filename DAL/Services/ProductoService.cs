using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity = Citec.Entity;

namespace DAL.Services
{
    public class ProductoService : IDisposable
    {
        CitecContext context = new CitecContext();

        public IList<Entity.ProductoViewModel> ObtenerTodos()
        {
            try
            {
                var listaProductos = context.Productos.
                    Select(x => new Entity.ProductoViewModel
                    {
                        ID = x.Id_Producto,
                        Marca = x.Marca,
                        Modelo = x.Modelo,
                        CostoImpo = x.CostoImpo,
                        Stock = x.Stock,
                        Minimo = x.Minimo,
                        Descripcion = x.Descripcion,
                        Linea = x.Linea,
                        Precio1 = x.Precio1,
                        Precio2 = x.Precio2,
                        Precio3 = x.Precio3,
                        Precio4 = x.Precio4,
                        Comision1 = x.Comision1,
                        Comision2 = x.Comision2,
                        Comision3 = x.Comision3,
                        Comision4 = x.Comision4
                    })
                    .ToList();
                return listaProductos;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int GuardarProducto(Models.Producto producto)
        {
            context.Entry(producto).State = EntityState.Added;
            context.SaveChanges();
            return context.Entry(producto).Entity.Id_Producto;
        }

        public void ModificarProducto(Models.Producto producto)
        {
            context.Entry(producto).State = EntityState.Modified;
            context.SaveChanges();
        }

        public Models.Producto FiltrarPorID(int ID)
        {
            var producto = context.Productos.Find(ID);
            return producto;
        }

        public IList<Entity.ProductoViewModel> FiltrarProductos(string filtro)
        {
            var listaClientes = context.Productos.Where(x => x.Modelo.Contains(filtro))
                .Select(x => new Entity.ProductoViewModel
                {
                    ID = x.Id_Producto,
                    Marca = x.Marca,
                    Modelo = x.Modelo,
                    CostoImpo = x.CostoImpo,
                    Stock = x.Stock,
                    Minimo = x.Minimo,
                    Descripcion = x.Descripcion,
                    Linea = x.Linea,
                    Precio1 = x.Precio1,
                    Precio2 = x.Precio2,
                    Precio3 = x.Precio3,
                    Precio4 = x.Precio4,
                    Comision1 = x.Comision1,
                    Comision2 = x.Comision2,
                    Comision3 = x.Comision3,
                    Comision4 = x.Comision4
                }).ToList();
            return listaClientes;
        }

        public void Dispose()
        {
            this.context = null;
        }
    }
}
