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
    public partial class frmSplash : Form
    {
        //Declaração de uma variável
        private bool novo = true;

        public frmSplash()
        {
            InitializeComponent();
        }

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            if (novo)
                this.Opacity += .04D;
            if (this.Opacity == 1)
            {
                novo = false;
                timerSplash.Enabled = false;
                frmLogin objLogin = new frmLogin();
                this.Visible = false;
                objLogin.ShowDialog();
                this.Close();
            }
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            timerSplash.Interval = 190;
            timerSplash.Tick += new EventHandler(this.timerSplash_Tick);
            timerSplash.Enabled = true;
            this.Opacity = 0;
        }

    }
}
