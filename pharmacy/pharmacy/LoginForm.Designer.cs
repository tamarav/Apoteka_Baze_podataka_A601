namespace pharmacy
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_info = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(11, 83);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(53, 13);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "username";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(12, 117);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(52, 13);
            this.lbl_password.TabIndex = 13;
            this.lbl_password.Text = "password";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(107, 18);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(49, 18);
            this.lbl_title.TabIndex = 12;
            this.lbl_title.Text = "Login";
            // 
            // lbl_info
            // 
            this.lbl_info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_info.AutoSize = true;
            this.lbl_info.ForeColor = System.Drawing.Color.Red;
            this.lbl_info.Location = new System.Drawing.Point(12, 152);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(184, 13);
            this.lbl_info.TabIndex = 9;
            this.lbl_info.Text = "Please enter username and password";
            this.lbl_info.Visible = false;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(110, 187);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(197, 187);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(70, 110);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(202, 20);
            this.tb_password.TabIndex = 2;
            this.tb_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_password_KeyPress);
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(70, 76);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(202, 20);
            this.tb_username.TabIndex = 1;
            this.tb_username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_username_KeyPress);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(282, 237);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Habitus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_username;
    }
}

