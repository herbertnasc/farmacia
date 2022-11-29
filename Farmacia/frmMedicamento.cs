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
    public partial class frmMedicamento : Form
    {
        private string strGrupo;
        private string strFornecedor;
        private bool novoMedicamento = false;
        private string iGrupo;
        private int i;
        private int numVendas = 0;
        
        
        public frmMedicamento()
        {
            InitializeComponent();
            cnBanco = new SqlConnection(strCnxBD);
        }

        private string strCnxBD = @"Data Source=.\SQLEXPRESS;AttachDbFilename=J:\Farmacia\Farmacia\bd_farmacia.mdf;Integrated Security=True;User Instance=True";
        private SqlConnection cnBanco;

        public string lbGrupo()
        {
            string sSQLlbGrupo = "SELECT cd_grupo FROM tb_grupos WHERE nome = '" + cbxGrupo.Text + "';";
            DataSet dtLBGrup = new DataSet();
            SqlDataAdapter daLbGrup = new SqlDataAdapter(sSQLlbGrupo, cnBanco);
            daLbGrup.Fill(dtLBGrup, "tb_grupos");
            cnBanco.Close();
            iGrupo = Convert.ToString(dtLBGrup.Tables[0].Rows[0][0]);
            return iGrupo;
        }

        public void LerCBXGrupo()
        {
            string sSQLcbxGrupo = "SELECT nome FROM tb_grupos;";
            string sSQLPesq = "SELECT COUNT(*) FROM tb_grupos;";
            DataSet dtGrupo = new DataSet();
            SqlDataAdapter daGrupo = new SqlDataAdapter(sSQLcbxGrupo, cnBanco);
            daGrupo.Fill(dtGrupo, "tb_grupos");
            cnBanco.Close();

            SqlCommand cmd = new SqlCommand(sSQLPesq, cnBanco);
            try
            {
                cmd.Connection.Open();
                numVendas = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Connection.Close();
            }
            catch
            {
                MessageBox.Show("Não foi possível efetuar busca de informações na Base de Dados\n\nEntre em contato com o Suporte ao Usuário", "Pesquisa de Dados");
            }
            
            for (i = 0;  i < numVendas; i++)
            {
                strGrupo = Convert.ToString(dtGrupo.Tables[0].Rows[i][0]);
                cbxGrupo.Items.Add(strGrupo);
            }
        }

        public string LerFornecedor()
        {
            DataSet dtFornecedor = new DataSet();
            string sSQLFornecedor = "SELECT razaosocial FROM tb_fornecedores WHERE cd_fornecedor  = '" + txtCodfornec.Text + "';";
            try
            {
                SqlDataAdapter daFornecedor = new SqlDataAdapter(sSQLFornecedor, cnBanco);
                daFornecedor.Fill(dtFornecedor, "tb_fornecedores");
                cnBanco.Close();
                strFornecedor = Convert.ToString(dtFornecedor.Tables[0].Rows[0][0]);
            }
            catch (Exception)
            {
                MessageBox.Show("Código do Fornecedor informado não está na base de Bados", "Verifica Código do Fornecedor");
            }
            return strFornecedor;
        }


        private void btGravar_Click(object sender, EventArgs e)
        {
            classMedicamento dbGrava = new classMedicamento();
            if (novoMedicamento)
            {
                dbGrava.GravarMedicamento(txtCodigo.Text, txtDescri.Text, txtGenerico.Text, txtApresen.Text, txtQtd.Text, txtEstoqmin.Text, txtValorcompra.Text, txtDatacompra.Text, txtDatacad.Text, Convert.ToInt32(lbCdGrupo.Text), txtCodfornec.Text);
                MessageBox.Show("Medicamento cadastrado com sucesso", "Cadastro Medicamento");
                LimpaCampos();
                HabiDesabi(false);
                txtCodigo.Enabled = true;
                novoMedicamento = false;
            }
            else
            {
                dbGrava.AtuaMedicamento(txtCodigo.Text, txtDescri.Text, txtGenerico.Text, txtApresen.Text, txtQtd.Text, txtEstoqmin.Text, txtValorcompra.Text, txtDatacompra.Text, txtDatacad.Text, Convert.ToInt32(lbCdGrupo.Text), txtCodfornec.Text);
                MessageBox.Show("Medicamento atualizado com sucesso", "Cadastro Medicamento");
                LimpaCampos();
                HabiDesabi(false);
                txtCodigo.Enabled = true;
                novoMedicamento = false;
            }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            novoMedicamento = true;
            HabiDesabi(true);
            LimpaCampos();
            txtCodigo.Enabled = true;
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            if (!novoMedicamento)
            {   
                classMedicamento dbVerMedicamento = new classMedicamento();
                if (dbVerMedicamento.VerCodMedicamento(txtCodigo.Text))
                {
                    DataSet dsMedicamento = new DataSet();

                    dsMedicamento = dbVerMedicamento.LerMedicamento(txtCodigo.Text);

                    txtDescri.Text = Convert.ToString(dsMedicamento.Tables[0].Rows[0][1]);
                    txtGenerico.Text = Convert.ToString(dsMedicamento.Tables[0].Rows[0][2]);
                    txtApresen.Text = Convert.ToString(dsMedicamento.Tables[0].Rows[0][3]);
                    txtQtd.Text = Convert.ToString(dsMedicamento.Tables[0].Rows[0][4]);
                    txtEstoqmin.Text = Convert.ToString(dsMedicamento.Tables[0].Rows[0][5]);
                    txtValorcompra.Text = Convert.ToString(dsMedicamento.Tables[0].Rows[0][6]);
                    txtDatacompra.Text = Convert.ToString(dsMedicamento.Tables[0].Rows[0][7]);
                    txtDatacad.Text = Convert.ToString(dsMedicamento.Tables[0].Rows[0][8]);
                    cbxGrupo.Text = Convert.ToString(dsMedicamento.Tables[0].Rows[0][10]);
                    lbCdGrupo.Text = Convert.ToString(dsMedicamento.Tables[0].Rows[0][9]);
                    txtCodfornec.Text = Convert.ToString(dsMedicamento.Tables[0].Rows[0][11]);
                    txtFornecedor.Text = LerFornecedor();
                    
                    btEditar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Código do medicamento informado não está na base de Bados", "Verifica Código do medicamento");
                    LimpaCampos();
                }
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            classMedicamento dbExclui = new classMedicamento();
            dbExclui.ExcluMedicamento(txtCodigo.Text);
            LimpaCampos();
            HabiDesabi(false);
            txtCodigo.Enabled = true;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            HabiDesabi(true);
            novoMedicamento = false;
            txtCodigo.Enabled = false;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            HabiDesabi(false);
            novoMedicamento = false;
            txtCodigo.Enabled = true;
        }

        private void LimpaCampos()
        {
            txtCodigo.Clear();
            txtApresen.Clear();
            txtCodfornec.Clear();
            txtDatacad.Clear();
            txtDatacompra.Clear();
            txtDescri.Clear();
            txtEstoqmin.Clear();
            txtFornecedor.Clear();
            txtGenerico.Clear();
            txtQtd.Clear();
            txtValorcompra.Clear();
            cbxGrupo.Text = "";
            lbCdGrupo.Text = "";
            txtCodigo.Focus();
        }

        private void HabiDesabi(bool flag)
        {
            txtApresen.Enabled = flag;
            txtCodfornec.Enabled = flag;
            txtDatacad.Enabled = flag;
            txtDatacompra.Enabled = flag;
            txtDescri.Enabled = flag;
            txtEstoqmin.Enabled = flag;
            txtGenerico.Enabled = flag;
            txtValorcompra.Enabled = flag;
            cbxGrupo.Enabled = flag;
            btEditar.Enabled = flag;
            btExcluir.Enabled = flag;
            btGravar.Enabled = flag;
        }

        private void frmMedicamento_Load(object sender, EventArgs e)
        {
            LerCBXGrupo();
        }

        private void txtCodfornec_Leave(object sender, EventArgs e)
        {
            txtFornecedor.Text = LerFornecedor();
        }

        private void cbxGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbCdGrupo.Text = lbGrupo(); ;
        }       
    }
}
