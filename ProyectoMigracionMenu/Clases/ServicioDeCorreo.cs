using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MimeKit;
using MailKit.Net.Smtp;
using MailKit.Security;
using System.Net.Mail;
using System.Net;

namespace ProyectoMigracionMenu.Clases
{

    /// <summary>
    /// Envío de correos electrónicos a través de un servidor SMTP.
    /// Esta clase configura y envía correos electrónicos utilizando Gmail como servidor de correo.
    /// </summary>
    public class ServicioDeCorreo
    {
        // Variables privadas que contienen las credenciales para el correo remitente.
        private readonly string _correoRemitente = "htambien088@gmail.com";
        private readonly string _contrasena = "rwsy stqx ljcp yoan"; // Contraseña de aplicacion del correo del remitente

        /// <summary>
        /// Envia un correo electrónico con los parámetros proporcionados.
        /// </summary>
        /// <param name="destinatario">El correo electrónico del destinatario.</param>
        /// <param name="asunto">El asunto del correo.</param>
        /// <param name="mensaje">El cuerpo del correo.</param>
        public void EnviarCorreo(string destinatario, string asunto, string mensaje)
        {
            try
            {
                // Se crea un objeto MailMessage para configurar el mensaje de correo.
                MailMessage mailMessage = new MailMessage(_correoRemitente, destinatario);
                mailMessage.Subject = asunto;
                mailMessage.Body = mensaje;
                mailMessage.IsBodyHtml = true;

                // Se crea un cliente SMTP para enviar el correo a través de Gmail
                // Usamos el puerto 587
                using (System.Net.Mail.SmtpClient smtpClient = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587))
                {
                    smtpClient.UseDefaultCredentials = false;
                    // Se establece el correo y la contraseña para autenticar el remitente
                    smtpClient.Credentials = new NetworkCredential(_correoRemitente, _contrasena);
                    smtpClient.EnableSsl = true;
                    smtpClient.Send(mailMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar el correo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}