using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DAL
{
    public class CitecContext : DbContext
    {
        public DbSet<Models.Cliente> Clientes { get; set; }
        public DbSet<Models.Factura> Facturas { get; set; }
        public DbSet<Models.FacturaDetalle> FacturaDetalles { get; set; }
        public DbSet<Models.Producto> Productos { get; set; }
        public DbSet<Models.Usuario> Usuarios { get; set; }

        public CitecContext()
            : base("CitecConnection")
        {

        }
    }   
}
