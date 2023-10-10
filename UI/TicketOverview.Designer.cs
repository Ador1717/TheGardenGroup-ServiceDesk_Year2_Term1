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
            this.pnlBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBarLicensed = new System.Windows.Forms.Label();
            this.lblBarNoDesk = new System.Windows.Forms.Label();
            this.btnMenuDashboard = new System.Windows.Forms.Button();
            this.btnMenuIncidentManagement = new System.Windows.Forms.Button();
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.listviewTicketOverview = new System.Windows.Forms.ListView();
            this.txtBoxFilterEmail = new System.Windows.Forms.TextBox();
            this.btnCreateIncident = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBar
            // 
            this.pnlBar.Controls.Add(this.pictureBox1);
            this.pnlBar.Controls.Add(this.lblBarLicensed);
            this.pnlBar.Controls.Add(this.lblBarNoDesk);
            this.pnlBar.Location = new System.Drawing.Point(54, 24);
            this.pnlBar.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBar.Name = "pnlBar";
            this.pnlBar.Size = new System.Drawing.Size(705, 92);
            this.pnlBar.TabIndex = 0;
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
            // btnMenuDashboard
            // 
            this.btnMenuDashboard.Location = new System.Drawing.Point(54, 120);
            this.btnMenuDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenuDashboard.Name = "btnMenuDashboard";
            this.btnMenuDashboard.Size = new System.Drawing.Size(235, 34);
            this.btnMenuDashboard.TabIndex = 1;
            this.btnMenuDashboard.Text = "Dashboard";
            this.btnMenuDashboard.UseVisualStyleBackColor = true;
            // 
            // btnMenuIncidentManagement
            // 
            this.btnMenuIncidentManagement.Location = new System.Drawing.Point(289, 120);
            this.btnMenuIncidentManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenuIncidentManagement.Name = "btnMenuIncidentManagement";
            this.btnMenuIncidentManagement.Size = new System.Drawing.Size(235, 34);
            this.btnMenuIncidentManagement.TabIndex = 2;
            this.btnMenuIncidentManagement.Text = "Incident Management";
            this.btnMenuIncidentManagement.UseVisualStyleBackColor = true;
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.Location = new System.Drawing.Point(524, 120);
            this.btnUserManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(235, 34);
            this.btnUserManagement.TabIndex = 3;
            this.btnUserManagement.Text = "User Management";
            this.btnUserManagement.UseVisualStyleBackColor = true;
            // 
            // listviewTicketOverview
            // 
            this.listviewTicketOverview.Location = new System.Drawing.Point(56, 262);
            this.listviewTicketOverview.Name = "listviewTicketOverview";
            this.listviewTicketOverview.Size = new System.Drawing.Size(703, 225);
            this.listviewTicketOverview.TabIndex = 4;
            this.listviewTicketOverview.UseCompatibleStateImageBehavior = false;
            // 
            // txtBoxFilterEmail
            // 
            this.txtBoxFilterEmail.Location = new System.Drawing.Point(56, 217);
            this.txtBoxFilterEmail.Name = "txtBoxFilterEmail";
            this.txtBoxFilterEmail.PlaceholderText = "     Filter by email";
            this.txtBoxFilterEmail.Size = new System.Drawing.Size(226, 31);
            this.txtBoxFilterEmail.TabIndex = 5;
            this.txtBoxFilterEmail.TextChanged += new System.EventHandler(this.txtBoxFilterEmail_TextChanged);
            // 
            // btnCreateIncident
            // 
            this.btnCreateIncident.Location = new System.Drawing.Point(508, 214);
            this.btnCreateIncident.Name = "btnCreateIncident";
            this.btnCreateIncident.Size = new System.Drawing.Size(235, 34);
            this.btnCreateIncident.TabIndex = 6;
            this.btnCreateIncident.Text = "CREATE INCIDENT";
            this.btnCreateIncident.UseVisualStyleBackColor = true;
            this.btnCreateIncident.Click += new System.EventHandler(this.btnCreateIncident_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(54, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 45);
            this.label1.TabIndex = 7;
            this.label1.Text = "Overview Tickets";
            // 
            // TicketOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateIncident);
            this.Controls.Add(this.txtBoxFilterEmail);
            this.Controls.Add(this.listviewTicketOverview);
            this.Controls.Add(this.btnUserManagement);
            this.Controls.Add(this.btnMenuIncidentManagement);
            this.Controls.Add(this.btnMenuDashboard);
            this.Controls.Add(this.pnlBar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TicketOverview";
            this.Text = "TicketOverview";
            this.Load += new System.EventHandler(this.TicketOverview_Load);
            this.pnlBar.ResumeLayout(false);
            this.pnlBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}