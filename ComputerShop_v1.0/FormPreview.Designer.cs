namespace ComputerShop_v1._0
{
    partial class FormPreview
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
            this.btn_PreviwSearch = new System.Windows.Forms.Button();
            this.txtbox_PreviewSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbox_Catagory = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_ClosePreview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_PreviwSearch
            // 
            this.btn_PreviwSearch.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PreviwSearch.Location = new System.Drawing.Point(446, 66);
            this.btn_PreviwSearch.Name = "btn_PreviwSearch";
            this.btn_PreviwSearch.Size = new System.Drawing.Size(100, 25);
            this.btn_PreviwSearch.TabIndex = 11;
            this.btn_PreviwSearch.Text = "Search";
            this.btn_PreviwSearch.UseVisualStyleBackColor = true;
            this.btn_PreviwSearch.Click += new System.EventHandler(this.btn_PreviwSearch_Click);
            // 
            // txtbox_PreviewSearch
            // 
            this.txtbox_PreviewSearch.Location = new System.Drawing.Point(168, 70);
            this.txtbox_PreviewSearch.Name = "txtbox_PreviewSearch";
            this.txtbox_PreviewSearch.Size = new System.Drawing.Size(260, 20);
            this.txtbox_PreviewSearch.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Chose Catagory";
            // 
            // cmbox_Catagory
            // 
            this.cmbox_Catagory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbox_Catagory.FormattingEnabled = true;
            this.cmbox_Catagory.Items.AddRange(new object[] {
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
            this.cmbox_Catagory.Location = new System.Drawing.Point(168, 30);
            this.cmbox_Catagory.Name = "cmbox_Catagory";
            this.cmbox_Catagory.Size = new System.Drawing.Size(260, 21);
            this.cmbox_Catagory.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.Size = new System.Drawing.Size(707, 395);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_ClosePreview
            // 
            this.btn_ClosePreview.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClosePreview.Location = new System.Drawing.Point(15, 524);
            this.btn_ClosePreview.Name = "btn_ClosePreview";
            this.btn_ClosePreview.Size = new System.Drawing.Size(100, 25);
            this.btn_ClosePreview.TabIndex = 14;
            this.btn_ClosePreview.Text = "Back";
            this.btn_ClosePreview.UseVisualStyleBackColor = true;
            this.btn_ClosePreview.Click += new System.EventHandler(this.btn_ClosePreview_Click);
            // 
            // FormPreview
            // 
            this.AcceptButton = this.btn_PreviwSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 561);
            this.Controls.Add(this.btn_ClosePreview);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbox_Catagory);
            this.Controls.Add(this.btn_PreviwSearch);
            this.Controls.Add(this.txtbox_PreviewSearch);
            this.Controls.Add(this.label4);
            this.Name = "FormPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preview";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_PreviwSearch;
        private System.Windows.Forms.TextBox txtbox_PreviewSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbox_Catagory;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_ClosePreview;
    }
}