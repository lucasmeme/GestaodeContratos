using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestaoContratos.Data;

namespace GestaoContratos
{
    public partial class frmCadParceiros : Form
    {
        DB_CONTRATOSDataContext db = new DB_CONTRATOSDataContext();
        private bool imagemAlternadaStatus = false;

        public frmCadParceiros()
        {
            InitializeComponent();
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
                if(cbCliente.Checked == false && cbFornec.Checked == false)
                {
                    MessageBox.Show("Informar o tipo do parceiro.", "Cadastro de Parceiro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    gbTipoParceiro.ForeColor = Color.Red;
                    return;
                }
                    

                PARCEIROS parc = new PARCEIROS();
                    
                parc.INDICA_CPF_CNPJ = rbPf.Checked ? 1 : 0;
                parc.INDICA_CLIENTE = cbCliente.Checked ? 1 : 0;
                parc.INDICA_FORNECEDOR = cbFornec.Checked ? 1 : 0;
                parc.CODIGO_PARCEIRO = txtParceiro.Text;
                parc.NOME_PARCEIRO = txtNomeParceiro.Text;
                parc.CPF_CNPJ = txtCpfCnpj.Text;
                parc.EMAIL = txtEmail.Text;
                parc.CELULAR = txtCelular.Text;
                parc.CEP = txtCep.Text;
                parc.LOGRADOURO = txtLogradouro.Text;
                parc.NUMERO = txtNumero.Text;
                parc.COMPLEMENTO = txtComplemento.Text;
                parc.BAIRRO = txtBairro.Text;
                parc.CIDADE = txtCidade.Text;
                parc.UF = txtUf.Text;
                parc.INATIVO = imagemAlternadaStatus ? 1 : 0;
                parc.DATA_CADASTRO = DateTime.Now;

                if(ParceirosDataAccess.InserirAtualizarParceiros(parc) == false)
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
    }
}
