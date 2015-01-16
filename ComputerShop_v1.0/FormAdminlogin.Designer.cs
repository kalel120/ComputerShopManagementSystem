namespace ComputerShop_v1._0
{
    partial class FormAdminlogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.btn_AdminLoginSubmit = new System.Windows.Forms.Button();
            this.txtbox_AdminName = new System.Windows.Forms.TextBox();
            this.txtbox_AdminPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // btn_AdminLoginSubmit
            // 
            this.btn_AdminLoginSubmit.Location = new System.Drawing.Point(16, 129);
            this.btn_AdminLoginSubmit.Name = "btn_AdminLoginSubmit";
            this.btn_AdminLoginSubmit.Size = new System.Drawing.Size(75, 23);
            this.btn_AdminLoginSubmit.TabIndex = 2;
            this.btn_AdminLoginSubmit.Text = "Submit";
            this.btn_AdminLoginSubmit.UseVisualStyleBackColor = true;
            this.btn_AdminLoginSubmit.Click += new System.EventHandler(this.btn_AdminLoginSubmit_Click);
            // 
            // txtbox_AdminName
            // 
            this.txtbox_AdminName.Location = new System.Drawing.Point(111, 22);
            this.txtbox_AdminName.Name = "txtbox_AdminName";
            this.txtbox_AdminName.Size = new System.Drawing.Size(100, 20);
            this.txtbox_AdminName.TabIndex = 3;
            // 
            // txtbox_AdminPassword
            // 
            this.txtbox_AdminPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_AdminPassword.Location = new System.Drawing.Point(111, 71);
            this.txtbox_AdminPassword.Name = "txtbox_AdminPassword";
            this.txtbox_AdminPassword.PasswordChar = '*';
            this.txtbox_AdminPassword.Size = new System.Drawing.Size(100, 24);
            this.txtbox_AdminPassword.TabIndex = 4;
            // 
            // FormAdminlogin
            // 
            this.AcceptButton = this.btn_AdminLoginSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 250);
            this.Controls.Add(this.txtbox_AdminPassword);
            this.Controls.Add(this.txtbox_AdminName);
            this.Controls.Add(this.btn_AdminLoginSubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(600, 600);
            this.Name = "FormAdminlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Login Panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_AdminLoginSubmit;
        private System.Windows.Forms.TextBox txtbox_AdminName;
        private System.Windows.Forms.TextBox txtbox_AdminPassword;
    }
}