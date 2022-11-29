using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Farmacia
{
    class classEmpresa
    {
        private string strCnxBD = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Estudos\C#\Farmacia\Farmacia\bd_farmacia.mdf;Integrated Security=True;User Instance=True";
        private SqlConnection cnBanco;

        public classEmpresa()
        {
            cnBanco = new SqlConnection(strCnxBD);
        }

        public DataSet LerEmpresa(string codEmpresa)
        {
            string sSQLEmpresa = "SELECT * FROM tb_empresas WHERE cd_empresa = '" + codEmpresa + "'";
            DataSet dtDados = new DataSet();
            SqlDataAdapter daEmpresa = new SqlDataAdapter(sSQLEmpresa, cnBanco);

            daEmpresa.Fill(dtDados, "tb_empresas");
            cnBanco.Close();

            return dtDados;
        }

        public void GravarEmpresa(string sCodigo, string sCNPJ, string sRazaosocial, string sLogradouro, string sNumero, string sComplemento, string sBairro, string sCEP, string sCidade, string sUF, string sEmail, string sSite, string sTel1, string sTel2, string sTel3, string sFamaceutico, string sCRF, string sObs)
        {
            string sSQLAtual = "INSERT INTO tb_empresas (cd_empresa, cnpj, razaosocial, logradouro, numero, complemento, bairro, cep, cidade, uf, email, site, tel1, tel2, tel3, farmaceutico, crf, obs) VALUES (@Codigo, @CNPJ, @Razaosocial, @Logradouro, @Numero, @Complemento, @Bairro, @CEP, @Cidade, @UF, @Email, @Site, @Tel1, @Tel2, @Tel3, @Farmaceutico, @CRF, @Obs)";

            SqlCommand cmdCadEmpresa = new SqlCommand(sSQLAtual, cnBanco);

            cmdCadEmpresa.Parameters.Add(new SqlParameter("@Codigo",        SqlDbType.NVarChar,  4)); cmdCadEmpresa.Parameters["@Codigo"].Value         = sCodigo;
            cmdCadEmpresa.Parameters.Add(new SqlParameter("@CNPJ",          SqlDbType.NVarChar, 20)); cmdCadEmpresa.Parameters["@CNPJ"].Value           = sCNPJ;
            cmdCadEmpresa.Parameters.Add(new SqlParameter("@Razaosocial",   SqlDbType.NVarChar, -1)); cmdCadEmpresa.Parameters["@Razaosocial"].Value    = sRazaosocial;
            cmdCadEmpresa.Parameters.Add(new SqlParameter("@Logradouro",    SqlDbType.NVarChar, 40)); cmdCadEmpresa.Parameters["@Logradouro"].Value     = sLogradouro;
            cmdCadEmpresa.Parameters.Add(new SqlParameter("@Numero",        SqlDbType.NVarChar, 10)); cmdCadEmpresa.Parameters["@Numero"].Value         = sNumero;
            cmdCadEmpresa.Parameters.Add(new SqlParameter("@Complemento",   SqlDbType.NVarChar, 30)); cmdCadEmpresa.Parameters["@Complemento"].Value    = sComplemento;
            cmdCadEmpresa.Parameters.Add(new SqlParameter("@Bairro",        SqlDbType.NVarChar, 30)); cmdCadEmpresa.Parameters["@Bairro"].Value         = sBairro;
            cmdCadEmpresa.Parameters.Add(new SqlParameter("@CEP",           SqlDbType.NVarChar, 10)); cmdCadEmpresa.Parameters["@CEP"].Value            = sCEP;
            cmdCadEmpresa.Parameters.Add(new SqlParameter("@Cidade",        SqlDbType.NVarChar, 30)); cmdCadEmpresa.Parameters["@Cidade"].Value         = sCidade;
            cmdCadEmpresa.Parameters.Add(new SqlParameter("@UF",            SqlDbType.NVarChar,  2)); cmdCadEmpresa.Parameters["@UF"].Value             = sUF;
            cmdCadEmpresa.Parameters.Add(new SqlParameter("@Email",         SqlDbType.NVarChar, -1)); cmdCadEmpresa.Parameters["@Email"].Value          = sEmail;
            cmdCadEmpresa.Parameters.Add(new SqlParameter("@Site",          SqlDbType.NVarChar, 50)); cmdCadEmpresa.Parameters["@Site"].Value           = sSite;
            cmdCadEmpresa.Parameters.Add(new SqlParameter("@Tel1",          SqlDbType.NVarChar, 13)); cmdCadEmpresa.Parameters["@Tel1"].Value           = sTel1;
            cmdCadEmpresa.Parameters.Add(new SqlParameter("@Tel2",          SqlDbType.NVarChar, 13)); cmdCadEmpresa.Parameters["@Tel2"].Value           = sTel2;
            cmdCadEmpresa.Parameters.Add(new SqlParameter("@Tel3",          SqlDbType.NVarChar, 13)); cmdCadEmpresa.Parameters["@Tel3"].Value           = sTel3;
            cmdCadEmpresa.Parameters.Add(new SqlParameter("@Farmaceutico",  SqlDbType.NVarChar, 50)); cmdCadEmpresa.Parameters["@Farmaceutico"].Value   = sFamaceutico;
            cmdCadEmpresa.Parameters.Add(new SqlParameter("@CRF",           SqlDbType.NVarChar, 20)); cmdCadEmpresa.Parameters["@CRF"].Value            = sCRF;
            cmdCadEmpresa.Parameters.Add(new SqlParameter("@Obs",           SqlDbType.NVarChar, -1)); cmdCadEmpresa.Parameters["@Obs"].Value            = sObs;

            try
            {
                cmdCadEmpresa.Connection.Open();
                cmdCadEmpresa.ExecuteNonQuery();
                cmdCadEmpresa.Connection.Close();
            }
            catch
            {
                MessageBox.Show("Não foi possível incluir as informações na Base de Dados\n\nEntre em contato com o Suporte ao Usuário", "Gravação de Dados");
            }
        }

        public void AtuaEmpresa(string sCodigo, string sCNPJ, string sRazaosocial, string sLogradouro, string sNumero, string sComplemento, string sBairro, string sCEP, string sCidade, string sUF, string sEmail, string sSite, string sTel1, string sTel2, string sTel3, string sFamaceutico, string sCRF, string sObs)
        {
            string sSQLAtual = "UPDATE tb_empresas SET cnpj = @CNPJ, razaosocial = @Razaosocial, logradouro = @Logradouro, numero = @Numero, complemento = @Complemento, bairro = @Bairro, cep = @CEP, cidade = @Cidade, uf = @UF, email = @Email, site = @Site, tel1 = @Tel1, tel2 = @Tel2, tel3 = @Tel3, farmaceutico = @Farmaceutico, crf = @CRF, obs = @Obs WHERE cd_empresa = @Codigo";

            SqlCommand cmdCadEmpresa = new SqlCommand(sSQLAtual, cnBanco);


            cmdCadEmpresa.Parameters.Add(new SqlParameter("@Codigo",        SqlDbType.NVarChar,  4)); cmdCadEmpresa.Parameters["@Codigo"].Value         = sCodigo;
            cmdCadEmpresa.Parameters.Add(new SqlParameter("@CNPJ",          SqlDbType.NVarChar, 20)); cmdCadEmpresa.Parameters["@CNPJ"].Value           = sCNPJ;
            cmdCadEmpresa.Parameters.Add(new SqlParameter("@Razaosocial",   SqlDbType.NVarChar, -1)); cmdCadEmpresa.Parameters["@Razaosocial"].Value    = sRazaosocial;
            cmdCadEmpresa.Parameters.Add(new SqlParameter("@Logradouro",    SqlDbType.NVarChar, 40)); cmdCadEmpresa.Parameters["@Logradouro"].Value     = sLogradouro;
            cmdCadEmpresa.Parameters.Add(new SqlParameter("@Numero",        SqlDbType.NVarChar, 10)); cmdCadEmpresa.Parameters["@Numero"].Value         = sNumero;
            cmdCadEmpresa.Parameters.Add(new SqlParameter("@Complemento",   SqlDbType.NVarChar, 30)); cmdCadEmpresa.Parameters["@Complemento"].Value    = sComplemento;
            cmdCadEmpresa.Parameters.Add(new SqlParameter("@Bairro",        SqlDbType.NVarChar, 30)); cmdCadEmpresa.Parameters["@Bairro"].Value         = sBairro;
            cmdCadEmpresa.Parameters.Add(new SqlParameter("@CEP",           SqlDbType.NVarChar, 10)); cmdCadEmpresa.Parameters["@CEP"].Value            = sCEP;
            cmdCadEmpresa.Parameters.Add(new SqlParameter("@Cidade",        SqlDbType.NVarChar, 30)); cmdCadEmpresa.Parameters["@Cidade"].Value         = sCidade;
            cmdCadEmpresa.Parameters.Add(new SqlParameter("@UF",            SqlDbType.NVarChar,  2)); cmdCadEmpresa.Parameters["@UF"].Value             = sUF;
            cmdCadEmpresa.Parameters.Add(new SqlParameter("@Email",         SqlDbType.NVarChar, -1)); cmdCadEmpresa.Parameters["@Email"].Value          = sEmail;
            cmdCadEmpresa.Parameters.Add(new SqlParameter("@Site",          SqlDbType.NVarChar, 50)); cmdCadEmpresa.Parameters["@Site"].Value           = sSite;
            cmdCadEmpresa.Parameters.Add(new SqlParameter("@Tel1",          SqlDbType.NVarChar, 13)); cmdCadEmpresa.Parameters["@Tel1"].Value           = sTel1;
            cmdCadEmpresa.Parameters.Add(new SqlParameter("@Tel2",          SqlDbType.NVarChar, 13)); cmdCadEmpresa.Parameters["@Tel2"].Value           = sTel2;
            cmdCadEmpresa.Parameters.Add(new SqlParameter("@Tel3",          SqlDbType.NVarChar, 13)); cmdCadEmpresa.Parameters["@Tel3"].Value           = sTel3;
            cmdCadEmpresa.Parameters.Add(new SqlParameter("@Farmaceutico",  SqlDbType.NVarChar, 50)); cmdCadEmpresa.Parameters["@Farmaceutico"].Value   = sFamaceutico;
            cmdCadEmpresa.Parameters.Add(new SqlParameter("@CRF",           SqlDbType.NVarChar, 20)); cmdCadEmpresa.Parameters["@CRF"].Value            = sCRF;
            cmdCadEmpresa.Parameters.Add(new SqlParameter("@Obs",           SqlDbType.NVarChar, -1)); cmdCadEmpresa.Parameters["@Obs"].Value            = sObs;

            try
            {
                cmdCadEmpresa.Connection.Open();
                cmdCadEmpresa.ExecuteNonQuery();
                cmdCadEmpresa.Connection.Close();
            }
            catch
            {
                MessageBox.Show("Não foi possível atualizar as informações na Base de Dados\n\nEntre em contato com o Suporte ao Usuário", "Atualização de Dados");
            }
        }

        public bool VerCodEmpresa(string codEmpresa)
        {
            string sSQLPesq = "SELECT Count(*) FROM tb_empresas WHERE cd_empresa = @CodEmpresa";
            bool locaCodEmpresa = false;
            SqlCommand cmd = new SqlCommand(sSQLPesq, cnBanco);

            cmd.Parameters.Add("@CodEmpresa", SqlDbType.NChar, 4); cmd.Parameters["@CodEmpresa"].Value = codEmpresa;

            try
            {
                cmd.Connection.Open();
                locaCodEmpresa = (Convert.ToInt32(cmd.ExecuteScalar())) > 0;
                cmd.Connection.Close();
            }
            catch
            {
                MessageBox.Show("Não foi possível efetuar busca de informações na Base de Dados\n\nEntre em contato com o Suporte ao Usuário", "Pesquisa de Dados");
            }
            return locaCodEmpresa;
        }

        public void ExcluEmpresa(string codEmpresa)
        {
            string strSQLEx = "DELETE FROM tb_empresas WHERE cd_empresa = '" + codEmpresa + "'";
            SqlCommand cmd = new SqlCommand(strSQLEx, cnBanco);

            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                MessageBox.Show("Empresa exluído com sucesso!", "Exclusão");
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível excluir as informações da Base de Dados/n/nEntre em contato com o Suporte ao Usuário", "Exclusão de Dados");
            }

        }
    }
}
