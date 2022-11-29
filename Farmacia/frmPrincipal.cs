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
    public partial class frmPrincipal : Form
    {
        private frmEmpresa objEmpresa;
        private frmMedicamento objMedica;
        private frmFornecedor objForne;
        private frmGrupo objGrupo;
        private frmUsuario objUser;
        private frmMovimento objMovimento;
        private frmLogin objLogin;
        private string nmUsuario;
        
        public frmPrincipal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        public string NmUsuario
        {
            get {return nmUsuario.ToUpper();}
            set {nmUsuario = value;}
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            stLabel.Text = NmUsuario;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuEmpresa_Click(object sender, EventArgs e)
        {
            if (objEmpresa != null)
            {
                objEmpresa.Activate();
            }
            else
            {
                objEmpresa = new frmEmpresa();
                objEmpresa.Closed += delegate { objEmpresa = null; };
                objEmpresa.MdiParent = this;
                objEmpresa.Show();
            }
        }

        private void menuMedicamento_Click(object sender, EventArgs e)
        {
            if (objMedica != null)
            {
                objMedica.Activate();
            }
            else
            {
                objMedica = new frmMedicamento();
                objMedica.Closed += delegate { objMedica = null; };
                objMedica.MdiParent = this;
                objMedica.Show();
            }
        }

        private void menuFornecedor_Click(object sender, EventArgs e)
        {
            if (objForne != null)
            {
                objForne.Activate();
            }
            else
            {
                objForne = new frmFornecedor();
                objForne.Closed += delegate { objForne = null; };
                objForne.MdiParent = this;
                objForne.Show();
            }
            objForne.Show();
        }

        private void menuGrupo_Click(object sender, EventArgs e)
        {
            if (objGrupo != null)
            {
                objGrupo.Activate();
            }
            else
            {
                objGrupo = new frmGrupo();
                objGrupo.Closed += delegate { objGrupo = null; };
                objGrupo.MdiParent = this;
                objGrupo.Show();
            }
            objGrupo.Show();
        }

        private void menuUsuario_Click(object sender, EventArgs e)
        {
            if (objUser != null)
            {
                objUser.Activate();
            }
            else
            {
                objUser = new frmUsuario();
                objUser.Closed += delegate { objUser = null; };
                objUser.MdiParent = this;
                objUser.Show();
            }
            objUser.Show();
        }

        private void menuMovimentacao_Click(object sender, EventArgs e)
        {
            if (objMovimento != null)
            {
                objMovimento.Activate();
            }
            else
            {
                objMovimento = new frmMovimento();
                objMovimento.Closed += delegate { objMovimento = null; };
                objMovimento.MdiParent = this;
                objMovimento.Show();
            }
            objMovimento.Show();
        }

        private void fecharTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChildForm in MdiChildren)
            {
                mdiChildForm.Close();
            }
        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void horizantalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void logofToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            objLogin = new frmLogin();
            objLogin.ShowDialog();
        }
    }
}
