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
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.btnMenuIncidentManagement = new System.Windows.Forms.Button();
            this.btnMenuDashboard = new System.Windows.Forms.Button();
            this.pnlBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBarLicensed = new System.Windows.Forms.Label();
            this.lblBarNoDesk = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOpenTicketCount = new System.Windows.Forms.Label();
            this.lblPastDeadlineCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbOpen = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbDeadline = new System.Windows.Forms.ProgressBar();
            this.btnListViewUnresolved = new System.Windows.Forms.Button();
            this.btnListViewDeadline = new System.Windows.Forms.Button();
            this.showList = new System.Windows.Forms.Button();
            this.pnlBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUserManagement.Location = new System.Drawing.Point(551, 96);
            this.btnUserManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(223, 43);
            this.btnUserManagement.TabIndex = 7;
            this.btnUserManagement.Text = "User Management";
            this.btnUserManagement.UseVisualStyleBackColor = true;
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // btnMenuIncidentManagement
            // 
            this.btnMenuIncidentManagement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMenuIncidentManagement.Location = new System.Drawing.Point(293, 96);
            this.btnMenuIncidentManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenuIncidentManagement.Name = "btnMenuIncidentManagement";
            this.btnMenuIncidentManagement.Size = new System.Drawing.Size(254, 43);
            this.btnMenuIncidentManagement.TabIndex = 6;
            this.btnMenuIncidentManagement.Text = "Incident Management";
            this.btnMenuIncidentManagement.UseVisualStyleBackColor = true;
            // 
            // btnMenuDashboard
            // 
            this.btnMenuDashboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMenuDashboard.Location = new System.Drawing.Point(37, 96);
            this.btnMenuDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenuDashboard.Name = "btnMenuDashboard";
            this.btnMenuDashboard.Size = new System.Drawing.Size(252, 43);
            this.btnMenuDashboard.TabIndex = 5;
            this.btnMenuDashboard.Text = "Dashboard";
            this.btnMenuDashboard.UseVisualStyleBackColor = true;
            this.btnMenuDashboard.Click += new System.EventHandler(this.btnMenuDashboard_Click);
            // 
            // pnlBar
            // 
            this.pnlBar.Controls.Add(this.pictureBox1);
            this.pnlBar.Controls.Add(this.lblBarLicensed);
            this.pnlBar.Controls.Add(this.lblBarNoDesk);
            this.pnlBar.Location = new System.Drawing.Point(37, 18);
            this.pnlBar.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBar.Name = "pnlBar";
            this.pnlBar.Size = new System.Drawing.Size(737, 74);
            this.pnlBar.TabIndex = 4;
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
            this.lblBarNoDesk.Location = new System.Drawing.Point(153, 0);
            this.lblBarNoDesk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBarNoDesk.Name = "lblBarNoDesk";
            this.lblBarNoDesk.Size = new System.Drawing.Size(103, 32);
            this.lblBarNoDesk.TabIndex = 0;
            this.lblBarNoDesk.Text = "NoDesk";
            this.lblBarNoDesk.Click += new System.EventHandler(this.lblBarNoDesk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Unresolved Incidents";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "All tickets currently open";
            // 
            // lblOpenTicketCount
            // 
            this.lblOpenTicketCount.AutoSize = true;
            this.lblOpenTicketCount.Location = new System.Drawing.Point(58, 84);
            this.lblOpenTicketCount.Name = "lblOpenTicketCount";
            this.lblOpenTicketCount.Size = new System.Drawing.Size(0, 20);
            this.lblOpenTicketCount.TabIndex = 12;
            // 
            // lblPastDeadlineCount
            // 
            this.lblPastDeadlineCount.AutoSize = true;
            this.lblPastDeadlineCount.Location = new System.Drawing.Point(46, 84);
            this.lblPastDeadlineCount.Name = "lblPastDeadlineCount";
            this.lblPastDeadlineCount.Size = new System.Drawing.Size(0, 20);
            this.lblPastDeadlineCount.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tickets need immidate action";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(14, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 31);
            this.label6.TabIndex = 13;
            this.label6.Text = "Incidents past deadline";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbOpen);
            this.groupBox1.Controls.Add(this.lblOpenTicketCount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(42, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 163);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // pbOpen
            // 
            this.pbOpen.Location = new System.Drawing.Point(27, 118);
            this.pbOpen.Name = "pbOpen";
            this.pbOpen.Size = new System.Drawing.Size(239, 29);
            this.pbOpen.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pbDeadline);
            this.groupBox2.Controls.Add(this.lblPastDeadlineCount);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(479, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 163);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // pbDeadline
            // 
            this.pbDeadline.Location = new System.Drawing.Point(30, 118);
            this.pbDeadline.Name = "pbDeadline";
            this.pbDeadline.Size = new System.Drawing.Size(240, 29);
            this.pbDeadline.TabIndex = 16;
            // 
            // btnListViewUnresolved
            // 
            this.btnListViewUnresolved.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListViewUnresolved.Location = new System.Drawing.Point(37, 361);
            this.btnListViewUnresolved.Name = "btnListViewUnresolved";
            this.btnListViewUnresolved.Size = new System.Drawing.Size(300, 38);
            this.btnListViewUnresolved.TabIndex = 19;
            this.btnListViewUnresolved.Text = "Open List Of Tickets";
            this.btnListViewUnresolved.UseVisualStyleBackColor = true;
            // 
            // btnListViewDeadline
            // 
            this.btnListViewDeadline.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListViewDeadline.Location = new System.Drawing.Point(479, 361);
            this.btnListViewDeadline.Name = "btnListViewDeadline";
            this.btnListViewDeadline.Size = new System.Drawing.Size(300, 38);
            this.btnListViewDeadline.TabIndex = 20;
            this.btnListViewDeadline.Text = "Open List Of Tickets";
            this.btnListViewDeadline.UseVisualStyleBackColor = true;
            // 
            // showList
            // 
            this.showList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.showList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.showList.ForeColor = System.Drawing.Color.White;
            this.showList.Location = new System.Drawing.Point(615, 144);
            this.showList.Name = "showList";
            this.showList.Size = new System.Drawing.Size(159, 42);
            this.showList.TabIndex = 21;
            this.showList.Text = "SHOW LIST";
            this.showList.UseVisualStyleBackColor = false;
            this.showList.Click += new System.EventHandler(this.showList_Click_1);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 411);
            this.Controls.Add(this.showList);
            this.Controls.Add(this.btnListViewDeadline);
            this.Controls.Add(this.btnListViewUnresolved);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUserManagement);
            this.Controls.Add(this.btnMenuIncidentManagement);
            this.Controls.Add(this.btnMenuDashboard);
            this.Controls.Add(this.pnlBar);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.pnlBar.ResumeLayout(false);
            this.pnlBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

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