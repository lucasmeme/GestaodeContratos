using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace GestaoContratos
{
    public partial class frmConfigEmail : Form
    {
        public frmConfigEmail()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.AppSettings.Settings["EMAIL"].Value = txtEmail.Text;
            config.AppSettings.Settings["SENHA"].Value = txtSenha.Text;
            config.AppSettings.Settings["SMTP"].Value = txtSmtp.Text;
            config.AppSettings.Settings["PORTA"].Value = txtPorta.Text;
            config.Save();
            ConfigurationManager.RefreshSection("AppSettings");

            MessageBox.Show("Dados salvos com sucesso.", "Configuração de envio de e-mail", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Application.Restart();
        }

        private void frmConfigEmail_Load(object sender, EventArgs e)
        {
            txtEmail.Text = ConfigurationManager.AppSettings["EMAIL"];
            txtSenha.Text = ConfigurationManager.AppSettings["SENHA"];
            txtSmtp.Text = ConfigurationManager.AppSettings["SMTP"];
            txtPorta.Text = ConfigurationManager.AppSettings["PORTA"];
        }
    }
}
