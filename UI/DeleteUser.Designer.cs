namespace UI
{
    partial class DeleteUser
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
            deleteUserButton = new Button();
            cancelButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // deleteUserButton
            // 
            deleteUserButton.BackColor = Color.LimeGreen;
            deleteUserButton.Location = new Point(243, 223);
            deleteUserButton.Name = "deleteUserButton";
            deleteUserButton.Size = new Size(120, 38);
            deleteUserButton.TabIndex = 0;
            deleteUserButton.Text = "Yes";
            deleteUserButton.UseVisualStyleBackColor = false;
            deleteUserButton.Click += deleteUserButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.Red;
            cancelButton.Location = new Point(463, 223);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(120, 38);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "No";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(199, 158);
            label1.Name = "label1";
            label1.Size = new Size(458, 28);
            label1.TabIndex = 2;
            label1.Text = "Are you sure that you want to delete this user?";
            // 
            // DeleteUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(cancelButton);
            Controls.Add(deleteUserButton);
            Name = "DeleteUser";
            Text = "DeleteUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button deleteUserButton;
        private Button cancelButton;
        private Label label1;
    }
}