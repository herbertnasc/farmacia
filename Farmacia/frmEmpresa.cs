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
    public partial class frmEmpresa : Form
    {
        private bool novoEmpresa = false;
        
        public frmEmpresa()
        {
            InitializeComponent();
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            classEmpresa dbGrava = new classEmpresa();
            if (novoEmpresa)
            {
                dbGrava.GravarEmpresa(txtCodigo.Text, txtCNPJ.Text, txtRS.Text, txtLogradouro.Text, txtNumero.Text, txtCompl.Text, txtBairro.Text, txtCep.Text, txtCidade.Text, txtUF.Text, txtEmail.Text, txtSite.Text, txtTel1.Text, txtTel2.Text, txtTel3.Text, txtFarmaceutico.Text, txtCRF.Text, txtObs.Text);
                MessageBox.Show("Empresa cadastrado com sucesso", "Cadastro Empresa");
                LimpaCampos();
                HabiDesabi(false);
                txtCodigo.Enabled = true;
                novoEmpresa = false;
            }
            else
            {
                dbGrava.AtuaEmpresa(txtCodigo.Text, txtCNPJ.Text, txtRS.Text, txtLogradouro.Text, txtNumero.Text, txtCompl.Text, txtBairro.Text, txtCep.Text, txtCidade.Text, txtUF.Text, txtEmail.Text, txtSite.Text, txtTel1.Text, txtTel2.Text, txtTel3.Text, txtFarmaceutico.Text, txtCRF.Text, txtObs.Text);
                MessageBox.Show("Empresa atualizado com sucesso", "Cadastro Empresa");
                LimpaCampos();
                HabiDesabi(false);
                txtCodigo.Enabled = true;
                novoEmpresa = false;
            }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            novoEmpresa = true;
            HabiDesabi(true);
            LimpaCampos();
            txtCodigo.Enabled = true;
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            if (!novoEmpresa)
            {    
                classEmpresa dbVerEmpresa = new classEmpresa();
                if (dbVerEmpresa.VerCodEmpresa(txtCodigo.Text))
                {
                    DataSet dsEmpresa = new DataSet();

                    dsEmpresa = dbVerEmpresa.LerEmpresa(txtCodigo.Text);

                    txtCNPJ.Text         = Convert.ToString(dsEmpresa.Tables[0].Rows[0][1]);
                    txtRS.Text           = Convert.ToString(dsEmpresa.Tables[0].Rows[0][2]);
                    txtLogradouro.Text   = Convert.ToString(dsEmpresa.Tables[0].Rows[0][3]);
                    txtNumero.Text       = Convert.ToString(dsEmpresa.Tables[0].Rows[0][4]);
                    txtCompl.Text        = Convert.ToString(dsEmpresa.Tables[0].Rows[0][5]);
                    txtBairro.Text       = Convert.ToString(dsEmpresa.Tables[0].Rows[0][6]);
                    txtCep.Text          = Convert.ToString(dsEmpresa.Tables[0].Rows[0][7]);
                    txtCidade.Text       = Convert.ToString(dsEmpresa.Tables[0].Rows[0][8]);
                    txtUF.Text           = Convert.ToString(dsEmpresa.Tables[0].Rows[0][9]);
                    txtEmail.Text        = Convert.ToString(dsEmpresa.Tables[0].Rows[0][10]);
                    txtSite.Text         = Convert.ToString(dsEmpresa.Tables[0].Rows[0][11]);
                    txtTel1.Text         = Convert.ToString(dsEmpresa.Tables[0].Rows[0][12]);
                    txtTel2.Text         = Convert.ToString(dsEmpresa.Tables[0].Rows[0][13]);
                    txtTel3.Text         = Convert.ToString(dsEmpresa.Tables[0].Rows[0][14]);
                    txtFarmaceutico.Text = Convert.ToString(dsEmpresa.Tables[0].Rows[0][15]);
                    txtCRF.Text          = Convert.ToString(dsEmpresa.Tables[0].Rows[0][16]);
                    txtObs.Text          = Convert.ToString(dsEmpresa.Tables[0].Rows[0][17]);
                    btEditar.Enabled = true;
                }
                
                else
                {
                    MessageBox.Show("Código da empresa informada não está na base de Bados", "Verifica Código da Empresa");
                    LimpaCampos();
                }
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            classEmpresa dbExclui = new classEmpresa();
            dbExclui.ExcluEmpresa(txtCodigo.Text);
            LimpaCampos();
            HabiDesabi(false);
            txtCodigo.Enabled = true;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            HabiDesabi(true);
            novoEmpresa = false;
            txtCodigo.Enabled = false;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            HabiDesabi(false);
            novoEmpresa = false;
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
            txtSite.Clear();
            txtTel1.Clear();
            txtTel2.Clear();
            txtTel3.Clear();
            txtFarmaceutico.Clear();
            txtCRF.Clear();
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
            txtSite.Enabled = flag;
            txtTel1.Enabled = flag;
            txtTel2.Enabled = flag;
            txtTel3.Enabled = flag;
            txtFarmaceutico.Enabled = flag;
            txtCRF.Enabled = flag;
            txtObs.Enabled = flag;
            btEditar.Enabled = flag;
            btExcluir.Enabled = flag;
            btGravar.Enabled = flag;
        }
    }
}
