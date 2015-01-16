using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ComputerShop_v1._0
{
    public partial class FormProductHistory : Form
    {
        public FormProductHistory()
        {
            InitializeComponent ();
        }

        private void btn_ViewProduct_Click(object sender, EventArgs e)
        {
            string strConnection = @"Data Source=F_NOOB-PC\;Initial Catalog=ComShopDB;Integrated Security=True";
            SqlConnection objcon = new SqlConnection (strConnection);
            objcon.Open ();

            //writing command
            string strcmd = "SELECT partID as 'Product SN',partCat as 'Product Catagory',partCompany as 'Company',partModel as 'Model',partPrice as 'Price',partAvailable as 'Available' FROM Parts WHERE partCat='"+cmbox_ProductCatagory.Text+"'";
            SqlCommand objcmd = new SqlCommand (strcmd,objcon);

            //Bind Data with DataGrid View
            DataSet objDataset = new DataSet ();
            SqlDataAdapter objAdapter = new SqlDataAdapter (objcmd);
            objAdapter.Fill (objDataset);
            dtg_ProductHistory.DataSource=objDataset.Tables[0];
            
            //Close Connection
            objcon.Close ();
        }

        private void FormProductHistory_Load(object sender, EventArgs e)
        {
            
        }
    }
}
