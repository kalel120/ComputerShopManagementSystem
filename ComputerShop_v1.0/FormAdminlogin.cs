using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerShop_v1._0
{
    public partial class FormAdminlogin : Form
    {
        public FormAdminlogin()
        {
            InitializeComponent();
        }
        string admin_name = "Admin";
        string admin_pass = "Admin";
        private void btn_AdminLoginSubmit_Click(object sender, EventArgs e)
        {
            //string admin_name_input= txtbox_AdminName.Text;
            //string admin_pass_input= txtbox_AdminPassword.Text;

            //if ((admin_name_input == admin_name) && (admin_pass_input == admin_pass))
            //{
                MDIAdmin objFormAdminPanel = new MDIAdmin();
                objFormAdminPanel.Show();
                this.Close();
            //}
            //else
                //MessageBox.Show("username or password is incorrect");
        }
    }
}
