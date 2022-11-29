namespace Farmacia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMedicamento = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEmpresa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGrupo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMovimentacao = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logofToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cascataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizantalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.fecharTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.menuMovimentacao,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.sobreToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1018, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMedicamento,
            this.menuEmpresa,
            this.menuFornecedor,
            this.menuGrupo,
            this.menuUsuario,
            this.toolStripSeparator1,
            this.menuSair});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // menuMedicamento
            // 
            this.menuMedicamento.Name = "menuMedicamento";
            this.menuMedicamento.Size = new System.Drawing.Size(156, 22);
            this.menuMedicamento.Text = "Medicamento";
            this.menuMedicamento.Click += new System.EventHandler(this.menuMedicamento_Click);
            // 
            // menuEmpresa
            // 
            this.menuEmpresa.Name = "menuEmpresa";
            this.menuEmpresa.Size = new System.Drawing.Size(156, 22);
            this.menuEmpresa.Text = "Empresa";
            this.menuEmpresa.Click += new System.EventHandler(this.menuEmpresa_Click);
            // 
            // menuFornecedor
            // 
            this.menuFornecedor.Name = "menuFornecedor";
            this.menuFornecedor.Size = new System.Drawing.Size(156, 22);
            this.menuFornecedor.Text = "Fornecedor";
            this.menuFornecedor.Click += new System.EventHandler(this.menuFornecedor_Click);
            // 
            // menuGrupo
            // 
            this.menuGrupo.Name = "menuGrupo";
            this.menuGrupo.Size = new System.Drawing.Size(156, 22);
            this.menuGrupo.Text = "Grupo";
            this.menuGrupo.Click += new System.EventHandler(this.menuGrupo_Click);
            // 
            // menuUsuario
            // 
            this.menuUsuario.Name = "menuUsuario";
            this.menuUsuario.Size = new System.Drawing.Size(156, 22);
            this.menuUsuario.Text = "Usuario";
            this.menuUsuario.Click += new System.EventHandler(this.menuUsuario_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(153, 6);
            // 
            // menuSair
            // 
            this.menuSair.Name = "menuSair";
            this.menuSair.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuSair.Size = new System.Drawing.Size(156, 22);
            this.menuSair.Text = "Sair";
            this.menuSair.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // menuMovimentacao
            // 
            this.menuMovimentacao.Name = "menuMovimentacao";
            this.menuMovimentacao.Size = new System.Drawing.Size(99, 20);
            this.menuMovimentacao.Text = "Movimentação";
            this.menuMovimentacao.Click += new System.EventHandler(this.menuMovimentacao_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logofToolStripMenuItem,
            this.toolStripSeparator2,
            this.cascataToolStripMenuItem,
            this.verticalToolStripMenuItem,
            this.horizantalToolStripMenuItem,
            this.toolStripSeparator3,
            this.fecharTodosToolStripMenuItem});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.sobreToolStripMenuItem.Text = "Janela";
            // 
            // logofToolStripMenuItem
            // 
            this.logofToolStripMenuItem.Name = "logofToolStripMenuItem";
            this.logofToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.logofToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.logofToolStripMenuItem.Text = "Logoff";
            this.logofToolStripMenuItem.Click += new System.EventHandler(this.logofToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(147, 6);
            // 
            // cascataToolStripMenuItem
            // 
            this.cascataToolStripMenuItem.Name = "cascataToolStripMenuItem";
            this.cascataToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.cascataToolStripMenuItem.Text = "Cascata";
            this.cascataToolStripMenuItem.Click += new System.EventHandler(this.cascataToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
            // 
            // horizantalToolStripMenuItem
            // 
            this.horizantalToolStripMenuItem.Name = "horizantalToolStripMenuItem";
            this.horizantalToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.horizantalToolStripMenuItem.Text = "Horizantal";
            this.horizantalToolStripMenuItem.Click += new System.EventHandler(this.horizantalToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(147, 6);
            // 
            // fecharTodosToolStripMenuItem
            // 
            this.fecharTodosToolStripMenuItem.Name = "fecharTodosToolStripMenuItem";
            this.fecharTodosToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.fecharTodosToolStripMenuItem.Text = "Fechar todos";
            this.fecharTodosToolStripMenuItem.Click += new System.EventHandler(this.fecharTodosToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 715);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1018, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stLabel
            // 
            this.stLabel.BackColor = System.Drawing.Color.Transparent;
            this.stLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stLabel.ForeColor = System.Drawing.Color.Black;
            this.stLabel.Name = "stLabel";
            this.stLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Farmacia.Properties.Resources.wpp16;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1018, 737);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Farmácia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuMedicamento;
        private System.Windows.Forms.ToolStripMenuItem menuEmpresa;
        private System.Windows.Forms.ToolStripMenuItem menuFornecedor;
        private System.Windows.Forms.ToolStripMenuItem menuGrupo;
        private System.Windows.Forms.ToolStripMenuItem menuUsuario;
        private System.Windows.Forms.ToolStripMenuItem menuMovimentacao;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharTodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cascataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizantalToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stLabel;
        private System.Windows.Forms.ToolStripMenuItem logofToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}