using SysClinic.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SsysClinic.View.Mdi
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            CarregaDados();
        }

        private void CarregaDados()
        {
            if (progressBar1.Value < 100) 
            {
                progressBar1.Value += 1;
            
            }
            else
            {
                timerSplash.Stop();
                if (Formularios.FormPrincipal == null) Formularios.FormPrincipal = new MdiPrincipal();

                this.Hide();
                Formularios.FormPrincipal.Show();
                Formularios.FormPrincipal.Focus();
            }
           
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            timerSplash.Start();
        }
    }
}
