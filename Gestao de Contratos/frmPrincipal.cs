using GestaoContratos;
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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cADASTRARToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string numeroContrato = "";
            string parceiro = "";
            string finalidade = "";
            DateTime dataInicio = DateTime.Now.Date;
            string dataFim = Convert.ToString(DateTime.Now.Date);
            decimal valorContrato = 0;
            string status = "Ativo";

            frmCadContratos cadContrato = new frmCadContratos(
                numeroContrato,
                parceiro,
                finalidade,
                dataInicio,
                dataFim,
                valorContrato,
                status);
            cadContrato.ShowDialog();
        }

        private void lISTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaContratos frm = new frmListaContratos();
            frm.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void cONTRATOSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pARCEIROSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadParceiros frm = new frmCadParceiros();
            frm.ShowDialog();
        }

        private void eNVIODEEMAILToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfigEmail frm = new frmConfigEmail();
            frm.ShowDialog();
        }
    }
}
