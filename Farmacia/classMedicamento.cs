using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Farmacia
{
    class classMedicamento
    {
        private string strCnxBD = @"Data Source=.\SQLEXPRESS;AttachDbFilename=J:\Farmacia\Farmacia\bd_farmacia.mdf;Integrated Security=True;User Instance=True";
        private SqlConnection cnBanco;

        frmMovimento tipo = new frmMovimento();

        public classMedicamento()
        {
            cnBanco = new SqlConnection(strCnxBD);
        }

        public DataSet LerMedicamento(string codMedicamento)
        {
        string sSQLMedicamento = "SELECT m.cd_medicamento, m.descricao, m.generico, m.apresentacao, m.qtd, m.estoqueminimo, m.valorcompra, m.datacompra, m.datacadastro, m.cd_grupo, g.nome, f.cd_fornecedor FROM tb_medicamentos AS m, tb_grupos AS g, tb_fornecedores AS f WHERE cd_medicamento = '" + codMedicamento + "' AND m.cd_grupo = g.cd_grupo AND m.cd_fornecedor = f.cd_fornecedor;"; 
            DataSet dtDados = new DataSet(); 
            SqlDataAdapter daMedicamento = new SqlDataAdapter(sSQLMedicamento, cnBanco); 

            daMedicamento.Fill(dtDados, "tb_medicamentos");
            cnBanco.Close(); 

            return dtDados; 
        }
        
        public void GravarMedicamento(string sCodigo, string sDescricao, string sGenerico, string sApresentacao, string sQtd, string sEstoqMin, string sValorCompra, string sDataCompra, string sDataCadastro, int sCodGrupo, string sCodFornecedor)
        {
            string sSQLAtual = "INSERT INTO tb_medicamentos (cd_medicamento, descricao, generico, apresentacao, qtd, estoqueminimo, valorcompra, datacompra, datacadastro, cd_grupo, cd_fornecedor) VALUES (@Codigo, @Descricao, @Generico, @Apresentacao, @Qtd, @EstoqMin, @ValorCompra, @DataCompra, @DataCadastro, @CodGrupo, @CodFornecedor)";

            SqlCommand cmdCadMedicamento = new SqlCommand(sSQLAtual, cnBanco);

            cmdCadMedicamento.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.NVarChar, 4)); cmdCadMedicamento.Parameters["@Codigo"].Value = sCodigo;
            cmdCadMedicamento.Parameters.Add(new SqlParameter("@Descricao", SqlDbType.NVarChar, -1)); cmdCadMedicamento.Parameters["@Descricao"].Value = sDescricao;
            cmdCadMedicamento.Parameters.Add(new SqlParameter("@Generico", SqlDbType.NVarChar, -1)); cmdCadMedicamento.Parameters["@Generico"].Value = sGenerico;
            cmdCadMedicamento.Parameters.Add(new SqlParameter("@Apresentacao", SqlDbType.NVarChar, -1)); cmdCadMedicamento.Parameters["@Apresentacao"].Value = sApresentacao;
            cmdCadMedicamento.Parameters.Add(new SqlParameter("@Qtd", SqlDbType.NVarChar, 20)); cmdCadMedicamento.Parameters["@Qtd"].Value = sQtd;
            cmdCadMedicamento.Parameters.Add(new SqlParameter("@EstoqMin", SqlDbType.NVarChar, 20)); cmdCadMedicamento.Parameters["@EstoqMin"].Value = sEstoqMin;
            cmdCadMedicamento.Parameters.Add(new SqlParameter("@ValorCompra", SqlDbType.NVarChar, 20)); cmdCadMedicamento.Parameters["@ValorCompra"].Value = sValorCompra;
            cmdCadMedicamento.Parameters.Add(new SqlParameter("@DataCompra", SqlDbType.NVarChar, 20)); cmdCadMedicamento.Parameters["@DataCompra"].Value = sDataCompra;
            cmdCadMedicamento.Parameters.Add(new SqlParameter("@DataCadastro", SqlDbType.NVarChar, 20)); cmdCadMedicamento.Parameters["@DataCadastro"].Value = sDataCadastro;
            cmdCadMedicamento.Parameters.Add(new SqlParameter("@CodGrupo", SqlDbType.Int, 5)); cmdCadMedicamento.Parameters["@CodGrupo"].Value = sCodGrupo;
            cmdCadMedicamento.Parameters.Add(new SqlParameter("@CodFornecedor", SqlDbType.NVarChar, -1)); cmdCadMedicamento.Parameters["@CodFornecedor"].Value = sCodFornecedor;


            try
            {
                cmdCadMedicamento.Connection.Open();
                cmdCadMedicamento.ExecuteNonQuery();
                cmdCadMedicamento.Connection.Close();
            }
            catch
            {
                MessageBox.Show("Não foi possível incluir as informações na Base de Dados\n\nEntre em contato com o Suporte ao Usuário", "Gravação de Dados");
            }
        }

        public void AtuaMedQtd(string sCod, int sQtd, string sTipo)
        {
            if (sTipo == "Saida")
            {
                string sSQLQtd = "UPDATE tb_medicamentos SET qtd = (qtd - @Qtd) WHERE cd_medicamento = '"+sCod+"';";
                SqlCommand cmdQtd = new SqlCommand(sSQLQtd, cnBanco);

                cmdQtd.Parameters.Add(new SqlParameter("@Qtd", SqlDbType.Int, 4)); cmdQtd.Parameters["@Qtd"].Value = sQtd;

                try
                {
                    cmdQtd.Connection.Open();
                    cmdQtd.ExecuteNonQuery();
                    cmdQtd.Connection.Close();
                }
                catch
                {
                    MessageBox.Show("Cadastro não realizado");
                }
            }
            else if (sTipo == "Entrada")
            {
                string sSQLQtd = "UPDATE tb_medicamentos SET qtd = (qtd + @Qtd) WHERE cd_medicamento = '" + sCod + "';";
                SqlCommand cmdQtd = new SqlCommand(sSQLQtd, cnBanco);

                cmdQtd.Parameters.Add(new SqlParameter("@Qtd", SqlDbType.Int, 4)); cmdQtd.Parameters["@Qtd"].Value = sQtd;

                try
                {
                    cmdQtd.Connection.Open();
                    cmdQtd.ExecuteNonQuery();
                    cmdQtd.Connection.Close();
                }
                catch
                {
                    MessageBox.Show("Cadastro não realizado");
                }
            }
        }

        public void AtuaMedicamento(string sCodigo, string sDescricao, string sGenerico, string sApresentacao, string sQtd, string sEstoqMin, string sValorCompra, string sDataCompra, string sDataCadastro, int sCodGrupo, string sCodFornecedor)
        {
            string sSQLAtual = "UPDATE tb_medicamentos SET descricao = @Descricao, generico = @Generico, apresentacao = @Apresentacao, qtd = @Qtd, estoqueminimo = @EstoqMin, valorcompra = @ValorCompra, datacompra = @DataCompra, datacadastro = @DataCadastro, cd_grupo = @CodGrupo, cd_fornecedor = @CodFornecedor WHERE cd_medicamento = @Codigo";

                SqlCommand cmdCadMedicamento = new SqlCommand(sSQLAtual, cnBanco);

                cmdCadMedicamento.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.NVarChar, 4)); cmdCadMedicamento.Parameters["@Codigo"].Value = sCodigo;
                cmdCadMedicamento.Parameters.Add(new SqlParameter("@Descricao", SqlDbType.NVarChar, -1)); cmdCadMedicamento.Parameters["@Descricao"].Value = sDescricao;
                cmdCadMedicamento.Parameters.Add(new SqlParameter("@Generico", SqlDbType.NVarChar, -1)); cmdCadMedicamento.Parameters["@Generico"].Value = sGenerico;
                cmdCadMedicamento.Parameters.Add(new SqlParameter("@Apresentacao", SqlDbType.NVarChar, -1)); cmdCadMedicamento.Parameters["@Apresentacao"].Value = sApresentacao;
                cmdCadMedicamento.Parameters.Add(new SqlParameter("@Qtd", SqlDbType.NVarChar, 20)); cmdCadMedicamento.Parameters["@Qtd"].Value = sQtd;
                cmdCadMedicamento.Parameters.Add(new SqlParameter("@EstoqMin", SqlDbType.NVarChar, 20)); cmdCadMedicamento.Parameters["@EstoqMin"].Value = sEstoqMin;
                cmdCadMedicamento.Parameters.Add(new SqlParameter("@ValorCompra", SqlDbType.NVarChar, 20)); cmdCadMedicamento.Parameters["@ValorCompra"].Value = sValorCompra;
                cmdCadMedicamento.Parameters.Add(new SqlParameter("@DataCompra", SqlDbType.NVarChar, 20)); cmdCadMedicamento.Parameters["@DataCompra"].Value = sDataCompra;
                cmdCadMedicamento.Parameters.Add(new SqlParameter("@DataCadastro", SqlDbType.NVarChar, 20)); cmdCadMedicamento.Parameters["@DataCadastro"].Value = sDataCadastro;
                cmdCadMedicamento.Parameters.Add(new SqlParameter("@CodGrupo", SqlDbType.NVarChar, 4)); cmdCadMedicamento.Parameters["@CodGrupo"].Value = sCodGrupo;
                cmdCadMedicamento.Parameters.Add(new SqlParameter("@CodFornecedor", SqlDbType.NVarChar, 4)); cmdCadMedicamento.Parameters["@CodFornecedor"].Value = sCodFornecedor;

                try
                {
                    cmdCadMedicamento.Connection.Open();
                    cmdCadMedicamento.ExecuteNonQuery();
                    cmdCadMedicamento.Connection.Close();
                }
                catch
                {
                    MessageBox.Show("Não foi possível atualizar as informações na Base de Dados\n\nEntre em contato com o Suporte ao Usuário", "Atualização de Dados");
                }
        }

        public bool VerCodMedicamento(string codMedicamento)
        {
            string sSQLPesq = "SELECT Count(*) FROM tb_medicamentos WHERE cd_medicamento = @CodMedicamento";
            bool locaCodMedicamento = false;
            SqlCommand cmd = new SqlCommand(sSQLPesq, cnBanco);

            cmd.Parameters.Add("@CodMedicamento", SqlDbType.NVarChar, 5);
            cmd.Parameters["@CodMedicamento"].Value = codMedicamento;

            try
            {
                cmd.Connection.Open();
                locaCodMedicamento = (Convert.ToInt32(cmd.ExecuteScalar())) > 0;
                cmd.Connection.Close();
            }
            catch
            {
                MessageBox.Show("Não foi possível efetuar busca de informações na Base de Dados\n\nEntre em contato com o Suporte ao Usuário", "Pesquisa de Dados");
            }
            return locaCodMedicamento;
        }

        public void ExcluMedicamento(string codMedicamento)
        {
            string strSQLEx = "DELETE FROM tb_medicamentos WHERE cd_medicamento = '" + codMedicamento + "'";
            SqlCommand cmd = new SqlCommand(strSQLEx, cnBanco);

            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                MessageBox.Show("Medicamento exluído com sucesso!", "Exclusão");
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível excluir as informações da Base de Dados/n/nEntre em contato com o Suporte ao Usuário", "Exclusão de Dados");
            }
        }        
    }
}
