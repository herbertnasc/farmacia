using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Farmacia
{
    class classGrupo
    
  {
        private string strCnxBD = @"Data Source=.\SQLEXPRESS;AttachDbFilename=J:\Farmacia\Farmacia\bd_farmacia.mdf;Integrated Security=True;User Instance=True";
    private SqlConnection cnBanco;

    public classGrupo()
    {
      cnBanco = new SqlConnection(strCnxBD);
    }

    public DataSet LerGrupo(string codGrupo)
    {
      string         sSQLGrupo    = "SELECT * FROM tb_grupos WHERE cd_grupo = '" + codGrupo + "'";
      DataSet        dtDados      = new DataSet();
      SqlDataAdapter daGrupo      = new SqlDataAdapter(sSQLGrupo, cnBanco);

      daGrupo.Fill(dtDados, "tb_grupos");
      cnBanco.Close();
      
      return dtDados;
    }

    public void GravarGrupo(string sCodigo, string sNome, string sDescricao)
    {
        string sSQLAtual = "INSERT INTO tb_grupos (cd_grupo, nome, descricao) VALUES (@Codigo, @Nome, @Descricao)";
        SqlCommand cmdCadGrupo = new SqlCommand(sSQLAtual, cnBanco);

        cmdCadGrupo.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.NChar, 4));
        cmdCadGrupo.Parameters["@Codigo"].Value = sCodigo;
        cmdCadGrupo.Parameters.Add(new SqlParameter("@Nome", SqlDbType.NVarChar, 30));
        cmdCadGrupo.Parameters["@Nome"].Value = sNome;
        cmdCadGrupo.Parameters.Add(new SqlParameter("@Descricao", SqlDbType.NVarChar, -1));
        cmdCadGrupo.Parameters["@Descricao"].Value = sDescricao;

      try
      {
          cmdCadGrupo.Connection.Open();
          cmdCadGrupo.ExecuteNonQuery();
          cmdCadGrupo.Connection.Close();
      }
      catch
      {
        MessageBox.Show("Não foi possível incluir as informações na Base de Dados\n\nEntre em contato com o Suporte ao Usuário", "Gravação de Dados");
      }
    }

    public void AtuaGrupo(string sCodigo, string sNome, string sDescricao)
    {
        string sSQLAtual = "UPDATE tb_grupos SET nome = @Nome, descricao = @Descricao WHERE cd_grupo = @Codigo";
        SqlCommand cmdCadGrupo = new SqlCommand(sSQLAtual, cnBanco);

        cmdCadGrupo.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.NChar, 4));
        cmdCadGrupo.Parameters["@Codigo"].Value = sCodigo;
        cmdCadGrupo.Parameters.Add(new SqlParameter("@Nome", SqlDbType.NVarChar, 30));
        cmdCadGrupo.Parameters["@Nome"].Value = sNome;
        cmdCadGrupo.Parameters.Add(new SqlParameter("@Descricao", SqlDbType.NVarChar, -1));
        cmdCadGrupo.Parameters["@Descricao"].Value = sDescricao;

      try
      {
          cmdCadGrupo.Connection.Open();
          cmdCadGrupo.ExecuteNonQuery();
          cmdCadGrupo.Connection.Close();
      }
      catch
      {
        MessageBox.Show("Não foi possível atualizar as informações na Base de Dados\n\nEntre em contato com o Suporte ao Usuário", "Atualização de Dados");
      }
    }

    public bool VerCodGrupo(string codGrupo)
    {
        string sSQLPesq = "SELECT Count(*) FROM tb_grupos WHERE cd_Grupo = @CodGrupo";
        bool locaCodGrupo = false;
      SqlCommand cmd = new SqlCommand(sSQLPesq, cnBanco);

      cmd.Parameters.Add("@CodGrupo", SqlDbType.NChar, 5);
      cmd.Parameters["@CodGrupo"].Value = codGrupo;

      try
      {
        cmd.Connection.Open();
        locaCodGrupo = (Convert.ToInt32(cmd.ExecuteScalar())) > 0;
        cmd.Connection.Close();
      }
      catch
      {
        MessageBox.Show("Não foi possível efetuar busca de informações na Base de Dados\n\nEntre em contato com o Suporte ao Usuário", "Pesquisa de Dados");
      }
      return locaCodGrupo;
    }

    public void ExcluGrupo(string codGrupo)
    {
        string strSQLEx = "DELETE FROM tb_grupos WHERE cd_grupo = '" + codGrupo + "'";
      SqlCommand cmd = new SqlCommand(strSQLEx, cnBanco);
      
      try
      {
        cmd.Connection.Open();
        cmd.ExecuteNonQuery();
        cmd.Connection.Close();
        MessageBox.Show("Grupo exluído com sucesso!", "Exclusão");
      }
      catch (Exception)
      {
        MessageBox.Show("Não foi possível excluir as informações da Base de Dados/n/nEntre em contato com o Suporte ao Usuário", "Exclusão de Dados");
      }
    }
  }
}
