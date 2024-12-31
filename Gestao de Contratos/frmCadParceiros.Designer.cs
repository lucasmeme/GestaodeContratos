namespace GestaoContratos
{
    partial class frmCadParceiros
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPj = new System.Windows.Forms.RadioButton();
            this.rbPf = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblCpfCnpj = new System.Windows.Forms.Label();
            this.txtNomeParceiro = new System.Windows.Forms.TextBox();
            this.lblTipoPessoa = new System.Windows.Forms.Label();
            this.txtParceiro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbTipoParceiro = new System.Windows.Forms.GroupBox();
            this.cbFornec = new System.Windows.Forms.CheckBox();
            this.cbCliente = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnListarParceiros = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pbStatus = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbTipoParceiro.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPj);
            this.groupBox1.Controls.Add(this.rbPf);
            this.groupBox1.Location = new System.Drawing.Point(13, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CPF/CNPJ";
            // 
            // rbPj
            // 
            this.rbPj.AutoSize = true;
            this.rbPj.Location = new System.Drawing.Point(109, 38);
            this.rbPj.Name = "rbPj";
            this.rbPj.Size = new System.Drawing.Size(74, 24);
            this.rbPj.TabIndex = 9;
            this.rbPj.Text = "CNPJ";
            this.rbPj.UseVisualStyleBackColor = true;
            this.rbPj.CheckedChanged += new System.EventHandler(this.rbPj_CheckedChanged);
            // 
            // rbPf
            // 
            this.rbPf.AutoSize = true;
            this.rbPf.Checked = true;
            this.rbPf.Location = new System.Drawing.Point(16, 39);
            this.rbPf.Name = "rbPf";
            this.rbPf.Size = new System.Drawing.Size(65, 24);
            this.rbPf.TabIndex = 8;
            this.rbPf.TabStop = true;
            this.rbPf.Text = "CPF";
            this.rbPf.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtComplemento);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtUf);
            this.groupBox2.Controls.Add(this.txtCidade);
            this.groupBox2.Controls.Add(this.txtBairro);
            this.groupBox2.Controls.Add(this.txtNumero);
            this.groupBox2.Controls.Add(this.txtLogradouro);
            this.groupBox2.Controls.Add(this.txtCep);
            this.groupBox2.Location = new System.Drawing.Point(19, 544);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(831, 259);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ENDEREÇO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(508, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "COMPLEMENTO";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(512, 121);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(163, 26);
            this.txtComplemento.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(375, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "UF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(188, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "CIDADE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "BAIRRO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nº";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "LOGRADOURO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "CEP";
            // 
            // txtUf
            // 
            this.txtUf.Location = new System.Drawing.Point(379, 180);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(100, 26);
            this.txtUf.TabIndex = 5;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(192, 180);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(158, 26);
            this.txtCidade.TabIndex = 4;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(7, 180);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(170, 26);
            this.txtBairro.TabIndex = 3;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(379, 121);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 26);
            this.txtNumero.TabIndex = 2;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(7, 121);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(343, 26);
            this.txtLogradouro.TabIndex = 1;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(7, 62);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(100, 26);
            this.txtCep.TabIndex = 0;
            this.txtCep.Leave += new System.EventHandler(this.TxtCep_Leave);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCelular);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtEmail);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtDocumento);
            this.groupBox3.Controls.Add(this.lblCpfCnpj);
            this.groupBox3.Controls.Add(this.txtNomeParceiro);
            this.groupBox3.Controls.Add(this.lblTipoPessoa);
            this.groupBox3.Controls.Add(this.txtParceiro);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(19, 226);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(831, 280);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DADOS";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(379, 190);
            this.txtCelular.MaxLength = 15;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(313, 26);
            this.txtCelular.TabIndex = 22;
            this.txtCelular.TextChanged += new System.EventHandler(this.txtCelular_TextChanged);
            this.txtCelular.Leave += new System.EventHandler(this.txtCelular_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "CELULAR";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(28, 190);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(313, 26);
            this.txtEmail.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "E-MAIL";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(28, 120);
            this.txtDocumento.MaxLength = 18;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(313, 26);
            this.txtDocumento.TabIndex = 18;
            this.txtDocumento.TextChanged += new System.EventHandler(this.txtDocumento_TextChanged);
            this.txtDocumento.Leave += new System.EventHandler(this.txtCpfCnpj_Leave);
            // 
            // lblCpfCnpj
            // 
            this.lblCpfCnpj.AutoSize = true;
            this.lblCpfCnpj.Location = new System.Drawing.Point(30, 97);
            this.lblCpfCnpj.Name = "lblCpfCnpj";
            this.lblCpfCnpj.Size = new System.Drawing.Size(51, 20);
            this.lblCpfCnpj.TabIndex = 17;
            this.lblCpfCnpj.Text = "label3";
            // 
            // txtNomeParceiro
            // 
            this.txtNomeParceiro.Location = new System.Drawing.Point(248, 51);
            this.txtNomeParceiro.Name = "txtNomeParceiro";
            this.txtNomeParceiro.Size = new System.Drawing.Size(444, 26);
            this.txtNomeParceiro.TabIndex = 16;
            // 
            // lblTipoPessoa
            // 
            this.lblTipoPessoa.AutoSize = true;
            this.lblTipoPessoa.Location = new System.Drawing.Point(244, 28);
            this.lblTipoPessoa.Name = "lblTipoPessoa";
            this.lblTipoPessoa.Size = new System.Drawing.Size(51, 20);
            this.lblTipoPessoa.TabIndex = 15;
            this.lblTipoPessoa.Text = "label2";
            // 
            // txtParceiro
            // 
            this.txtParceiro.Location = new System.Drawing.Point(28, 52);
            this.txtParceiro.Name = "txtParceiro";
            this.txtParceiro.Size = new System.Drawing.Size(186, 26);
            this.txtParceiro.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "CÓDIGO";
            // 
            // gbTipoParceiro
            // 
            this.gbTipoParceiro.Controls.Add(this.cbFornec);
            this.gbTipoParceiro.Controls.Add(this.cbCliente);
            this.gbTipoParceiro.Location = new System.Drawing.Point(257, 102);
            this.gbTipoParceiro.Name = "gbTipoParceiro";
            this.gbTipoParceiro.Size = new System.Drawing.Size(391, 100);
            this.gbTipoParceiro.TabIndex = 10;
            this.gbTipoParceiro.TabStop = false;
            this.gbTipoParceiro.Text = "TIPO";
            // 
            // cbFornec
            // 
            this.cbFornec.AutoSize = true;
            this.cbFornec.Location = new System.Drawing.Point(166, 38);
            this.cbFornec.Name = "cbFornec";
            this.cbFornec.Size = new System.Drawing.Size(149, 24);
            this.cbFornec.TabIndex = 1;
            this.cbFornec.Text = "FORNECEDOR";
            this.cbFornec.UseVisualStyleBackColor = true;
            // 
            // cbCliente
            // 
            this.cbCliente.AutoSize = true;
            this.cbCliente.Location = new System.Drawing.Point(45, 38);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(102, 24);
            this.cbCliente.TabIndex = 0;
            this.cbCliente.Text = "CLIENTE";
            this.cbCliente.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(26, 27);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(86, 36);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnListarParceiros
            // 
            this.btnListarParceiros.Location = new System.Drawing.Point(143, 27);
            this.btnListarParceiros.Name = "btnListarParceiros";
            this.btnListarParceiros.Size = new System.Drawing.Size(75, 36);
            this.btnListarParceiros.TabIndex = 16;
            this.btnListarParceiros.Text = "LISTAR";
            this.btnListarParceiros.UseVisualStyleBackColor = true;
            this.btnListarParceiros.Click += new System.EventHandler(this.btnListarParceiros_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pbStatus);
            this.groupBox5.Location = new System.Drawing.Point(668, 102);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(182, 100);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "STATUS";
            // 
            // pbStatus
            // 
            this.pbStatus.Location = new System.Drawing.Point(50, 23);
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(75, 69);
            this.pbStatus.TabIndex = 0;
            this.pbStatus.TabStop = false;
            this.pbStatus.Click += new System.EventHandler(this.pbStatus_Click);
            // 
            // frmCadParceiros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 824);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnListarParceiros);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gbTipoParceiro);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCadParceiros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Parceiros";
            this.Load += new System.EventHandler(this.frmClienteFornecedor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbTipoParceiro.ResumeLayout(false);
            this.gbTipoParceiro.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPj;
        private System.Windows.Forms.RadioButton rbPf;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lblCpfCnpj;
        private System.Windows.Forms.TextBox txtNomeParceiro;
        private System.Windows.Forms.Label lblTipoPessoa;
        private System.Windows.Forms.TextBox txtParceiro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbTipoParceiro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.CheckBox cbFornec;
        private System.Windows.Forms.CheckBox cbCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnListarParceiros;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pbStatus;
    }
}

