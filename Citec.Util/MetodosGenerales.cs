using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing;

namespace Citec.Util
{
    public class MetodosGenerales
    {
        public void LimpiarControles(Control.ControlCollection controlCollection)
        {
            foreach (Control tbControl in controlCollection)
            {
                if (tbControl is TextBox)
                {
                    tbControl.Text = "";
                }
            }
        }

        public void DeshabilitarBotones(ToolStripItemCollection toolStripItemCollection)
        {
            foreach (ToolStripItem boton in toolStripItemCollection)
            {
                boton.Enabled = false;
            }
        }

        public void ActivarBotones(ToolStripItemCollection toolStripItemCollection)
        {
            foreach (ToolStripItem boton in toolStripItemCollection)
            {
                boton.Enabled = true;
            }
        }

       
    }
}
