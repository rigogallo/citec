using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citec.Entity
{
    public class ProductoViewModel
    {
        public int ID { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Stock { get; set; }
        public int? Minimo { get; set; }
        public double? CostoImpo { get; set; }
        public double? Precio1 { get; set; }
        public double? Precio2 { get; set; }
        public double? Precio3 { get; set; }
        public double? Precio4 { get; set; }
        public int? Comision1 { get; set; }
        public int? Comision2 { get; set; }
        public int? Comision3 { get; set; }
        public int? Comision4 { get; set; }
        public string Linea { get; set; }
        public string Descripcion { get; set; }
    }
}
