namespace UI
{
    partial class TicketOverview
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
            label2 = new Label();
            pictureBox1 = new PictureBox();
            lblBarLicensed = new Label();
            lblBarNoDesk = new Label();
            btnMenuDashboard = new Button();
            btnMenuIncidentManagement = new Button();
            btnUserManagement = new Button();
            listviewTicketOverview = new ListView();
            txtBoxFilterEmail = new TextBox();
            btnCreateIncident = new Button();
            label1 = new Label();
            Delete_incident = new Button();
            btnEdit = new Button();
            pnlBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlBar
            // 
            pnlBar.Controls.Add(label2);
            pnlBar.Controls.Add(pictureBox1);
            pnlBar.Controls.Add(lblBarLicensed);
            pnlBar.Controls.Add(lblBarNoDesk);
            pnlBar.Location = new Point(43, 19);
            pnlBar.Margin = new Padding(2);
            pnlBar.Name = "pnlBar";
            pnlBar.Size = new Size(705, 79);
            pnlBar.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(150, 0);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 28);
            label2.TabIndex = 4;
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
            lblBarLicensed.Location = new Point(443, 48);
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
            lblBarNoDesk.Location = new Point(589, 12);
            lblBarNoDesk.Margin = new Padding(2, 0, 2, 0);
            lblBarNoDesk.Name = "lblBarNoDesk";
            lblBarNoDesk.Size = new Size(103, 32);
            lblBarNoDesk.TabIndex = 0;
            lblBarNoDesk.Text = "NoDesk";
            // 
            // btnMenuDashboard
            // 
            btnMenuDashboard.Location = new Point(38, 98);
            btnMenuDashboard.Margin = new Padding(2);
            btnMenuDashboard.Name = "btnMenuDashboard";
            btnMenuDashboard.Size = new Size(235, 43);
            btnMenuDashboard.TabIndex = 1;
            btnMenuDashboard.Text = "Dashboard";
            btnMenuDashboard.UseVisualStyleBackColor = true;
            btnMenuDashboard.Click += btnMenuDashboard_Click;
            // 
            // btnMenuIncidentManagement
            // 
            btnMenuIncidentManagement.Location = new Point(277, 98);
            btnMenuIncidentManagement.Margin = new Padding(2);
            btnMenuIncidentManagement.Name = "btnMenuIncidentManagement";
            btnMenuIncidentManagement.Size = new Size(235, 43);
            btnMenuIncidentManagement.TabIndex = 2;
            btnMenuIncidentManagement.Text = "Incident Management";
            btnMenuIncidentManagement.UseVisualStyleBackColor = true;
            // 
            // btnUserManagement
            // 
            btnUserManagement.Location = new Point(516, 98);
            btnUserManagement.Margin = new Padding(2);
            btnUserManagement.Name = "btnUserManagement";
            btnUserManagement.Size = new Size(235, 43);
            btnUserManagement.TabIndex = 3;
            btnUserManagement.Text = "User Management";
            btnUserManagement.UseVisualStyleBackColor = true;
            btnUserManagement.Click += btnUserManagement_Click;
            // 
            // listviewTicketOverview
            // 
            listviewTicketOverview.Location = new Point(43, 188);
            listviewTicketOverview.Margin = new Padding(2);
            listviewTicketOverview.Name = "listviewTicketOverview";
            listviewTicketOverview.Size = new Size(698, 181);
            listviewTicketOverview.TabIndex = 4;
            listviewTicketOverview.UseCompatibleStateImageBehavior = false;
            // 
            // txtBoxFilterEmail
            // 
            txtBoxFilterEmail.Location = new Point(559, 151);
            txtBoxFilterEmail.Margin = new Padding(2);
            txtBoxFilterEmail.Name = "txtBoxFilterEmail";
            txtBoxFilterEmail.PlaceholderText = "     Filter by username";
            txtBoxFilterEmail.Size = new Size(182, 27);
            txtBoxFilterEmail.TabIndex = 5;
            txtBoxFilterEmail.TextChanged += txtBoxFilterEmail_TextChanged;
            // 
            // btnCreateIncident
            // 
            btnCreateIncident.BackColor = Color.Chartreuse;
            btnCreateIncident.ForeColor = SystemColors.Desktop;
            btnCreateIncident.Location = new Point(43, 373);
            btnCreateIncident.Margin = new Padding(2);
            btnCreateIncident.Name = "btnCreateIncident";
            btnCreateIncident.Size = new Size(188, 33);
            btnCreateIncident.TabIndex = 6;
            btnCreateIncident.Text = "CREATE INCIDENT";
            btnCreateIncident.UseVisualStyleBackColor = false;
            btnCreateIncident.Click += btnCreateIncident_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(45, 141);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(236, 37);
            label1.TabIndex = 7;
            label1.Text = "Overview Tickets";
            // 
            // Delete_incident
            // 
            Delete_incident.BackColor = Color.Red;
            Delete_incident.ForeColor = SystemColors.ButtonHighlight;
            Delete_incident.Location = new Point(555, 373);
            Delete_incident.Margin = new Padding(2);
            Delete_incident.Name = "Delete_incident";
            Delete_incident.Size = new Size(188, 33);
            Delete_incident.TabIndex = 8;
            Delete_incident.Text = "DELETE INCIDENT";
            Delete_incident.UseVisualStyleBackColor = false;
            Delete_incident.Click += Delete_incident_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DodgerBlue;
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = SystemColors.ButtonHighlight;
            btnEdit.Location = new Point(398, 373);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(152, 33);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit Ticket";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // TicketOverview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 411);
            Controls.Add(btnEdit);
            Controls.Add(Delete_incident);
            Controls.Add(label1);
            Controls.Add(btnCreateIncident);
            Controls.Add(txtBoxFilterEmail);
            Controls.Add(listviewTicketOverview);
            Controls.Add(btnUserManagement);
            Controls.Add(btnMenuIncidentManagement);
            Controls.Add(btnMenuDashboard);
            Controls.Add(pnlBar);
            Margin = new Padding(2);
            Name = "TicketOverview";
            Text = "TicketOverview";
            Load += TicketOverview_Load;
            pnlBar.ResumeLayout(false);
            pnlBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlBar;
        private Label lblBarNoDesk;
        private Label lblBarLicensed;
        private PictureBox pictureBox1;
        private Button btnMenuDashboard;
        private Button btnMenuIncidentManagement;
        private Button btnUserManagement;
        private ListView listviewTicketOverview;
        private TextBox txtBoxFilterEmail;
        private Button btnCreateIncident;
        private Label label1;
        private Label label2;
        private Button Delete_incident;
        private Button btnEdit;
    }
}