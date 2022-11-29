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
    public partial class frmUsuario : Form
    {
        private bool novoUsuario = false;

        public frmUsuario()
        {
            InitializeComponent();
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            classManipulabd dbGrava = new classManipulabd();
            if (novoUsuario)
            {
                dbGrava.GravarUsuario(txtCodigo.Text, txtNome.Text, txtUsuario.Text, txtSenha.Text);
                MessageBox.Show("Usuario cadastrado com sucesso", "Cadastro usuario");
                LimpaCampos();
                HabiDesabi(false);
                txtCodigo.Enabled = true;
                novoUsuario = false;
            }
            else
            {
                dbGrava.AtuaUsuario(txtCodigo.Text, txtNome.Text, txtUsuario.Text, txtSenha.Text);
                MessageBox.Show("Usuario atualizado com sucesso", "Cadastro usuario");
                LimpaCampos();
                HabiDesabi(false);
                txtCodigo.Enabled = true;
                novoUsuario = false;
            }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            novoUsuario = true;
            HabiDesabi(true);
            LimpaCampos();
            txtCodigo.Enabled = true;
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            if (!novoUsuario)
            {     
                    classManipulabd dbVerUsuario = new classManipulabd();
                    if (dbVerUsuario.VerCodUsuario(txtCodigo.Text))
                    {
                        DataSet dsUsuario = new DataSet();

                        dsUsuario = dbVerUsuario.LerUsuario(txtCodigo.Text);

                        txtNome.Text = Convert.ToString(dsUsuario.Tables[0].Rows[0][1]);
                        txtUsuario.Text = Convert.ToString(dsUsuario.Tables[0].Rows[0][2]);
                        txtSenha.Text = Convert.ToString(dsUsuario.Tables[0].Rows[0][3]);
                        btEditar.Enabled = true;
                    }                        
                    else
                    {
                        MessageBox.Show("Código do usuario informado não está na base de Bados", "Verifica Código do Usuario");
                        LimpaCampos();
                    }
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            HabiDesabi(false);
            novoUsuario = false;
            txtCodigo.Enabled = true;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            HabiDesabi(true);
            novoUsuario = false;
            txtCodigo.Enabled = false;
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            classManipulabd dbExclui = new classManipulabd();
            dbExclui.ExcluUsuario(txtCodigo.Text);
            LimpaCampos();
            HabiDesabi(false);
            txtCodigo.Enabled = true;
        }

        private void LimpaCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtUsuario.Clear();
            txtSenha.Clear();
            txtCodigo.Focus();
        }

        private void HabiDesabi(bool flag)
        {
            txtNome.Enabled = flag;
            txtNome.Enabled = flag;
            txtUsuario.Enabled = flag;
            txtSenha.Enabled = flag;
            btEditar.Enabled = flag;
            btExcluir.Enabled = flag;
            btGravar.Enabled = flag;
        }
    }
}
