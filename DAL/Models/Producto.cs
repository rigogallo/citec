using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    [Table("Producto")]
    public class Producto
    {
        [Key()]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Producto { get; set; }
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

        public virtual ICollection<FacturaDetalle> FacturaDetalle { get; set; }
        public virtual ICollection<Regalias> Regalia { get; set; }

    }
}
