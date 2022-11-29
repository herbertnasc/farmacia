using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class frmFornecedor : Form
    {
        private bool novoFornecedor = false;

        public frmFornecedor()
        {
            InitializeComponent();
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            classFornecedor dbGrava = new classFornecedor();
            if (novoFornecedor)
            {
                dbGrava.GravarFornecedor(txtCodigo.Text, txtCNPJ.Text, txtRS.Text, txtLogradouro.Text, txtNumero.Text, txtCompl.Text, txtBairro.Text, txtCep.Text, txtCidade.Text, txtUF.Text, txtEmail.Text, txtContato.Text, txtTel1.Text, txtTel2.Text, txtTel3.Text, txtObs.Text);
                MessageBox.Show("Fornecedor cadastrado com sucesso", "Cadastro Fornecedor");
                LimpaCampos();
                HabiDesabi(false);
                txtCodigo.Enabled = true;
                novoFornecedor = false;
            }
            else
            {
                dbGrava.AtuaFornecedor(txtCodigo.Text, txtCNPJ.Text, txtRS.Text, txtLogradouro.Text, txtNumero.Text, txtCompl.Text, txtBairro.Text, txtCep.Text, txtCidade.Text, txtUF.Text, txtEmail.Text, txtContato.Text, txtTel1.Text, txtTel2.Text, txtTel3.Text, txtObs.Text);
                MessageBox.Show("Fornecedor atualizado com sucesso", "Cadastro Fornecedor");
                LimpaCampos();
                HabiDesabi(false);
                txtCodigo.Enabled = true;
                novoFornecedor = false;
            }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            novoFornecedor = true;
            HabiDesabi(true);
            LimpaCampos();
            txtCodigo.Enabled = true;
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            if (!novoFornecedor)
            {      
                classFornecedor dbVerFornecedor = new classFornecedor();
                if (dbVerFornecedor.VerCodFornecedor(txtCodigo.Text))
                {
                    DataSet dsFornecedor = new DataSet();

                    dsFornecedor = dbVerFornecedor.LerFornecedor(txtCodigo.Text);

                    txtCNPJ.Text = Convert.ToString(dsFornecedor.Tables[0].Rows[0][1]);
                    txtRS.Text = Convert.ToString(dsFornecedor.Tables[0].Rows[0][2]);
                    txtLogradouro.Text = Convert.ToString(dsFornecedor.Tables[0].Rows[0][3]);
                    txtNumero.Text = Convert.ToString(dsFornecedor.Tables[0].Rows[0][4]);
                    txtCompl.Text = Convert.ToString(dsFornecedor.Tables[0].Rows[0][5]);
                    txtBairro.Text = Convert.ToString(dsFornecedor.Tables[0].Rows[0][6]);
                    txtCep.Text = Convert.ToString(dsFornecedor.Tables[0].Rows[0][7]);
                    txtCidade.Text = Convert.ToString(dsFornecedor.Tables[0].Rows[0][8]);
                    txtUF.Text = Convert.ToString(dsFornecedor.Tables[0].Rows[0][9]);
                    txtEmail.Text = Convert.ToString(dsFornecedor.Tables[0].Rows[0][10]);
                    txtContato.Text = Convert.ToString(dsFornecedor.Tables[0].Rows[0][11]);
                    txtTel1.Text = Convert.ToString(dsFornecedor.Tables[0].Rows[0][12]);
                    txtTel2.Text = Convert.ToString(dsFornecedor.Tables[0].Rows[0][13]);
                    txtTel3.Text = Convert.ToString(dsFornecedor.Tables[0].Rows[0][14]);
                    txtObs.Text = Convert.ToString(dsFornecedor.Tables[0].Rows[0][15]);
                    btEditar.Enabled = true;
                }

                else
                {
                    MessageBox.Show("Código do Fornecedor informada não está na base de Bados", "Verifica Código do Fornecedor");
                    LimpaCampos();
                }
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            classFornecedor dbExclui = new classFornecedor();
            dbExclui.ExcluFornecedor(txtCodigo.Text);
            LimpaCampos();
            HabiDesabi(false);
            txtCodigo.Enabled = true;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            HabiDesabi(true);
            novoFornecedor = false;
            txtCodigo.Enabled = false;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            HabiDesabi(false);
            novoFornecedor = false;
            txtCodigo.Enabled = true;
        }
        private void LimpaCampos()
        {
            txtCodigo.Focus();
            txtCodigo.Clear();
            txtCNPJ.Clear();
            txtRS.Clear();
            txtLogradouro.Clear();
            txtNumero.Clear();
            txtCompl.Clear();
            txtBairro.Clear();
            txtCep.Clear();
            txtCidade.Clear();
            txtUF.Clear();
            txtEmail.Clear();
            txtContato.Clear();
            txtTel1.Clear();
            txtTel2.Clear();
            txtTel3.Clear();
            txtObs.Clear();
        }

        private void HabiDesabi(bool flag)
        {
            txtRS.Enabled = flag;
            txtLogradouro.Enabled = flag;
            txtNumero.Enabled = flag;
            txtCompl.Enabled = flag;
            txtBairro.Enabled = flag;
            txtCep.Enabled = flag;
            txtCidade.Enabled = flag;
            txtUF.Enabled = flag;
            txtEmail.Enabled = flag;
            txtContato.Enabled = flag;
            txtTel1.Enabled = flag;
            txtTel2.Enabled = flag;
            txtTel3.Enabled = flag;
            txtObs.Enabled = flag;
            btEditar.Enabled = flag;
            btExcluir.Enabled = flag;
            btGravar.Enabled = flag;
        }
    }
}
