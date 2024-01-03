namespace UI
{
    partial class CreateTicket
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
            lblCreateTicket = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            tBSubject = new TextBox();
            dTPReportedDate = new DateTimePicker();
            dTPDeadline = new DateTimePicker();
            tBDescription = new TextBox();
            btnCancel = new Button();
            btnSubmitTicket = new Button();
            btnUserManagement = new Button();
            btnMenuIncidentManagement = new Button();
            btnMenuDashboard = new Button();
            pnlBar = new Panel();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            lblBarLicensed = new Label();
            lblBarNoDesk = new Label();
            cBUser = new TextBox();
            cBTypeIncident = new ComboBox();
            cBPriority = new ComboBox();
            pnlBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblCreateTicket
            // 
            lblCreateTicket.AutoSize = true;
            lblCreateTicket.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblCreateTicket.Location = new Point(29, 198);
            lblCreateTicket.Margin = new Padding(5, 0, 5, 0);
            lblCreateTicket.Name = "lblCreateTicket";
            lblCreateTicket.Size = new Size(386, 41);
            lblCreateTicket.TabIndex = 8;
            lblCreateTicket.Text = "Create new incident ticket";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(75, 286);
            label1.Name = "label1";
            label1.Size = new Size(194, 28);
            label1.TabIndex = 9;
            label1.Text = "Date/time reported:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(75, 341);
            label2.Name = "label2";
            label2.Size = new Size(188, 28);
            label2.TabIndex = 10;
            label2.Text = "Subject of incident:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(75, 405);
            label3.Name = "label3";
            label3.Size = new Size(170, 28);
            label3.TabIndex = 11;
            label3.Text = "Type of incident: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(75, 473);
            label4.Name = "label4";
            label4.Size = new Size(175, 28);
            label4.TabIndex = 12;
            label4.Text = "Reported by user:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(75, 544);
            label5.Name = "label5";
            label5.Size = new Size(82, 28);
            label5.TabIndex = 13;
            label5.Text = "Priority:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(75, 611);
            label6.Name = "label6";
            label6.Size = new Size(191, 28);
            label6.TabIndex = 14;
            label6.Text = "Deadline/follow up:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(75, 678);
            label7.Name = "label7";
            label7.Size = new Size(120, 28);
            label7.TabIndex = 15;
            label7.Text = "Description:";
            // 
            // tBSubject
            // 
            tBSubject.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tBSubject.Location = new Point(369, 335);
            tBSubject.Name = "tBSubject";
            tBSubject.Size = new Size(328, 34);
            tBSubject.TabIndex = 16;
            // 
            // dTPReportedDate
            // 
            dTPReportedDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dTPReportedDate.Location = new Point(369, 281);
            dTPReportedDate.Name = "dTPReportedDate";
            dTPReportedDate.Size = new Size(350, 27);
            dTPReportedDate.TabIndex = 17;
            // 
            // dTPDeadline
            // 
            dTPDeadline.CalendarFont = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dTPDeadline.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dTPDeadline.Location = new Point(368, 611);
            dTPDeadline.Name = "dTPDeadline";
            dTPDeadline.Size = new Size(350, 30);
            dTPDeadline.TabIndex = 21;
            // 
            // tBDescription
            // 
            tBDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tBDescription.Location = new Point(368, 678);
            tBDescription.Multiline = true;
            tBDescription.Name = "tBDescription";
            tBDescription.Size = new Size(350, 146);
            tBDescription.TabIndex = 22;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(51, 837);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(177, 47);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSubmitTicket
            // 
            btnSubmitTicket.BackColor = SystemColors.Highlight;
            btnSubmitTicket.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmitTicket.ForeColor = SystemColors.ControlLightLight;
            btnSubmitTicket.Location = new Point(365, 837);
            btnSubmitTicket.Name = "btnSubmitTicket";
            btnSubmitTicket.Size = new Size(350, 47);
            btnSubmitTicket.TabIndex = 24;
            btnSubmitTicket.Text = "SUBMIT TICKET";
            btnSubmitTicket.UseVisualStyleBackColor = false;
            btnSubmitTicket.Click += btnSubmitTicket_Click;
            // 
            // btnUserManagement
            // 
            btnUserManagement.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnUserManagement.Location = new Point(497, 110);
            btnUserManagement.Margin = new Padding(2);
            btnUserManagement.Name = "btnUserManagement";
            btnUserManagement.Size = new Size(235, 43);
            btnUserManagement.TabIndex = 28;
            btnUserManagement.Text = "User Management";
            btnUserManagement.UseVisualStyleBackColor = true;
            btnUserManagement.Click += btnUserManagement_Click_1;
            // 
            // btnMenuIncidentManagement
            // 
            btnMenuIncidentManagement.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenuIncidentManagement.Location = new Point(262, 110);
            btnMenuIncidentManagement.Margin = new Padding(2);
            btnMenuIncidentManagement.Name = "btnMenuIncidentManagement";
            btnMenuIncidentManagement.Size = new Size(235, 43);
            btnMenuIncidentManagement.TabIndex = 27;
            btnMenuIncidentManagement.Text = "Incident Management";
            btnMenuIncidentManagement.UseVisualStyleBackColor = true;
            btnMenuIncidentManagement.Click += btnMenuIncidentManagement_Click;
            // 
            // btnMenuDashboard
            // 
            btnMenuDashboard.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenuDashboard.Location = new Point(27, 110);
            btnMenuDashboard.Margin = new Padding(2);
            btnMenuDashboard.Name = "btnMenuDashboard";
            btnMenuDashboard.Size = new Size(235, 43);
            btnMenuDashboard.TabIndex = 26;
            btnMenuDashboard.Text = "Dashboard";
            btnMenuDashboard.UseVisualStyleBackColor = true;
            btnMenuDashboard.Click += btnMenuDashboard_Click;
            // 
            // pnlBar
            // 
            pnlBar.Controls.Add(label8);
            pnlBar.Controls.Add(pictureBox1);
            pnlBar.Controls.Add(lblBarLicensed);
            pnlBar.Controls.Add(lblBarNoDesk);
            pnlBar.Location = new Point(27, 27);
            pnlBar.Margin = new Padding(2);
            pnlBar.Name = "pnlBar";
            pnlBar.Size = new Size(705, 79);
            pnlBar.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(151, 3);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(0, 28);
            label8.TabIndex = 4;
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
            lblBarLicensed.Location = new Point(424, 52);
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
            lblBarNoDesk.Location = new Point(578, 9);
            lblBarNoDesk.Margin = new Padding(2, 0, 2, 0);
            lblBarNoDesk.Name = "lblBarNoDesk";
            lblBarNoDesk.Size = new Size(103, 32);
            lblBarNoDesk.TabIndex = 0;
            lblBarNoDesk.Text = "NoDesk";
            // 
            // cBUser
            // 
            cBUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cBUser.Location = new Point(369, 467);
            cBUser.Name = "cBUser";
            cBUser.Size = new Size(328, 34);
            cBUser.TabIndex = 30;
            // 
            // cBTypeIncident
            // 
            cBTypeIncident.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cBTypeIncident.FormattingEnabled = true;
            cBTypeIncident.Location = new Point(369, 397);
            cBTypeIncident.Name = "cBTypeIncident";
            cBTypeIncident.Size = new Size(328, 36);
            cBTypeIncident.TabIndex = 32;
            // 
            // cBPriority
            // 
            cBPriority.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cBPriority.FormattingEnabled = true;
            cBPriority.Location = new Point(369, 536);
            cBPriority.Name = "cBPriority";
            cBPriority.Size = new Size(328, 36);
            cBPriority.TabIndex = 33;
            // 
            // CreateTicket
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 942);
            Controls.Add(cBPriority);
            Controls.Add(cBTypeIncident);
            Controls.Add(cBUser);
            Controls.Add(btnUserManagement);
            Controls.Add(btnMenuIncidentManagement);
            Controls.Add(btnMenuDashboard);
            Controls.Add(pnlBar);
            Controls.Add(btnSubmitTicket);
            Controls.Add(btnCancel);
            Controls.Add(tBDescription);
            Controls.Add(dTPDeadline);
            Controls.Add(dTPReportedDate);
            Controls.Add(tBSubject);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblCreateTicket);
            Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "CreateTicket";
            Text = "CreateTicket";
            Load += CreateTicket_Load;
            pnlBar.ResumeLayout(false);
            pnlBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCreateTicket;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox tBSubject;
        private DateTimePicker dTPReportedDate;
        private DateTimePicker dTPDeadline;
        private TextBox tBDescription;
        private Button btnCancel;
        private Button btnSubmitTicket;
        private Button btnUserManagement;
        private Button btnMenuIncidentManagement;
        private Button btnMenuDashboard;
        private Panel pnlBar;
        private PictureBox pictureBox1;
        private Label lblBarLicensed;
        private Label lblBarNoDesk;
        private TextBox cBUser;
        private ComboBox cBTypeIncident;
        private ComboBox cBPriority;
        private Label label8;
    }

}