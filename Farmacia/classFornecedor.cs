using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Farmacia
{
    class classFornecedor
    {
        private string strCnxBD = @"Data Source=.\SQLEXPRESS;AttachDbFilename=J:\Farmacia\Farmacia\bd_farmacia.mdf;Integrated Security=True;User Instance=True";
        private SqlConnection cnBanco;

        public classFornecedor()
        {
            cnBanco = new SqlConnection(strCnxBD);
        }

        public DataSet LerFornecedor(string codFornecedor)
        {
            string sSQLFornecedor = "SELECT * FROM tb_fornecedores WHERE cd_fornecedor = '" + codFornecedor + "'";
            DataSet dtDados = new DataSet(); 
            SqlDataAdapter daFornecedor = new SqlDataAdapter(sSQLFornecedor, cnBanco);

            daFornecedor.Fill(dtDados, "tb_fornecedores");
            cnBanco.Close();

            return dtDados;
        }

        public void GravarFornecedor(string sCodigo, string sCNPJ, string sRazaosocial, string sLogradouro, string sNumero, string sComplemento, string sBairro, string sCEP, string sCidade, string sUF, string sEmail, string sContato, string sTel1, string sTel2, string sTel3, string sObs)
        {
            string sSQLAtual = "INSERT INTO tb_fornecedores (cd_fornecedor, cnpj, razaosocial, logradouro, numero, complemento, bairro, cep, cidade, uf, email, contato, tel1, tel2, tel3, obs) VALUES (@Codigo, @CNPJ, @Razaosocial, @Logradouro, @Numero, @Complemento, @Bairro, @CEP, @Cidade, @UF, @Email, @Contato, @Tel1, @Tel2, @Tel3, @Obs)";

            SqlCommand cmdCadFornecedor = new SqlCommand(sSQLAtual, cnBanco);

            cmdCadFornecedor.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.NVarChar, 4)); cmdCadFornecedor.Parameters["@Codigo"].Value = sCodigo;
            cmdCadFornecedor.Parameters.Add(new SqlParameter("@CNPJ", SqlDbType.NVarChar, 20)); cmdCadFornecedor.Parameters["@CNPJ"].Value = sCNPJ;
            cmdCadFornecedor.Parameters.Add(new SqlParameter("@Razaosocial", SqlDbType.NVarChar, -1)); cmdCadFornecedor.Parameters["@Razaosocial"].Value = sRazaosocial;
            cmdCadFornecedor.Parameters.Add(new SqlParameter("@Logradouro", SqlDbType.NVarChar, 40)); cmdCadFornecedor.Parameters["@Logradouro"].Value = sLogradouro;
            cmdCadFornecedor.Parameters.Add(new SqlParameter("@Numero", SqlDbType.NVarChar, 10)); cmdCadFornecedor.Parameters["@Numero"].Value = sNumero;
            cmdCadFornecedor.Parameters.Add(new SqlParameter("@Complemento", SqlDbType.NVarChar, 30)); cmdCadFornecedor.Parameters["@Complemento"].Value = sComplemento;
            cmdCadFornecedor.Parameters.Add(new SqlParameter("@Bairro", SqlDbType.NVarChar, 30)); cmdCadFornecedor.Parameters["@Bairro"].Value = sBairro;
            cmdCadFornecedor.Parameters.Add(new SqlParameter("@CEP", SqlDbType.NVarChar, 10)); cmdCadFornecedor.Parameters["@CEP"].Value = sCEP;
            cmdCadFornecedor.Parameters.Add(new SqlParameter("@Cidade", SqlDbType.NVarChar, 30)); cmdCadFornecedor.Parameters["@Cidade"].Value = sCidade;
            cmdCadFornecedor.Parameters.Add(new SqlParameter("@UF", SqlDbType.NVarChar, 2)); cmdCadFornecedor.Parameters["@UF"].Value = sUF;
            cmdCadFornecedor.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar, -1)); cmdCadFornecedor.Parameters["@Email"].Value = sEmail;
            cmdCadFornecedor.Parameters.Add(new SqlParameter("@Contato", SqlDbType.NVarChar, 50)); cmdCadFornecedor.Parameters["@Contato"].Value = sContato;
            cmdCadFornecedor.Parameters.Add(new SqlParameter("@Tel1", SqlDbType.NVarChar, 13)); cmdCadFornecedor.Parameters["@Tel1"].Value = sTel1;
            cmdCadFornecedor.Parameters.Add(new SqlParameter("@Tel2", SqlDbType.NVarChar, 13)); cmdCadFornecedor.Parameters["@Tel2"].Value = sTel2;
            cmdCadFornecedor.Parameters.Add(new SqlParameter("@Tel3", SqlDbType.NVarChar, 13)); cmdCadFornecedor.Parameters["@Tel3"].Value = sTel3;
            cmdCadFornecedor.Parameters.Add(new SqlParameter("@Obs", SqlDbType.NVarChar, -1)); cmdCadFornecedor.Parameters["@Obs"].Value = sObs;

            try
            {
                cmdCadFornecedor.Connection.Open();
                cmdCadFornecedor.ExecuteNonQuery();
                cmdCadFornecedor.Connection.Close();
            }
            catch
            {
                MessageBox.Show("Não foi possível incluir as informações na Base de Dados\n\nEntre em contato com o Suporte ao Usuário", "Gravação de Dados");
            }
        }

        public void AtuaFornecedor(string sCodigo, string sCNPJ, string sRazaosocial, string sLogradouro, string sNumero, string sComplemento, string sBairro, string sCEP, string sCidade, string sUF, string sEmail, string sContato, string sTel1, string sTel2, string sTel3, string sObs)
        {
            string sSQLAtual = "UPDATE tb_fornecedores SET cnpj = @CNPJ, razaosocial = @Razaosocial, logradouro = @Logradouro, numero = @Numero, complemento = @Complemento, bairro = @Bairro, cep = @CEP, cidade = @Cidade, uf = @UF, email = @Email, contato = @Contato, tel1 = @Tel1, tel2 = @Tel2, tel3 = @Tel3, obs = @Obs WHERE cd_fornecedor = @Codigo";

            SqlCommand cmdCadFornecedor = new SqlCommand(sSQLAtual, cnBanco);

            cmdCadFornecedor.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.NVarChar, 4)); cmdCadFornecedor.Parameters["@Codigo"].Value = sCodigo;
            cmdCadFornecedor.Parameters.Add(new SqlParameter("@CNPJ", SqlDbType.NVarChar, 20)); cmdCadFornecedor.Parameters["@CNPJ"].Value = sCNPJ;
            cmdCadFornecedor.Parameters.Add(new SqlParameter("@Razaosocial", SqlDbType.NVarChar, -1)); cmdCadFornecedor.Parameters["@Razaosocial"].Value = sRazaosocial;
            cmdCadFornecedor.Parameters.Add(new SqlParameter("@Logradouro", SqlDbType.NVarChar, 40)); cmdCadFornecedor.Parameters["@Logradouro"].Value = sLogradouro;
            cmdCadFornecedor.Parameters.Add(new SqlParameter("@Numero", SqlDbType.NVarChar, 10)); cmdCadFornecedor.Parameters["@Numero"].Value = sNumero;
            cmdCadFornecedor.Parameters.Add(new SqlParameter("@Complemento", SqlDbType.NVarChar, 30)); cmdCadFornecedor.Parameters["@Complemento"].Value = sComplemento;
            cmdCadFornecedor.Parameters.Add(new SqlParameter("@Bairro", SqlDbType.NVarChar, 30)); cmdCadFornecedor.Parameters["@Bairro"].Value = sBairro;
            cmdCadFornecedor.Parameters.Add(new SqlParameter("@CEP", SqlDbType.NVarChar, 10)); cmdCadFornecedor.Parameters["@CEP"].Value = sCEP;
            cmdCadFornecedor.Parameters.Add(new SqlParameter("@Cidade", SqlDbType.NVarChar, 30)); cmdCadFornecedor.Parameters["@Cidade"].Value = sCidade;
            cmdCadFornecedor.Parameters.Add(new SqlParameter("@UF", SqlDbType.NVarChar, 2)); cmdCadFornecedor.Parameters["@UF"].Value = sUF;
            cmdCadFornecedor.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar, -1)); cmdCadFornecedor.Parameters["@Email"].Value = sEmail;
            cmdCadFornecedor.Parameters.Add(new SqlParameter("@Contato", SqlDbType.NVarChar, 50)); cmdCadFornecedor.Parameters["@Contato"].Value = sContato;
            cmdCadFornecedor.Parameters.Add(new SqlParameter("@Tel1", SqlDbType.NVarChar, 13)); cmdCadFornecedor.Parameters["@Tel1"].Value = sTel1;
            cmdCadFornecedor.Parameters.Add(new SqlParameter("@Tel2", SqlDbType.NVarChar, 13)); cmdCadFornecedor.Parameters["@Tel2"].Value = sTel2;
            cmdCadFornecedor.Parameters.Add(new SqlParameter("@Tel3", SqlDbType.NVarChar, 13)); cmdCadFornecedor.Parameters["@Tel3"].Value = sTel3;
            cmdCadFornecedor.Parameters.Add(new SqlParameter("@Obs", SqlDbType.NVarChar, -1)); cmdCadFornecedor.Parameters["@Obs"].Value = sObs;

            try
            {
                cmdCadFornecedor.Connection.Open();
                cmdCadFornecedor.ExecuteNonQuery();
                cmdCadFornecedor.Connection.Close();
            }
            catch
            {
                MessageBox.Show("Não foi possível atualizar as informações na Base de Dados\n\nEntre em contato com o Suporte ao Usuário", "Atualização de Dados");
            }
        }

        public bool VerCodFornecedor(string codFornecedor)
        {
            string sSQLPesq = "SELECT Count(*) FROM tb_fornecedores WHERE cd_fornecedor = @CodFornecedor";
            bool locaCodFornecedor = false;
            SqlCommand cmd = new SqlCommand(sSQLPesq, cnBanco);

            cmd.Parameters.Add("@CodFornecedor", SqlDbType.NChar, 4); cmd.Parameters["@CodFornecedor"].Value = codFornecedor;

            try
            {
                cmd.Connection.Open();
                locaCodFornecedor = (Convert.ToInt32(cmd.ExecuteScalar())) > 0;
                cmd.Connection.Close();
            }
            catch
            {
                MessageBox.Show("Não foi possível efetuar busca de informações na Base de Dados\n\nEntre em contato com o Suporte ao Usuário", "Pesquisa de Dados");
            }
            return locaCodFornecedor;
        }

        public void ExcluFornecedor(string codFornecedor)
        {
            string strSQLEx = "DELETE FROM tb_fornecedores WHERE cd_fornecedor = '" + codFornecedor + "'";
            SqlCommand cmd = new SqlCommand(strSQLEx, cnBanco);

            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                MessageBox.Show("Fornecedor exluído com sucesso!", "Exclusão");
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível excluir as informações da Base de Dados/n/nEntre em contato com o Suporte ao Usuário", "Exclusão de Dados");
            }

        }
    }
}
