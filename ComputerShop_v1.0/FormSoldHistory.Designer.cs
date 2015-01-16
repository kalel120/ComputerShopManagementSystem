namespace ComputerShop_v1._0
{
    partial class FormSoldHistory
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
            if ( disposing && ( components != null ) )
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
            this.dtg_soldhistory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_soldhistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_soldhistory
            // 
            this.dtg_soldhistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_soldhistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_soldhistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_soldhistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_soldhistory.Location = new System.Drawing.Point(12, 12);
            this.dtg_soldhistory.Name = "dtg_soldhistory";
            this.dtg_soldhistory.Size = new System.Drawing.Size(687, 459);
            this.dtg_soldhistory.TabIndex = 0;
            // 
            // FormSoldHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 483);
            this.Controls.Add(this.dtg_soldhistory);
            this.Name = "FormSoldHistory";
            this.Text = "Sold History";
            this.Load += new System.EventHandler(this.FormSoldHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_soldhistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_soldhistory;
    }
}