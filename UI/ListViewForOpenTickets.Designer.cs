namespace UI
{
    partial class ListViewForOpenTickets
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
            btnGoBack = new Button();
            listViewTickets = new ListView();
            SuspendLayout();
            // 
            // btnGoBack
            // 
            btnGoBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGoBack.Location = new Point(36, 289);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(151, 42);
            btnGoBack.TabIndex = 3;
            btnGoBack.Text = "Back";
            btnGoBack.UseVisualStyleBackColor = true;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // listViewTickets
            // 
            listViewTickets.Location = new Point(36, 12);
            listViewTickets.Name = "listViewTickets";
            listViewTickets.Size = new Size(728, 271);
            listViewTickets.TabIndex = 2;
            listViewTickets.UseCompatibleStateImageBehavior = false;
            Load += TicketOverview_Load;

            // 
            // ListViewForOpenTickets
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 342);
            Controls.Add(btnGoBack);
            Controls.Add(listViewTickets);
            Name = "ListViewForOpenTickets";
            Text = "ListViewForOpenTickets";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGoBack;
        private ListView listViewTickets;
    }
}