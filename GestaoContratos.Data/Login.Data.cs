using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestaoContratos.Data;
using GestaoContratos.Model;
using System.Net.Mail;
using System.Net;
using MailKit;
using GestaoContratos.Model;

namespace GestaoContratos.Data
{
    public class Login
    {
        public static DB_CONTRATOSDataContext db = new DB_CONTRATOSDataContext();

        public static bool ValidaLogin(USUARIO pUser)
        {
            try
            {
                var login = (from a in db.USUARIOs
                             where a.LOGIN == pUser.LOGIN && a.SENHA == pUser.SENHA
                             select a
                             ).Count();


                return login > 0;
            }
            catch (Exception ex)
            {
                // Log de erro ou tratamento (opcional)
                MessageBox.Show($"Erro ao validar login: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Retorna falso como padrão em caso de erro
                return false;
            }
        }
        public static string localizarUsuario(string localizarUser)
        {
            try
            {
                var localizaUser = (from a in db.USUARIOs
                                    where a.EMAIL == localizarUser || a.LOGIN == localizarUser
                                    select new
                                    {
                                        a.NOME_USUARIO,
                                        a.EMAIL,
                                        a.LOGIN,
                                        a.SENHA,
                                        a.INATIVO
                                    }).FirstOrDefault();

                if(localizarUser != null)
                {
                    var mailService = new MailService.ConfiguracaoEmail();
                    mailService.sendMail(
                        subject: "RECUPERAÇÃO DE SENHA",
                        body: "Olá, " + localizaUser.NOME_USUARIO + "," + "\nFoi requisitada a recuperação de senha para seu usuário.\n" +
                        "Sua senha atual é:" + localizaUser.SENHA +
                        "\nNo entanto, solicitamos que altere sua senha imediatamente \napós entrar no sistema.",
                        recipientmail: new List<string> { localizaUser.EMAIL }
                        );
                    return "Enviado para " + localizaUser.EMAIL + " os dados \nde acesso para o sistema.";
                }
                else
                    return "Usuário e/ou e-mail não encontrado.";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }

        }
    }
}
