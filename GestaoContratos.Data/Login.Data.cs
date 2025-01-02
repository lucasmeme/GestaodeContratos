using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestaoContratos.Data;

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
    }
}
