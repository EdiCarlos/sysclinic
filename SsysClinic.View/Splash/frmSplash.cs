using SsysClinic.View.Authorization;
using SysClinic.Bll;
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
            MacBll macBll = new MacBll();

            if (progressBar1.Value < 100) 
            {
                if (progressBar1.Value >= 50)
                {
                    if (macBll.VerificaMac() == true)
                    {
                        lblValidado.Visible = true;  
                    }
                }
                lblStatus.Text = "Carregando Sistema...";
                progressBar1.Value += 1;
            
            }
            else
            {
                timerSplash.Stop();

                if (macBll.VerificaMac() == true)
                {
                    if (Formularios.FormPrincipal == null) Formularios.FormPrincipal = new MdiPrincipal();

                    this.Hide();
                    Formularios.FormPrincipal.Show();
                    Formularios.FormPrincipal.Focus();
                }
                else
                {
                    if (Formularios.FormApresentacao == null) Formularios.FormApresentacao = new frmApresentacao();

                    this.Hide();
                    Formularios.FormApresentacao.Show();
                    Formularios.FormApresentacao.Focus();
                }
               
            }
           
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            timerSplash.Start();
        }

        
    }
}
