namespace UI
{
    partial class UserAuthentication
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.RestPasswordLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Show_HidePass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(140, 205);
            this.textBoxUserName.Multiline = true;
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(383, 59);
            this.textBoxUserName.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(140, 322);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(326, 58);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.UseWaitCursor = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLogin.Location = new System.Drawing.Point(244, 472);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(177, 59);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // RestPasswordLinkLabel
            // 
            this.RestPasswordLinkLabel.AutoSize = true;
            this.RestPasswordLinkLabel.Location = new System.Drawing.Point(396, 410);
            this.RestPasswordLinkLabel.Name = "RestPasswordLinkLabel";
            this.RestPasswordLinkLabel.Size = new System.Drawing.Size(108, 20);
            this.RestPasswordLinkLabel.TabIndex = 3;
            this.RestPasswordLinkLabel.TabStop = true;
            this.RestPasswordLinkLabel.Text = "reset password";
            this.RestPasswordLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RestPasswordLinkLabel_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(229, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "NoDesk: TGG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(112, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(437, 62);
            this.label2.TabIndex = 5;
            this.label2.Text = "Please provide login credentials to login \r\nto NoDesk for The Garden Group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(140, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(140, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "password";
            // 
            // Show_HidePass
            // 
            this.Show_HidePass.Appearance = System.Windows.Forms.Appearance.Button;
            this.Show_HidePass.AutoSize = true;
            this.Show_HidePass.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Show_HidePass.Location = new System.Drawing.Point(457, 322);
            this.Show_HidePass.MinimumSize = new System.Drawing.Size(0, 60);
            this.Show_HidePass.Name = "Show_HidePass";
            this.Show_HidePass.Size = new System.Drawing.Size(66, 60);
            this.Show_HidePass.TabIndex = 8;
            this.Show_HidePass.Text = "show";
            this.Show_HidePass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Show_HidePass.UseVisualStyleBackColor = true;
            this.Show_HidePass.CheckedChanged += new System.EventHandler(this.Show_HidePass_CheckedChanged);
            // 
            // UserAuthentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 639);
            this.Controls.Add(this.Show_HidePass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RestPasswordLinkLabel);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "UserAuthentication";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.UserAuthentication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxUserName;
        private TextBox textBox2;
        private Button buttonLogin;
        private TextBox textBoxPassword;
        private LinkLabel RestPasswordLinkLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox Show_HidePass;
        private Button button1;
    }
}