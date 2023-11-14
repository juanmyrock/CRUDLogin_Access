﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SERVICIOS
{
    public static class SoloNumeros
    {
        ////Metodo para ingresar solo numeros en un textbox
        ////Se lo llama desde el evento KeyPress del objeto
        public static bool ValidarNro(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) | Char.IsControl(e.KeyChar) | char.ToString(e.KeyChar) == ",")
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            return e.Handled;
        }
    }
}
