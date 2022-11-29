namespace Farmacia
{
    partial class frmUsuario
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
            this.gbGrupo = new System.Windows.Forms.GroupBox();
            this.btEditar = new System.Windows.Forms.Button();
            this.btConsultar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btNovo = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btGravar = new System.Windows.Forms.Button();
            this.gbGrupo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGrupo
            // 
            this.gbGrupo.Controls.Add(this.btEditar);
            this.gbGrupo.Controls.Add(this.btConsultar);
            this.gbGrupo.Controls.Add(this.txtSenha);
            this.gbGrupo.Controls.Add(this.label3);
            this.gbGrupo.Controls.Add(this.label2);
            this.gbGrupo.Controls.Add(this.txtNome);
            this.gbGrupo.Controls.Add(this.txtUsuario);
            this.gbGrupo.Controls.Add(this.label1);
            this.gbGrupo.Controls.Add(this.txtCodigo);
            this.gbGrupo.Controls.Add(this.label18);
            this.gbGrupo.Location = new System.Drawing.Point(13, 13);
            this.gbGrupo.Name = "gbGrupo";
            this.gbGrupo.Size = new System.Drawing.Size(453, 144);
            this.gbGrupo.TabIndex = 0;
            this.gbGrupo.TabStop = false;
            // 
            // btEditar
            // 
            this.btEditar.Enabled = false;
            this.btEditar.Image = global::Farmacia.Properties.Resources.PhotoshopSZ;
            this.btEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEditar.Location = new System.Drawing.Point(298, 9);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(110, 44);
            this.btEditar.TabIndex = 2;
            this.btEditar.Text = "      Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btConsultar
            // 
            this.btConsultar.Image = global::Farmacia.Properties.Resources.procura;
            this.btConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btConsultar.Location = new System.Drawing.Point(181, 9);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(110, 44);
            this.btConsultar.TabIndex = 1;
            this.btConsultar.Text = "         Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Enabled = false;
            this.txtSenha.Location = new System.Drawing.Point(76, 112);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenha.MaxLength = 6;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(372, 23);
            this.txtSenha.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 42;
            this.label3.Text = "Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 41;
            this.label2.Text = "Usuario:";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(76, 58);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(372, 23);
            this.txtNome.TabIndex = 3;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(76, 85);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(372, 23);
            this.txtUsuario.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 38;
            this.label1.Text = "Nome:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(76, 30);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(88, 23);
            this.txtCodigo.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(23, 33);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 15);
            this.label18.TabIndex = 37;
            this.label18.Text = "Código:";
            // 
            // btNovo
            // 
            this.btNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btNovo.Image = global::Farmacia.Properties.Resources.edit_add;
            this.btNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNovo.Location = new System.Drawing.Point(12, 163);
            this.btNovo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(110, 44);
            this.btNovo.TabIndex = 4;
            this.btNovo.Text = "Novo         ";
            this.btNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Image = global::Farmacia.Properties.Resources.edit_remove;
            this.btCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCancelar.Location = new System.Drawing.Point(128, 163);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(110, 44);
            this.btCancelar.TabIndex = 2;
            this.btCancelar.Text = "Cancelar    ";
            this.btCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Enabled = false;
            this.btExcluir.Image = global::Farmacia.Properties.Resources.button_cancel;
            this.btExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExcluir.Location = new System.Drawing.Point(242, 163);
            this.btExcluir.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(110, 44);
            this.btExcluir.TabIndex = 3;
            this.btExcluir.Text = "Excluir      ";
            this.btExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btGravar
            // 
            this.btGravar.Enabled = false;
            this.btGravar.Image = global::Farmacia.Properties.Resources.apply;
            this.btGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGravar.Location = new System.Drawing.Point(356, 163);
            this.btGravar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(110, 44);
            this.btGravar.TabIndex = 1;
            this.btGravar.Text = "Gravar      ";
            this.btGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btGravar.UseVisualStyleBackColor = true;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // frmUsuario
            // 
            this.AcceptButton = this.btConsultar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.CancelButton = this.btCancelar;
            this.ClientSize = new System.Drawing.Size(478, 216);
            this.Controls.Add(this.gbGrupo);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btGravar);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmUsuario";
            this.Text = "Usuario";
            this.gbGrupo.ResumeLayout(false);
            this.gbGrupo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.GroupBox gbGrupo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Button btEditar;
    }
}