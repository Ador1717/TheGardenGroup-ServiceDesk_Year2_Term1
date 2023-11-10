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
            this.lblCreateTicket = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tBSubject = new System.Windows.Forms.TextBox();
            this.dTPReportedDate = new System.Windows.Forms.DateTimePicker();
            this.dTPDeadline = new System.Windows.Forms.DateTimePicker();
            this.tBDescription = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmitTicket = new System.Windows.Forms.Button();
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.btnMenuIncidentManagement = new System.Windows.Forms.Button();
            this.btnMenuDashboard = new System.Windows.Forms.Button();
            this.pnlBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBarLicensed = new System.Windows.Forms.Label();
            this.lblBarNoDesk = new System.Windows.Forms.Label();
            this.cBUser = new System.Windows.Forms.TextBox();
            this.cBTypeIncident = new System.Windows.Forms.ComboBox();
            this.cBPriority = new System.Windows.Forms.ComboBox();
            this.pnlBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCreateTicket
            // 
            this.lblCreateTicket.AutoSize = true;
            this.lblCreateTicket.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCreateTicket.Location = new System.Drawing.Point(29, 198);
            this.lblCreateTicket.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCreateTicket.Name = "lblCreateTicket";
            this.lblCreateTicket.Size = new System.Drawing.Size(456, 48);
            this.lblCreateTicket.TabIndex = 8;
            this.lblCreateTicket.Text = "Create new incident ticket";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(75, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Date/time reported:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(85, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Subject of incident:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(85, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "Type of incident: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(85, 475);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = "Reported by user:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(85, 544);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "Priority:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(85, 613);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "Deadline/follow up:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(85, 678);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 32);
            this.label7.TabIndex = 15;
            this.label7.Text = "Description:";
            // 
            // tBSubject
            // 
            this.tBSubject.Location = new System.Drawing.Point(369, 335);
            this.tBSubject.Name = "tBSubject";
            this.tBSubject.Size = new System.Drawing.Size(328, 45);
            this.tBSubject.TabIndex = 16;
            // 
            // dTPReportedDate
            // 
            this.dTPReportedDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dTPReportedDate.Location = new System.Drawing.Point(369, 281);
            this.dTPReportedDate.Name = "dTPReportedDate";
            this.dTPReportedDate.Size = new System.Drawing.Size(350, 31);
            this.dTPReportedDate.TabIndex = 17;
            // 
            // dTPDeadline
            // 
            this.dTPDeadline.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dTPDeadline.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dTPDeadline.Location = new System.Drawing.Point(368, 611);
            this.dTPDeadline.Name = "dTPDeadline";
            this.dTPDeadline.Size = new System.Drawing.Size(350, 34);
            this.dTPDeadline.TabIndex = 21;
            // 
            // tBDescription
            // 
            this.tBDescription.Location = new System.Drawing.Point(368, 678);
            this.tBDescription.Multiline = true;
            this.tBDescription.Name = "tBDescription";
            this.tBDescription.Size = new System.Drawing.Size(350, 146);
            this.tBDescription.TabIndex = 22;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(51, 837);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(177, 47);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmitTicket
            // 
            this.btnSubmitTicket.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSubmitTicket.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSubmitTicket.Location = new System.Drawing.Point(365, 837);
            this.btnSubmitTicket.Name = "btnSubmitTicket";
            this.btnSubmitTicket.Size = new System.Drawing.Size(350, 47);
            this.btnSubmitTicket.TabIndex = 24;
            this.btnSubmitTicket.Text = "SUBMIT TICKET";
            this.btnSubmitTicket.UseVisualStyleBackColor = false;
            this.btnSubmitTicket.Click += new System.EventHandler(this.btnSubmitTicket_Click);
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.Location = new System.Drawing.Point(497, 123);
            this.btnUserManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(235, 43);
            this.btnUserManagement.TabIndex = 28;
            this.btnUserManagement.Text = "User Management";
            this.btnUserManagement.UseVisualStyleBackColor = true;
            // 
            // btnMenuIncidentManagement
            // 
            this.btnMenuIncidentManagement.Location = new System.Drawing.Point(262, 123);
            this.btnMenuIncidentManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenuIncidentManagement.Name = "btnMenuIncidentManagement";
            this.btnMenuIncidentManagement.Size = new System.Drawing.Size(235, 43);
            this.btnMenuIncidentManagement.TabIndex = 27;
            this.btnMenuIncidentManagement.Text = "Incident Management";
            this.btnMenuIncidentManagement.UseVisualStyleBackColor = true;
            // 
            // btnMenuDashboard
            // 
            this.btnMenuDashboard.Location = new System.Drawing.Point(27, 123);
            this.btnMenuDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenuDashboard.Name = "btnMenuDashboard";
            this.btnMenuDashboard.Size = new System.Drawing.Size(235, 43);
            this.btnMenuDashboard.TabIndex = 26;
            this.btnMenuDashboard.Text = "Dashboard";
            this.btnMenuDashboard.UseVisualStyleBackColor = true;
            // 
            // pnlBar
            // 
            this.pnlBar.Controls.Add(this.pictureBox1);
            this.pnlBar.Controls.Add(this.lblBarLicensed);
            this.pnlBar.Controls.Add(this.lblBarNoDesk);
            this.pnlBar.Location = new System.Drawing.Point(27, 27);
            this.pnlBar.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBar.Name = "pnlBar";
            this.pnlBar.Size = new System.Drawing.Size(705, 101);
            this.pnlBar.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources._11;
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblBarLicensed
            // 
            this.lblBarLicensed.AutoSize = true;
            this.lblBarLicensed.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBarLicensed.Location = new System.Drawing.Point(395, 54);
            this.lblBarLicensed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBarLicensed.Name = "lblBarLicensed";
            this.lblBarLicensed.Size = new System.Drawing.Size(303, 28);
            this.lblBarLicensed.TabIndex = 1;
            this.lblBarLicensed.Text = "Licensed to: The Garden Group";
            // 
            // lblBarNoDesk
            // 
            this.lblBarNoDesk.AutoSize = true;
            this.lblBarNoDesk.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBarNoDesk.Location = new System.Drawing.Point(578, 9);
            this.lblBarNoDesk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBarNoDesk.Name = "lblBarNoDesk";
            this.lblBarNoDesk.Size = new System.Drawing.Size(120, 38);
            this.lblBarNoDesk.TabIndex = 0;
            this.lblBarNoDesk.Text = "NoDesk";
            // 
            // cBUser
            // 
            this.cBUser.Location = new System.Drawing.Point(369, 467);
            this.cBUser.Name = "cBUser";
            this.cBUser.Size = new System.Drawing.Size(328, 45);
            this.cBUser.TabIndex = 30;
            // 
            // cBTypeIncident
            // 
            this.cBTypeIncident.FormattingEnabled = true;
            this.cBTypeIncident.Location = new System.Drawing.Point(369, 397);
            this.cBTypeIncident.Name = "cBTypeIncident";
            this.cBTypeIncident.Size = new System.Drawing.Size(328, 46);
            this.cBTypeIncident.TabIndex = 32;
            // 
            // cBPriority
            // 
            this.cBPriority.FormattingEnabled = true;
            this.cBPriority.Location = new System.Drawing.Point(369, 536);
            this.cBPriority.Name = "cBPriority";
            this.cBPriority.Size = new System.Drawing.Size(328, 46);
            this.cBPriority.TabIndex = 33;
            // 
            // CreateTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 942);
            this.Controls.Add(this.cBPriority);
            this.Controls.Add(this.cBTypeIncident);
            this.Controls.Add(this.cBUser);
            this.Controls.Add(this.btnUserManagement);
            this.Controls.Add(this.btnMenuIncidentManagement);
            this.Controls.Add(this.btnMenuDashboard);
            this.Controls.Add(this.pnlBar);
            this.Controls.Add(this.btnSubmitTicket);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tBDescription);
            this.Controls.Add(this.dTPDeadline);
            this.Controls.Add(this.dTPReportedDate);
            this.Controls.Add(this.tBSubject);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCreateTicket);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CreateTicket";
            this.Text = "CreateTicket";
            this.pnlBar.ResumeLayout(false);
            this.pnlBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }

}