using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoContratos
{
    public partial class frmListaContratos : Form
    {
        DB_CONTRATOSDataContext db = new DB_CONTRATOSDataContext();
        public frmListaContratos()
        {
            InitializeComponent();
        }

        private void frmListaContratos_Load(object sender, EventArgs e)
        {
            ListaContratos();
        }
       
        public class ListaContrato
        {
            public string NUMERO_CONTRATO { get; set; }
            public string PARCEIRO { get; set; }
            public string FINALIDADE { get; set; }
            public DateTime DATA_INICIO { get; set; }
            public string DATA_FIM { get; set; }
            public decimal VALOR_CONTRATO { get; set; }
            public string STATUS {  get; set; }
            public string PRAZO { get; set; }
        }

        private List<ListaContrato> dadosOriginais;
        private void ListaContratos()
        {

            var lista = (from a in db.CONTRATOs
                         join b in db.PARCEIROs
                         on a.ID_PARCEIRO equals b.ID_PARCEIRO
                         select new
                         {
                             a.NUMERO_CONTRATO,
                             Parceiro = b.NOME_PARCEIRO,
                             a.ID_FINALIDADE,
                             DataInicio = a.DATA_INICIO,
                             DataFim = a.DATA_FIM,
                             a.VALOR_CONTRATO,
                             a.STATUS_CONTRATO
                            
                         }).AsEnumerable() // Move a execução para a memória
                 .Select(x => new ListaContrato
                 {
                     NUMERO_CONTRATO = x.NUMERO_CONTRATO,
                     PARCEIRO = x.Parceiro,
                     FINALIDADE = "FINALIDADE",
                     DATA_INICIO = x.DataInicio.Date,
                     DATA_FIM = x.DataFim.HasValue ? x.DataFim.Value.Date.ToString("dd/MM/yyyy") : "SEM DATA FIM",
                     PRAZO = x.DataFim.HasValue ? (x.DataFim.Value - x.DataInicio).Days + " Dias" : (string)null,
                     VALOR_CONTRATO = x.VALOR_CONTRATO,
                     STATUS = x.STATUS_CONTRATO
                     
                 })
                 .ToList();

            // Armazenar os dados originais para restaurar quando necessário
            dadosOriginais = lista;
            // Definir os dados no DataGridView
            dgListaContratos.DataSource = lista;

            dgListaContratos.Columns["VALOR_CONTRATO"].DefaultCellStyle.Format = "C2";
            dgListaContratos.Columns["VALOR_CONTRATO"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("pt-BR");

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarGrid(txtFiltro.Text);
        }

        private void FiltrarGrid(string textoFiltro)
        {
            // Verifica se o texto de filtro está vazio
            if (string.IsNullOrEmpty(textoFiltro))
            {
                ListaContratos();
            }
            // Obter a fonte de dados original (Lista de objetos)
            else
            {
                // Filtrar com base no texto digitado
                var dadosFiltrados = dadosOriginais.Where(item =>
                    (item.NUMERO_CONTRATO != null && item.NUMERO_CONTRATO.ToLower().Contains(textoFiltro.ToLower())) ||
                    (item.PARCEIRO != null && item.PARCEIRO.ToLower().Contains(textoFiltro.ToLower())) ||
                    (item.FINALIDADE != null && item.FINALIDADE.ToLower().Contains(textoFiltro.ToLower())) ||
                    (item.DATA_INICIO.ToString("dd/MM/yyyy").Contains(textoFiltro)) ||
                    (item.DATA_FIM != null && item.DATA_FIM.ToLower().Contains(textoFiltro.ToLower())) ||
                    (item.VALOR_CONTRATO.ToString().Contains(textoFiltro)) ||
                    (item.STATUS != null && item.STATUS.ToLower().Contains(textoFiltro.ToLower()))
                ).ToList();

                // Atualizar o DataGridView
                dgListaContratos.DataSource = dadosFiltrados;
            }
        }

        private void dgListaContratos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var contratoSelecionado = (ListaContrato)dgListaContratos.Rows[e.RowIndex].DataBoundItem;

                frmCadContratos frmCadContrato = new frmCadContratos(
                    contratoSelecionado.NUMERO_CONTRATO,
                    contratoSelecionado.PARCEIRO,
                    contratoSelecionado.FINALIDADE,
                    contratoSelecionado.DATA_INICIO,
                    contratoSelecionado.DATA_FIM,
                    contratoSelecionado.VALOR_CONTRATO,
                    contratoSelecionado.STATUS                    
                    );
                this.Hide();
                frmCadContrato.ShowDialog();
            }
        }
    }
}
