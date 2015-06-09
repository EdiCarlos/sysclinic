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

namespace SsysClinic.View.Mdi
{
    public partial class frmValidacao : Form
    {
        public frmValidacao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MacBll mac = new MacBll();

            label1.Text = mac.PegarEnderecoMAc();
        }
    }
}
