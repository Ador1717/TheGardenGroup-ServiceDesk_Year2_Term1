namespace UI
{
    partial class ListViewForDeadlineTickets
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
            listViewTickets = new ListView();
            btnGoBack = new Button();
            SuspendLayout();
            // 
            // listViewTickets
            // 
            listViewTickets.Location = new Point(34, 12);
            listViewTickets.Name = "listViewTickets";
            listViewTickets.Size = new Size(728, 271);
            listViewTickets.TabIndex = 0;
            listViewTickets.UseCompatibleStateImageBehavior = false;
            // 
            // btnGoBack
            // 
            btnGoBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGoBack.Location = new Point(34, 289);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(151, 42);
            btnGoBack.TabIndex = 1;
            btnGoBack.Text = "Back";
            btnGoBack.UseVisualStyleBackColor = true;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // ListViewForDeadlineTickets
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 348);
            Controls.Add(btnGoBack);
            Controls.Add(listViewTickets);
            Name = "ListViewForDeadlineTickets";
            Text = "ListViewForDeadlineTickets";
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewTickets;
        private Button btnGoBack;

    }
}