using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GestaoContratos.frmListaParceiros;

namespace GestaoContratos
{
    public partial class frmListaParceiros : Form
    {
        DB_CONTRATOSDataContext db = new DB_CONTRATOSDataContext();
        public frmListaParceiros()
        {
            InitializeComponent();
        }

        private void frmListaParceiros_Load(object sender, EventArgs e)
        {
            ListaParceiros();
        }
        public class ListaParceiro
        {
            public string CODIGO_PARCEIRO { get; set; }
            public string NOME_PARCEIRO { get; set; }
            public string CPF_CNPJ { get; set; }
            public string EMAIL { get; set; }
            public string CELULAR { get; set; }
            public int STATUS { get; set; }
        }

        private List<ListaParceiro> dadosOriginais;
        private void ListaParceiros()
        {

            var lista = (from a in db.PARCEIROs
                         select new
                         {
                             a.CODIGO_PARCEIRO,
                             a.NOME_PARCEIRO,
                             a.CPF_CNPJ,
                             a.EMAIL,
                             a.CELULAR,
                             a.INATIVO

                         }).AsEnumerable() // Move a execução para a memória
                 .Select(x => new ListaParceiro
                 {
                     CODIGO_PARCEIRO = x.CODIGO_PARCEIRO,
                     NOME_PARCEIRO = x.NOME_PARCEIRO,
                     CPF_CNPJ = x.CPF_CNPJ,
                     EMAIL = x.EMAIL,
                     CELULAR = x.CELULAR,
                     STATUS = x.INATIVO
                 })
                 .ToList();

            // Armazenar os dados originais para restaurar quando necessário
            dadosOriginais = lista;
            // Definir os dados no DataGridView
            dgListaParceiros.DataSource = lista;

        }

        private void FiltrarGrid(string textoFiltro)
        {
            // Verifica se o texto de filtro está vazio
            if (string.IsNullOrEmpty(textoFiltro))
            {
                ListaParceiros();
            }
            // Obter a fonte de dados original (Lista de objetos)
            else
            {
                // Filtrar com base no texto digitado
                var dadosFiltrados = dadosOriginais.Where(item =>
                    (item.CODIGO_PARCEIRO != null && item.CODIGO_PARCEIRO.ToLower().Contains(textoFiltro.ToLower())) ||
                    (item.NOME_PARCEIRO != null && item.NOME_PARCEIRO.ToLower().Contains(textoFiltro.ToLower())) ||
                    (item.CPF_CNPJ != null && item.CPF_CNPJ.ToLower().Contains(textoFiltro.ToLower())) ||
                    (item.EMAIL != null && item.EMAIL.ToLower().Contains(textoFiltro.ToLower())) ||
                    (item.CELULAR != null && item.CELULAR.ToLower().Contains(textoFiltro.ToLower()))
                ).ToList();

                // Atualizar o DataGridView
                dgListaParceiros.DataSource = dadosFiltrados;
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarGrid(txtFiltro.Text);
        }
    }
}
