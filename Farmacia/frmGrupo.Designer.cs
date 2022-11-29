namespace Farmacia
{
    partial class frmGrupo
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
            this.label18 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.gbGrupo = new System.Windows.Forms.GroupBox();
            this.btEditar = new System.Windows.Forms.Button();
            this.btConsultar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btNovo = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btGravar = new System.Windows.Forms.Button();
            this.gbGrupo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(23, 34);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 15);
            this.label18.TabIndex = 37;
            this.label18.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(76, 31);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(88, 23);
            this.txtCodigo.TabIndex = 1;
            // 
            // gbGrupo
            // 
            this.gbGrupo.Controls.Add(this.btEditar);
            this.gbGrupo.Controls.Add(this.btConsultar);
            this.gbGrupo.Controls.Add(this.label2);
            this.gbGrupo.Controls.Add(this.txtNome);
            this.gbGrupo.Controls.Add(this.txtDescricao);
            this.gbGrupo.Controls.Add(this.label1);
            this.gbGrupo.Controls.Add(this.txtCodigo);
            this.gbGrupo.Controls.Add(this.label18);
            this.gbGrupo.Location = new System.Drawing.Point(13, 13);
            this.gbGrupo.Name = "gbGrupo";
            this.gbGrupo.Size = new System.Drawing.Size(453, 202);
            this.gbGrupo.TabIndex = 0;
            this.gbGrupo.TabStop = false;
            // 
            // btEditar
            // 
            this.btEditar.Enabled = false;
            this.btEditar.Image = global::Farmacia.Properties.Resources.PhotoshopSZ;
            this.btEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEditar.Location = new System.Drawing.Point(298, 10);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(110, 44);
            this.btEditar.TabIndex = 9;
            this.btEditar.Text = "      Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btConsultar
            // 
            this.btConsultar.Image = global::Farmacia.Properties.Resources.procura;
            this.btConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btConsultar.Location = new System.Drawing.Point(182, 9);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(110, 44);
            this.btConsultar.TabIndex = 44;
            this.btConsultar.Text = "         Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 41;
            this.label2.Text = "Descrição:";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(76, 58);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(372, 23);
            this.txtNome.TabIndex = 2;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Location = new System.Drawing.Point(76, 85);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(372, 108);
            this.txtDescricao.TabIndex = 3;
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
            // btNovo
            // 
            this.btNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btNovo.Image = global::Farmacia.Properties.Resources.edit_add;
            this.btNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNovo.Location = new System.Drawing.Point(13, 221);
            this.btNovo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(110, 44);
            this.btNovo.TabIndex = 8;
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
            this.btCancelar.Location = new System.Drawing.Point(129, 221);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(110, 44);
            this.btCancelar.TabIndex = 6;
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
            this.btExcluir.Location = new System.Drawing.Point(243, 221);
            this.btExcluir.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(110, 44);
            this.btExcluir.TabIndex = 7;
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
            this.btGravar.Location = new System.Drawing.Point(357, 221);
            this.btGravar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(110, 44);
            this.btGravar.TabIndex = 5;
            this.btGravar.Text = "Gravar      ";
            this.btGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btGravar.UseVisualStyleBackColor = true;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // frmGrupo
            // 
            this.AcceptButton = this.btConsultar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.CancelButton = this.btCancelar;
            this.ClientSize = new System.Drawing.Size(478, 276);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.gbGrupo);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmGrupo";
            this.Text = "Grupo";
            this.gbGrupo.ResumeLayout(false);
            this.gbGrupo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.GroupBox gbGrupo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Button btEditar;
    }
}