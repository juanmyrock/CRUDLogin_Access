using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SERVICIOS
{
    public static class Bloquear
    {
        // Metodo para "bloquear" los controles de un formulario
        

        public static void BloquearControles(Control control)
        {
            foreach (Control item in control.Controls)
            {
                if (item is GroupBox | item is Panel) BloquearControles(item);
                if (item is TextBox txt) txt.Enabled = false;
                if (item is ComboBox cmb) cmb.Enabled = false;
            }
        }

        // Metodo para "desbloquear" los controles de un formulario
        // recibe como parametro el nombre del form
        public static void DesbloquearControles(Control control)
        {
            foreach (Control item in control.Controls)
            {
                if (item is GroupBox | item is Panel) DesbloquearControles(item);
                if (item is TextBox txt) txt.Enabled = true;
                if (item is ComboBox cmb) cmb.Enabled = true;
            }
        }
    }
}
