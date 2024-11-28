using ProyectoMigracionMenu.Clases;
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

namespace ProyectoMigracionMenu.TemasDeLogin
{
    public partial class FormVerificarToken : Form
    {
        /// <summary>
        /// Variable para almacenar el ID del usuario.
        /// </summary>
        private int idUsuario;

        /// <summary>
        /// Instancia de la clase TokenGenerador para generar y verificar tokens.
        /// </summary>
        private TokenGenerador tokenGenerador = new TokenGenerador();

        /// <summary>
        /// Instancia de la clase RecuperacionContrasena para realizar acciones relacionadas con la recuperación de contraseñas.
        /// </summary>
        private RecuperacionContrasena recuperacionContrasena = new RecuperacionContrasena();

        /// <summary>
        /// Constructor del formulario, inicializa el formulario y asigna el ID del usuario.
        /// </summary>
        /// <param name="usuarioId">ID del usuario que está realizando la recuperación de contraseña.</param>
        public FormVerificarToken(int usuarioId)
        {
            InitializeComponent();
            idUsuario = usuarioId;
        }

        // Métodos para manejar la captura y el envío de mensajes al sistema
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        /// <summary>
        /// Evento que se ejecuta cuando se hace clic en el botón "Actualizar Contraseña".
        /// Verifica el token, las contraseñas ingresadas y actualiza la contraseña si todo es válido.
        /// </summary>
        private void btnActualizarContrasena_Click(object sender, EventArgs e)
        {
            // Obtiene los valores ingresados en los campos de texto.
            string token = txtToken.Text.Trim();
            string nuevaContrasena = txtNuevaContrasena.Text.Trim();
            string confirmarContrasena = txtConfirmarContrasena.Text.Trim();

            // Valida que el token no esté vacío ni contenga espacios consecutivos.
            if (string.IsNullOrWhiteSpace(token) || System.Text.RegularExpressions.Regex.IsMatch(token, @"\s{2,}"))
            {
                MessageBox.Show("El token no puede contener dos o más espacios consecutivos ni estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Valida que la nueva contraseña no esté vacía ni contenga espacios consecutivos.
            if (string.IsNullOrWhiteSpace(nuevaContrasena) || System.Text.RegularExpressions.Regex.IsMatch(nuevaContrasena, @"\s{2,}"))
            {
                MessageBox.Show("La nueva contraseña no puede contener dos o más espacios consecutivos ni estar vacía.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verifica que las contraseñas coincidan.
            if (nuevaContrasena != confirmarContrasena)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            // Verifica si el token es válido utilizando el método de la clase TokenGenerador.
            if (tokenGenerador.VerificarToken(idUsuario, token))
            {
                // Si el token es válido, intenta actualizar la contraseña.
                bool actualizado = recuperacionContrasena.ActualizarContrasena(idUsuario, nuevaContrasena);

                // Si la contraseña fue actualizada correctamente, muestra un mensaje y cierra el formulario.
                if (actualizado)
                {
                    MessageBox.Show("Contraseña actualizada. Inicie sesión con su nueva contraseña.");

                    // Intenta encontrar el formulario de login y abrirlo.
                    Form loginForm = Application.OpenForms["Login"];

                    if (loginForm != null)
                    {
                        loginForm.Show();
                    }

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar la contraseña.");
                }
            }
            else
            {
                // Si el token no es válido o ha expirado, muestra un mensaje de error.
                MessageBox.Show("Token incorrecto o expirado.");
            }
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
