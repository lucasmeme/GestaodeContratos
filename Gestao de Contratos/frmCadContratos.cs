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
    public partial class frmCadContratos : Form
    {
        private string numeroContratoOriginal;
        DB_CONTRATOSDataContext db = new DB_CONTRATOSDataContext();
        public frmCadContratos(string numeroContrato, string parceiro, string finalidade, DateTime dataInicio, string dataFim, decimal valorContrato, string status)
        {
            InitializeComponent();

            numeroContratoOriginal = numeroContrato;


            // Preencher os campos do formulário com os dados passados
            var tipoParceiro = (from a in db.PARCEIROs
                                where a.NOME_PARCEIRO == parceiro
                                select a.INDICA_CLIENTE).FirstOrDefault();
            if (tipoParceiro == 1)
                rbClientes.Checked = true;
            else
                rbFornecedores.Checked = true;
            txtNCotnrato.Text = numeroContrato;
            cbListaParceiros.Text = parceiro;
            cbFinalidade.Text = finalidade;
            dtInicioContrato.Value = dataInicio;
            if(dataFim != "SEM DATA FIM")
                dtFimContrato.Value = DateTime.Parse(dataFim);
            else
            {
                dtFimContrato.Enabled = false;
                rbIndeterminado.Checked = true; 
            }
            
            txtValorContrato.Text = valorContrato.ToString("C2");  // Formatação de moeda
            //txtStatus.Text = status;
            //txtPrazo.Text = prazo.HasValue ? prazo.Value.ToString() : "N/A"; // Se prazo for null, exibe "N/A"
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void rbPrazo_CheckedChanged(object sender, EventArgs e)
        {
            if(rbPrazo.Checked)
            {
                txtPrazo.Visible = true;
                lblMeses.Visible = true;
            }
            else
            {
                txtPrazo.Visible = false;
                lblMeses.Visible = false;
            }
        }

        private void rbIndeterminado_CheckedChanged(object sender, EventArgs e)
        {
            if(rbIndeterminado.Checked)
            {
                dtFimContrato.Enabled = false;
            }
            else
                dtFimContrato.Enabled=true;
        }

        private void txtValorContrato_TextChanged(object sender, EventArgs e)
        {
            TextBox txtValorContrato = sender as TextBox;

            if (string.IsNullOrWhiteSpace(txtValorContrato.Text))
                return;

            // Remover qualquer formatação anterior e manter apenas números
            string textoSemFormatacao = new string(txtValorContrato.Text.Where(char.IsDigit).ToArray());

            if (string.IsNullOrEmpty(textoSemFormatacao))
            {
                txtValorContrato.Text = "0,00";
                txtValorContrato.SelectionStart = txtValorContrato.Text.Length;
                return;
            }

            // Converter para decimal e formatar com duas casas decimais
            decimal valor = decimal.Parse(textoSemFormatacao) / 100; // Dividir por 100 para ajustar as casas decimais
            txtValorContrato.Text = $"R$ {valor:N2}";

            // Reposicionar o cursor no final do texto
            txtValorContrato.SelectionStart = txtValorContrato.Text.Length;
        }

        private void frmCadContratos_Load(object sender, EventArgs e)
        {
            string textoSemFormatacao = new string(txtValorContrato.Text.Where(char.IsDigit).ToArray());

            if (string.IsNullOrEmpty(textoSemFormatacao))
            {
                txtValorContrato.Text = "R$ 0,00";
                txtValorContrato.SelectionStart = txtValorContrato.Text.Length;
                return;
            }



        }


        private void txtPrazo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrazo.Text))
                return;

            int qtdMeses;
            if(int.TryParse(txtPrazo.Text, out qtdMeses))
            {
                DateTime dataInicial = dtInicioContrato.Value;
                DateTime dataFim = dataInicial.AddMonths(qtdMeses);
                dtFimContrato.Value = dataFim;
            }
            else
            {
                // Mensagem para entrada inválida
                MessageBox.Show("Informe um número válido de meses.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrazo.Clear();
            }
        }
        private void CarregarComboBox(string tipo)
        {
            // Limpar o ComboBox
            //cbListaParceiros.Items.Clear();

            try
            {
                using (var db = new DB_CONTRATOSDataContext())
                {
                    if (tipo == "Clientes")
                    {
                       

                        // Consulta LINQ para obter os clientes
                        var clientes = (from a in db.PARCEIROs
                                        orderby a.NOME_PARCEIRO
                                        where a.INDICA_CLIENTE == 1
                                        select new
                                        {
                                            a.CODIGO_PARCEIRO,
                                            a.NOME_PARCEIRO,
                                        }).ToList();

                        // Preencher o ComboBox
                       cbListaParceiros.DataSource = clientes;
                       
                    }
                    else if (tipo == "Fornecedores")
                    {
                        

                        // Consulta LINQ para obter os fornecedores
                        var fornecedores = (from a in db.PARCEIROs
                                        orderby a.NOME_PARCEIRO
                                        where a.INDICA_FORNECEDOR == 1
                                        select new
                                        {
                                            a.CODIGO_PARCEIRO,
                                            a.NOME_PARCEIRO,
                                        }).ToList();

                        // Preencher o ComboBox
                        cbListaParceiros.DataSource = fornecedores;
                   

                    }


                    // Configurar exibição no ComboBox
                    cbListaParceiros.DisplayMember = "NOME_PARCEIRO"; 
                    cbListaParceiros.ValueMember = "CODIGO_PARCEIRO";
                    
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void rbClientes_CheckedChanged(object sender, EventArgs e)
        {
            if(rbClientes.Checked)
            {
                CarregarComboBox("Clientes");
            }
        }

        private void rbFornecedores_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFornecedores.Checked)
            {
                CarregarComboBox("Fornecedores");
            }
        }

        private void cbListaParceiros_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new DB_CONTRATOSDataContext())
                {

                    var contrato = db.CONTRATOs.FirstOrDefault(c => c.NUMERO_CONTRATO == numeroContratoOriginal);

                    if (contrato == null)
                        contrato = new CONTRATO();
                    var codigoParceiro = cbListaParceiros.SelectedValue;
                    var idParceiro = (from a in db.PARCEIROs
                                      where a.CODIGO_PARCEIRO == codigoParceiro.ToString()
                                      select a.ID_PARCEIRO).FirstOrDefault();

                    DateTime? datafim = rbIndeterminado.Checked ? (DateTime?)null : dtFimContrato.Value.Date;

                    CONTRATO cONTRATO = new CONTRATO
                    {
                        ID_PARCEIRO = idParceiro,
                        ID_USER_RESPONSAVEL = 1,
                        ID_FINALIDADE = 1,
                        NUMERO_CONTRATO = txtNCotnrato.Text,
                        DATA_INICIO = dtInicioContrato.Value.Date,
                        DATA_FIM =  datafim,
                        PRAZO = !string.IsNullOrWhiteSpace(txtPrazo.Text) ? Convert.ToInt32(txtPrazo.Text) : 0,
                        VALOR_CONTRATO = decimal.Parse(txtValorContrato.Text, System.Globalization.NumberStyles.Currency),
                        STATUS_CONTRATO = "RASCUNHO",
                        DATA_CADASTRO = DateTime.Now
                    };
                    if (contrato == null)
                    {
                        db.CONTRATOs.InsertOnSubmit(cONTRATO);
                    }                    
                    db.SubmitChanges();
                    MessageBox.Show("Contrato cadastrado com sucesso!", "Cadastro de Contratos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Violation of UNIQUE KEY constraint") || ex.Message.Contains("chave duplicada"))
                {
                    MessageBox.Show("O código do contrato já existe no banco de dados. Tente usar outro código.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtValorContrato.Focus();
                }
                else
                    MessageBox.Show($"Erro ao gravar no banco: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
