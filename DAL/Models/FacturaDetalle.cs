using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    [Table("Factura_Detalle")]
    public class FacturaDetalle
    {
        [Key()]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_FacturaDetalle { get; set; }
        public int Id_Factura { get; set; }
        public int Id_Producto { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public int? Porcentaje { get; set; }

        [ForeignKey("Id_Factura")]
        public Factura Factura { get; set; }

        [ForeignKey("Id_Producto")]
        public Producto Producto { get; set; }
    }
}
