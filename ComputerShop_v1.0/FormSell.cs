using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ComputerShop_v1._0
{
    public partial class FormSell : Form
    {
        DateTime curDate = DateTime.Now;
        public FormSell()
        {
            InitializeComponent ();
        }

        private void btn_ShowSoldData_Click(object sender, EventArgs e)
        {
            //MessageBox.Show ("Purchase Confirmed", "Cornfirmation");
            string strConnection = @"Data Source=F_NOOB-PC\;Initial Catalog=ComShopDB;Integrated Security=True";
            SqlConnection objcon = new SqlConnection (strConnection);
            objcon.Open ();
            string strcmd = "SELECT cusID as 'Customer ID',cusName as 'Customer Name', cusMobile as 'Customer Moblie No.',cusBuyDate as 'Buy Date',partID as 'Product SN',partCat as 'Product Category',partModel as 'Product Model',partPrice as 'Price' FROM SellRecord";
            SqlCommand objcmd = new SqlCommand (strcmd, objcon);

            DataSet objDataset = new DataSet ();
            SqlDataAdapter objAdapter = new SqlDataAdapter (objcmd);
            objAdapter.Fill (objDataset);
            dtg_Sell.DataSource = objDataset.Tables[0];
            objcon.Close ();
        }

        private void btn_CancelSell_Click(object sender, EventArgs e)
        {
            MessageBox.Show ("Cancelled", "Confirmation");
        }

        private void FormSell_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point (0, 0);
            this.Size = new Size (w, h - 40);
        }

        private void btn_InputCancel_Click(object sender, EventArgs e)
        {
            txtbox_ProductSerial.Clear ();
            txtbox_CsMail.Clear ();
            txtbox_CsMobNum.Clear ();
            txtbox_CsName.Clear ();
        }

        private void btn_InputConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                int product_serial = Convert.ToInt32 (txtbox_ProductSerial.Text);
                string strConnection = @"Data Source=F_NOOB-PC\;Initial Catalog=ComShopDB;Integrated Security=True";
                SqlConnection objcon = new SqlConnection (strConnection);

                string strcmd1 = @"SELECT partID,partAvailable 
                                 FROM Parts WHERE partID = " + product_serial + " +AND partAvailable ='yes'";
                SqlCommand objcmd1 = new SqlCommand (strcmd1, objcon);

                objcon.Open ();
                SqlDataReader reader = objcmd1.ExecuteReader ();

                if ( reader.Read () )
                {
                    objcon.Close ();
                    objcon.Open ();
                    string strcmd2 = "INSERT INTO Customer (cusName,cusMobile,cusMail,cusBuyDate,cusPartID) VALUES ('" + txtbox_CsName.Text + "','" + txtbox_CsMobNum.Text + "','" + txtbox_CsMail.Text + "','" + curDate + "','" + product_serial + "')";
                    SqlCommand objcmd2 = new SqlCommand (strcmd2, objcon);
                    objcmd2.ExecuteNonQuery ();

                    string strcmd3 = "INSERT INTO SellRecord (cusID,cusName,cusMobile,cusBuyDate,partID,partCat,partModel,partPrice) SELECT c.cusID,c.cusName,c.cusMobile,c.cusBuyDate,p.partID,p.partCat,p.partModel,p.partPrice FROM Customer as c,Parts as p WHERE c.cusPartID = p.partID AND p.partID = " + product_serial + "";
                    SqlCommand objcmd3 = new SqlCommand (strcmd3, objcon);
                    objcmd3.ExecuteNonQuery ();

                    string strcmd4 = "UPDATE Parts SET partAvailable='sold' WHERE partID=" + product_serial + "";
                    SqlCommand objcmd4 = new SqlCommand (strcmd4, objcon);
                    objcmd4.ExecuteNonQuery ();
                    objcon.Close ();
                    MessageBox.Show ("Added to Cart!");
                }
                else
                {
                    MessageBox.Show ("That Paticular item is not available");
                    objcon.Close ();
                }
            }
            catch
            {
                if ( ( txtbox_CsMail.Text == string.Empty ) | ( txtbox_CsMobNum.Text == string.Empty ) | ( txtbox_CsName.Text == string.Empty ) | ( txtbox_ProductSerial.Text == string.Empty ) )
                {
                    MessageBox.Show ("Required Field/s are empty", "Error");
                }
            }

        }

        private void btn_Again_Click(object sender, EventArgs e)
        {
            if ( ( txtbox_CsMail.Text == string.Empty ) | ( txtbox_CsMobNum.Text == string.Empty ) | ( txtbox_CsName.Text == string.Empty ) | ( txtbox_ProductSerial.Text == string.Empty ) )
            {
                MessageBox.Show ("Required Field/s are empty", "Error");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show ("Sell to Same Customer?", "Product Sell", MessageBoxButtons.YesNo);
                if ( dialogResult == DialogResult.Yes )
                {
                    txtbox_ProductSerial.Clear ();
                }
                else if ( dialogResult == DialogResult.No )
                {
                    txtbox_CsMail.Clear ();
                    txtbox_CsMobNum.Clear ();
                    txtbox_CsName.Clear ();
                    txtbox_ProductSerial.Clear ();
                }
            }
        }

    }
}

