using SysClinic.Bll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysClinic.View;
using SsysClinic.View.Mdi;


namespace SsysClinic.View.Authorization
{
    public partial class frmPasswordValidacao : Form
    {
        public frmPasswordValidacao()
        {
            InitializeComponent();
        }

        private void btnIr_Click(object sender, EventArgs e)
        {
            MacBll macBll = new MacBll();
            try
            {
                if (macBll.ValidaPassword(txtSenha.Text.Trim()) == true)
                {
                    if (Formularios.FormValidacao == null) Formularios.FormValidacao = new frmValidacao();

                    this.Hide();
                    Formularios.FormValidacao.Show();
                    Formularios.FormValidacao.Focus();
                }
                else
                {
                    if (Formularios.FormApresentacao == null) Formularios.FormApresentacao = new frmApresentacao();

                    this.Hide();
                    Formularios.FormApresentacao.Show();
                    Formularios.FormApresentacao.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
              
    }
}
