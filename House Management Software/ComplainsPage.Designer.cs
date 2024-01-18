namespace House_Management_Software
{
    partial class ComplainsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComplainsPage));
            TopLabel = new Label();
            cbComplainCategory = new ComboBox();
            SelectCategoryLabel = new Label();
            PlsDescribeLabel = new Label();
            SubmitComlainButton = new Button();
            pbBackToMenuButton = new PictureBox();
            tbComplainsDescription = new TextBox();
            pbLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbBackToMenuButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // TopLabel
            // 
            TopLabel.AutoSize = true;
            TopLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TopLabel.ForeColor = Color.FromArgb(255, 73, 152);
            TopLabel.Location = new Point(273, 31);
            TopLabel.Name = "TopLabel";
            TopLabel.Size = new Size(891, 45);
            TopLabel.TabIndex = 0;
            TopLabel.Text = "{Name}, Please share weith us if anything disturbs you!";
            // 
            // cbComplainCategory
            // 
            cbComplainCategory.BackColor = Color.FromArgb(236, 238, 245);
            cbComplainCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbComplainCategory.FormattingEnabled = true;
            cbComplainCategory.Location = new Point(567, 210);
            cbComplainCategory.Name = "cbComplainCategory";
            cbComplainCategory.Size = new Size(300, 40);
            cbComplainCategory.TabIndex = 2;
            cbComplainCategory.SelectedIndexChanged += cbComplainCategory_SelectedIndexChanged;
            // 
            // SelectCategoryLabel
            // 
            SelectCategoryLabel.AutoSize = true;
            SelectCategoryLabel.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            SelectCategoryLabel.ForeColor = Color.Black;
            SelectCategoryLabel.Location = new Point(567, 167);
            SelectCategoryLabel.Name = "SelectCategoryLabel";
            SelectCategoryLabel.Size = new Size(260, 40);
            SelectCategoryLabel.TabIndex = 3;
            SelectCategoryLabel.Text = "Select a category:";
            // 
            // PlsDescribeLabel
            // 
            PlsDescribeLabel.AutoSize = true;
            PlsDescribeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PlsDescribeLabel.ForeColor = Color.Black;
            PlsDescribeLabel.Location = new Point(393, 272);
            PlsDescribeLabel.Name = "PlsDescribeLabel";
            PlsDescribeLabel.Size = new Size(257, 45);
            PlsDescribeLabel.TabIndex = 4;
            PlsDescribeLabel.Text = "Please describe:";
            // 
            // SubmitComlainButton
            // 
            SubmitComlainButton.BackColor = Color.FromArgb(0, 204, 116);
            SubmitComlainButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SubmitComlainButton.ForeColor = Color.White;
            SubmitComlainButton.Location = new Point(567, 789);
            SubmitComlainButton.Name = "SubmitComlainButton";
            SubmitComlainButton.Size = new Size(300, 96);
            SubmitComlainButton.TabIndex = 5;
            SubmitComlainButton.Text = "Submit Complain";
            SubmitComlainButton.UseVisualStyleBackColor = false;
            SubmitComlainButton.Click += SubmitComlainButton_Click;
            // 
            // pbBackToMenuButton
            // 
            pbBackToMenuButton.Image = (Image)resources.GetObject("pbBackToMenuButton.Image");
            pbBackToMenuButton.Location = new Point(12, 12);
            pbBackToMenuButton.Name = "pbBackToMenuButton";
            pbBackToMenuButton.Size = new Size(111, 109);
            pbBackToMenuButton.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBackToMenuButton.TabIndex = 6;
            pbBackToMenuButton.TabStop = false;
            pbBackToMenuButton.Click += pbBackToMenuButton_Click;
            // 
            // tbComplainsDescription
            // 
            tbComplainsDescription.BackColor = Color.FromArgb(236, 238, 245);
            tbComplainsDescription.Location = new Point(393, 333);
            tbComplainsDescription.Multiline = true;
            tbComplainsDescription.Name = "tbComplainsDescription";
            tbComplainsDescription.Size = new Size(634, 387);
            tbComplainsDescription.TabIndex = 7;
            tbComplainsDescription.TextChanged += tbComplainsDescription_TextChanged;
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(12, 217);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(372, 503);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 17;
            pbLogo.TabStop = false;
            // 
            // ComplainsPage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1414, 953);
            Controls.Add(pbLogo);
            Controls.Add(tbComplainsDescription);
            Controls.Add(pbBackToMenuButton);
            Controls.Add(SubmitComlainButton);
            Controls.Add(PlsDescribeLabel);
            Controls.Add(SelectCategoryLabel);
            Controls.Add(cbComplainCategory);
            Controls.Add(TopLabel);
            ForeColor = Color.FromArgb(227, 190, 198);
            Name = "ComplainsPage";
            Text = "ComplainsPage";
            FormClosing += AnyForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pbBackToMenuButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TopLabel;
        private ComboBox cbComplainCategory;
        private Label SelectCategoryLabel;
        private Label PlsDescribeLabel;
        private Button SubmitComlainButton;
        private PictureBox pbBackToMenuButton;
        private TextBox tbComplainsDescription;
        private PictureBox pbLogo;
    }
}