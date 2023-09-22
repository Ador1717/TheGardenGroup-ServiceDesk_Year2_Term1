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
            this.lblBarNoDesk = new System.Windows.Forms.Label();
            this.lblBarLicensed = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMenuDashboard = new System.Windows.Forms.Button();
            this.btnMenuIncidentManagement = new System.Windows.Forms.Button();
            this.btnUserManagement = new System.Windows.Forms.Button();
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
            this.pnlBar.Name = "pnlBar";
            this.pnlBar.Size = new System.Drawing.Size(705, 92);
            this.pnlBar.TabIndex = 0;
            // 
            // lblBarNoDesk
            // 
            this.lblBarNoDesk.AutoSize = true;
            this.lblBarNoDesk.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBarNoDesk.Location = new System.Drawing.Point(578, 9);
            this.lblBarNoDesk.Name = "lblBarNoDesk";
            this.lblBarNoDesk.Size = new System.Drawing.Size(120, 38);
            this.lblBarNoDesk.TabIndex = 0;
            this.lblBarNoDesk.Text = "NoDesk";
            this.lblBarNoDesk.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblBarLicensed
            // 
            this.lblBarLicensed.AutoSize = true;
            this.lblBarLicensed.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBarLicensed.Location = new System.Drawing.Point(395, 54);
            this.lblBarLicensed.Name = "lblBarLicensed";
            this.lblBarLicensed.Size = new System.Drawing.Size(303, 28);
            this.lblBarLicensed.TabIndex = 1;
            this.lblBarLicensed.Text = "Licensed to: The Garden Group";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources._11;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnMenuDashboard
            // 
            this.btnMenuDashboard.Location = new System.Drawing.Point(54, 120);
            this.btnMenuDashboard.Name = "btnMenuDashboard";
            this.btnMenuDashboard.Size = new System.Drawing.Size(235, 34);
            this.btnMenuDashboard.TabIndex = 1;
            this.btnMenuDashboard.Text = "Dashboard";
            this.btnMenuDashboard.UseVisualStyleBackColor = true;
            // 
            // btnMenuIncidentManagement
            // 
            this.btnMenuIncidentManagement.Location = new System.Drawing.Point(289, 120);
            this.btnMenuIncidentManagement.Name = "btnMenuIncidentManagement";
            this.btnMenuIncidentManagement.Size = new System.Drawing.Size(235, 34);
            this.btnMenuIncidentManagement.TabIndex = 2;
            this.btnMenuIncidentManagement.Text = "Incident Management";
            this.btnMenuIncidentManagement.UseVisualStyleBackColor = true;
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.Location = new System.Drawing.Point(524, 120);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(235, 34);
            this.btnUserManagement.TabIndex = 3;
            this.btnUserManagement.Text = "User Management";
            this.btnUserManagement.UseVisualStyleBackColor = true;
            // 
            // TicketOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUserManagement);
            this.Controls.Add(this.btnMenuIncidentManagement);
            this.Controls.Add(this.btnMenuDashboard);
            this.Controls.Add(this.pnlBar);
            this.Name = "TicketOverview";
            this.Text = "TicketOverview";
            this.pnlBar.ResumeLayout(false);
            this.pnlBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlBar;
        private Label lblBarNoDesk;
        private Label lblBarLicensed;
        private PictureBox pictureBox1;
        private Button btnMenuDashboard;
        private Button btnMenuIncidentManagement;
        private Button btnUserManagement;
    }
}