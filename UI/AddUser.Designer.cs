namespace UI
{
    partial class AddUser
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
            pnlBar = new Panel();
            pictureBox1 = new PictureBox();
            lblBarLicensed = new Label();
            lblBarNoDesk = new Label();
            btnMenuDashboard = new Button();
            btnMenuIncidentManagement = new Button();
            btnUserManagement = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            btnCancel = new Button();
            btnAddUserToDatabase = new Button();
            pnlBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlBar
            // 
            pnlBar.Controls.Add(pictureBox1);
            pnlBar.Controls.Add(lblBarLicensed);
            pnlBar.Controls.Add(lblBarNoDesk);
            pnlBar.Location = new Point(11, 11);
            pnlBar.Margin = new Padding(2);
            pnlBar.Name = "pnlBar";
            pnlBar.Size = new Size(569, 84);
            pnlBar.TabIndex = 16;
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
            lblBarLicensed.Location = new Point(307, 39);
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
            lblBarNoDesk.Location = new Point(462, 7);
            lblBarNoDesk.Margin = new Padding(2, 0, 2, 0);
            lblBarNoDesk.Name = "lblBarNoDesk";
            lblBarNoDesk.Size = new Size(103, 32);
            lblBarNoDesk.TabIndex = 0;
            lblBarNoDesk.Text = "NoDesk";
            // 
            // btnMenuDashboard
            // 
            btnMenuDashboard.Location = new Point(11, 109);
            btnMenuDashboard.Margin = new Padding(2);
            btnMenuDashboard.Name = "btnMenuDashboard";
            btnMenuDashboard.Size = new Size(188, 27);
            btnMenuDashboard.TabIndex = 17;
            btnMenuDashboard.Text = "Dashboard";
            btnMenuDashboard.UseVisualStyleBackColor = true;
            // 
            // btnMenuIncidentManagement
            // 
            btnMenuIncidentManagement.Location = new Point(203, 109);
            btnMenuIncidentManagement.Margin = new Padding(2);
            btnMenuIncidentManagement.Name = "btnMenuIncidentManagement";
            btnMenuIncidentManagement.Size = new Size(188, 27);
            btnMenuIncidentManagement.TabIndex = 18;
            btnMenuIncidentManagement.Text = "Incident Management";
            btnMenuIncidentManagement.UseVisualStyleBackColor = true;
            // 
            // btnUserManagement
            // 
            btnUserManagement.Location = new Point(392, 109);
            btnUserManagement.Margin = new Padding(2);
            btnUserManagement.Name = "btnUserManagement";
            btnUserManagement.Size = new Size(188, 27);
            btnUserManagement.TabIndex = 19;
            btnUserManagement.Text = "User Management";
            btnUserManagement.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(11, 156);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(222, 37);
            label1.TabIndex = 20;
            label1.Text = "Create new user";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 225);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 21;
            label2.Text = "First name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 258);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 22;
            label3.Text = "Last name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 291);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 23;
            label4.Text = "Type of user:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 326);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 24;
            label5.Text = "E-mail address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 359);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 25;
            label6.Text = "Phone number";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 392);
            label7.Name = "label7";
            label7.Size = new Size(120, 20);
            label7.TabIndex = 26;
            label7.Text = "Location/branch:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 406);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 27;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(148, 218);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(302, 27);
            textBox1.TabIndex = 29;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(148, 251);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(302, 27);
            textBox2.TabIndex = 30;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(148, 284);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(302, 27);
            textBox3.TabIndex = 31;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(148, 319);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(302, 27);
            textBox4.TabIndex = 32;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(148, 352);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(302, 27);
            textBox5.TabIndex = 33;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(148, 385);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(302, 27);
            textBox6.TabIndex = 34;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(176, 444);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(131, 34);
            btnCancel.TabIndex = 35;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAddUserToDatabase
            // 
            btnAddUserToDatabase.BackColor = SystemColors.GradientActiveCaption;
            btnAddUserToDatabase.Location = new Point(319, 444);
            btnAddUserToDatabase.Name = "btnAddUserToDatabase";
            btnAddUserToDatabase.Size = new Size(131, 34);
            btnAddUserToDatabase.TabIndex = 36;
            btnAddUserToDatabase.Text = "ADD USER";
            btnAddUserToDatabase.UseVisualStyleBackColor = false;
            btnAddUserToDatabase.Click += btnAddUserToDatabase_Click;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 490);
            Controls.Add(btnAddUserToDatabase);
            Controls.Add(btnCancel);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnUserManagement);
            Controls.Add(btnMenuIncidentManagement);
            Controls.Add(btnMenuDashboard);
            Controls.Add(pnlBar);
            Name = "AddUser";
            Text = "AddUser";
            pnlBar.ResumeLayout(false);
            pnlBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlBar;
        private PictureBox pictureBox1;
        private Label lblBarLicensed;
        private Label lblBarNoDesk;
        private Button btnMenuDashboard;
        private Button btnMenuIncidentManagement;
        private Button btnUserManagement;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button btnCancel;
        private Button btnAddUserToDatabase;
    }
}