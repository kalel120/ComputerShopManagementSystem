namespace ComputerShop_v1._0
{
    partial class FormProductHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbox_ProductCatagory = new System.Windows.Forms.ComboBox();
            this.btn_ViewProduct = new System.Windows.Forms.Button();
            this.dtg_ProductHistory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ProductHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Catagory";
            // 
            // cmbox_ProductCatagory
            // 
            this.cmbox_ProductCatagory.AutoCompleteCustomSource.AddRange(new string[] {
            "Motherboard ",
            "Processor",
            "RAM",
            "Graphics Card",
            "Monitor",
            "HDD",
            "Ext.HDD",
            "Keyboard ",
            "Mouse",
            "Chassis",
            "Speaker",
            "Printer",
            "Flash Drive",
            "Accessories"});
            this.cmbox_ProductCatagory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbox_ProductCatagory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbox_ProductCatagory.FormattingEnabled = true;
            this.cmbox_ProductCatagory.Items.AddRange(new object[] {
            "Motherboard ",
            "Processor",
            "RAM",
            "Graphics Card",
            "Monitor",
            "HDD",
            "Ext.HDD",
            "Keyboard ",
            "Mouse",
            "Chassis",
            "Speaker",
            "Printer",
            "Flash Drive",
            "Accessories"});
            this.cmbox_ProductCatagory.Location = new System.Drawing.Point(150, 22);
            this.cmbox_ProductCatagory.Name = "cmbox_ProductCatagory";
            this.cmbox_ProductCatagory.Size = new System.Drawing.Size(170, 21);
            this.cmbox_ProductCatagory.TabIndex = 1;
            // 
            // btn_ViewProduct
            // 
            this.btn_ViewProduct.Location = new System.Drawing.Point(356, 22);
            this.btn_ViewProduct.Name = "btn_ViewProduct";
            this.btn_ViewProduct.Size = new System.Drawing.Size(75, 23);
            this.btn_ViewProduct.TabIndex = 2;
            this.btn_ViewProduct.Text = "View";
            this.btn_ViewProduct.UseVisualStyleBackColor = true;
            this.btn_ViewProduct.Click += new System.EventHandler(this.btn_ViewProduct_Click);
            // 
            // dtg_ProductHistory
            // 
            this.dtg_ProductHistory.AllowUserToAddRows = false;
            this.dtg_ProductHistory.AllowUserToDeleteRows = false;
            this.dtg_ProductHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_ProductHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_ProductHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_ProductHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ProductHistory.Location = new System.Drawing.Point(12, 61);
            this.dtg_ProductHistory.Name = "dtg_ProductHistory";
            this.dtg_ProductHistory.ReadOnly = true;
            this.dtg_ProductHistory.Size = new System.Drawing.Size(710, 470);
            this.dtg_ProductHistory.TabIndex = 3;
            // 
            // FormProductHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 561);
            this.Controls.Add(this.dtg_ProductHistory);
            this.Controls.Add(this.btn_ViewProduct);
            this.Controls.Add(this.cmbox_ProductCatagory);
            this.Controls.Add(this.label1);
            this.Name = "FormProductHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product History";
            this.Load += new System.EventHandler(this.FormProductHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ProductHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbox_ProductCatagory;
        private System.Windows.Forms.Button btn_ViewProduct;
        private System.Windows.Forms.DataGridView dtg_ProductHistory;
    }
}