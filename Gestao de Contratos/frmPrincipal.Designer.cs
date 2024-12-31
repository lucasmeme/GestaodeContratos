namespace GestaoContratos
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cONTRATOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cADASTRARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lISTARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cADASTROSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pARCEIROSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cONTRATOSToolStripMenuItem,
            this.cADASTROSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1423, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cONTRATOSToolStripMenuItem
            // 
            this.cONTRATOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cADASTRARToolStripMenuItem,
            this.lISTARToolStripMenuItem});
            this.cONTRATOSToolStripMenuItem.Name = "cONTRATOSToolStripMenuItem";
            this.cONTRATOSToolStripMenuItem.Size = new System.Drawing.Size(226, 29);
            this.cONTRATOSToolStripMenuItem.Text = "GESTÃO DE CONTRATOS";
            this.cONTRATOSToolStripMenuItem.Click += new System.EventHandler(this.cONTRATOSToolStripMenuItem_Click);
            // 
            // cADASTRARToolStripMenuItem
            // 
            this.cADASTRARToolStripMenuItem.Name = "cADASTRARToolStripMenuItem";
            this.cADASTRARToolStripMenuItem.Size = new System.Drawing.Size(215, 34);
            this.cADASTRARToolStripMenuItem.Text = "CADASTRAR";
            this.cADASTRARToolStripMenuItem.Click += new System.EventHandler(this.cADASTRARToolStripMenuItem_Click);
            // 
            // lISTARToolStripMenuItem
            // 
            this.lISTARToolStripMenuItem.Name = "lISTARToolStripMenuItem";
            this.lISTARToolStripMenuItem.Size = new System.Drawing.Size(215, 34);
            this.lISTARToolStripMenuItem.Text = "LISTAR";
            this.lISTARToolStripMenuItem.Click += new System.EventHandler(this.lISTARToolStripMenuItem_Click);
            // 
            // cADASTROSToolStripMenuItem
            // 
            this.cADASTROSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pARCEIROSToolStripMenuItem});
            this.cADASTROSToolStripMenuItem.Name = "cADASTROSToolStripMenuItem";
            this.cADASTROSToolStripMenuItem.Size = new System.Drawing.Size(130, 29);
            this.cADASTROSToolStripMenuItem.Text = "CADASTROS";
            // 
            // pARCEIROSToolStripMenuItem
            // 
            this.pARCEIROSToolStripMenuItem.Name = "pARCEIROSToolStripMenuItem";
            this.pARCEIROSToolStripMenuItem.Size = new System.Drawing.Size(206, 34);
            this.pARCEIROSToolStripMenuItem.Text = "PARCEIROS";
            this.pARCEIROSToolStripMenuItem.Click += new System.EventHandler(this.pARCEIROSToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 781);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "DASH CONTRATOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cONTRATOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cADASTRARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lISTARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cADASTROSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pARCEIROSToolStripMenuItem;
    }
}