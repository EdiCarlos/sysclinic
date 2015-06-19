using SysClinic.View;
using System;
using System.Windows.Forms;

namespace SsysClinic.View.Authorization
{
    public partial class frmApresentacao : Form
    {
        public frmApresentacao()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (Formularios.FormPasswordValidacao == null) Formularios.FormPasswordValidacao = new frmPasswordValidacao();

            this.Hide();
            Formularios.FormPasswordValidacao.Show();
            Formularios.FormPasswordValidacao.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
