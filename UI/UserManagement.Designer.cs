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
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "User management";
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAddNewUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddNewUser.ForeColor = System.Drawing.Color.White;
            this.btnAddNewUser.Location = new System.Drawing.Point(448, 181);
            this.btnAddNewUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(154, 35);
            this.btnAddNewUser.TabIndex = 13;
            this.btnAddNewUser.Text = "+ ADD NEW USER";
            this.btnAddNewUser.UseVisualStyleBackColor = false;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // txtBoxFilterEmail
            // 
            this.txtBoxFilterEmail.Location = new System.Drawing.Point(39, 185);
            this.txtBoxFilterEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxFilterEmail.Name = "txtBoxFilterEmail";
            this.txtBoxFilterEmail.PlaceholderText = "     Filter by email";
            this.txtBoxFilterEmail.Size = new System.Drawing.Size(182, 27);
            this.txtBoxFilterEmail.TabIndex = 12;
            // 
            // listviewUsermanagement
            // 
            this.listviewUsermanagement.Location = new System.Drawing.Point(39, 221);
            this.listviewUsermanagement.Margin = new System.Windows.Forms.Padding(2);
            this.listviewUsermanagement.Name = "listviewUsermanagement";
            this.listviewUsermanagement.Size = new System.Drawing.Size(563, 182);
            this.listviewUsermanagement.TabIndex = 11;
            this.listviewUsermanagement.UseCompatibleStateImageBehavior = false;
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.Location = new System.Drawing.Point(551, 96);
            this.btnUserManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(223, 43);
            this.btnUserManagement.TabIndex = 10;
            this.btnUserManagement.Text = "User Management";
            this.btnUserManagement.UseVisualStyleBackColor = true;
            // 
            // btnMenuIncidentManagement
            // 
            this.btnMenuIncidentManagement.Location = new System.Drawing.Point(293, 96);
            this.btnMenuIncidentManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenuIncidentManagement.Name = "btnMenuIncidentManagement";
            this.btnMenuIncidentManagement.Size = new System.Drawing.Size(252, 43);
            this.btnMenuIncidentManagement.TabIndex = 9;
            this.btnMenuIncidentManagement.Text = "Incident Management";
            this.btnMenuIncidentManagement.UseVisualStyleBackColor = true;
            // 
            // btnMenuDashboard
            // 
            this.btnMenuDashboard.Location = new System.Drawing.Point(37, 96);
            this.btnMenuDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenuDashboard.Name = "btnMenuDashboard";
            this.btnMenuDashboard.Size = new System.Drawing.Size(252, 43);
            this.btnMenuDashboard.TabIndex = 8;
            this.btnMenuDashboard.Text = "Dashboard";
            this.btnMenuDashboard.UseVisualStyleBackColor = true;
            // 
            // pnlBar
            // 
            this.pnlBar.Controls.Add(this.label2);
            this.pnlBar.Controls.Add(this.pictureBox1);
            this.pnlBar.Controls.Add(this.lblBarLicensed);
            this.pnlBar.Controls.Add(this.lblBarNoDesk);
            this.pnlBar.Location = new System.Drawing.Point(37, 18);
            this.pnlBar.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBar.Name = "pnlBar";
            this.pnlBar.Size = new System.Drawing.Size(737, 74);
            this.pnlBar.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(152, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 28);
            this.label2.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources._11;
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblBarLicensed
            // 
            this.lblBarLicensed.AutoSize = true;
            this.lblBarLicensed.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBarLicensed.Location = new System.Drawing.Point(472, 45);
            this.lblBarLicensed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBarLicensed.Name = "lblBarLicensed";
            this.lblBarLicensed.Size = new System.Drawing.Size(257, 23);
            this.lblBarLicensed.TabIndex = 1;
            this.lblBarLicensed.Text = "Licensed to: The Garden Group";
            // 
            // lblBarNoDesk
            // 
            this.lblBarNoDesk.AutoSize = true;
            this.lblBarNoDesk.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBarNoDesk.Location = new System.Drawing.Point(626, 13);
            this.lblBarNoDesk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBarNoDesk.Name = "lblBarNoDesk";
            this.lblBarNoDesk.Size = new System.Drawing.Size(103, 32);
            this.lblBarNoDesk.TabIndex = 0;
            this.lblBarNoDesk.Text = "NoDesk";
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.Red;
            this.btnDeleteUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.Location = new System.Drawing.Point(448, 408);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(154, 35);
            this.btnDeleteUser.TabIndex = 16;
            this.btnDeleteUser.Text = "DELETE USER";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.pnlBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.txtBoxFilterEmail);
            this.Controls.Add(this.listviewUsermanagement);
            this.Controls.Add(this.btnUserManagement);
            this.Controls.Add(this.btnMenuIncidentManagement);
            this.Controls.Add(this.btnMenuDashboard);
            this.Name = "UserManagement";
            this.Text = "UserManagement";
            this.pnlBar.ResumeLayout(false);
            this.pnlBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnAddNewUser;
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