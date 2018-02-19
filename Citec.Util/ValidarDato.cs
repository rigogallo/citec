using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citec.Util
{
    public class ValidarDato
    {
        #region Properties
        public bool EsValido { get; set; }
        public List<String> MensajesDeError { get; set; }
        
        #endregion

        #region Constructors
        public ValidarDato()
        {
            EsValido = true;
            MensajesDeError = new List<String>();
        }
        #endregion

        #region Methods
        public void AgregarError(String mensajeError)
        {
            EsValido = false;
            MensajesDeError.Add(mensajeError);
        }
        #endregion
    }
}
