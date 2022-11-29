using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Farmacia
{
    class classLogin
    {
        private string strCnxBD = @"Data Source=.\SQLEXPRESS;AttachDbFilename=J:\Farmacia\Farmacia\bd_farmacia.mdf;Integrated Security=True;User Instance=True";
        private SqlConnection cnBanco;

        public classLogin()
        {
            cnBanco = new SqlConnection(strCnxBD);
        }

        public string LerUsuario(string codUsuario, string Senha)
        {
            string sSQLUsuario = "SELECT nome FROM tb_usuarios WHERE usuario = '" + codUsuario + "' AND senha = '" + Senha + "'"; 
            DataSet dtDados = new DataSet();                                        
            SqlDataAdapter daUsuario = new SqlDataAdapter(sSQLUsuario, cnBanco);  

            daUsuario.Fill(dtDados, "tb_Usuarios"); 
            cnBanco.Close();       

            return Convert.ToString(dtDados.Tables[0].Rows[0][0]);
        }

        public bool VerCodUsuario(string Usuario, string Senha)
        {
            string sSQLPesq = "SELECT Count(*) FROM tb_usuarios WHERE usuario = @Usuario AND senha = @Senha";
            bool locaCodUsuario = false;
            SqlCommand cmd = new SqlCommand(sSQLPesq, cnBanco);

            cmd.Parameters.Add("@Usuario", SqlDbType.NVarChar, 20);
            cmd.Parameters["@Usuario"].Value = Usuario;
            cmd.Parameters.Add("@Senha", SqlDbType.NVarChar, 6);
            cmd.Parameters["@Senha"].Value = Senha;
            
            
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
    }
}