using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoMigracionMenu.Clases;

namespace ProyectoMigracionMenu
{
    public partial class Menu : Form
    {

        private Form activeForm;
        private Button botonResaltadoActual; 
        public Menu()
        {
            InitializeComponent();
            CargarDatosUsuario();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
            DoubleBufferedPanel(panelContenedor);
            OpenChildForm(new FormDashboard(), null);
            ResaltarBoton(BtnDashboard); 


        }
        private void DoubleBufferedPanel(Control control)
        {
            typeof(Panel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic,
                null, control, new object[] { true });
        }
        private void ResaltarBoton(object btnSender)
        {
            foreach (Control control in MenuVertical.Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    Button btn = (Button)control;
                    btn.BackColor = Color.FromArgb(169, 209, 212);

                }
            }

            if (btnSender != null)
            {
                Button currentButton = (Button)btnSender;
                currentButton.BackColor = Color.FromArgb(52, 161, 166);

            }
        }
        private void CargarDatosUsuario()
        {
            if (Login.UsuarioActual != null)
            {
                lblUsuario.Text = Login.UsuarioActual.Nombre;
                lblDelegacion.Text = Login.UsuarioActual.Delegacion;
                lblRol.Text = Login.UsuarioActual.Rol;
            }
        }
        public void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            this.panelContenedor.Controls.Add(childForm);
            this.panelContenedor.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();

            lblTitulo.Text = childForm.Text;


            ResaltarBoton(btnSender);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BtnRestaurar.Visible = false;
            BtnMaximizar.Visible = true;
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnMaximizar.Visible = false;
            BtnRestaurar.Visible = true;
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraMain_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            if (Login.UsuarioActual.Rol == "Delegado")
            {
            
                FormReportes reportesForm = new FormReportes();
                OpenChildForm(reportesForm, sender);  
            }
            else
            {

                MessageBox.Show("No tienes permisos para acceder a este módulo.");
            }

        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDashboard(), sender);
        }

        private void BtnInspeccionPrimaria_Click(object sender, EventArgs e)
        {
            FormInspPrimariaINICIO formInspPrimariaInicio = new FormInspPrimariaINICIO();
            formInspPrimariaInicio.Owner = this;
            OpenChildForm(formInspPrimariaInicio, sender);
        }

        private void BtnInspeccionSecundaria_Click(object sender, EventArgs e)
        {
            FormInspSecundariaINICIO formInspSecundariaInicio = new FormInspSecundariaINICIO();
            formInspSecundariaInicio.Owner = this;
            OpenChildForm(formInspSecundariaInicio, sender);
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            Login loginForm = new Login(); 
            loginForm.Show(); 
        }
    }
}
