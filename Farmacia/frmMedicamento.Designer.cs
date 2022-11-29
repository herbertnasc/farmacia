namespace Farmacia
{
    partial class frmMedicamento
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDescri = new System.Windows.Forms.TextBox();
            this.txtApresen = new System.Windows.Forms.TextBox();
            this.txtGenerico = new System.Windows.Forms.TextBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.txtEstoqmin = new System.Windows.Forms.TextBox();
            this.txtValorcompra = new System.Windows.Forms.TextBox();
            this.txtDatacompra = new System.Windows.Forms.TextBox();
            this.txtDatacad = new System.Windows.Forms.TextBox();
            this.txtCodfornec = new System.Windows.Forms.TextBox();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.cbxGrupo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gbMedicamento = new System.Windows.Forms.GroupBox();
            this.lbCdGrupo = new System.Windows.Forms.Label();
            this.btEditar = new System.Windows.Forms.Button();
            this.btConsultar = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btGravar = new System.Windows.Forms.Button();
            this.gbMedicamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(137, 29);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(118, 23);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtDescri
            // 
            this.txtDescri.Enabled = false;
            this.txtDescri.Location = new System.Drawing.Point(137, 58);
            this.txtDescri.Name = "txtDescri";
            this.txtDescri.Size = new System.Drawing.Size(356, 23);
            this.txtDescri.TabIndex = 2;
            // 
            // txtApresen
            // 
            this.txtApresen.Enabled = false;
            this.txtApresen.Location = new System.Drawing.Point(137, 87);
            this.txtApresen.Name = "txtApresen";
            this.txtApresen.Size = new System.Drawing.Size(356, 23);
            this.txtApresen.TabIndex = 3;
            // 
            // txtGenerico
            // 
            this.txtGenerico.Enabled = false;
            this.txtGenerico.Location = new System.Drawing.Point(137, 116);
            this.txtGenerico.Name = "txtGenerico";
            this.txtGenerico.Size = new System.Drawing.Size(356, 23);
            this.txtGenerico.TabIndex = 4;
            // 
            // txtQtd
            // 
            this.txtQtd.Enabled = false;
            this.txtQtd.Location = new System.Drawing.Point(137, 145);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(118, 23);
            this.txtQtd.TabIndex = 5;
            // 
            // txtEstoqmin
            // 
            this.txtEstoqmin.Enabled = false;
            this.txtEstoqmin.Location = new System.Drawing.Point(375, 145);
            this.txtEstoqmin.Name = "txtEstoqmin";
            this.txtEstoqmin.Size = new System.Drawing.Size(118, 23);
            this.txtEstoqmin.TabIndex = 6;
            // 
            // txtValorcompra
            // 
            this.txtValorcompra.Enabled = false;
            this.txtValorcompra.Location = new System.Drawing.Point(137, 174);
            this.txtValorcompra.Name = "txtValorcompra";
            this.txtValorcompra.Size = new System.Drawing.Size(118, 23);
            this.txtValorcompra.TabIndex = 7;
            // 
            // txtDatacompra
            // 
            this.txtDatacompra.Enabled = false;
            this.txtDatacompra.Location = new System.Drawing.Point(375, 174);
            this.txtDatacompra.Name = "txtDatacompra";
            this.txtDatacompra.Size = new System.Drawing.Size(118, 23);
            this.txtDatacompra.TabIndex = 8;
            // 
            // txtDatacad
            // 
            this.txtDatacad.Enabled = false;
            this.txtDatacad.Location = new System.Drawing.Point(137, 203);
            this.txtDatacad.Name = "txtDatacad";
            this.txtDatacad.Size = new System.Drawing.Size(118, 23);
            this.txtDatacad.TabIndex = 9;
            // 
            // txtCodfornec
            // 
            this.txtCodfornec.Enabled = false;
            this.txtCodfornec.Location = new System.Drawing.Point(137, 232);
            this.txtCodfornec.Name = "txtCodfornec";
            this.txtCodfornec.Size = new System.Drawing.Size(118, 23);
            this.txtCodfornec.TabIndex = 10;
            this.txtCodfornec.Leave += new System.EventHandler(this.txtCodfornec_Leave);
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Enabled = false;
            this.txtFornecedor.Location = new System.Drawing.Point(137, 261);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(356, 23);
            this.txtFornecedor.TabIndex = 11;
            // 
            // cbxGrupo
            // 
            this.cbxGrupo.Enabled = false;
            this.cbxGrupo.FormattingEnabled = true;
            this.cbxGrupo.Location = new System.Drawing.Point(137, 290);
            this.cbxGrupo.Name = "cbxGrupo";
            this.cbxGrupo.Size = new System.Drawing.Size(356, 23);
            this.cbxGrupo.TabIndex = 12;
            this.cbxGrupo.SelectedIndexChanged += new System.EventHandler(this.cbxGrupo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Descrição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Data do Cadastro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Genérico:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Apresentação:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Grupo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 27;
            this.label7.Text = "Quantidade:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(266, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 15);
            this.label8.TabIndex = 28;
            this.label8.Text = "Data da Compra:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 15);
            this.label9.TabIndex = 29;
            this.label9.Text = "Fornecedor:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 15);
            this.label10.TabIndex = 30;
            this.label10.Text = "Código do Fornecedor:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 15);
            this.label11.TabIndex = 31;
            this.label11.Text = "Valor Compra:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(267, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 15);
            this.label12.TabIndex = 32;
            this.label12.Text = "Estoque Mínimo:";
            // 
            // gbMedicamento
            // 
            this.gbMedicamento.Controls.Add(this.lbCdGrupo);
            this.gbMedicamento.Controls.Add(this.btEditar);
            this.gbMedicamento.Controls.Add(this.btConsultar);
            this.gbMedicamento.Controls.Add(this.label1);
            this.gbMedicamento.Controls.Add(this.label12);
            this.gbMedicamento.Controls.Add(this.txtCodigo);
            this.gbMedicamento.Controls.Add(this.label11);
            this.gbMedicamento.Controls.Add(this.txtDescri);
            this.gbMedicamento.Controls.Add(this.label10);
            this.gbMedicamento.Controls.Add(this.txtApresen);
            this.gbMedicamento.Controls.Add(this.label9);
            this.gbMedicamento.Controls.Add(this.txtGenerico);
            this.gbMedicamento.Controls.Add(this.label8);
            this.gbMedicamento.Controls.Add(this.txtQtd);
            this.gbMedicamento.Controls.Add(this.label7);
            this.gbMedicamento.Controls.Add(this.txtEstoqmin);
            this.gbMedicamento.Controls.Add(this.label6);
            this.gbMedicamento.Controls.Add(this.txtValorcompra);
            this.gbMedicamento.Controls.Add(this.label5);
            this.gbMedicamento.Controls.Add(this.txtDatacompra);
            this.gbMedicamento.Controls.Add(this.label4);
            this.gbMedicamento.Controls.Add(this.txtDatacad);
            this.gbMedicamento.Controls.Add(this.label3);
            this.gbMedicamento.Controls.Add(this.txtCodfornec);
            this.gbMedicamento.Controls.Add(this.label2);
            this.gbMedicamento.Controls.Add(this.txtFornecedor);
            this.gbMedicamento.Controls.Add(this.cbxGrupo);
            this.gbMedicamento.Location = new System.Drawing.Point(12, 13);
            this.gbMedicamento.Name = "gbMedicamento";
            this.gbMedicamento.Size = new System.Drawing.Size(503, 319);
            this.gbMedicamento.TabIndex = 0;
            this.gbMedicamento.TabStop = false;
            // 
            // lbCdGrupo
            // 
            this.lbCdGrupo.AutoSize = true;
            this.lbCdGrupo.Location = new System.Drawing.Point(375, 235);
            this.lbCdGrupo.Name = "lbCdGrupo";
            this.lbCdGrupo.Size = new System.Drawing.Size(49, 15);
            this.lbCdGrupo.TabIndex = 45;
            this.lbCdGrupo.Text = "label13";
            this.lbCdGrupo.Visible = false;
            // 
            // btEditar
            // 
            this.btEditar.Enabled = false;
            this.btEditar.Image = global::Farmacia.Properties.Resources.PhotoshopSZ;
            this.btEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEditar.Location = new System.Drawing.Point(385, 10);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(110, 44);
            this.btEditar.TabIndex = 37;
            this.btEditar.Text = "      Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btConsultar
            // 
            this.btConsultar.Image = global::Farmacia.Properties.Resources.procura;
            this.btConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btConsultar.Location = new System.Drawing.Point(269, 10);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(110, 44);
            this.btConsultar.TabIndex = 44;
            this.btConsultar.Text = "         Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // btNovo
            // 
            this.btNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btNovo.Image = global::Farmacia.Properties.Resources.edit_add;
            this.btNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNovo.Location = new System.Drawing.Point(62, 337);
            this.btNovo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(110, 44);
            this.btNovo.TabIndex = 36;
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
            this.btCancelar.Location = new System.Drawing.Point(178, 337);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(110, 44);
            this.btCancelar.TabIndex = 34;
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
            this.btExcluir.Location = new System.Drawing.Point(292, 337);
            this.btExcluir.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(110, 44);
            this.btExcluir.TabIndex = 35;
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
            this.btGravar.Location = new System.Drawing.Point(406, 337);
            this.btGravar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(110, 44);
            this.btGravar.TabIndex = 33;
            this.btGravar.Text = "Gravar      ";
            this.btGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btGravar.UseVisualStyleBackColor = true;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // frmMedicamento
            // 
            this.AcceptButton = this.btConsultar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.CancelButton = this.btCancelar;
            this.ClientSize = new System.Drawing.Size(527, 393);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.gbMedicamento);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.btExcluir);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmMedicamento";
            this.Text = "Medicamento";
            this.Load += new System.EventHandler(this.frmMedicamento_Load);
            this.gbMedicamento.ResumeLayout(false);
            this.gbMedicamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDescri;
        private System.Windows.Forms.TextBox txtApresen;
        private System.Windows.Forms.TextBox txtGenerico;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.TextBox txtEstoqmin;
        private System.Windows.Forms.TextBox txtValorcompra;
        private System.Windows.Forms.TextBox txtDatacompra;
        private System.Windows.Forms.TextBox txtDatacad;
        private System.Windows.Forms.TextBox txtCodfornec;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.ComboBox cbxGrupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox gbMedicamento;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Label lbCdGrupo;
    }
}