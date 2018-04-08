using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity = Citec.Entity;

namespace DAL.Services
{
    public class FacturaService : IDisposable
    {
        CitecContext context = new CitecContext();

        public bool EsFacturaDuplicada(int numeroFactura)
        {
            try
            {
                var factura = context.Facturas.Where(x => x.Num_Factura.Equals(numeroFactura)).FirstOrDefault();
                if (factura != null)
                {
                    return true;
                }

                return false;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Models.Factura FiltrarPorID(int ID)
        {
            var factura = context.Facturas.Find(ID);
            return factura;
        }

        public Entity.FacturaViewModel FiltrarPorNumero(int numeroFactura)
        {
            var factura = context.Facturas.Where(x => x.Num_Factura.Equals(numeroFactura))
               .Select(x => new Entity.
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

        public bool CrearFactura(Models.Factura factura)
        {
            try
            {
                context.Entry(factura).State = EntityState.Added;
                foreach (var producto in factura.FacturaDetalle)
                {
                    var productoEncontrado = context.Productos.Find(producto.Id_Producto);
                    productoEncontrado.Stock = productoEncontrado.Stock - producto.Cantidad;
                    context.Productos.Attach(productoEncontrado);
                    var entry = context.Entry(productoEncontrado);
                    entry.Property(e => e.Stock).IsModified = true;
                }
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public List<Entity.FacturasPendientesViewModel> ObtenerFacturasPendientes()
        {
            try
            {
                var facturasPendientes = context.Facturas
                    .Join(context.Usuarios,
                        factura => factura.Id_Usuario,
                        usuario => usuario.Id_Usuario,
                        (factura, usuario) => new { factura, usuario })
                    .Where(x => x.factura.Credito == true)
                    .Select(x => new Entity.FacturasPendientesViewModel
                        {
                            IdFactura = x.factura.Id_Factura,
                            NombreCliente = x.factura.Nombre_Cliente,
                            NombreUsuario = x.usuario.Nombre + " " + x.usuario.Apellido,
                            Fecha = x.factura.Fecha,
                            Num_Factura = x.factura.Num_Factura,
                            Monto = x.factura.Monto,
                            IVA = x.factura.IVA,
                            Credito = x.factura.Credito,
                            FechaVencimiento = x.factura.Fecha_Venc
                        })
                        .OrderBy(x => x.Num_Factura)
                        .ToList();

                return facturasPendientes;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Entity.FacturasPendientesViewModel> ObtenerFacturasNoAnuladas()
        {
            try
            {
                var facturasPendientes = context.Facturas
                    .Join(context.Usuarios,
                        factura => factura.Id_Usuario,
                        usuario => usuario.Id_Usuario,
                        (factura, usuario) => new { factura, usuario })
                    .Where(x => x.factura.anulada == 0)
                    .Select(x => new Entity.FacturasPendientesViewModel
                    {
                        IdFactura = x.factura.Id_Factura,
                        NombreCliente = x.factura.Nombre_Cliente,
                        NombreUsuario = x.usuario.Nombre + " " + x.usuario.Apellido,
                        Fecha = x.factura.Fecha,
                        Num_Factura = x.factura.Num_Factura,
                        Monto = x.factura.Monto,
                        IVA = x.factura.IVA,
                        Credito = x.factura.Credito,
                        FechaVencimiento = x.factura.Fecha_Venc
                    })
                        .OrderBy(x => x.Num_Factura)
                        .ToList();

                return facturasPendientes;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool AnularFactura(int IdFactura)
        {
            try
            {
                var factura = context.Facturas.Find(IdFactura);
                factura.anulada = 1;
                context.Facturas.Attach(factura);
                var entry = context.Entry(factura);
                entry.Property(e => e.anulada).IsModified = true;
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
               
        }

        public void Dispose()
        {
            this.context = null;
        }


    }
}
