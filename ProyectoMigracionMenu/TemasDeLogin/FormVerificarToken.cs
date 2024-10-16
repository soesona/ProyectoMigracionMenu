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
            string token = txtToken.Text;
            string nuevaContrasena = txtNuevaContrasena.Text;
            string confirmarContrasena = txtConfirmarContrasena.Text;

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
            Application.Exit();
        }
    }
}
