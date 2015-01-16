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
using System.IO;                //For using memory stream//

namespace ComputerShop_v1._0
{
    public partial class FormShowProduct : Form
    {
        public FormShowProduct(int product_info)
        {
            InitializeComponent();
            lbl_product_Serial.Text = Convert.ToString(product_info);
        }

        private void FormShowProduct_Load(object sender, EventArgs e)
        {
            string strcon = @"Data Source=F_NOOB-PC\;Initial Catalog=ComShopDB;Integrated Security=True";
            SqlConnection objcon = new SqlConnection(strcon);
            objcon.Open();

            string strcmd = "SELECT * FROM Parts WHERE partID=" + Convert.ToInt32(lbl_product_Serial.Text) + "";
            SqlCommand objcmd = new SqlCommand(strcmd, objcon);

            DataSet objDataSet = new DataSet();
            SqlDataAdapter objAdapter = new SqlDataAdapter(objcmd);
            objAdapter.Fill(objDataSet);

            lbl_catagory.Text = objDataSet.Tables[0].Rows[0][1].ToString();
            lbl_company.Text = objDataSet.Tables[0].Rows[0][2].ToString();
            lbl_ModelName.Text = objDataSet.Tables[0].Rows[0][3].ToString();
            lbl_Price.Text = objDataSet.Tables[0].Rows[0][4].ToString();

            //Byte[] data = new Byte[0];
            try
            {
                Byte[] imgdata = (Byte[])(objDataSet.Tables[0].Rows[0][6]);
                MemoryStream mem = new MemoryStream(imgdata);
                pictureBox1.Image = System.Drawing.Image.FromStream(mem);
            }
            catch
            {
                pictureBox1.Image = null;
            }
        }

    }
}
