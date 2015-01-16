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
    public partial class FormOperatorPanel : Form
    {
        public FormOperatorPanel()
        {
            InitializeComponent();

        }

        private void btn_Exit2mm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSell objFormSell = new FormSell();
            objFormSell.Show();
        }

        private void previewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPreview objFormPreviw = new FormPreview();
            objFormPreviw.Show();
        }

        private void menuStrip_OpPanel_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FormOperatorPanel_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h - 40);
        }

        private void productHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProductHistory objFormProductHistory = new FormProductHistory();
            objFormProductHistory.Show();
        }

        private void btn_OpPanelSearch_Click(object sender, EventArgs e)
        {
            if (txtbox_OpPanelSearch.Text == string.Empty)
                MessageBox.Show("You Have to write something to search", "Error");
            else
            {
                string strcon = @"Data Source=F_NOOB-PC\;Initial Catalog=ComShopDB;Integrated Security=True";
                SqlConnection objcon = new SqlConnection(strcon);
                objcon.Open();
                //Sql Command
                string strcmd = "SELECT partID as 'Product SN', partCat as 'Catagory',partModel as 'Model Name',partCompany as 'Company Name',partPrice 'Price',partAvailable as 'Available' FROM Parts WHERE partModel Like '%" + txtbox_OpPanelSearch.Text + "%' AND partAvailable='yes' ";
                SqlCommand objcmd = new SqlCommand(strcmd, objcon);
                //Bind Data with UI
                DataSet objDataSet = new DataSet();                      //Creating an object of DataSet Class
                SqlDataAdapter objAdapter = new SqlDataAdapter(objcmd); //Creating an objcect of SqlDataAdapter Class and send the query command objct as the parameter of it
                objAdapter.Fill(objDataSet);                              //Fill the Adapter object with dataset object
                dtg_OpPanel_Search.DataSource = objDataSet.Tables[0];       //set the source of dataGirdview as dataset object.table
            }
        }

        private void btn_clearGridview_Click(object sender, EventArgs e)
        {
            dtg_OpPanel_Search.DataSource = null;
        }

        int parts_info = 0;
        private void dtg_OpPanel_Search_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                parts_info = Convert.ToInt32(dtg_OpPanel_Search.Rows[e.RowIndex].Cells[0].Value.ToString());
                FormShowProduct objFshowProduct = new FormShowProduct(parts_info);
                objFshowProduct.Show();
            }
            catch
            {
                MessageBox.Show("Click Any Cell to Show Information", "Error");
            }
        }
    }
}
