namespace UI
{
    partial class EditTicket
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
            dTPReportedDate = new DateTimePicker();
            label1 = new Label();
            tBSubject = new TextBox();
            label2 = new Label();
            cBPriority = new ComboBox();
            cBTypeIncident = new ComboBox();
            cBUser = new TextBox();
            dTPDeadline = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            tBDescription = new TextBox();
            label7 = new Label();
            btnSaveTicket = new Button();
            btnCancelEdit = new Button();
            lblCreateTicket = new Label();
            pictureBox1 = new PictureBox();
            cBStuts = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dTPReportedDate
            // 
            dTPReportedDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dTPReportedDate.Location = new Point(243, 68);
            dTPReportedDate.Name = "dTPReportedDate";
            dTPReportedDate.Size = new Size(350, 27);
            dTPReportedDate.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(31, 66);
            label1.Name = "label1";
            label1.Size = new Size(194, 28);
            label1.TabIndex = 18;
            label1.Text = "Date/time reported:";
            // 
            // tBSubject
            // 
            tBSubject.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tBSubject.Location = new Point(243, 113);
            tBSubject.Name = "tBSubject";
            tBSubject.Size = new Size(328, 34);
            tBSubject.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(37, 119);
            label2.Name = "label2";
            label2.Size = new Size(188, 28);
            label2.TabIndex = 20;
            label2.Text = "Subject of incident:";
            // 
            // cBPriority
            // 
            cBPriority.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cBPriority.FormattingEnabled = true;
            cBPriority.Location = new Point(243, 255);
            cBPriority.Name = "cBPriority";
            cBPriority.Size = new Size(328, 36);
            cBPriority.TabIndex = 41;
            // 
            // cBTypeIncident
            // 
            cBTypeIncident.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cBTypeIncident.FormattingEnabled = true;
            cBTypeIncident.Location = new Point(243, 160);
            cBTypeIncident.Name = "cBTypeIncident";
            cBTypeIncident.Size = new Size(328, 36);
            cBTypeIncident.TabIndex = 40;
            // 
            // cBUser
            // 
            cBUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cBUser.Location = new Point(243, 207);
            cBUser.Name = "cBUser";
            cBUser.Size = new Size(328, 34);
            cBUser.TabIndex = 39;
            // 
            // dTPDeadline
            // 
            dTPDeadline.CalendarFont = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dTPDeadline.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dTPDeadline.Location = new Point(243, 317);
            dTPDeadline.Name = "dTPDeadline";
            dTPDeadline.Size = new Size(350, 30);
            dTPDeadline.TabIndex = 38;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(34, 317);
            label6.Name = "label6";
            label6.Size = new Size(191, 28);
            label6.TabIndex = 37;
            label6.Text = "Deadline/follow up:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(37, 259);
            label5.Name = "label5";
            label5.Size = new Size(82, 28);
            label5.TabIndex = 36;
            label5.Text = "Priority:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(37, 209);
            label4.Name = "label4";
            label4.Size = new Size(175, 28);
            label4.TabIndex = 35;
            label4.Text = "Reported by user:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(37, 164);
            label3.Name = "label3";
            label3.Size = new Size(170, 28);
            label3.TabIndex = 34;
            label3.Text = "Type of incident: ";
            // 
            // tBDescription
            // 
            tBDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tBDescription.Location = new Point(243, 362);
            tBDescription.Multiline = true;
            tBDescription.Name = "tBDescription";
            tBDescription.Size = new Size(350, 73);
            tBDescription.TabIndex = 43;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(37, 362);
            label7.Name = "label7";
            label7.Size = new Size(120, 28);
            label7.TabIndex = 42;
            label7.Text = "Description:";
            // 
            // btnSaveTicket
            // 
            btnSaveTicket.BackColor = Color.YellowGreen;
            btnSaveTicket.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveTicket.ForeColor = SystemColors.ControlLightLight;
            btnSaveTicket.Location = new Point(397, 534);
            btnSaveTicket.Name = "btnSaveTicket";
            btnSaveTicket.Size = new Size(196, 39);
            btnSaveTicket.TabIndex = 45;
            btnSaveTicket.Text = "SAVE TICKET";
            btnSaveTicket.UseVisualStyleBackColor = false;
            btnSaveTicket.Click += btnSaveTicket_Click;
            // 
            // btnCancelEdit
            // 
            btnCancelEdit.BackColor = SystemColors.ControlLight;
            btnCancelEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelEdit.Location = new Point(243, 534);
            btnCancelEdit.Name = "btnCancelEdit";
            btnCancelEdit.Size = new Size(107, 39);
            btnCancelEdit.TabIndex = 44;
            btnCancelEdit.Text = "CANCEL";
            btnCancelEdit.UseVisualStyleBackColor = false;
            btnCancelEdit.Click += btnCancelEdit_Click;
            // 
            // lblCreateTicket
            // 
            lblCreateTicket.AutoSize = true;
            lblCreateTicket.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblCreateTicket.Location = new Point(37, 9);
            lblCreateTicket.Margin = new Padding(5, 0, 5, 0);
            lblCreateTicket.Name = "lblCreateTicket";
            lblCreateTicket.Size = new Size(260, 41);
            lblCreateTicket.TabIndex = 46;
            lblCreateTicket.Text = "Edit Ticket Detail";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._11;
            pictureBox1.Location = new Point(656, 9);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // cBStuts
            // 
            cBStuts.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cBStuts.FormattingEnabled = true;
            cBStuts.Location = new Point(243, 478);
            cBStuts.Name = "cBStuts";
            cBStuts.Size = new Size(350, 36);
            cBStuts.TabIndex = 47;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(37, 486);
            label8.Name = "label8";
            label8.Size = new Size(62, 28);
            label8.TabIndex = 48;
            label8.Text = "Stuts:";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Light", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(243, 458);
            label9.Name = "label9";
            label9.Size = new Size(472, 17);
            label9.TabIndex = 49;
            label9.Text = "*if stuts changed to resolved or Closed, it will be removed from the ticket overview!";
            // 
            // EditTicket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 632);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(cBStuts);
            Controls.Add(pictureBox1);
            Controls.Add(lblCreateTicket);
            Controls.Add(btnSaveTicket);
            Controls.Add(btnCancelEdit);
            Controls.Add(tBDescription);
            Controls.Add(label7);
            Controls.Add(cBPriority);
            Controls.Add(cBTypeIncident);
            Controls.Add(cBUser);
            Controls.Add(dTPDeadline);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tBSubject);
            Controls.Add(label2);
            Controls.Add(dTPReportedDate);
            Controls.Add(label1);
            Name = "EditTicket";
            Text = "EditTicket";
            Load += EditTicket_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dTPReportedDate;
        private Label label1;
        private TextBox tBSubject;
        private Label label2;
        private ComboBox cBPriority;
        private ComboBox cBTypeIncident;
        private TextBox cBUser;
        private DateTimePicker dTPDeadline;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox tBDescription;
        private Label label7;
        private Button btnSaveTicket;
        private Button btnCancelEdit;
        private Label lblCreateTicket;
        private PictureBox pictureBox1;
        private ComboBox cBStuts;
        private Label label8;
        private Label label9;
    }
}