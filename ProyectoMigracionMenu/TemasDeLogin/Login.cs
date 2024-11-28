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
using ProyectoMigracionMenu.Clases;
using System.Data.SqlClient;


namespace ProyectoMigracionMenu
{
    /// <summary>
    /// Clase que representa la ventana de inicio de sesión (Login) de la aplicación.
    /// Contiene funcionalidades para la autenticación de usuarios y la manipulación de eventos de la ventana.
    /// </summary>
    public partial class Login : Form
    {
        // Establece la conexión con la base de datos.
        SqlServerConnection conexion = new SqlServerConnection();

        // Propiedad para mantener la información del usuario actual logeado
        public static ClaseDeLogin UsuarioActual { get; private set; }

        /// <summary>
        /// Constructor que inicializa los componentes de la ventana de inicio de sesión.
        /// </summary>
        public Login()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Función externa importada desde la biblioteca user32.DLL que permite liberar el control de la ventana.
        /// </summary>
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        /// <summary>
        /// Función externa importada desde la biblioteca user32.DLL que envía un mensaje a la ventana para moverla.
        /// </summary>
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        /// <summary>
        /// Evento que ocurre cuando el usuario entra en el campo de texto del nombre de usuario.
        /// Elimina el texto por defecto "Usuario" y cambia el color del texto.
        /// </summary>
        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "Usuario")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.Black;
            }
        }

        /// <summary>
        /// Evento que ocurre cuando se hace clic en el botón de cerrar. Cierra la aplicación.
        /// </summary>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Evento que ocurre cuando se hace clic en el botón de minimizar. Minimiza la ventana.
        /// </summary>
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Evento que ocurre cuando el usuario deja el campo de texto del nombre de usuario.
        /// Restaura el texto por defecto "Usuario" si el campo está vacío.
        /// </summary>
        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "Usuario";
                txtuser.ForeColor = Color.Silver;
            }
        }

        /// <summary>
        /// Evento que ocurre cuando el usuario entra en el campo de texto de la contraseña.
        /// Elimina el texto por defecto "Contraseña", cambia el color del texto y oculta la contraseña.
        /// </summary>
        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Contraseña")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.Black;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        /// <summary>
        /// Evento que ocurre cuando el usuario deja el campo de texto de la contraseña.
        /// Restaura el texto por defecto "Contraseña" si el campo está vacío y muestra el texto.
        /// </summary>
        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Contraseña";
                txtpass.ForeColor = Color.Silver;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        /// <summary>
        /// Evento que permite arrastrar la ventana haciendo clic en cualquier parte del formulario.
        /// </summary>
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /// <summary>
        /// Evento que permite arrastrar la ventana haciendo clic en el panel de la ventana.
        /// </summary>
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /// <summary>
        /// Evento que ocurre cuando el usuario hace clic en el botón de inicio de sesión.
        /// Intenta autenticar al usuario con los datos proporcionados y, si es exitoso, muestra el menú principal.
        /// </summary>
        private void btnlogin_Click(object sender, EventArgs e)
        {
            UsuarioActual = new ClaseDeLogin();  // Crea una nueva instancia de la clase de login

            // Intenta iniciar sesión con el nombre de usuario y la contraseña proporcionados
            if (UsuarioActual.IniciarSesion(txtuser.Text, txtpass.Text))
            {
                this.Hide();  // Oculta la ventana de login
                Menu menuForm = new Menu();  // Crea una nueva instancia del formulario de menú
                menuForm.Show();  // Muestra el formulario de menú
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");  // Muestra un mensaje de error si los datos son incorrectos
            }
        }

        /// <summary>
        /// Evento que ocurre cuando se hace clic en el enlace para recuperar la contraseña.
        /// Oculta el formulario de login y muestra el formulario para recuperar la contraseña.
        /// </summary>
        private void LinkContra_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();  // Oculta la ventana de login

            // Crea una nueva instancia del formulario de recuperación de contraseña
            FormRecuperarContrasena formRecuperarContrasena = new FormRecuperarContrasena();
            formRecuperarContrasena.ShowDialog();  // Muestra el formulario de recuperación de contraseña
        }
    }
}
 