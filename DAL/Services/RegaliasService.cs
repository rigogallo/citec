using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
    public class RegaliasService : IDisposable
    {
        CitecContext context = new CitecContext();

        public void IngresarRegalia(Models.Producto producto, Models.Regalias regalia)
        {
            context.Entry(producto).State = EntityState.Modified;
            context.Entry(regalia).State = EntityState.Added;            
            context.SaveChanges();            
        }

        public void Dispose()
        {
            context = null;
        }
    }
}
