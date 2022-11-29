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
    public partial class frmLogin : Form
    {
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {            
            
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            classLogin dbVerUsuario = new classLogin();
            if (dbVerUsuario.VerCodUsuario(txtUsuario.Text,txtSenha.Text))
            {
                string nomeUsuario;

                nomeUsuario = dbVerUsuario.LerUsuario(txtUsuario.Text, txtSenha.Text);

                frmPrincipal objPrinc = new frmPrincipal();
                objPrinc.NmUsuario = nomeUsuario;
                this.Visible = false;
                objPrinc.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Código ou senha do usuario informado esta incorreto!", "Dados incorreto");
            }
        }
    }
}
