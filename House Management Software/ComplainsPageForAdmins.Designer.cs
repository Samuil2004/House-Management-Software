namespace House_Management_Software
{
    partial class ComplainsPageForAdmins
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
            LoadDataButton = new Button();
            lbComplains = new ListBox();
            BackToMenuButton = new Button();
            SuspendLayout();
            // 
            // LoadDataButton
            // 
            LoadDataButton.BackColor = Color.FromArgb(0, 204, 116);
            LoadDataButton.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            LoadDataButton.ForeColor = Color.White;
            LoadDataButton.Location = new Point(596, 726);
            LoadDataButton.Name = "LoadDataButton";
            LoadDataButton.Size = new Size(248, 129);
            LoadDataButton.TabIndex = 0;
            LoadDataButton.Text = "Load";
            LoadDataButton.UseVisualStyleBackColor = false;
            LoadDataButton.Click += LoadDataButton_Click;
            // 
            // lbComplains
            // 
            lbComplains.FormattingEnabled = true;
            lbComplains.ItemHeight = 32;
            lbComplains.Location = new Point(62, 143);
            lbComplains.Name = "lbComplains";
            lbComplains.Size = new Size(1340, 452);
            lbComplains.TabIndex = 1;
            // 
            // BackToMenuButton
            // 
            BackToMenuButton.BackColor = Color.FromArgb(47, 62, 131);
            BackToMenuButton.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            BackToMenuButton.ForeColor = Color.White;
            BackToMenuButton.Location = new Point(1031, 792);
            BackToMenuButton.Name = "BackToMenuButton";
            BackToMenuButton.Size = new Size(298, 63);
            BackToMenuButton.TabIndex = 2;
            BackToMenuButton.Text = "Back To Menu";
            BackToMenuButton.UseVisualStyleBackColor = false;
            BackToMenuButton.Click += BackToMenuButton_Click;
            // 
            // ComplainsPageForAdmins
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 238, 245);
            ClientSize = new Size(1414, 953);
            Controls.Add(BackToMenuButton);
            Controls.Add(lbComplains);
            Controls.Add(LoadDataButton);
            Name = "ComplainsPageForAdmins";
            Text = "ComplainsPageForAdmins";
            FormClosing += AnyForm_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button LoadDataButton;
        private ListBox lbComplains;
        private Button BackToMenuButton;
    }
}