namespace GestaoContratos
{
    partial class frmCadContratos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbFornecedores = new System.Windows.Forms.RadioButton();
            this.rbClientes = new System.Windows.Forms.RadioButton();
            this.txtResponsavel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbListaParceiros = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbFinalidade = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorContrato = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMeses = new System.Windows.Forms.Label();
            this.txtPrazo = new System.Windows.Forms.TextBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.rbPrazo = new System.Windows.Forms.RadioButton();
            this.rbIndeterminado = new System.Windows.Forms.RadioButton();
            this.txtNCotnrato = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFimContrato = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtInicioContrato = new System.Windows.Forms.DateTimePicker();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbFornecedores);
            this.groupBox4.Controls.Add(this.rbClientes);
            this.groupBox4.Controls.Add(this.txtResponsavel);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.cbListaParceiros);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(28, 121);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(954, 253);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PARCEIRO / RESPONSÁVEL";
            // 
            // rbFornecedores
            // 
            this.rbFornecedores.AutoSize = true;
            this.rbFornecedores.Location = new System.Drawing.Point(136, 34);
            this.rbFornecedores.Name = "rbFornecedores";
            this.rbFornecedores.Size = new System.Drawing.Size(116, 24);
            this.rbFornecedores.TabIndex = 37;
            this.rbFornecedores.Text = "Fornecedor";
            this.rbFornecedores.UseVisualStyleBackColor = true;
            this.rbFornecedores.CheckedChanged += new System.EventHandler(this.rbFornecedores_CheckedChanged);
            // 
            // rbClientes
            // 
            this.rbClientes.AutoSize = true;
            this.rbClientes.Location = new System.Drawing.Point(12, 34);
            this.rbClientes.Name = "rbClientes";
            this.rbClientes.Size = new System.Drawing.Size(83, 24);
            this.rbClientes.TabIndex = 36;
            this.rbClientes.Text = "Cliente";
            this.rbClientes.UseVisualStyleBackColor = true;
            this.rbClientes.CheckedChanged += new System.EventHandler(this.rbClientes_CheckedChanged);
            // 
            // txtResponsavel
            // 
            this.txtResponsavel.Location = new System.Drawing.Point(15, 181);
            this.txtResponsavel.Name = "txtResponsavel";
            this.txtResponsavel.Size = new System.Drawing.Size(622, 26);
            this.txtResponsavel.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "RESPONSÁVEL";
            // 
            // cbListaParceiros
            // 
            this.cbListaParceiros.FormattingEnabled = true;
            this.cbListaParceiros.Location = new System.Drawing.Point(15, 101);
            this.cbListaParceiros.Name = "cbListaParceiros";
            this.cbListaParceiros.Size = new System.Drawing.Size(622, 28);
            this.cbListaParceiros.TabIndex = 6;
            this.cbListaParceiros.SelectedIndexChanged += new System.EventHandler(this.cbListaParceiros_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "NOME PARCEIRO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.cbFinalidade);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtValorContrato);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtNCotnrato);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtFimContrato);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtInicioContrato);
            this.groupBox1.Location = new System.Drawing.Point(28, 397);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(954, 397);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DADOS DO CONTRATO";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(696, 69);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 160);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "STATUS";
            // 
            // cbFinalidade
            // 
            this.cbFinalidade.FormattingEnabled = true;
            this.cbFinalidade.Location = new System.Drawing.Point(15, 268);
            this.cbFinalidade.Name = "cbFinalidade";
            this.cbFinalidade.Size = new System.Drawing.Size(323, 28);
            this.cbFinalidade.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "FINALIDADE";
            // 
            // txtValorContrato
            // 
            this.txtValorContrato.Location = new System.Drawing.Point(15, 330);
            this.txtValorContrato.Name = "txtValorContrato";
            this.txtValorContrato.Size = new System.Drawing.Size(323, 26);
            this.txtValorContrato.TabIndex = 33;
            this.txtValorContrato.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorContrato.TextChanged += new System.EventHandler(this.txtValorContrato_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "VALOR DO CONTRATO";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMeses);
            this.groupBox2.Controls.Add(this.txtPrazo);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.rbPrazo);
            this.groupBox2.Controls.Add(this.rbIndeterminado);
            this.groupBox2.Location = new System.Drawing.Point(391, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 167);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CONTROLE DE VIGÊNCIA";
            // 
            // lblMeses
            // 
            this.lblMeses.AutoSize = true;
            this.lblMeses.Location = new System.Drawing.Point(175, 128);
            this.lblMeses.Name = "lblMeses";
            this.lblMeses.Size = new System.Drawing.Size(56, 20);
            this.lblMeses.TabIndex = 35;
            this.lblMeses.Text = "meses";
            this.lblMeses.Visible = false;
            this.lblMeses.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtPrazo
            // 
            this.txtPrazo.Location = new System.Drawing.Point(111, 125);
            this.txtPrazo.Name = "txtPrazo";
            this.txtPrazo.Size = new System.Drawing.Size(58, 26);
            this.txtPrazo.TabIndex = 34;
            this.txtPrazo.Visible = false;
            this.txtPrazo.TextChanged += new System.EventHandler(this.txtPrazo_TextChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(32, 40);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(94, 24);
            this.radioButton3.TabIndex = 32;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Data fim";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // rbPrazo
            // 
            this.rbPrazo.AutoSize = true;
            this.rbPrazo.Location = new System.Drawing.Point(32, 126);
            this.rbPrazo.Name = "rbPrazo";
            this.rbPrazo.Size = new System.Drawing.Size(75, 24);
            this.rbPrazo.TabIndex = 31;
            this.rbPrazo.Text = "Prazo";
            this.rbPrazo.UseVisualStyleBackColor = true;
            this.rbPrazo.CheckedChanged += new System.EventHandler(this.rbPrazo_CheckedChanged);
            // 
            // rbIndeterminado
            // 
            this.rbIndeterminado.AutoSize = true;
            this.rbIndeterminado.Location = new System.Drawing.Point(32, 82);
            this.rbIndeterminado.Name = "rbIndeterminado";
            this.rbIndeterminado.Size = new System.Drawing.Size(137, 24);
            this.rbIndeterminado.TabIndex = 30;
            this.rbIndeterminado.Text = "Indeterminado";
            this.rbIndeterminado.UseVisualStyleBackColor = true;
            this.rbIndeterminado.CheckedChanged += new System.EventHandler(this.rbIndeterminado_CheckedChanged);
            // 
            // txtNCotnrato
            // 
            this.txtNCotnrato.Location = new System.Drawing.Point(15, 63);
            this.txtNCotnrato.Name = "txtNCotnrato";
            this.txtNCotnrato.Size = new System.Drawing.Size(323, 26);
            this.txtNCotnrato.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Nº CONTRATO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "FIM CONTRATO";
            // 
            // dtFimContrato
            // 
            this.dtFimContrato.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFimContrato.Location = new System.Drawing.Point(15, 203);
            this.dtFimContrato.Name = "dtFimContrato";
            this.dtFimContrato.Size = new System.Drawing.Size(323, 26);
            this.dtFimContrato.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "INICIO CONTRATO";
            // 
            // dtInicioContrato
            // 
            this.dtInicioContrato.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicioContrato.Location = new System.Drawing.Point(15, 134);
            this.dtInicioContrato.Name = "dtInicioContrato";
            this.dtInicioContrato.Size = new System.Drawing.Size(323, 26);
            this.dtInicioContrato.TabIndex = 20;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(28, 36);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(85, 38);
            this.btnSalvar.TabIndex = 21;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmCadContratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 847);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Name = "frmCadContratos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Contratos";
            this.Load += new System.EventHandler(this.frmCadContratos_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbListaParceiros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNCotnrato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFimContrato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtInicioContrato;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton rbPrazo;
        private System.Windows.Forms.RadioButton rbIndeterminado;
        private System.Windows.Forms.TextBox txtValorContrato;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrazo;
        private System.Windows.Forms.ComboBox cbFinalidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtResponsavel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMeses;
        private System.Windows.Forms.RadioButton rbFornecedores;
        private System.Windows.Forms.RadioButton rbClientes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSalvar;
    }
}