using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citec.Entity
{
    public class FacturasPendientesViewModel
    {
        public int IdFactura { get; set; }
        public string NombreUsuario { get; set; }
        public string NombreCliente { get; set; }
        public DateTime Fecha { get; set; }
        public double Monto { get; set; }
        public bool Credito { get; set; }                
        public DateTime FechaVencimiento { get; set; }
        public double IVA { get; set; }
        public int Num_Factura { get; set; }
        //public int anulada { get; set; }
        //public double Tcambio { get; set; }
    }
}
