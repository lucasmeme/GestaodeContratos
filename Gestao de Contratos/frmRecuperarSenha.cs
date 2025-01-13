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
using GestaoContratos.Model;

namespace GestaoContratos
{
    public partial class frmRecuperarSenha : Form
    {
        public frmRecuperarSenha()
        {
            InitializeComponent();
        }

        private void pbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string emailDestino = txtEmail.Text;
            

            // Valida se os campos estão preenchidos
            if (string.IsNullOrEmpty(emailDestino))
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de enviar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var resultado = Login.localizarUsuario(emailDestino);
                lblResultado.Text = resultado;
                //MessageBox.Show(resultado, "Retorno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
               lblResultado.Text = ex.Message;
               //MessageBox.Show($"Erro ao enviar o e-mail: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmRecuperarSenha_Load(object sender, EventArgs e)
        {
            lblResultado.Text = "";
        }
    }
}
