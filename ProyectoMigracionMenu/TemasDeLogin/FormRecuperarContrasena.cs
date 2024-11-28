using ProyectoMigracionMenu.Clases;
using ProyectoMigracionMenu.TemasDeLogin;
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

namespace ProyectoMigracionMenu
{
    public partial class FormRecuperarContrasena : Form
    {
        public FormRecuperarContrasena()
        {
            InitializeComponent();
        }
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón "Enviar" para iniciar el proceso de recuperación de contraseña.
        /// Valida el nombre de usuario, genera un token de recuperación y lo envía al correo del usuario.
        /// </summary>
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            // Obtiene el nombre de usuario desde el campo de texto, eliminando espacios al inicio y al final.
            string nombreUsuario = txtUsuario.Text.Trim();

            // Valida que el nombre de usuario no esté vacío.
            if (string.IsNullOrWhiteSpace(nombreUsuario))
            {
                MessageBox.Show("El nombre de usuario no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crea una instancia de la clase RecuperacionContrasena para obtener el ID y el correo del usuario.
            RecuperacionContrasena recuperacion = new RecuperacionContrasena();

            // Obtiene el ID del usuario basado en el nombre de usuario ingresado.
            int idUsuario = recuperacion.ObtenerIdUsuarioPorNombre(nombreUsuario);

            // Si el ID de usuario es válido (mayor a 0), continúa con el proceso de recuperación.
            if (idUsuario > 0)
            {
                // Obtiene el correo del usuario utilizando el ID.
                string correo = recuperacion.ObtenerCorreoDelUsuario(idUsuario);

                // Crea una instancia de la clase TokenGenerador para generar el token de recuperación.
                TokenGenerador tokenGenerador = new TokenGenerador();
                string token = tokenGenerador.GenerarToken(idUsuario);

                // Crea una instancia de la clase ServicioDeCorreo para enviar el token al correo del usuario.
                ServicioDeCorreo servicioDeCorreo = new ServicioDeCorreo();
                string asunto = "Recuperación de Contraseña";
                string mensaje = $"Aquí está su token de recuperación: {token}";
                servicioDeCorreo.EnviarCorreo(correo, asunto, mensaje);

                // Muestra un mensaje informando al usuario que el token ha sido enviado a su correo.
                MessageBox.Show("El token ha sido enviado a su correo electrónico.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abre el formulario para verificar el token y cierra el formulario actual.
                FormVerificarToken formVerificarToken = new FormVerificarToken(idUsuario);
                formVerificarToken.Show();
                this.Close();
            }
            else
            {
                // Si el nombre de usuario no existe, muestra un mensaje de error.
                MessageBox.Show("El usuario no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

