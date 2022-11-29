namespace Farmacia
{
    partial class frmMovimento
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
            this.btNovo = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btGravar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.gbMovimento = new System.Windows.Forms.GroupBox();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.btEditar = new System.Windows.Forms.Button();
            this.btConsultar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDatacompra = new System.Windows.Forms.TextBox();
            this.txtCodUsuario = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtCodMedica = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtValorcompra = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtMedicamento = new System.Windows.Forms.TextBox();
            this.gbMovimento.SuspendLayout();
            this.SuspendLayout();
            // 
            // btNovo
            // 
            this.btNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btNovo.Image = global::Farmacia.Properties.Resources.edit_add;
            this.btNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNovo.Location = new System.Drawing.Point(25, 287);
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
            this.btCancelar.Location = new System.Drawing.Point(141, 287);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(110, 44);
            this.btCancelar.TabIndex = 2;
            this.btCancelar.Text = "Cancelar    ";
            this.btCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btGravar
            // 
            this.btGravar.Enabled = false;
            this.btGravar.Image = global::Farmacia.Properties.Resources.apply;
            this.btGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGravar.Location = new System.Drawing.Point(369, 287);
            this.btGravar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(110, 44);
            this.btGravar.TabIndex = 1;
            this.btGravar.Text = "Gravar      ";
            this.btGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btGravar.UseVisualStyleBackColor = true;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Enabled = false;
            this.btExcluir.Image = global::Farmacia.Properties.Resources.button_cancel;
            this.btExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExcluir.Location = new System.Drawing.Point(255, 287);
            this.btExcluir.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(110, 44);
            this.btExcluir.TabIndex = 3;
            this.btExcluir.Text = "Excluir      ";
            this.btExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // gbMovimento
            // 
            this.gbMovimento.Controls.Add(this.cbxTipo);
            this.gbMovimento.Controls.Add(this.btEditar);
            this.gbMovimento.Controls.Add(this.btConsultar);
            this.gbMovimento.Controls.Add(this.label11);
            this.gbMovimento.Controls.Add(this.label10);
            this.gbMovimento.Controls.Add(this.label9);
            this.gbMovimento.Controls.Add(this.label8);
            this.gbMovimento.Controls.Add(this.label7);
            this.gbMovimento.Controls.Add(this.label6);
            this.gbMovimento.Controls.Add(this.label5);
            this.gbMovimento.Controls.Add(this.label4);
            this.gbMovimento.Controls.Add(this.label3);
            this.gbMovimento.Controls.Add(this.label2);
            this.gbMovimento.Controls.Add(this.label1);
            this.gbMovimento.Controls.Add(this.txtDatacompra);
            this.gbMovimento.Controls.Add(this.txtCodUsuario);
            this.gbMovimento.Controls.Add(this.txtUsuario);
            this.gbMovimento.Controls.Add(this.txtCodMedica);
            this.gbMovimento.Controls.Add(this.txtCodigo);
            this.gbMovimento.Controls.Add(this.txtValorcompra);
            this.gbMovimento.Controls.Add(this.txtHora);
            this.gbMovimento.Controls.Add(this.txtData);
            this.gbMovimento.Controls.Add(this.txtQuantidade);
            this.gbMovimento.Controls.Add(this.txtMedicamento);
            this.gbMovimento.Location = new System.Drawing.Point(13, 13);
            this.gbMovimento.Name = "gbMovimento";
            this.gbMovimento.Size = new System.Drawing.Size(479, 268);
            this.gbMovimento.TabIndex = 0;
            this.gbMovimento.TabStop = false;
            // 
            // cbxTipo
            // 
            this.cbxTipo.Enabled = false;
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Entrada",
            "Saida"});
            this.cbxTipo.Location = new System.Drawing.Point(274, 25);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(84, 23);
            this.cbxTipo.TabIndex = 25;
            this.cbxTipo.SelectedIndexChanged += new System.EventHandler(this.cbxTipo_SelectedIndexChanged);
            // 
            // btEditar
            // 
            this.btEditar.Enabled = false;
            this.btEditar.Image = global::Farmacia.Properties.Resources.PhotoshopSZ;
            this.btEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEditar.Location = new System.Drawing.Point(364, 63);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(110, 44);
            this.btEditar.TabIndex = 24;
            this.btEditar.Text = "      Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btConsultar
            // 
            this.btConsultar.Image = global::Farmacia.Properties.Resources.procura;
            this.btConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btConsultar.Location = new System.Drawing.Point(364, 13);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(110, 44);
            this.btConsultar.TabIndex = 23;
            this.btConsultar.Text = "         Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(76, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "Usuário:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Medicamento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Código Usuário:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Código Medicamento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(228, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Data da Compra:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Valor da Compra:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Quantidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Hora:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Data:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Código:";
            // 
            // txtDatacompra
            // 
            this.txtDatacompra.Enabled = false;
            this.txtDatacompra.Location = new System.Drawing.Point(333, 170);
            this.txtDatacompra.Name = "txtDatacompra";
            this.txtDatacompra.Size = new System.Drawing.Size(88, 23);
            this.txtDatacompra.TabIndex = 8;
            // 
            // txtCodUsuario
            // 
            this.txtCodUsuario.Enabled = false;
            this.txtCodUsuario.Location = new System.Drawing.Point(136, 199);
            this.txtCodUsuario.Name = "txtCodUsuario";
            this.txtCodUsuario.Size = new System.Drawing.Size(88, 23);
            this.txtCodUsuario.TabIndex = 9;
            this.txtCodUsuario.Leave += new System.EventHandler(this.txtCodUsuario_Leave);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(136, 228);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(285, 23);
            this.txtUsuario.TabIndex = 10;
            // 
            // txtCodMedica
            // 
            this.txtCodMedica.Enabled = false;
            this.txtCodMedica.Location = new System.Drawing.Point(136, 54);
            this.txtCodMedica.Name = "txtCodMedica";
            this.txtCodMedica.Size = new System.Drawing.Size(88, 23);
            this.txtCodMedica.TabIndex = 2;
            this.txtCodMedica.Leave += new System.EventHandler(this.txtCodMedica_Leave);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(136, 25);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(88, 23);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtValorcompra
            // 
            this.txtValorcompra.Enabled = false;
            this.txtValorcompra.Location = new System.Drawing.Point(136, 170);
            this.txtValorcompra.Name = "txtValorcompra";
            this.txtValorcompra.Size = new System.Drawing.Size(88, 23);
            this.txtValorcompra.TabIndex = 7;
            // 
            // txtHora
            // 
            this.txtHora.Enabled = false;
            this.txtHora.Location = new System.Drawing.Point(333, 141);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(88, 23);
            this.txtHora.TabIndex = 6;
            // 
            // txtData
            // 
            this.txtData.Enabled = false;
            this.txtData.Location = new System.Drawing.Point(136, 141);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(88, 23);
            this.txtData.TabIndex = 5;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Enabled = false;
            this.txtQuantidade.Location = new System.Drawing.Point(136, 112);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(88, 23);
            this.txtQuantidade.TabIndex = 4;
            // 
            // txtMedicamento
            // 
            this.txtMedicamento.Enabled = false;
            this.txtMedicamento.Location = new System.Drawing.Point(136, 83);
            this.txtMedicamento.Name = "txtMedicamento";
            this.txtMedicamento.Size = new System.Drawing.Size(222, 23);
            this.txtMedicamento.TabIndex = 3;
            // 
            // frmMovimento
            // 
            this.AcceptButton = this.btConsultar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.CancelButton = this.btCancelar;
            this.ClientSize = new System.Drawing.Size(504, 337);
            this.Controls.Add(this.gbMovimento);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.btExcluir);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmMovimento";
            this.ShowIcon = false;
            this.Text = "Movimento";
            this.gbMovimento.ResumeLayout(false);
            this.gbMovimento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.GroupBox gbMovimento;
        private System.Windows.Forms.TextBox txtDatacompra;
        private System.Windows.Forms.TextBox txtCodUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtCodMedica;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtValorcompra;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtMedicamento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.ComboBox cbxTipo;
    }
}