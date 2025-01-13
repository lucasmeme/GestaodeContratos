using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;

namespace GestaoContratos.Data.MailService
{
    public abstract class emailService
    {
        private SmtpClient smtp;
        protected string senderMail { get; set; }
        protected string password { get; set; }
        protected string host { get; set; }
        protected int port { get; set; }
        protected bool ssl { get; set; }

        protected void initializeSmtpClient()
        {
            smtp = new SmtpClient();
            smtp.Credentials = new NetworkCredential(senderMail, password);
            smtp.Host = host;
            smtp.Port = port;
            smtp.EnableSsl = ssl;
        }
        public void sendMail(string subject, string body, List<string> recipientmail)
        {
            using (var smtp = new SmtpClient(host, port)) // Configura o SMTP
            {
                try
                {
                    // Configurações do servidor SMTP
                    smtp.Credentials = new NetworkCredential(senderMail, password);
                    smtp.EnableSsl = true;

                    // Configura a mensagem de e-mail
                    using (var mailMessage = new MailMessage())
                    {
                        mailMessage.From = new MailAddress(senderMail);

                        foreach (string email in recipientmail)
                        {
                            mailMessage.To.Add(email);
                        }

                        mailMessage.Subject = subject;
                        mailMessage.Body = body;
                        mailMessage.IsBodyHtml = true; // Define se o corpo da mensagem suporta HTML
                        mailMessage.Priority = MailPriority.Normal;

                        // Envia o e-mail
                        smtp.Send(mailMessage);
                        //Console.WriteLine("E-mail enviado com sucesso!");
                        mailMessage.Dispose();
                        smtp.Dispose();
                    }
                }
                catch (SmtpException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    
                }
            }
        }
    }
}
