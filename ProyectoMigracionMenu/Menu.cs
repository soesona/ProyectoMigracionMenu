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

        // Variables para almacenar el formulario activo y el botón principal actualmente seleccionado
        private Form activeForm;
        private Button currentMainButton;
        public Menu()
        {
            InitializeComponent();
            CargarDatosUsuario();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
            DoubleBufferedPanel(panelContenedor); // Habilita el doble búfer en el panel para mejorar el rendimiento visual
            OpenChildForm(new FormDashboard(), BtnDashboard); // Abre el formulario principal en el área de contenido
            currentMainButton = BtnDashboard;// Establece el botón principal actual como el de Dashboard



        }

        // Método para habilitar el doble búfer en el control para evitar parpadeos al actualizar la interfaz
        private void DoubleBufferedPanel(Control control)
        {
            typeof(Panel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic,
                null, control, new object[] { true });
        }

        // Resalta el botón que ha sido presionado y restablece el color de los demás botones
        private void ResaltarBoton(object btnSender)
        {
            if (btnSender == null) return;

            foreach (Control control in MenuVertical.Controls)
            {
                if (control is Button btn)
                {
                    btn.BackColor = Color.FromArgb(169, 209, 212);
                }
            }

            if (btnSender is Button currentButton)
            {
                currentButton.BackColor = Color.FromArgb(52, 161, 166);
            }
        }

        // Carga los datos del usuario actual desde el objeto Login
        private void CargarDatosUsuario()
        {
            if (Login.UsuarioActual != null)
            {
                lblUsuario.Text = Login.UsuarioActual.Nombre;
                lblDelegacion.Text = Login.UsuarioActual.Delegacion;
                lblRol.Text = Login.UsuarioActual.Rol;
            }
        }

        //  Abrir un formulario hijo dentro del formulario principal
        public void OpenChildForm(Form childForm, object btnSender, bool isMainMenuButton = true)
        {
            // Cierra el formulario hijo actual si existe
            if (activeForm != null)
            {
                activeForm.Close();
            }

            // Establece el nuevo formulario hijo y configura sus propiedades
            activeForm = childForm;
            childForm.TopLevel = false; // Hace que el formulario hijo no tenga una barra de título
            childForm.FormBorderStyle = FormBorderStyle.None; // Elimina el borde del formulario
            childForm.Dock = DockStyle.Fill; // Ajusta el formulario hijo para llenar el panel contenedor

            // Añade el formulario hijo al contenedor y lo trae al frente
            panelContenedor.Controls.Add(childForm);
            panelContenedor.Tag = childForm;

            // Muestra el formulario hijo
            childForm.BringToFront();
            childForm.Show();

            // Actualiza el título del formulario con el nombre del formulario hijo
            lblTitulo.Text = childForm.Text;

            // Resalta el botón asociado con el formulario abierto
            if (btnSender != null)
            {
                if (isMainMenuButton)
                {
                    currentMainButton = btnSender as Button;
                    ResaltarBoton(currentMainButton); // Resalta el botón de menú principal
                }
                else
                {
                    ResaltarBoton(currentMainButton); // Resalta el último botón presionado
                }
            }
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

        // Funciones necesarias para mover la ventana arrastrando la barra de título

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraMain_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Evento para abrir el formulario de reportes si el usuario tiene permisos
        private void BtnReportes_Click(object sender, EventArgs e)
        {
            if (Login.UsuarioActual.Rol == "Delegado") // Verifica si el usuario tiene rol de delegado
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
            formInspPrimariaInicio.Owner = this; // Establece este formulario como propietario del formulario hijo
            OpenChildForm(formInspPrimariaInicio, sender, true);
        }

        private void BtnInspeccionSecundaria_Click(object sender, EventArgs e)
        {
            FormInspSecundariaINICIO formInspSecundariaInicio = new FormInspSecundariaINICIO();
            formInspSecundariaInicio.Owner = this;
            OpenChildForm(formInspSecundariaInicio, sender, true); 
        }

      
        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            Login loginForm = new Login(); 
            loginForm.Show(); 
        }
    }
}
