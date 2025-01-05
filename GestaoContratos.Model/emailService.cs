using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;

namespace GestaoContratos.Model
{
    public static class emailService
    {
        public static void EnviarEmail(string emailDestino, string nomeUsuario, string senhaUsuario)
        {
            try
            {

                
                // Criação da mensagem de e-mail
                var email = new MimeMessage();
                email.From.Add(new MailboxAddress("Sistema de Gestão de Contratos", "lucas.meme070712@gmail.com")); // Seu e-mail e nome
                email.To.Add(MailboxAddress.Parse(emailDestino)); // E-mail de destino
                email.Subject = "Recuperar senha";

                // Corpo do e-mail
                email.Body = new TextPart("html")
                {
                    Text = "Olá, " + nomeUsuario + "," + "\nFoi requisitada a recuperação de senha para seu usuário.\n" +
                        "Sua senha atual é:" + senhaUsuario +
                        "\nNo entanto, solicitamos que altere sua senha imediatamente \napós entrar no sistema."
                };

                // Configuração e envio do e-mail
                using (var smtp = new SmtpClient())
                {
                    // Conexão com o servidor SMTP
                    smtp.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);

                    // Autenticação
                    smtp.Authenticate("lucas.meme070712@gmail.com", "dufs akol yucm uxhw"); // Substitua pelas suas credenciais

                    // Envio do e-mail
                    smtp.Send(email);

                    // Desconectar do servidor SMTP
                    smtp.Disconnect(true);
                }

                // Informar sucesso ao usuário
                Console.WriteLine("E-mail enviado com sucesso!");
            }
            catch (Exception ex)
            {
                // Tratar e exibir erros
                Console.WriteLine($"Erro ao enviar o e-mail: {ex.Message}");
            }
        }
    }
}
