using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestaoContratos.Data;
using GestaoContratos.Model;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestaoContratos
{
    public partial class frmCadParceiros : Form
    {
        DB_CONTRATOSDataContext db = new DB_CONTRATOSDataContext();
        private bool imagemAlternadaStatus = false;

        public frmCadParceiros()
        {
            InitializeComponent();
            txtCep.Leave += TxtCep_Leave;
        }

        private void TxtCep_Leave(object sender, EventArgs e)
        {
            BuscarCep();
        }

        private void frmClienteFornecedor_Load(object sender, EventArgs e)
        {
            if (rbPf.Checked == true)
            {
                lblTipoPessoa.Text = "NOME COMPLETO";
                lblCpfCnpj.Text = "CPF";
            }

            //string imgStatus = @"C:\Projetos VS\GestaodeProjetos\Gestao de Projetos\Imagens\CHECK.png";
            string pastaImagens = System.IO.Path.Combine(Application.StartupPath, "IMAGENS");
            string imgStatus = System.IO.Path.Combine(pastaImagens, "CHECK.png");

            if (System.IO.File.Exists(imgStatus))
            {
                pbStatus.Image = Image.FromFile(imgStatus);
            }
            else
            {
                MessageBox.Show("A imagem inicial não foi encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbPj_CheckedChanged(object sender, EventArgs e)
        {
            if(rbPj.Checked == true)
            {
                lblTipoPessoa.Text = "NOME FANTASIA";
                lblCpfCnpj.Text = "CNPJ";
            }
            else
            {
                lblTipoPessoa.Text = "NOME COMPLETO";
                lblCpfCnpj.Text = "CPF";
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string pastaImagens = System.IO.Path.Combine(Application.StartupPath, "IMAGENS");
            try
            {
                
                PARCEIROS parc = new PARCEIROS();
                    
                parc.INDICA_CPF_CNPJ = rbPf.Checked ? 1 : 0;
                parc.INDICA_CLIENTE = cbCliente.Checked ? 1 : 0;
                parc.INDICA_FORNECEDOR = cbFornec.Checked ? 1 : 0;
                parc.CODIGO_PARCEIRO = txtParceiro.Text.Trim();
                parc.NOME_PARCEIRO = txtNomeParceiro.Text.Trim();
                parc.CPF_CNPJ = txtDocumento.Text.Replace(".", "").Replace("-", "").Replace("/", "").Trim(); 
                parc.EMAIL = txtEmail.Text;
                parc.CELULAR = txtCelular.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "").Trim(); ;
                parc.CEP = txtCep.Text.Trim();
                parc.LOGRADOURO = txtLogradouro.Text.Trim();
                parc.NUMERO = txtNumero.Text.Trim();
                parc.COMPLEMENTO = txtComplemento.Text.Trim();
                parc.BAIRRO = txtBairro.Text.Trim();
                parc.CIDADE = txtCidade.Text;
                parc.UF = txtUf.Text.Trim();
                parc.INATIVO = imagemAlternadaStatus ? 1 : 0;
                parc.DATA_CADASTRO = DateTime.Now;

                validaCpfCnpj();

                if (cbCliente.Checked == false && cbFornec.Checked == false)
                {
                    MessageBox.Show("Informar o tipo do parceiro!", "Cadastro de Parceiro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    gbTipoParceiro.ForeColor = Color.Red;
                    return;
                }
                if (!string.IsNullOrWhiteSpace(txtLogradouro.Text) && string.IsNullOrWhiteSpace(txtNumero.Text))
                {
                    MessageBox.Show("Informar número do endereço!", "Cadastro de Parceiro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNumero.Focus();
                    return;
                }

                if (ParceirosDataAccess.InserirAtualizarParceiros(parc) == false)
                {
                    MessageBox.Show("Falha ao tentar cadastrar o parceiro!", "Cadastro de Parceiro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Parceiro salvo com sucesso.Deseja fazer um novo cadastro?", "Cadastro de Parceiro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        return;
                    }
                }  
            }
            catch (Exception ex)
            {
                if(ex.Message.Contains("Violation of UNIQUE KEY constraint") || ex.Message.Contains("chave duplicada"))
                {
                    MessageBox.Show("O código do parceiro já existe no banco de dados. Tente usar outro código.","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtParceiro.Focus();
                }
                else
                    MessageBox.Show($"Erro ao gravar no banco: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            
        }

        private void pbStatus_Click(object sender, EventArgs e)
        {
            // Caminho da pasta de imagens
            string pastaImagens = System.IO.Path.Combine(Application.StartupPath, "IMAGENS");
            string caminhoImagem1 = System.IO.Path.Combine(pastaImagens, "CHECK.png");
            string caminhoImagem2 = System.IO.Path.Combine(pastaImagens, "INATIVO.png");

            // Alternar entre as imagens
            if (!imagemAlternadaStatus)
            {
                if (System.IO.File.Exists(caminhoImagem2))
                {
                    pbStatus.Image = Image.FromFile(caminhoImagem2);
                    imagemAlternadaStatus = true;
                }
                else
                {
                    MessageBox.Show("A segunda imagem não foi encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (System.IO.File.Exists(caminhoImagem1))
                {
                    pbStatus.Image = Image.FromFile(caminhoImagem1);
                    imagemAlternadaStatus = false;
                }
                else
                {
                    MessageBox.Show("A imagem inicial não foi encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnListarParceiros_Click(object sender, EventArgs e)
        {
            frmListaParceiros frm = new frmListaParceiros();
            frm.ShowDialog();
        }

        public class Endereco
        {
            public string Logradouro { get; set; }
            public string Bairro { get; set; }
            public string Localidade { get; set; } // Cidade
            public string Uf { get; set; } // Estado
            public string Cep { get; set; }
            public string Erro { get; set; } // Campo usado quando o CEP não existe
        }
        private async void BuscarCep()
        {
            if (string.IsNullOrEmpty(txtCep.Text))
                return;
            string cep = txtCep.Text.Trim();

            if(cep.Length !=8 || !long.TryParse(cep, out _))
            {
                MessageBox.Show("Digite um CEP válido (8 dígitos)!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // URL da API ViaCEP
                string url = $"https://viacep.com.br/ws/{cep}/json/";

                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();

                        // Usando Newtonsoft.Json para desserializar
                        var endereco = JsonConvert.DeserializeObject<Endereco>(json);

                        if (endereco != null && string.IsNullOrEmpty(endereco.Erro))
                        {
                            txtLogradouro.Text = endereco.Logradouro;
                            txtBairro.Text = endereco.Bairro;
                            txtCidade.Text = endereco.Localidade;
                            txtUf.Text = endereco.Uf;
                        }
                        else
                        {
                            MessageBox.Show("CEP não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro ao buscar o CEP. Tente novamente mais tarde!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar o CEP: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCpfCnpj_Leave(object sender, EventArgs e)
        {
            validaCpfCnpj();
        }
        private void validaCpfCnpj()
        {
            if (string.IsNullOrEmpty(txtDocumento.Text))
                return;
            
            string documento = txtDocumento.Text.Trim();
            if (rbPf.Checked) // CPF
            {
                if (validaDocumento.ValidarCpf(documento))
                    return;
                else
                {
                    MessageBox.Show("CPF informado é inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDocumento.Focus();
                    txtDocumento.SelectAll();
                }
                    
                
            }
            if (rbPj.Checked) // CNPJ
            {
                if (validaDocumento.ValidarCnpj(documento))
                    return;
                else
                {
                    MessageBox.Show("CNPJ informado é inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDocumento.Focus();
                    txtDocumento.SelectAll();
                }
                    
            }
        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {
            string celular = txtCelular.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");

            if (celular.Length > 0)
            {
                if (celular.Length <= 2)
                {
                    txtCelular.Text = $"({celular}";
                }
                else if (celular.Length <= 7)
                {
                    txtCelular.Text = $"({celular.Substring(0, 2)}) {celular.Substring(2)}";
                }
                else
                {
                    txtCelular.Text = $"({celular.Substring(0, 2)}) {celular.Substring(2, 5)}-{celular.Substring(7)}";
                }
            }

            // Move o cursor para o final do texto
            txtCelular.SelectionStart = txtCelular.Text.Length;
        }

        private void txtCelular_Leave(object sender, EventArgs e)
        {
            if (txtCelular.Text.Length != 15) // Verifica o tamanho esperado com máscara
            {
                MessageBox.Show("Número de celular incompleto.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCelular.Focus();
                txtCelular.SelectAll();
            }
        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {
            string input = txtDocumento.Text.Replace(".", "").Replace("-", "").Replace("/", "");

            if(rbPf.Checked)
            {
                txtDocumento.MaxLength = 14;
                if (input.Length <= 11) // Aplica máscara de CPF
                {
                    if (input.Length > 3)
                        input = input.Insert(3, ".");
                    if (input.Length > 7)
                        input = input.Insert(7, ".");
                    if (input.Length > 11)
                        input = input.Insert(11, "-");
                }
            }
            if (rbPj.Checked)
            {
                txtDocumento.MaxLength = 18;
                if (input.Length <= 14) // Aplica máscara de CNPJ
                {
                    if (input.Length > 2)
                        input = input.Insert(2, ".");
                    if (input.Length > 6)
                        input = input.Insert(6, ".");
                    if (input.Length > 10)
                        input = input.Insert(10, "/");
                    if (input.Length > 15)
                        input = input.Insert(15, "-");
                }
            }
            

            // Atualiza o texto com a máscara
            txtDocumento.Text = input;

            // Move o cursor para o final do texto
            txtDocumento.SelectionStart = txtDocumento.Text.Length;
        }
    }
}
