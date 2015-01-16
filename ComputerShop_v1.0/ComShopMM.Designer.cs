namespace ComputerShop_v1._0
{
    partial class ComShopMM
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbox_StaffName = new System.Windows.Forms.TextBox();
            this.txtbox_StaffPassword = new System.Windows.Forms.TextBox();
            this.btn_Adminlogin = new System.Windows.Forms.Button();
            this.btn_StaffLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Computer Shop Management System";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Login as Staff";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "User Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password";
            // 
            // txtbox_StaffName
            // 
            this.txtbox_StaffName.Location = new System.Drawing.Point(141, 153);
            this.txtbox_StaffName.Name = "txtbox_StaffName";
            this.txtbox_StaffName.Size = new System.Drawing.Size(100, 20);
            this.txtbox_StaffName.TabIndex = 5;
            // 
            // txtbox_StaffPassword
            // 
            this.txtbox_StaffPassword.Location = new System.Drawing.Point(141, 187);
            this.txtbox_StaffPassword.Name = "txtbox_StaffPassword";
            this.txtbox_StaffPassword.Size = new System.Drawing.Size(100, 20);
            this.txtbox_StaffPassword.TabIndex = 6;
            // 
            // btn_Adminlogin
            // 
            this.btn_Adminlogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Adminlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Adminlogin.Location = new System.Drawing.Point(604, 107);
            this.btn_Adminlogin.Name = "btn_Adminlogin";
            this.btn_Adminlogin.Size = new System.Drawing.Size(117, 33);
            this.btn_Adminlogin.TabIndex = 7;
            this.btn_Adminlogin.Text = "Admin Login";
            this.btn_Adminlogin.UseVisualStyleBackColor = true;
            this.btn_Adminlogin.Click += new System.EventHandler(this.btn_Adminlogin_Click);
            // 
            // btn_StaffLogin
            // 
            this.btn_StaffLogin.Location = new System.Drawing.Point(65, 229);
            this.btn_StaffLogin.Name = "btn_StaffLogin";
            this.btn_StaffLogin.Size = new System.Drawing.Size(75, 23);
            this.btn_StaffLogin.TabIndex = 8;
            this.btn_StaffLogin.Text = "Submit";
            this.btn_StaffLogin.UseVisualStyleBackColor = true;
            this.btn_StaffLogin.Click += new System.EventHandler(this.btn_StaffLogin_Click);
            // 
            // ComShopMM
            // 
            this.AcceptButton = this.btn_StaffLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 311);
            this.Controls.Add(this.btn_StaffLogin);
            this.Controls.Add(this.btn_Adminlogin);
            this.Controls.Add(this.txtbox_StaffPassword);
            this.Controls.Add(this.txtbox_StaffName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(900, 900);
            this.Name = "ComShopMM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbox_StaffName;
        private System.Windows.Forms.TextBox txtbox_StaffPassword;
        private System.Windows.Forms.Button btn_Adminlogin;
        private System.Windows.Forms.Button btn_StaffLogin;
    }
}

