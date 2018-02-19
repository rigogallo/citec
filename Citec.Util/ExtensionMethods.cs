using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citec.Util
{
    public static class ExtensionMethods
    {
        public static DataGridView DecorarGrid(this DataGridView grid)
        {
            DataGridViewCellStyle objAlignRightCellStyle = new DataGridViewCellStyle();
            objAlignRightCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DataGridViewCellStyle objAlternatingCellStyle = new DataGridViewCellStyle();
            objAlternatingCellStyle.BackColor = Color.LightBlue;
            grid.AlternatingRowsDefaultCellStyle = objAlternatingCellStyle;

            return grid;
        }

        public static DataGridView OcultarValores(this DataGridView grid, int[] campos) 
        {
            foreach (var campo in campos)
            {
                grid.Columns[campo].Visible = false;
            }        
            return grid;
        }

        public static DataGridView CargarGrid<T>(this DataGridView grid, IList<T> datos)
        {
            grid.DataSource = datos;
            return grid;
        }
    }
}
