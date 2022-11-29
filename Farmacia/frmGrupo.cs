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
    public partial class frmGrupo : Form
    {
        private bool novoGrupo = false;

        public frmGrupo()
        {
            InitializeComponent();
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            classGrupo dbGrava = new classGrupo();
            if (novoGrupo)
            {
                dbGrava.GravarGrupo(txtCodigo.Text, txtNome.Text, txtDescricao.Text);
                MessageBox.Show("Grupo cadastrado com sucesso", "Cadastro Grupo");
                LimpaCampos();
                HabiDesabi(false);
                txtCodigo.Enabled = true;
                novoGrupo = false;
            }
            else
            {
                dbGrava.AtuaGrupo(txtCodigo.Text, txtNome.Text, txtDescricao.Text);
                MessageBox.Show("Grupo atualizado com sucesso", "Cadastro Grupo");
                LimpaCampos();
                HabiDesabi(false);
                txtCodigo.Enabled = true;
                novoGrupo = false;
            }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            novoGrupo = true;
            HabiDesabi(true);
            LimpaCampos();
            txtCodigo.Enabled = true;
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            if (!novoGrupo)
            {    
                classGrupo dbVerGrupo = new classGrupo();
                if (dbVerGrupo.VerCodGrupo(txtCodigo.Text))
                {
                    DataSet dsGrupo = new DataSet();

                    dsGrupo = dbVerGrupo.LerGrupo(txtCodigo.Text);

                    txtNome.Text = Convert.ToString(dsGrupo.Tables[0].Rows[0][1]);
                    txtDescricao.Text = Convert.ToString(dsGrupo.Tables[0].Rows[0][2]);
                    btEditar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Código do grupo informado não está na base de Bados", "Verifica Código do Grupo");
                    LimpaCampos();
                }
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            classGrupo dbExclui = new classGrupo();
            dbExclui.ExcluGrupo(txtCodigo.Text);
            LimpaCampos();
            HabiDesabi(false);
            txtCodigo.Enabled = true;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            HabiDesabi(true);
            novoGrupo = false;
            txtCodigo.Enabled = false;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            HabiDesabi(false);
            novoGrupo = false;
            txtCodigo.Enabled = true;
        }

        private void LimpaCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtDescricao.Clear();
            txtCodigo.Focus();
        }

        private void HabiDesabi(bool flag)
        {
            txtNome.Enabled = flag;
            txtDescricao.Enabled = flag;
            btEditar.Enabled = flag;
            btExcluir.Enabled = flag;
            btGravar.Enabled = flag;
        }
    }
}
