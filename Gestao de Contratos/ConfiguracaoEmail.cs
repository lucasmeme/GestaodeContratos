using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace GestaoContratos.Model
{
    public static class ConfiguracaoEmail
    {
        public static string EmailRemetente => ConfigurationManager.AppSettings["EMAIL"];
    }
}
