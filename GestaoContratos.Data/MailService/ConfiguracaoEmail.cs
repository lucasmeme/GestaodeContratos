using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace GestaoContratos.Data.MailService
{
    class ConfiguracaoEmail:emailService
    {
        public ConfiguracaoEmail()

        {
            senderMail = ConfigurationManager.AppSettings["EMAIL"];
            password = ConfigurationManager.AppSettings["SENHA"];
            host = ConfigurationManager.AppSettings["SMTP"];
            port = Convert.ToInt32(ConfigurationManager.AppSettings["PORTA"]);
            ssl = bool.Parse(ConfigurationManager.AppSettings["SSL"]);
            initializeSmtpClient();
        }

    }
}
