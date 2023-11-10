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
            label9 = new Label();
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
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            btnCancel = new Button();
            btnAddUserToDatabase = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            pnlBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlBar
            // 
            pnlBar.Controls.Add(label9);
            pnlBar.Controls.Add(pictureBox1);
            pnlBar.Controls.Add(lblBarLicensed);
            pnlBar.Controls.Add(lblBarNoDesk);
            pnlBar.Location = new Point(37, 18);
            pnlBar.Margin = new Padding(2);
            pnlBar.Name = "pnlBar";
            pnlBar.Size = new Size(737, 74);
            pnlBar.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(153, 3);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(0, 28);
            label9.TabIndex = 4;
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
            lblBarLicensed.Location = new Point(477, 46);
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
            // btnMenuDashboard
            // 
            btnMenuDashboard.Location = new Point(37, 96);
            btnMenuDashboard.Margin = new Padding(2);
            btnMenuDashboard.Name = "btnMenuDashboard";
            btnMenuDashboard.Size = new Size(252, 43);
            btnMenuDashboard.TabIndex = 17;
            btnMenuDashboard.Text = "Dashboard";
            btnMenuDashboard.UseVisualStyleBackColor = true;
            btnMenuDashboard.Click += btnMenuDashboard_Click;
            // 
            // btnMenuIncidentManagement
            // 
            btnMenuIncidentManagement.Location = new Point(293, 96);
            btnMenuIncidentManagement.Margin = new Padding(2);
            btnMenuIncidentManagement.Name = "btnMenuIncidentManagement";
            btnMenuIncidentManagement.Size = new Size(252, 43);
            btnMenuIncidentManagement.TabIndex = 18;
            btnMenuIncidentManagement.Text = "Incident Management";
            btnMenuIncidentManagement.UseVisualStyleBackColor = true;
            btnMenuIncidentManagement.Click += btnMenuIncidentManagement_Click;
            // 
            // btnUserManagement
            // 
            btnUserManagement.Location = new Point(551, 96);
            btnUserManagement.Margin = new Padding(2);
            btnUserManagement.Name = "btnUserManagement";
            btnUserManagement.Size = new Size(223, 43);
            btnUserManagement.TabIndex = 19;
            btnUserManagement.Text = "User Management";
            btnUserManagement.UseVisualStyleBackColor = true;
            btnUserManagement.Click += btnUserManagement_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(37, 141);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(222, 37);
            label1.TabIndex = 20;
            label1.Text = "Create new user";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 191);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 21;
            label2.Text = "First name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 224);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 22;
            label3.Text = "Last name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 257);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 23;
            label4.Text = "Type of user:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 292);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 24;
            label5.Text = "E-mail address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 325);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 25;
            label6.Text = "Phone number";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 358);
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
            textBox1.Location = new Point(176, 184);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(302, 27);
            textBox1.TabIndex = 29;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(176, 217);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(302, 27);
            textBox2.TabIndex = 30;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(176, 285);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(302, 27);
            textBox4.TabIndex = 32;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(176, 318);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(302, 27);
            textBox5.TabIndex = 33;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(39, 392);
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
            btnAddUserToDatabase.Location = new Point(176, 392);
            btnAddUserToDatabase.Name = "btnAddUserToDatabase";
            btnAddUserToDatabase.Size = new Size(131, 34);
            btnAddUserToDatabase.TabIndex = 36;
            btnAddUserToDatabase.Text = "ADD USER";
            btnAddUserToDatabase.UseVisualStyleBackColor = false;
            btnAddUserToDatabase.Click += btnAddUserToDatabase_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(176, 251);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(302, 28);
            comboBox1.TabIndex = 37;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(176, 351);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(302, 28);
            comboBox2.TabIndex = 38;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 445);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(btnAddUserToDatabase);
            Controls.Add(btnCancel);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
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
        private TextBox textBox4;
        private TextBox textBox5;
        private Button btnCancel;
        private Button btnAddUserToDatabase;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label9;
    }
}