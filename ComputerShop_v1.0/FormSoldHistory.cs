using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace ComputerShop_v1._0
{
    public partial class FormSoldHistory : Form
    {
        public FormSoldHistory()
        {
            InitializeComponent ();
        }

        private void FormSoldHistory_Load(object sender, EventArgs e)
        {
            //open connection
            string strConnection = @"Data Source=F_NOOB-PC\;Initial Catalog=ComShopDB;Integrated Security=True";
            SqlConnection objConnection = new SqlConnection (strConnection);
            objConnection.Open ();
            //command
            string strcmd = "SELECT * FROM SellRecord";
            SqlCommand objcmd = new SqlCommand (strcmd,objConnection);
            //Bind with UI
            DataSet objDataset = new DataSet ();
            SqlDataAdapter objAdapter = new SqlDataAdapter (objcmd);
            objAdapter.Fill (objDataset);
            dtg_soldhistory.DataSource = objDataset.Tables[0];
            objConnection.Close ();
        }
    }
}
