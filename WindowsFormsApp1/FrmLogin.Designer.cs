namespace WindowsFormsApp1
{
    partial class FrmLogin
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
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txtBox_username = new System.Windows.Forms.TextBox();
            this.txtBox_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_signup = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(29, 76);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(55, 13);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "Username";
            this.lbl_username.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(32, 120);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(53, 13);
            this.lbl_password.TabIndex = 1;
            this.lbl_password.Text = "Password";
            // 
            // txtBox_username
            // 
            this.txtBox_username.Location = new System.Drawing.Point(99, 76);
            this.txtBox_username.Name = "txtBox_username";
            this.txtBox_username.Size = new System.Drawing.Size(100, 20);
            this.txtBox_username.TabIndex = 2;
            this.txtBox_username.TextChanged += new System.EventHandler(this.txtBox_username_TextChanged);
            // 
            // txtBox_password
            // 
            this.txtBox_password.Location = new System.Drawing.Point(99, 120);
            this.txtBox_password.Name = "txtBox_password";
            this.txtBox_password.Size = new System.Drawing.Size(100, 20);
            this.txtBox_password.TabIndex = 3;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(77, 208);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_signup
            // 
            this.btn_signup.Location = new System.Drawing.Point(175, 208);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(75, 23);
            this.btn_signup.TabIndex = 5;
            this.btn_signup.Text = "Signup";
            this.btn_signup.UseVisualStyleBackColor = true;
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.Color.PeachPuff;
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(316, 32);
            this.lbl_title.TabIndex = 7;
            this.lbl_title.Text = "SHOP";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_title.Click += new System.EventHandler(this.lbl_title_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 450);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txtBox_password);
            this.Controls.Add(this.txtBox_username);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Name = "FrmLogin";
            this.Text = "FrmInventory";
            this.Load += new System.EventHandler(this.FrmInventory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txtBox_username;
        private System.Windows.Forms.TextBox txtBox_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.Label lbl_title;
    }
}