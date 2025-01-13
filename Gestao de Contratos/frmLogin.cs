using GestaoContratos.Data;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void pbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                string login = txtUsuario.Text;
                string senha = txtSenha.Text;

                USUARIO user = new USUARIO();
                user.LOGIN = login;
                user.SENHA = senha;

                if(login == string.Empty || login == "USUÁRIO") 
                {
                    lblMensagem.Visible = true;
                    lblMensagem.Text = "Por favor informar o seu usuário.";
                    txtUsuario.Focus();
                    return;
                
                }
                if (senha == string.Empty || senha == "SENHA")
                {
                    lblMensagem.Visible = true;
                    lblMensagem.Text = "Por favor informar sua senha.";
                    txtSenha.Focus();
                    return;

                }

                if (Login.ValidaLogin(user) == true)
                {
                    this.Hide();
                    frmPrincipal frm = new frmPrincipal();
                    frm.ShowDialog();
                }
                else
                {
                    lblMensagem.Visible = true;
                    lblMensagem.Text = "Usuário/senha incorretos ou usuário não cadastrado no sistema.";
                }
                    
            }
            catch (Exception ex)
            {
                // Log de erro ou tratamento (opcional)
                MessageBox.Show($"Erro ao validar login: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void lblRecuperarSenha_Click(object sender, EventArgs e)
        {
            frmRecuperarSenha frm = new frmRecuperarSenha();
            frm.ShowDialog();
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUÁRIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUÁRIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            btnEntrar.Focus();
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.Text = "SENHA";
                txtSenha.ForeColor = Color.DimGray;
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.Text = "SENHA";
                txtSenha.ForeColor = Color.DimGray;
            }
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            txtSenha.Text = "";
        }
    }
}
