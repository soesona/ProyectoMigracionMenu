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


        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text.Trim(); 

           
            if (string.IsNullOrWhiteSpace(nombreUsuario))
            {
                MessageBox.Show("El nombre de usuario no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            RecuperacionContrasena recuperacion = new RecuperacionContrasena();


            int idUsuario = recuperacion.ObtenerIdUsuarioPorNombre(nombreUsuario);

            if (idUsuario > 0)
            {

                string correo = recuperacion.ObtenerCorreoDelUsuario(idUsuario);

                
                TokenGenerador tokenGenerador = new TokenGenerador();
                string token = tokenGenerador.GenerarToken(idUsuario);

                
                ServicioDeCorreo servicioDeCorreo = new ServicioDeCorreo();
                string asunto = "Recuperación de Contraseña";
                string mensaje = $"Aquí está su token de recuperación: {token}";
                servicioDeCorreo.EnviarCorreo(correo, asunto, mensaje);

                MessageBox.Show("El token ha sido enviado a su correo electrónico.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormVerificarToken formVerificarToken = new FormVerificarToken(idUsuario);
                formVerificarToken.Show();
                this.Close();
            }
            else
            {
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

