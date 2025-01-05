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
                USUARIO user = new USUARIO();
                user.LOGIN = txtUsuario.Text;
                user.SENHA = txtSenha.Text;

                if (Login.ValidaLogin(user) == true)
                {
                    this.Hide();
                    frmPrincipal frm = new frmPrincipal();
                    frm.ShowDialog();
                }
                else
                    MessageBox.Show("Usuário/senha incorretos ou usuário não cadastrado no sistema.", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
    }
}
