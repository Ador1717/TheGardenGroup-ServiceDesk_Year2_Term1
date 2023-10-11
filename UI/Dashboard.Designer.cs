namespace UI
{
    partial class Dashboard
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
            btnUserManagement = new Button();
            btnMenuIncidentManagement = new Button();
            btnMenuDashboard = new Button();
            pnlBar = new Panel();
            pictureBox1 = new PictureBox();
            lblBarLicensed = new Label();
            lblBarNoDesk = new Label();
            label1 = new Label();
            label2 = new Label();
            lblOpenTicketCount = new Label();
            lblPastDeadlineCount = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            pbOpen = new ProgressBar();
            groupBox2 = new GroupBox();
            pbDeadline = new ProgressBar();
            btnListViewUnresolved = new Button();
            btnListViewDeadline = new Button();
            showList = new Button();
            pnlBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnUserManagement
            // 
            btnUserManagement.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUserManagement.Location = new Point(551, 96);
            btnUserManagement.Margin = new Padding(2);
            btnUserManagement.Name = "btnUserManagement";
            btnUserManagement.Size = new Size(223, 43);
            btnUserManagement.TabIndex = 7;
            btnUserManagement.Text = "User Management";
            btnUserManagement.UseVisualStyleBackColor = true;
            // 
            // btnMenuIncidentManagement
            // 
            btnMenuIncidentManagement.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMenuIncidentManagement.Location = new Point(293, 96);
            btnMenuIncidentManagement.Margin = new Padding(2);
            btnMenuIncidentManagement.Name = "btnMenuIncidentManagement";
            btnMenuIncidentManagement.Size = new Size(254, 43);
            btnMenuIncidentManagement.TabIndex = 6;
            btnMenuIncidentManagement.Text = "Incident Management";
            btnMenuIncidentManagement.UseVisualStyleBackColor = true;
            // 
            // btnMenuDashboard
            // 
            btnMenuDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMenuDashboard.Location = new Point(37, 96);
            btnMenuDashboard.Margin = new Padding(2);
            btnMenuDashboard.Name = "btnMenuDashboard";
            btnMenuDashboard.Size = new Size(252, 43);
            btnMenuDashboard.TabIndex = 5;
            btnMenuDashboard.Text = "Dashboard";
            btnMenuDashboard.UseVisualStyleBackColor = true;
            // 
            // pnlBar
            // 
            pnlBar.Controls.Add(pictureBox1);
            pnlBar.Controls.Add(lblBarLicensed);
            pnlBar.Controls.Add(lblBarNoDesk);
            pnlBar.Location = new Point(37, 18);
            pnlBar.Margin = new Padding(2);
            pnlBar.Name = "pnlBar";
            pnlBar.Size = new Size(737, 74);
            pnlBar.TabIndex = 4;
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
            lblBarNoDesk.Location = new Point(618, 9);
            lblBarNoDesk.Margin = new Padding(2, 0, 2, 0);
            lblBarNoDesk.Name = "lblBarNoDesk";
            lblBarNoDesk.Size = new Size(103, 32);
            lblBarNoDesk.TabIndex = 0;
            lblBarNoDesk.Text = "NoDesk";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(27, 23);
            label1.Name = "label1";
            label1.Size = new Size(239, 31);
            label1.TabIndex = 10;
            label1.Text = "Unresolved Incidents";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 54);
            label2.Name = "label2";
            label2.Size = new Size(172, 20);
            label2.TabIndex = 11;
            label2.Text = "All tickets currently open";
            // 
            // lblOpenTicketCount
            // 
            lblOpenTicketCount.AutoSize = true;
            lblOpenTicketCount.Location = new Point(58, 84);
            lblOpenTicketCount.Name = "lblOpenTicketCount";
            lblOpenTicketCount.Size = new Size(0, 20);
            lblOpenTicketCount.TabIndex = 12;
            // 
            // lblPastDeadlineCount
            // 
            lblPastDeadlineCount.AutoSize = true;
            lblPastDeadlineCount.Location = new Point(46, 84);
            lblPastDeadlineCount.Name = "lblPastDeadlineCount";
            lblPastDeadlineCount.Size = new Size(0, 20);
            lblPastDeadlineCount.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 54);
            label5.Name = "label5";
            label5.Size = new Size(204, 20);
            label5.TabIndex = 14;
            label5.Text = "Tickets need immidate action";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(14, 23);
            label6.Name = "label6";
            label6.Size = new Size(261, 31);
            label6.TabIndex = 13;
            label6.Text = "Incidents past deadline";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pbOpen);
            groupBox1.Controls.Add(lblOpenTicketCount);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(42, 192);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(295, 163);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            // 
            // pbOpen
            // 
            pbOpen.Location = new Point(27, 118);
            pbOpen.Name = "pbOpen";
            pbOpen.Size = new Size(239, 29);
            pbOpen.TabIndex = 13;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pbDeadline);
            groupBox2.Controls.Add(lblPastDeadlineCount);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(479, 192);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(295, 163);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            // 
            // pbDeadline
            // 
            pbDeadline.Location = new Point(30, 118);
            pbDeadline.Name = "pbDeadline";
            pbDeadline.Size = new Size(240, 29);
            pbDeadline.TabIndex = 16;
            // 
            // btnListViewUnresolved
            // 
            btnListViewUnresolved.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnListViewUnresolved.Location = new Point(37, 361);
            btnListViewUnresolved.Name = "btnListViewUnresolved";
            btnListViewUnresolved.Size = new Size(300, 38);
            btnListViewUnresolved.TabIndex = 19;
            btnListViewUnresolved.Text = "Open List Of Tickets";
            btnListViewUnresolved.UseVisualStyleBackColor = true;
            btnListViewUnresolved.Click += btnListViewUnresolved_Click;
            // 
            // btnListViewDeadline
            // 
            btnListViewDeadline.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnListViewDeadline.Location = new Point(479, 361);
            btnListViewDeadline.Name = "btnListViewDeadline";
            btnListViewDeadline.Size = new Size(300, 38);
            btnListViewDeadline.TabIndex = 20;
            btnListViewDeadline.Text = "Open List Of Tickets";
            btnListViewDeadline.UseVisualStyleBackColor = true;
            btnListViewDeadline.Click += btnListViewDeadline_Click;
            // 
            // showList
            // 
            showList.BackColor = Color.FromArgb(0, 0, 192);
            showList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            showList.ForeColor = Color.White;
            showList.Location = new Point(615, 144);
            showList.Name = "showList";
            showList.Size = new Size(159, 42);
            showList.TabIndex = 21;
            showList.Text = "SHOW LIST";
            showList.UseVisualStyleBackColor = false;
            showList.Click += showList_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 411);
            Controls.Add(showList);
            Controls.Add(btnListViewDeadline);
            Controls.Add(btnListViewUnresolved);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnUserManagement);
            Controls.Add(btnMenuIncidentManagement);
            Controls.Add(btnMenuDashboard);
            Controls.Add(pnlBar);
            Name = "Dashboard";
            Text = "Dashboard";
            pnlBar.ResumeLayout(false);
            pnlBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnUserManagement;
        private Button btnMenuIncidentManagement;
        private Button btnMenuDashboard;
        private Panel pnlBar;
        private PictureBox pictureBox1;
        private Label lblBarLicensed;
        private Label lblBarNoDesk;
        private Label label1;
        private Label label2;
        private Label lblOpenTicketCount;
        private Label lblPastDeadlineCount;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnListViewUnresolved;
        private Button btnListViewDeadline;
        private ProgressBar pbOpen;
        private ProgressBar pbDeadline;
        private Button showList;
    }
}