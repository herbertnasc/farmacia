using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Farmacia
{
    public partial class frmMovimento : Form
    {
        private bool novoMovimento = false;
        private string strMedicamento;
        private string strUsuario;
        private int qtd;
        private int txtqtd;
      
        public frmMovimento()
        {
            InitializeComponent();
            cnBanco = new SqlConnection(strCnxBD);
        }

        private string strCnxBD = @"Data Source=.\SQLEXPRESS;AttachDbFilename=J:\Farmacia\Farmacia\bd_farmacia.mdf;Integrated Security=True;User Instance=True";
        private SqlConnection cnBanco;

        public string LerMedicamento()
        {
            DataSet dtMedicamento = new DataSet();
            string sSQLMedicamento = "SELECT descricao, datacompra FROM tb_medicamentos WHERE cd_medicamento = '" + txtCodMedica.Text + "';";
            try
            {
                SqlDataAdapter daMedicamento = new SqlDataAdapter(sSQLMedicamento, cnBanco);
                daMedicamento.Fill(dtMedicamento, "tb_medicamentos");
                cnBanco.Close();
                strMedicamento = Convert.ToString(dtMedicamento.Tables[0].Rows[0][0]);
                txtDatacompra.Text = Convert.ToString(dtMedicamento.Tables[0].Rows[0][1]);
            }
            catch (Exception)
            {
                MessageBox.Show("Código do Medicamento informado não está na base de Bados", "Verifica Medicamento do Fornecedor");
            }
            return strMedicamento;
        }

        public string LerUsuario()
        {
            DataSet dtUsuario = new DataSet();
            string sSQLUsuario = "SELECT nome FROM tb_usuarios WHERE cd_user = '" + txtCodUsuario.Text + "';";
            try
            {
                SqlDataAdapter daUsuario = new SqlDataAdapter(sSQLUsuario, cnBanco);
                daUsuario.Fill(dtUsuario, "tb_medicamentos");
                cnBanco.Close();
                strUsuario = Convert.ToString(dtUsuario.Tables[0].Rows[0][0]);
            }
            catch (Exception)
            {
                MessageBox.Show("Código do Usuario informado não está na base de Bados", "Verifica Medicamento do Usuario");
            }
            return strUsuario;
        }

        public int lerQtd()
        {
            DataSet dtQtd = new DataSet();
            string sSQLQtd = "SELECT qtd FROM tb_medicamentos WHERE cd_medicamento = '"+ txtCodMedica.Text +"';";
            try
            {
                SqlDataAdapter daQtd = new SqlDataAdapter(sSQLQtd, cnBanco);
                daQtd.Fill(dtQtd, "tb_medicamentos");
                cnBanco.Close();
                qtd = Convert.ToInt32(dtQtd.Tables[0].Rows[0]["qtd"]);
            }
            catch (Exception)
            { }
            return qtd;
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            classMovimento dbGrava = new classMovimento();
            classMedicamento dbmed = new classMedicamento();

            if (novoMovimento)
            {
                txtqtd = Convert.ToInt32(txtQuantidade.Text);
                if (cbxTipo.Text.Equals("Saida"))
                {                    
                    lerQtd();
                    if (qtd >= txtqtd)
                    {
                        dbGrava.GravarMovimento(txtCodigo.Text, txtData.Text, txtHora.Text, cbxTipo.Text, txtQuantidade.Text, txtValorcompra.Text, txtDatacompra.Text, Convert.ToInt32(txtCodMedica.Text), Convert.ToInt32(txtCodUsuario.Text));
                        dbmed.AtuaMedQtd(txtCodMedica.Text, txtqtd, cbxTipo.Text);
                        MessageBox.Show("Movimento cadastrado com sucesso", "Cadastro Movimento");
                        LimpaCampos();
                        HabiDesabi(false);
                        txtCodigo.Enabled = true;
                        novoMovimento = false;
                    }

                    else if (qtd < txtqtd)
                    {
                        MessageBox.Show("Quantidade insuficiente!");
                    }
                }

                else if (cbxTipo.Text.Equals("Entrada"))
                {
                    dbGrava.GravarMovimento(txtCodigo.Text, txtData.Text, txtHora.Text, cbxTipo.Text, txtQuantidade.Text, txtValorcompra.Text, txtDatacompra.Text, Convert.ToInt32(txtCodMedica.Text), Convert.ToInt32(txtCodUsuario.Text));
                    dbmed.AtuaMedQtd(txtCodMedica.Text, txtqtd, cbxTipo.Text);
                    MessageBox.Show("Movimento cadastrado com sucesso", "Cadastro Movimento");
                    LimpaCampos();
                    HabiDesabi(false);
                    txtCodigo.Enabled = true;
                    novoMovimento = false;
                }
            }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            novoMovimento = true;
            HabiDesabi(true);
            LimpaCampos();
            txtCodigo.Enabled = true;
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            if (!novoMovimento)
            {   
                classMovimento dbVerMovimeto = new classMovimento();
                if (dbVerMovimeto.VerCodMovimento(txtCodigo.Text))
                {
                    DataSet dsMovimento = new DataSet();

                    dsMovimento = dbVerMovimeto.LerMovimento(txtCodigo.Text);

                    txtData.Text = Convert.ToString(dsMovimento.Tables[0].Rows[0]["data"]);
                    txtHora.Text = Convert.ToString(dsMovimento.Tables[0].Rows[0]["hora"]);
                    cbxTipo.Text = Convert.ToString(dsMovimento.Tables[0].Rows[0]["tipo"]);
                    txtQuantidade.Text = Convert.ToString(dsMovimento.Tables[0].Rows[0]["qtd"]);
                    txtValorcompra.Text = Convert.ToString(dsMovimento.Tables[0].Rows[0]["valorcompra"]);
                    txtDatacompra.Text = Convert.ToString(dsMovimento.Tables[0].Rows[0]["datacompra"]);
                    txtCodMedica.Text = Convert.ToString(dsMovimento.Tables[0].Rows[0]["cd_medicamento"]);
                    txtCodUsuario.Text = Convert.ToString(dsMovimento.Tables[0].Rows[0]["cd_user"]);
                    txtMedicamento.Text = LerMedicamento();
                    txtUsuario.Text = LerUsuario();
                    btEditar.Enabled = true;
                }

                else
                {
                    MessageBox.Show("Código do movimento informada não está na base de Bados", "Verifica Código do movimento");
                    LimpaCampos();
                }
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            HabiDesabi(true);
            novoMovimento = false;
            txtCodigo.Enabled = false;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            HabiDesabi(false);
            novoMovimento = false;
            txtCodigo.Enabled = true;
        }

        private void LimpaCampos()
        {
            txtCodigo.Focus();
            txtCodigo.Clear();
            txtData.Clear();
            txtCodMedica.Clear();
            txtCodUsuario.Clear();
            txtDatacompra.Clear();
            txtHora.Clear();
            txtMedicamento.Clear();
            txtQuantidade.Clear();
            txtUsuario.Clear();
            txtValorcompra.Clear();
            cbxTipo.ResetText();
        }

        private void HabiDesabi(bool flag)
        {
            txtCodMedica.Enabled = flag;
            txtCodUsuario.Enabled = flag;
            txtData.Enabled = flag;
            txtDatacompra.Enabled = flag;
            txtHora.Enabled = flag;
            txtQuantidade.Enabled = flag;
            txtValorcompra.Enabled = flag;
            cbxTipo.Enabled = flag;
            btGravar.Enabled = flag;
        }

        private void txtCodMedica_Leave(object sender, EventArgs e)
        {
            txtMedicamento.Text = LerMedicamento();
        }

        private void txtCodUsuario_Leave(object sender, EventArgs e)
        {
            txtUsuario.Text = LerUsuario();
        }

        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (novoMovimento)
            {
                if (cbxTipo.Text.Equals("Entrada"))
                {
                    txtDatacompra.Text = Convert.ToString(System.DateTime.Now.ToShortDateString());
                    txtHora.Text = Convert.ToString(System.DateTime.Now.ToShortTimeString());
                }
                else if (cbxTipo.Text.Equals("Saida"))
                {
                    txtValorcompra.Enabled = false;
                    txtDatacompra.Enabled = false;
                    txtHora.Text = Convert.ToString(System.DateTime.Now.ToShortTimeString());
                    txtDatacompra.Clear();
                }
            }
        }
    }
}
