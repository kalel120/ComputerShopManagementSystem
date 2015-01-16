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
    public partial class ComShopMM : Form
    {
        public ComShopMM()
        {
            InitializeComponent();
        }

        private void btn_Adminlogin_Click(object sender, EventArgs e)
        {
            FormAdminlogin objFormAdminlogin = new FormAdminlogin();
            objFormAdminlogin.Show();
        }

        private void btn_StaffLogin_Click(object sender, EventArgs e)
        {
            FormOperatorPanel objFormStaffPanle = new FormOperatorPanel();
            objFormStaffPanle.Show();
        }

        
    }
}
