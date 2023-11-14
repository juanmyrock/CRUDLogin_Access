using LOGICA;
using SERVICIOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace VISTA
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        #region Config Formulario

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FormMenu_Load_1(object sender, EventArgs e)
        {
            logoISFT_Click(null, e);
            //AbrirForms(new FormLogin());
        }

        private void btnCerrar_Click(object sender, EventArgs e) //para cerrar la aplicación
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "¡Alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        
        private void btnMinimize_Click(object sender, EventArgs e) //para minimizar a modo ventana
        {
            this.WindowState = FormWindowState.Normal;
            btnMinimize.Visible = false;
            btnMaximize.Visible = true;
        }

        private void btnOcultar_Click(object sender, EventArgs e) //para ocultar/minimizar la aplicación
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e) //para maximizar la ventana a pantalla completa
        {
            this.WindowState = FormWindowState.Maximized;
            btnMinimize.Visible = true;
            btnMaximize.Visible = false;
        }

        private void panelBarraClose_Paint(object sender, PaintEventArgs e) //para poder mover la ventana libremente
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void AbrirForms(object formHijo) //método para abrir otros formularios dentro del panel contenedor principal
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0); //si hay algún panel abierto lo cierra
            }
            Form fh = formHijo as Form; //crea objeto como tipo form
            fh.TopLevel = false; //panel secundario no principal
            fh.Dock = DockStyle.Fill; //que se acople en el centro
            this.panelContenedor.Controls.Add(fh); //agrego el formulario hijo al panel
            this.panelContenedor.Tag = formHijo; //instancio el contenedor de datos
            fh.Show(); //muestro el formulario
        }
        #endregion

        #region Config Botones


        private void btnSlide_Click(object sender, EventArgs e) //para minimizar el panel de menú y acomodar los íconos
        {
            if (panelMenu.Width == 240)
            {
                panelMenu.Width = 72;
                pictureBox1.Location = new Point(25, 301);
                pictureBox2.Location = new Point(25, 363);
                pictureBox3.Location = new Point(25, 425);
                pictureBox4.Location = new Point(25, 486);
                pictureBox5.Location = new Point(25, 549);
            }
            else
            {
                panelMenu.Width = 240;
                pictureBox1.Location = new Point(25, 301);
                pictureBox2.Location = new Point(25, 363);
                pictureBox3.Location = new Point(25, 425);
                pictureBox4.Location = new Point(25, 486);
                pictureBox5.Location = new Point(25, 549);
            }
        }

        private void logoISFT_Click(object sender, EventArgs e)
        {
            //AbrirForms(new FormPagInicio());
        }
        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirForms(new FormProductos());
        }
        private void btnVentas_Click(object sender, EventArgs e)
        {
            //AbrirForms(new FormVentas());
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            //AbrirForms(new FormClientes());
        }
        private void btnFacturas_Click(object sender, EventArgs e)
        {
            //AbrirForms(new FormFacturas());
        }
        private void btnReportes_Click(object sender, EventArgs e)
        {
            //AbrirForms(new FormReportes());
        }

        private void picBoxLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cerrar sesión?", "¡Alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }



        #endregion


    }




}