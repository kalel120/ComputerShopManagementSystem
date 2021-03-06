﻿using System;
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
    public partial class FormPreview : Form
    {
        public FormPreview()
        {
            InitializeComponent ();
        }

        private void btn_ClosePreview_Click(object sender, EventArgs e)
        {
            this.Close ();
        }

        private void btn_PreviwSearch_Click(object sender, EventArgs e)
        {
            if (cmbox_Catagory.Text == string.Empty | txtbox_PreviewSearch.Text == string.Empty)
                MessageBox.Show("Required Fields are Empty","Error");
            else
            {
                string strcon = @"Data Source=F_NOOB-PC\;Initial Catalog=ComShopDB;Integrated Security=True";
                SqlConnection objcon = new SqlConnection(strcon);
                objcon.Open();
                //Sql Command
                string strcmd = "SELECT partID as 'Product SN', partCat as 'Catagory',partModel as 'Model Name',partCompany as 'Company Name',partPrice 'Price',partAvailable as 'Available' FROM Parts WHERE partCat ='"+cmbox_Catagory.Text+"' AND partModel LIKE '%"+txtbox_PreviewSearch.Text+"%' ";
                SqlCommand objcmd = new SqlCommand(strcmd, objcon);
                //Bind Data with UI
                DataSet objDataSet = new DataSet();                      //Creating an object of DataSet Class
                SqlDataAdapter objAdapter = new SqlDataAdapter(objcmd); //Creating an objcect of SqlDataAdapter Class and send the query command objct as the parameter of it
                objAdapter.Fill(objDataSet);                              //Fill the Adapter object with dataset object
                dataGridView1.DataSource = objDataSet.Tables[0];//set the source of dataGirdview as dataset object.table
            }
        }

        int parts_info = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                parts_info = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
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
