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
using System.IO;

namespace ComputerShop_v1._0
{
    public partial class FormPartsInput : Form
    {
        public FormPartsInput()
        {
            InitializeComponent ();
        }

        private void btn_ConfirmInput_Click(object sender, EventArgs e)
        {
            byte[] imgbt = null;
            FileStream frstream= new FileStream(txtbox_picPath.Text,FileMode.Open,FileAccess.Read);
            BinaryReader br = new BinaryReader(frstream);
            imgbt = br.ReadBytes((int)frstream.Length);

            string strpid = txtbox_PID.Text;
            int intpid = Convert.ToInt32 (strpid);
            //open a connection
            string strConnection = @"Data Source=F_NOOB-PC\;Initial Catalog=ComShopDB;Integrated Security=True";
            SqlConnection objConnection = new SqlConnection (strConnection);
            //SqlDataReader rd = new SqlDataReader();
            objConnection.Open ();

            //Writing SQL Command
            string strcmd = "INSERT INTO Parts (partCat,partID,partCompany,partModel,partPrice,partAvailable,partImage) VALUES ( '" + cmbox_Catagory.Text + "','" + intpid + "','" + txtbox_PartsCompany.Text + "','" + txtbox_ModelName.Text + "','" + txtbox_PartsPrice.Text + "','yes',@IMG)";
            SqlCommand objcmd = new SqlCommand (strcmd, objConnection);
            objcmd.Parameters.AddWithValue("@IMG",imgbt);
            objcmd.ExecuteNonQuery ();

            //Close the connection
            objConnection.Close ();

            MessageBox.Show ("Input Confirmed", "Confirmation");
        }

        private void btn_CancelInput_Click(object sender, EventArgs e)
        {
            txtbox_ModelName.Clear ();
            txtbox_PartsCompany.Clear ();
            txtbox_PartsPrice.Clear ();
            txtbox_PID.Clear ();
            MessageBox.Show ("Canceled", "Confirmation");
        }

        public void btn_LoadImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog objOfd = new OpenFileDialog ();
                objOfd.Filter = "Image only. |*.jpg; *.jpeg; *.png; *.bmp;";
                DialogResult dr = objOfd.ShowDialog ();
   
                string picPath = objOfd.FileName.ToString();
                txtbox_picPath.Text = picPath;
                picbox_Input.ImageLocation = picPath;
                
            }
            catch ( Exception ex )
            {
                MessageBox.Show (ex.Message);
            }



        }
    }
}
