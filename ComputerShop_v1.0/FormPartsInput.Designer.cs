namespace ComputerShop_v1._0
{
    partial class FormPartsInput
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_InputDetail = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_ConfirmInput = new System.Windows.Forms.Button();
            this.btn_CancelInput = new System.Windows.Forms.Button();
            this.picbox_Input = new System.Windows.Forms.PictureBox();
            this.btn_LoadImage = new System.Windows.Forms.Button();
            this.txtbox_PID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_PartsCompany = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbox_ModelName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbox_PartsPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbox_Catagory = new System.Windows.Forms.ComboBox();
            this.txtbox_picPath = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Input)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Catagory";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tab_InputDetail);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(15, 263);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(707, 226);
            this.tabControl1.TabIndex = 12;
            // 
            // tab_InputDetail
            // 
            this.tab_InputDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_InputDetail.Location = new System.Drawing.Point(4, 22);
            this.tab_InputDetail.Name = "tab_InputDetail";
            this.tab_InputDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tab_InputDetail.Size = new System.Drawing.Size(699, 200);
            this.tab_InputDetail.TabIndex = 0;
            this.tab_InputDetail.Text = "Specification";
            this.tab_InputDetail.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(699, 222);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Review";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_ConfirmInput
            // 
            this.btn_ConfirmInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ConfirmInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConfirmInput.Location = new System.Drawing.Point(12, 509);
            this.btn_ConfirmInput.Name = "btn_ConfirmInput";
            this.btn_ConfirmInput.Size = new System.Drawing.Size(120, 23);
            this.btn_ConfirmInput.TabIndex = 13;
            this.btn_ConfirmInput.Text = "Confirm";
            this.btn_ConfirmInput.UseVisualStyleBackColor = true;
            this.btn_ConfirmInput.Click += new System.EventHandler(this.btn_ConfirmInput_Click);
            // 
            // btn_CancelInput
            // 
            this.btn_CancelInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CancelInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelInput.Location = new System.Drawing.Point(602, 509);
            this.btn_CancelInput.Name = "btn_CancelInput";
            this.btn_CancelInput.Size = new System.Drawing.Size(120, 23);
            this.btn_CancelInput.TabIndex = 14;
            this.btn_CancelInput.Text = "Cancel";
            this.btn_CancelInput.UseVisualStyleBackColor = true;
            this.btn_CancelInput.Click += new System.EventHandler(this.btn_CancelInput_Click);
            // 
            // picbox_Input
            // 
            this.picbox_Input.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picbox_Input.Location = new System.Drawing.Point(488, 12);
            this.picbox_Input.Name = "picbox_Input";
            this.picbox_Input.Size = new System.Drawing.Size(230, 179);
            this.picbox_Input.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_Input.TabIndex = 15;
            this.picbox_Input.TabStop = false;
            // 
            // btn_LoadImage
            // 
            this.btn_LoadImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_LoadImage.Location = new System.Drawing.Point(618, 234);
            this.btn_LoadImage.Name = "btn_LoadImage";
            this.btn_LoadImage.Size = new System.Drawing.Size(100, 23);
            this.btn_LoadImage.TabIndex = 16;
            this.btn_LoadImage.Text = "Browse Picture";
            this.btn_LoadImage.UseVisualStyleBackColor = true;
            this.btn_LoadImage.Click += new System.EventHandler(this.btn_LoadImage_Click);
            // 
            // txtbox_PID
            // 
            this.txtbox_PID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_PID.Location = new System.Drawing.Point(147, 68);
            this.txtbox_PID.Name = "txtbox_PID";
            this.txtbox_PID.Size = new System.Drawing.Size(300, 22);
            this.txtbox_PID.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Component ID/SN";
            // 
            // txtbox_PartsCompany
            // 
            this.txtbox_PartsCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_PartsCompany.Location = new System.Drawing.Point(147, 103);
            this.txtbox_PartsCompany.Name = "txtbox_PartsCompany";
            this.txtbox_PartsCompany.Size = new System.Drawing.Size(300, 22);
            this.txtbox_PartsCompany.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Company Name";
            // 
            // txtbox_ModelName
            // 
            this.txtbox_ModelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_ModelName.Location = new System.Drawing.Point(147, 136);
            this.txtbox_ModelName.Name = "txtbox_ModelName";
            this.txtbox_ModelName.Size = new System.Drawing.Size(300, 22);
            this.txtbox_ModelName.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Model Name";
            // 
            // txtbox_PartsPrice
            // 
            this.txtbox_PartsPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_PartsPrice.Location = new System.Drawing.Point(147, 169);
            this.txtbox_PartsPrice.Name = "txtbox_PartsPrice";
            this.txtbox_PartsPrice.Size = new System.Drawing.Size(300, 22);
            this.txtbox_PartsPrice.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Component Price";
            // 
            // cmbox_Catagory
            // 
            this.cmbox_Catagory.AutoCompleteCustomSource.AddRange(new string[] {
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
            this.cmbox_Catagory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbox_Catagory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbox_Catagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cmbox_Catagory.Location = new System.Drawing.Point(147, 31);
            this.cmbox_Catagory.Name = "cmbox_Catagory";
            this.cmbox_Catagory.Size = new System.Drawing.Size(300, 24);
            this.cmbox_Catagory.TabIndex = 27;
            // 
            // txtbox_picPath
            // 
            this.txtbox_picPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_picPath.Location = new System.Drawing.Point(488, 208);
            this.txtbox_picPath.Name = "txtbox_picPath";
            this.txtbox_picPath.Size = new System.Drawing.Size(230, 20);
            this.txtbox_picPath.TabIndex = 28;
            // 
            // FormPartsInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 561);
            this.Controls.Add(this.txtbox_picPath);
            this.Controls.Add(this.cmbox_Catagory);
            this.Controls.Add(this.txtbox_PartsPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbox_ModelName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbox_PartsCompany);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbox_PID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_LoadImage);
            this.Controls.Add(this.picbox_Input);
            this.Controls.Add(this.btn_CancelInput);
            this.Controls.Add(this.btn_ConfirmInput);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormPartsInput";
            this.Text = "Component Input";
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_InputDetail;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_ConfirmInput;
        private System.Windows.Forms.Button btn_CancelInput;
        private System.Windows.Forms.PictureBox picbox_Input;
        private System.Windows.Forms.Button btn_LoadImage;
        private System.Windows.Forms.TextBox txtbox_PID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_PartsCompany;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbox_ModelName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbox_PartsPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbox_Catagory;
        private System.Windows.Forms.TextBox txtbox_picPath;
    }
}