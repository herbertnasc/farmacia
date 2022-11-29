using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Farmacia
{
    class classMovimento
    {
        private string strCnxBD = @"Data Source=.\SQLEXPRESS;AttachDbFilename=J:\Farmacia\Farmacia\bd_farmacia.mdf;Integrated Security=True;User Instance=True";
        private SqlConnection cnBanco;

        public classMovimento()
        {
            cnBanco = new SqlConnection(strCnxBD);
        }

        public DataSet LerMovimento(string codMovimento)
        {
            string sSQLMovimento = "SELECT * FROM tb_movimentos WHERE cd_movimento = '" + codMovimento + "';";
            DataSet dtDados = new DataSet();
            SqlDataAdapter daMovimento = new SqlDataAdapter(sSQLMovimento, cnBanco);
            daMovimento.Fill(dtDados, "tb_movimentos");
            cnBanco.Close();
            return dtDados;
        }

        public void GravarMovimento(string sCodigo, string sData, string sHora, string sTipo, string sQtd, string sValorCompra, string sDataCompra, int cd_medicamento, int cd_user)
        {
            string sSQLAtual = "INSERT INTO tb_movimentos (cd_movimento, data, hora, tipo, qtd, valorcompra, datacompra, cd_medicamento, cd_user) VALUES (@Codigo, @Data, @Hora, @Tipo, @Qtd, @ValorCompra, @DataCompra, @CodMedicamento, @CodUsuario)";

            SqlCommand cmdCadMovimento = new SqlCommand(sSQLAtual, cnBanco);

            cmdCadMovimento.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.NVarChar, 4)); cmdCadMovimento.Parameters["@Codigo"].Value = sCodigo;
            cmdCadMovimento.Parameters.Add(new SqlParameter("@Data", SqlDbType.NVarChar, 20)); cmdCadMovimento.Parameters["@Data"].Value = sData;
            cmdCadMovimento.Parameters.Add(new SqlParameter("@Hora", SqlDbType.NVarChar, -1)); cmdCadMovimento.Parameters["@Hora"].Value = sHora;
            cmdCadMovimento.Parameters.Add(new SqlParameter("@Tipo", SqlDbType.NVarChar, 40)); cmdCadMovimento.Parameters["@Tipo"].Value = sTipo;
            cmdCadMovimento.Parameters.Add(new SqlParameter("@Qtd", SqlDbType.NVarChar, 10)); cmdCadMovimento.Parameters["@Qtd"].Value = sQtd;
            cmdCadMovimento.Parameters.Add(new SqlParameter("@ValorCompra", SqlDbType.NVarChar, 30)); cmdCadMovimento.Parameters["@ValorCompra"].Value = sValorCompra;
            cmdCadMovimento.Parameters.Add(new SqlParameter("@DataCompra", SqlDbType.NVarChar, 30)); cmdCadMovimento.Parameters["@DataCompra"].Value = sDataCompra;
            cmdCadMovimento.Parameters.Add(new SqlParameter("@CodMedicamento", SqlDbType.Int, 5)); cmdCadMovimento.Parameters["@CodMedicamento"].Value = cd_medicamento;
            cmdCadMovimento.Parameters.Add(new SqlParameter("@CodUsuario", SqlDbType.Int, 5)); cmdCadMovimento.Parameters["@CodUsuario"].Value = cd_user;

            try
            {
                cmdCadMovimento.Connection.Open();
                cmdCadMovimento.ExecuteNonQuery();
                cmdCadMovimento.Connection.Close();
            }
            catch
            {
                MessageBox.Show("Não foi possível incluir as informações na Base de Dados\n\nEntre em contato com o Suporte ao Usuário", "Gravação de Dados");
            }
        }

        public void AtuaMovimento(string sCodigo, string sData, string sHora, string sTipo, string sQtd, string sValorCompra, string sDataCompra, int cd_medicamento, int cd_user)
        {
            string sSQLAtual = "UPDATE tb_movimentos SET data = @Data, hora = @Hora, tipo = @Tipo, qtd = @Qtd, valorcompra = @ValorCompra, datacompra = @DataCompra, cd_medicamento = @CodMedicamento, cd_user = @CodUsuario WHERE cd_movimento = @Codigo";

            SqlCommand cmdCadMovimento = new SqlCommand(sSQLAtual, cnBanco);

            cmdCadMovimento.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.NVarChar, 4)); cmdCadMovimento.Parameters["@Codigo"].Value = sCodigo;
            cmdCadMovimento.Parameters.Add(new SqlParameter("@Data", SqlDbType.NVarChar, 20)); cmdCadMovimento.Parameters["@Data"].Value = sData;
            cmdCadMovimento.Parameters.Add(new SqlParameter("@Hora", SqlDbType.NVarChar, -1)); cmdCadMovimento.Parameters["@Hora"].Value = sHora;
            cmdCadMovimento.Parameters.Add(new SqlParameter("@Tipo", SqlDbType.NVarChar, 40)); cmdCadMovimento.Parameters["@Tipo"].Value = sTipo;
            cmdCadMovimento.Parameters.Add(new SqlParameter("@Qtd", SqlDbType.NVarChar, 10)); cmdCadMovimento.Parameters["@Qtd"].Value = sQtd;
            cmdCadMovimento.Parameters.Add(new SqlParameter("@ValorCompra", SqlDbType.NVarChar, 30)); cmdCadMovimento.Parameters["@ValorCompra"].Value = sValorCompra;
            cmdCadMovimento.Parameters.Add(new SqlParameter("@DataCompra", SqlDbType.NVarChar, 30)); cmdCadMovimento.Parameters["@DataCompra"].Value = sDataCompra;
            cmdCadMovimento.Parameters.Add(new SqlParameter("@CodMedicamento", SqlDbType.Int, 5)); cmdCadMovimento.Parameters["@CodMedicamento"].Value = cd_medicamento;
            cmdCadMovimento.Parameters.Add(new SqlParameter("@CodUsuario", SqlDbType.Int, 5)); cmdCadMovimento.Parameters["@CodUsuario"].Value = cd_user;

            try
            {
                cmdCadMovimento.Connection.Open();
                cmdCadMovimento.ExecuteNonQuery();
                cmdCadMovimento.Connection.Close();
            }
            catch
            {
                MessageBox.Show("Não foi possível atualizar as informações na Base de Dados\n\nEntre em contato com o Suporte ao Usuário", "Atualização de Dados");
            }
        }

        public bool VerCodMovimento(string codMovimento)
        {
            string sSQLPesq = "SELECT Count(*) FROM tb_movimentos WHERE cd_movimento = @CodMovimento";
            bool locaCodMovimento = false;
            SqlCommand cmd = new SqlCommand(sSQLPesq, cnBanco);

            cmd.Parameters.Add("@CodMovimento", SqlDbType.NChar, 4); cmd.Parameters["@CodMovimento"].Value = codMovimento;

            try
            {
                cmd.Connection.Open();
                locaCodMovimento = (Convert.ToInt32(cmd.ExecuteScalar())) > 0;
                cmd.Connection.Close();
            }
            catch
            {
                MessageBox.Show("Não foi possível efetuar busca de informações na Base de Dados\n\nEntre em contato com o Suporte ao Usuário", "Pesquisa de Dados");
            }
            return locaCodMovimento;
        }
    }
}
