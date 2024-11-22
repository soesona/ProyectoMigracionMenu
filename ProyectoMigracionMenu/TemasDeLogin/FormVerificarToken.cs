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
        private int idUsuario;
        private TokenGenerador tokenGenerador = new TokenGenerador();
        private RecuperacionContrasena recuperacionContrasena = new RecuperacionContrasena();

        public FormVerificarToken(int usuarioId)
        {
            InitializeComponent();
            idUsuario = usuarioId;
        }
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnActualizarContrasena_Click(object sender, EventArgs e)
        {
            string token = txtToken.Text.Trim(); 
            string nuevaContrasena = txtNuevaContrasena.Text.Trim();
            string confirmarContrasena = txtConfirmarContrasena.Text.Trim();


            if (string.IsNullOrWhiteSpace(token) || System.Text.RegularExpressions.Regex.IsMatch(token, @"\s{2,}"))
            {
                MessageBox.Show("El token no puede contener dos o más espacios consecutivos ni estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(nuevaContrasena) || System.Text.RegularExpressions.Regex.IsMatch(nuevaContrasena, @"\s{2,}"))
            {
                MessageBox.Show("La nueva contraseña no puede contener dos o más espacios consecutivos ni estar vacía.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nuevaContrasena != confirmarContrasena)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }
            if (tokenGenerador.VerificarToken(idUsuario, token))
            {
                bool actualizado = recuperacionContrasena.ActualizarContrasena(idUsuario, nuevaContrasena);
                if (actualizado)
                {
                    MessageBox.Show("Contraseña actualizada. Inicie sesión con su nueva contraseña.");

                    
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
