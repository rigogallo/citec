using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    [Table("Factura")]
    public class Factura
    {
        public Factura()
        {
            this.FacturaDetalle = new Collection<FacturaDetalle>();
        }

        [Key()]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Factura { get; set; }
        public int Id_Usuario { get; set; }
        public int Id_Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public double Monto { get; set; }
        public bool Credito { get; set; }
        public string nRUC { get; set; }
        public string Nombre_Cliente { get; set; }
        public DateTime Fecha_Venc { get; set; }
        public double IVA { get; set; }
        public int Num_Factura { get; set; }
        public int anulada { get; set; }
        public double Tcambio { get; set; }

        public virtual Collection<FacturaDetalle> FacturaDetalle { get; set; }

        [ForeignKey("Id_Cliente")]
        public Cliente Cliente { get; set; }

        [ForeignKey("Id_Usuario")]
        public Usuario Usuario { get; set; } 
    }
}
