using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Farmacia
{
    class classManipulabd
    
  {
        private string strCnxBD = @"Data Source=.\SQLEXPRESS;AttachDbFilename=J:\Farmacia\Farmacia\bd_farmacia.mdf;Integrated Security=True;User Instance=True";
    private SqlConnection cnBanco;
    
    public classManipulabd()
    {
      cnBanco = new SqlConnection(strCnxBD);
    }

    public DataSet LerUsuario(string codUsuario)
    {
      string         sSQLUsuario   = "SELECT * FROM tb_usuarios WHERE cd_user = '" + codUsuario +  "'"; 
      DataSet        dtDados       = new DataSet();  
      SqlDataAdapter daUsuario     = new SqlDataAdapter(sSQLUsuario, cnBanco);  

      daUsuario.Fill(dtDados, "tb_Usuarios");
      cnBanco.Close(); 
      
      return dtDados;
    }

    public void GravarUsuario(string sCodigo, string sNome, string sUsuario, string sSenha)
    {
        string sSQLAtual = "INSERT INTO tb_Usuarios (cd_user, nome, usuario, senha) VALUES (@Codigo, @Nome, @usuario, @senha)";
        SqlCommand cmdCadUsuario = new SqlCommand(sSQLAtual, cnBanco);

        cmdCadUsuario.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.NChar, 5));
        cmdCadUsuario.Parameters["@Codigo"].Value = sCodigo;
        cmdCadUsuario.Parameters.Add(new SqlParameter("@Nome", SqlDbType.NVarChar, 45));
        cmdCadUsuario.Parameters["@Nome"].Value = sNome;
        cmdCadUsuario.Parameters.Add(new SqlParameter("@usuario", SqlDbType.NVarChar, 20));
        cmdCadUsuario.Parameters["@usuario"].Value = sUsuario;
        cmdCadUsuario.Parameters.Add(new SqlParameter("@senha", SqlDbType.NVarChar, 6));
        cmdCadUsuario.Parameters["@senha"].Value = sSenha;

      try
      {
          cmdCadUsuario.Connection.Open();
          cmdCadUsuario.ExecuteNonQuery();
          cmdCadUsuario.Connection.Close();
      }
      catch
      {
        MessageBox.Show("Não foi possível incluir as informações na Base de Dados\n\nEntre em contato com o Suporte ao Usuário", "Gravação de Dados");
      }
    }

    public void AtuaUsuario(string sCodigo, string sNome, string sUsuario, string sSenha)
    {
      string sSQLAtual = "UPDATE tb_usuarios SET nome = @Nome, usuario = @Usuario, senha = @Senha WHERE cd_user = @Codigo";
      SqlCommand cmdCadUsuario = new SqlCommand(sSQLAtual, cnBanco);

      cmdCadUsuario.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.NChar, 5));
      cmdCadUsuario.Parameters["@Codigo"].Value = sCodigo;
      cmdCadUsuario.Parameters.Add(new SqlParameter("@Nome", SqlDbType.NVarChar, 45));
      cmdCadUsuario.Parameters["@Nome"].Value = sNome;
      cmdCadUsuario.Parameters.Add(new SqlParameter("@usuario", SqlDbType.NVarChar, 20));
      cmdCadUsuario.Parameters["@usuario"].Value = sUsuario;
      cmdCadUsuario.Parameters.Add(new SqlParameter("@senha", SqlDbType.NVarChar, 6));
      cmdCadUsuario.Parameters["@senha"].Value = sSenha;

      try
      {
        cmdCadUsuario.Connection.Open();
        cmdCadUsuario.ExecuteNonQuery();
        cmdCadUsuario.Connection.Close();
      }
      catch
      {
        MessageBox.Show("Não foi possível atualizar as informações na Base de Dados\n\nEntre em contato com o Suporte ao Usuário", "Atualização de Dados");
      }
    }

    public bool VerCodUsuario(string codUsuario)
    {
        string sSQLPesq = "SELECT Count(*) FROM tb_usuarios WHERE cd_user = @CodUsuario";
      bool locaCodUsuario = false;
      SqlCommand cmd = new SqlCommand(sSQLPesq, cnBanco);

      cmd.Parameters.Add("@CodUsuario", SqlDbType.NChar, 5);
      cmd.Parameters["@CodUsuario"].Value = codUsuario;

      try
      {
        cmd.Connection.Open();
        locaCodUsuario = (Convert.ToInt32(cmd.ExecuteScalar())) > 0;
        cmd.Connection.Close();
      }
      catch
      {
        MessageBox.Show("Não foi possível efetuar busca de informações na Base de Dados\n\nEntre em contato com o Suporte ao Usuário", "Pesquisa de Dados");
      }
      return locaCodUsuario;
    }

    public void ExcluUsuario(string codUsuario)
    {
        string strSQLEx = "DELETE FROM tb_usuarios WHERE cd_user = '" + codUsuario + "'";
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