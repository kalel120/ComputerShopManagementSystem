namespace ComputerShop_v1._0
{
    partial class FormOperatorPanel
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
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip_OpPanel = new System.Windows.Forms.MenuStrip();
            this.sellingComponentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soldHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productWarrentyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_OpPanelSearch = new System.Windows.Forms.TextBox();
            this.btn_OpPanelSearch = new System.Windows.Forms.Button();
            this.dtg_OpPanel_Search = new System.Windows.Forms.DataGridView();
            this.btn_Exit2mm = new System.Windows.Forms.Button();
            this.btn_clearGridview = new System.Windows.Forms.Button();
            this.menuStrip_OpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_OpPanel_Search)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip_OpPanel
            // 
            this.menuStrip_OpPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sellingComponentsToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.manageToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip_OpPanel.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_OpPanel.Name = "menuStrip_OpPanel";
            this.menuStrip_OpPanel.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip_OpPanel.Size = new System.Drawing.Size(734, 24);
            this.menuStrip_OpPanel.TabIndex = 0;
            this.menuStrip_OpPanel.Text = "menuStrip1";
            this.menuStrip_OpPanel.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_OpPanel_ItemClicked);
            // 
            // sellingComponentsToolStripMenuItem
            // 
            this.sellingComponentsToolStripMenuItem.Checked = true;
            this.sellingComponentsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sellingComponentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.previewProductToolStripMenuItem,
            this.sellToolStripMenuItem});
            this.sellingComponentsToolStripMenuItem.Name = "sellingComponentsToolStripMenuItem";
            this.sellingComponentsToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.sellingComponentsToolStripMenuItem.Text = "Selling Components";
            // 
            // previewProductToolStripMenuItem
            // 
            this.previewProductToolStripMenuItem.Name = "previewProductToolStripMenuItem";
            this.previewProductToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.previewProductToolStripMenuItem.Text = "Preview Product";
            this.previewProductToolStripMenuItem.Click += new System.EventHandler(this.previewProductToolStripMenuItem_Click);
            // 
            // sellToolStripMenuItem
            // 
            this.sellToolStripMenuItem.Name = "sellToolStripMenuItem";
            this.sellToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.sellToolStripMenuItem.Text = "Sell";
            this.sellToolStripMenuItem.Click += new System.EventHandler(this.sellToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soldHistoryToolStripMenuItem,
            this.productHistoryToolStripMenuItem});
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.historyToolStripMenuItem.Text = "History";
            // 
            // soldHistoryToolStripMenuItem
            // 
            this.soldHistoryToolStripMenuItem.Name = "soldHistoryToolStripMenuItem";
            this.soldHistoryToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.soldHistoryToolStripMenuItem.Text = "Sold History";
            // 
            // productHistoryToolStripMenuItem
            // 
            this.productHistoryToolStripMenuItem.Name = "productHistoryToolStripMenuItem";
            this.productHistoryToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.productHistoryToolStripMenuItem.Text = "Product History";
            this.productHistoryToolStripMenuItem.Click += new System.EventHandler(this.productHistoryToolStripMenuItem_Click);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productWarrentyToolStripMenuItem});
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // productWarrentyToolStripMenuItem
            // 
            this.productWarrentyToolStripMenuItem.Name = "productWarrentyToolStripMenuItem";
            this.productWarrentyToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.productWarrentyToolStripMenuItem.Text = "Product Warrenty";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Search String";
            // 
            // txtbox_OpPanelSearch
            // 
            this.txtbox_OpPanelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_OpPanelSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtbox_OpPanelSearch.Location = new System.Drawing.Point(184, 51);
            this.txtbox_OpPanelSearch.Name = "txtbox_OpPanelSearch";
            this.txtbox_OpPanelSearch.Size = new System.Drawing.Size(289, 22);
            this.txtbox_OpPanelSearch.TabIndex = 2;
            // 
            // btn_OpPanelSearch
            // 
            this.btn_OpPanelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_OpPanelSearch.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpPanelSearch.Location = new System.Drawing.Point(521, 48);
            this.btn_OpPanelSearch.Name = "btn_OpPanelSearch";
            this.btn_OpPanelSearch.Size = new System.Drawing.Size(113, 25);
            this.btn_OpPanelSearch.TabIndex = 3;
            this.btn_OpPanelSearch.Text = "Search";
            this.btn_OpPanelSearch.UseVisualStyleBackColor = true;
            this.btn_OpPanelSearch.Click += new System.EventHandler(this.btn_OpPanelSearch_Click);
            // 
            // dtg_OpPanel_Search
            // 
            this.dtg_OpPanel_Search.AllowUserToAddRows = false;
            this.dtg_OpPanel_Search.AllowUserToDeleteRows = false;
            this.dtg_OpPanel_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_OpPanel_Search.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_OpPanel_Search.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_OpPanel_Search.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtg_OpPanel_Search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_OpPanel_Search.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_OpPanel_Search.GridColor = System.Drawing.SystemColors.Control;
            this.dtg_OpPanel_Search.Location = new System.Drawing.Point(15, 97);
            this.dtg_OpPanel_Search.Name = "dtg_OpPanel_Search";
            this.dtg_OpPanel_Search.ReadOnly = true;
            this.dtg_OpPanel_Search.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtg_OpPanel_Search.Size = new System.Drawing.Size(707, 265);
            this.dtg_OpPanel_Search.TabIndex = 4;
            this.dtg_OpPanel_Search.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_OpPanel_Search_CellClick);
            // 
            // btn_Exit2mm
            // 
            this.btn_Exit2mm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Exit2mm.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit2mm.Location = new System.Drawing.Point(12, 377);
            this.btn_Exit2mm.Name = "btn_Exit2mm";
            this.btn_Exit2mm.Size = new System.Drawing.Size(113, 25);
            this.btn_Exit2mm.TabIndex = 5;
            this.btn_Exit2mm.Text = "Back";
            this.btn_Exit2mm.UseVisualStyleBackColor = true;
            this.btn_Exit2mm.Click += new System.EventHandler(this.btn_Exit2mm_Click);
            // 
            // btn_clearGridview
            // 
            this.btn_clearGridview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_clearGridview.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearGridview.Location = new System.Drawing.Point(569, 377);
            this.btn_clearGridview.Name = "btn_clearGridview";
            this.btn_clearGridview.Size = new System.Drawing.Size(153, 25);
            this.btn_clearGridview.TabIndex = 6;
            this.btn_clearGridview.Text = "Clear Search Result";
            this.btn_clearGridview.UseVisualStyleBackColor = true;
            this.btn_clearGridview.Click += new System.EventHandler(this.btn_clearGridview_Click);
            // 
            // FormOperatorPanel
            // 
            this.AcceptButton = this.btn_OpPanelSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 414);
            this.Controls.Add(this.btn_clearGridview);
            this.Controls.Add(this.btn_Exit2mm);
            this.Controls.Add(this.dtg_OpPanel_Search);
            this.Controls.Add(this.btn_OpPanelSearch);
            this.Controls.Add(this.txtbox_OpPanelSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip_OpPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip_OpPanel;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormOperatorPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operator Panel";
            this.Load += new System.EventHandler(this.FormOperatorPanel_Load);
            this.menuStrip_OpPanel.ResumeLayout(false);
            this.menuStrip_OpPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_OpPanel_Search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_OpPanel;
        private System.Windows.Forms.ToolStripMenuItem sellingComponentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previewProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soldHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productWarrentyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_OpPanelSearch;
        private System.Windows.Forms.Button btn_OpPanelSearch;
        private System.Windows.Forms.DataGridView dtg_OpPanel_Search;
        private System.Windows.Forms.Button btn_Exit2mm;
        private System.Windows.Forms.Button btn_clearGridview;


    }
}