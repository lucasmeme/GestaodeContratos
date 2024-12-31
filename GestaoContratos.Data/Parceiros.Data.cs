using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoContratos.Data;


namespace GestaoContratos.Data
{
    public class ParceirosDataAccess
    {
        public static DB_CONTRATOSDataContext db = new DB_CONTRATOSDataContext();

        
        public static bool InserirAtualizarParceiros(PARCEIROS pArca)
        {
             try
             {
                var parc = (from a in db.PARCEIROS
                             where a.CPF_CNPJ == pArca.CPF_CNPJ
                             select a).FirstOrDefault();

                 if (parc == null)
                     parc = new PARCEIROS();

                 parc.INDICA_CPF_CNPJ = pArca.INDICA_CPF_CNPJ;
                 parc.INDICA_CLIENTE = pArca.INDICA_CLIENTE;
                 parc.INDICA_FORNECEDOR = pArca.INDICA_FORNECEDOR;
                 parc.CODIGO_PARCEIRO = pArca.CODIGO_PARCEIRO;
                 parc.NOME_PARCEIRO = pArca.NOME_PARCEIRO;
                 parc.CPF_CNPJ = pArca.CPF_CNPJ;
                 parc.EMAIL = pArca.EMAIL;
                 parc.CELULAR = pArca.CELULAR;
                 parc.CEP = pArca.CEP;
                 parc.LOGRADOURO = pArca.LOGRADOURO;
                 parc.NUMERO = pArca.NUMERO;
                 parc.COMPLEMENTO = pArca.COMPLEMENTO;
                 parc.BAIRRO = pArca.BAIRRO;
                 parc.CIDADE = pArca.CIDADE;
                 parc.UF = pArca.UF;
                 parc.INATIVO = pArca.INATIVO;
                 parc.DATA_CADASTRO = pArca.DATA_CADASTRO;

                 if (parc.ID_PARCEIRO == 0)
                 {
                     db.PARCEIROS.InsertOnSubmit(parc);
                 }
                 db.SubmitChanges();
            
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

       
    }
}
