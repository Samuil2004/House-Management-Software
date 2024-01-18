namespace House_Management_Software
{
    partial class AdminConfirmation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminConfirmation));
            pbLogo = new PictureBox();
            lbChangedData = new ListBox();
            ConfirmChangesLabel = new Label();
            ConfirmButton = new Button();
            DenyButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(12, 129);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(408, 471);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // lbChangedData
            // 
            lbChangedData.Font = new Font("Arial", 13.125F, FontStyle.Bold, GraphicsUnit.Point);
            lbChangedData.FormattingEnabled = true;
            lbChangedData.ItemHeight = 41;
            lbChangedData.Location = new Point(644, 129);
            lbChangedData.Name = "lbChangedData";
            lbChangedData.Size = new Size(701, 578);
            lbChangedData.TabIndex = 1;
            // 
            // ConfirmChangesLabel
            // 
            ConfirmChangesLabel.AutoSize = true;
            ConfirmChangesLabel.Font = new Font("Arial", 25.125F, FontStyle.Bold, GraphicsUnit.Point);
            ConfirmChangesLabel.ForeColor = Color.FromArgb(255, 73, 152);
            ConfirmChangesLabel.Location = new Point(132, 29);
            ConfirmChangesLabel.Name = "ConfirmChangesLabel";
            ConfirmChangesLabel.Size = new Size(1234, 78);
            ConfirmChangesLabel.TabIndex = 2;
            ConfirmChangesLabel.Text = "Please confirm the following changes";
            // 
            // ConfirmButton
            // 
            ConfirmButton.BackColor = Color.FromArgb(0, 204, 116);
            ConfirmButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ConfirmButton.ForeColor = Color.White;
            ConfirmButton.Location = new Point(785, 798);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(196, 128);
            ConfirmButton.TabIndex = 3;
            ConfirmButton.Text = "Confirm";
            ConfirmButton.UseVisualStyleBackColor = false;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // DenyButton
            // 
            DenyButton.BackColor = Color.FromArgb(255, 73, 152);
            DenyButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DenyButton.ForeColor = Color.White;
            DenyButton.Location = new Point(1034, 798);
            DenyButton.Name = "DenyButton";
            DenyButton.Size = new Size(196, 128);
            DenyButton.TabIndex = 4;
            DenyButton.Text = "Deny";
            DenyButton.UseVisualStyleBackColor = false;
            DenyButton.Click += DenyButton_Click;
            // 
            // AdminConfirmation
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 238, 245);
            ClientSize = new Size(1414, 953);
            Controls.Add(DenyButton);
            Controls.Add(ConfirmButton);
            Controls.Add(ConfirmChangesLabel);
            Controls.Add(lbChangedData);
            Controls.Add(pbLogo);
            Name = "AdminConfirmation";
            Text = "ChangesConfirmationPage";
            FormClosing += AnyForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogo;
        private ListBox lbChangedData;
        private Label ConfirmChangesLabel;
        private Button ConfirmButton;
        private Button DenyButton;
    }
}