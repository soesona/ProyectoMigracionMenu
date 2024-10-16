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
    public class ServicioDeCorreo
    {

        private readonly string _correoRemitente = "htambien088@gmail.com"; 
        private readonly string _contrasena = "rwsy stqx ljcp yoan"; 

        public void EnviarCorreo(string destinatario, string asunto, string mensaje)
        {
            try
            {
                MailMessage mailMessage = new MailMessage(_correoRemitente, destinatario);
                mailMessage.Subject = asunto;
                mailMessage.Body = mensaje;
                mailMessage.IsBodyHtml = true; 

                using (System.Net.Mail.SmtpClient smtpClient = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587))
                {
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential(_correoRemitente, _contrasena);
                    smtpClient.EnableSsl = true;

                    smtpClient.Send(mailMessage);
                }

                Console.WriteLine("Correo enviado exitosamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al enviar el correo: " + ex.Message);
            }
        }
    }
}