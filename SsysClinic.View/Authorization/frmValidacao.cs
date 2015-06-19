using SysClinic.Bll;
using SysClinic.Bll.Common;
using SysClinic.Dto.AuthorizationDto;
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
    public partial class frmValidacao : Form
    {
        public frmValidacao()
        {
            InitializeComponent();
        }



        private void frmValidacao_Load(object sender, EventArgs e)
        {
            MacBll mac = new MacBll();
            MacDto macDto = new MacDto();

            try
            {
                macDto = mac.GetMac();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lblEndMAC.Text = mac.PegarEnderecoMAc();
            txtEmpresa.Text = macDto.Empresa;
            txtCnpj.Text = macDto.Cnpj;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            MacBll mac = new MacBll();
            MacDto macDto = new MacDto();
            CifraBll cf = new CifraBll();

            macDto.Chave = cf.GetCriptografiaMD5(lblEndMAC.Text.Trim());
            macDto.Empresa = txtEmpresa.Text.Trim();
            macDto.Cnpj = txtCnpj.Text.Trim();

            try
            {
                mac.AlteraMac(macDto);
                MessageBox.Show("Sistema validado com sucesso.\n Bem Vindo ao SysClinic!!!", 
                Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                if (Formularios.FormPrincipal == null) Formularios.FormPrincipal = new MdiPrincipal();
                this.Close();
                Formularios.FormPrincipal.Show();
                Formularios.FormPrincipal.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
