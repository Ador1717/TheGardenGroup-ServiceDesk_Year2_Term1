namespace UI
{
    partial class UserManagement
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
            label1 = new Label();
            btnAddNewUser = new Button();
            txtBoxFilterEmail = new TextBox();
            listviewUsermanagement = new ListView();
            btnUserManagement = new Button();
            btnMenuIncidentManagement = new Button();
            btnMenuDashboard = new Button();
            pnlBar = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            lblBarLicensed = new Label();
            lblBarNoDesk = new Label();
            btnDeleteUser = new Button();
            pnlBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(37, 144);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(252, 37);
            label1.TabIndex = 14;
            label1.Text = "User management";
            // 
            // btnAddNewUser
            // 
            btnAddNewUser.BackColor = Color.DarkGreen;
            btnAddNewUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddNewUser.ForeColor = Color.White;
            btnAddNewUser.Location = new Point(448, 181);
            btnAddNewUser.Margin = new Padding(2);
            btnAddNewUser.Name = "btnAddNewUser";
            btnAddNewUser.Size = new Size(154, 35);
            btnAddNewUser.TabIndex = 13;
            btnAddNewUser.Text = "+ ADD NEW USER";
            btnAddNewUser.UseVisualStyleBackColor = false;
            btnAddNewUser.Click += btnAddNewUser_Click;
            // 
            // txtBoxFilterEmail
            // 
            txtBoxFilterEmail.Location = new Point(39, 185);
            txtBoxFilterEmail.Margin = new Padding(2);
            txtBoxFilterEmail.Name = "txtBoxFilterEmail";
            txtBoxFilterEmail.PlaceholderText = "     Filter by email";
            txtBoxFilterEmail.Size = new Size(182, 27);
            txtBoxFilterEmail.TabIndex = 12;
            // 
            // listviewUsermanagement
            // 
            listviewUsermanagement.Location = new Point(39, 221);
            listviewUsermanagement.Margin = new Padding(2);
            listviewUsermanagement.Name = "listviewUsermanagement";
            listviewUsermanagement.Size = new Size(563, 182);
            listviewUsermanagement.TabIndex = 11;
            listviewUsermanagement.UseCompatibleStateImageBehavior = false;
            // 
            // btnUserManagement
            // 
            btnUserManagement.Location = new Point(551, 96);
            btnUserManagement.Margin = new Padding(2);
            btnUserManagement.Name = "btnUserManagement";
            btnUserManagement.Size = new Size(223, 43);
            btnUserManagement.TabIndex = 10;
            btnUserManagement.Text = "User Management";
            btnUserManagement.UseVisualStyleBackColor = true;
            btnUserManagement.Click += btnUserManagement_Click;
            // 
            // btnMenuIncidentManagement
            // 
            btnMenuIncidentManagement.Location = new Point(293, 96);
            btnMenuIncidentManagement.Margin = new Padding(2);
            btnMenuIncidentManagement.Name = "btnMenuIncidentManagement";
            btnMenuIncidentManagement.Size = new Size(252, 43);
            btnMenuIncidentManagement.TabIndex = 9;
            btnMenuIncidentManagement.Text = "Incident Management";
            btnMenuIncidentManagement.UseVisualStyleBackColor = true;
            btnMenuIncidentManagement.Click += btnMenuIncidentManagement_Click;
            // 
            // btnMenuDashboard
            // 
            btnMenuDashboard.Location = new Point(37, 96);
            btnMenuDashboard.Margin = new Padding(2);
            btnMenuDashboard.Name = "btnMenuDashboard";
            btnMenuDashboard.Size = new Size(252, 43);
            btnMenuDashboard.TabIndex = 8;
            btnMenuDashboard.Text = "Dashboard";
            btnMenuDashboard.UseVisualStyleBackColor = true;
            btnMenuDashboard.Click += btnMenuDashboard_Click;
            // 
            // pnlBar
            // 
            pnlBar.Controls.Add(label2);
            pnlBar.Controls.Add(pictureBox1);
            pnlBar.Controls.Add(lblBarLicensed);
            pnlBar.Controls.Add(lblBarNoDesk);
            pnlBar.Location = new Point(37, 18);
            pnlBar.Margin = new Padding(2);
            pnlBar.Name = "pnlBar";
            pnlBar.Size = new Size(737, 74);
            pnlBar.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(152, 3);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 28);
            label2.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._11;
            pictureBox1.Location = new Point(2, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblBarLicensed
            // 
            lblBarLicensed.AutoSize = true;
            lblBarLicensed.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblBarLicensed.Location = new Point(472, 45);
            lblBarLicensed.Margin = new Padding(2, 0, 2, 0);
            lblBarLicensed.Name = "lblBarLicensed";
            lblBarLicensed.Size = new Size(257, 23);
            lblBarLicensed.TabIndex = 1;
            lblBarLicensed.Text = "Licensed to: The Garden Group";
            // 
            // lblBarNoDesk
            // 
            lblBarNoDesk.AutoSize = true;
            lblBarNoDesk.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblBarNoDesk.Location = new Point(626, 13);
            lblBarNoDesk.Margin = new Padding(2, 0, 2, 0);
            lblBarNoDesk.Name = "lblBarNoDesk";
            lblBarNoDesk.Size = new Size(103, 32);
            lblBarNoDesk.TabIndex = 0;
            lblBarNoDesk.Text = "NoDesk";
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = Color.Red;
            btnDeleteUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteUser.ForeColor = Color.White;
            btnDeleteUser.Location = new Point(448, 408);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(154, 35);
            btnDeleteUser.TabIndex = 16;
            btnDeleteUser.Text = "DELETE USER";
            btnDeleteUser.UseVisualStyleBackColor = false;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 449);
            Controls.Add(btnDeleteUser);
            Controls.Add(pnlBar);
            Controls.Add(label1);
            Controls.Add(btnAddNewUser);
            Controls.Add(txtBoxFilterEmail);
            Controls.Add(listviewUsermanagement);
            Controls.Add(btnUserManagement);
            Controls.Add(btnMenuIncidentManagement);
            Controls.Add(btnMenuDashboard);
            Name = "UserManagement";
            Text = "UserManagement";
            pnlBar.ResumeLayout(false);
            pnlBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAddNewUser;
        private TextBox txtBoxFilterEmail;
        private ListView listviewUsermanagement;
        private Button btnUserManagement;
        private Button btnMenuIncidentManagement;
        private Button btnMenuDashboard;
        private Panel pnlBar;
        private PictureBox pictureBox1;
        private Label lblBarLicensed;
        private Label lblBarNoDesk;
        private Button btnDeleteUser;
        private Label label2;
    }
}