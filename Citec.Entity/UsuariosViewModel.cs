using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citec.Entity
{
    public class UsuariosViewModel
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Nick { get; set; }
        public string Pass { get; set; }
        public string Cargo { get; set; }
        public string Permiso { get; set; }
    }
}
