using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SERVICIOS
{
    public static class Limpiar
    {
        // Metodo para "limpiar" los controles de un formulario
        // recibe como parametro el nombre del form
        // El Metodo esta aplicando "RECURSIVIDAD" (cuando un metodo se llama a si mismo)
        // La recursividad es muy utilizada en programacion a los efectos de escribir
        // menos codigo y mas optimo (en muchos casos es fundamental darle al metodo
        // recursivo una condicion de salida para que no quede dentro de un loop)
        public static void LimpiarControles(Control control)
        {
            foreach (Control item in control.Controls)
            {
                if (item is GroupBox | item is Panel) LimpiarControles(item);
                if (item is TextBox txt) txt.Text = null;
                if (item is ComboBox cmb) cmb.Text = null;
            }
        }
    }
}
