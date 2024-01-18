namespace House_Management_Software
{
    partial class GarbageSchedulePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GarbageSchedulePage));
            RecyclingCollectionLabel = new Label();
            pbPaperTrash = new PictureBox();
            pbResidualTrash = new PictureBox();
            pbBioTrash = new PictureBox();
            BackToMenuButton = new Button();
            DateLabelPaper = new Label();
            DateLabelResidual = new Label();
            DateBioLabel = new Label();
            PersonPaperLabel = new Label();
            PersonResidualLabel = new Label();
            PersonBioLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pbPaperTrash).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbResidualTrash).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBioTrash).BeginInit();
            SuspendLayout();
            // 
            // RecyclingCollectionLabel
            // 
            RecyclingCollectionLabel.AutoSize = true;
            RecyclingCollectionLabel.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            RecyclingCollectionLabel.ForeColor = Color.FromArgb(255, 73, 152);
            RecyclingCollectionLabel.Location = new Point(164, 13);
            RecyclingCollectionLabel.Margin = new Padding(2, 0, 2, 0);
            RecyclingCollectionLabel.Name = "RecyclingCollectionLabel";
            RecyclingCollectionLabel.Size = new Size(412, 25);
            RecyclingCollectionLabel.TabIndex = 0;
            RecyclingCollectionLabel.Text = "Garbage and Recycling Collection Calendar";
            // 
            // pbPaperTrash
            // 
            pbPaperTrash.BackgroundImageLayout = ImageLayout.Zoom;
            pbPaperTrash.Image = (Image)resources.GetObject("pbPaperTrash.Image");
            pbPaperTrash.Location = new Point(-36, 20);
            pbPaperTrash.Margin = new Padding(2, 1, 2, 1);
            pbPaperTrash.Name = "pbPaperTrash";
            pbPaperTrash.Size = new Size(314, 387);
            pbPaperTrash.SizeMode = PictureBoxSizeMode.Zoom;
            pbPaperTrash.TabIndex = 1;
            pbPaperTrash.TabStop = false;
            // 
            // pbResidualTrash
            // 
            pbResidualTrash.Image = (Image)resources.GetObject("pbResidualTrash.Image");
            pbResidualTrash.Location = new Point(221, 20);
            pbResidualTrash.Margin = new Padding(2, 1, 2, 1);
            pbResidualTrash.Name = "pbResidualTrash";
            pbResidualTrash.Size = new Size(314, 387);
            pbResidualTrash.SizeMode = PictureBoxSizeMode.Zoom;
            pbResidualTrash.TabIndex = 2;
            pbResidualTrash.TabStop = false;
            // 
            // pbBioTrash
            // 
            pbBioTrash.Image = (Image)resources.GetObject("pbBioTrash.Image");
            pbBioTrash.Location = new Point(462, 20);
            pbBioTrash.Margin = new Padding(2, 1, 2, 1);
            pbBioTrash.Name = "pbBioTrash";
            pbBioTrash.Size = new Size(314, 387);
            pbBioTrash.SizeMode = PictureBoxSizeMode.Zoom;
            pbBioTrash.TabIndex = 3;
            pbBioTrash.TabStop = false;
            // 
            // BackToMenuButton
            // 
            BackToMenuButton.BackColor = Color.FromArgb(47, 62, 131);
            BackToMenuButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BackToMenuButton.ForeColor = Color.White;
            BackToMenuButton.Location = new Point(309, 408);
            BackToMenuButton.Margin = new Padding(2, 1, 2, 1);
            BackToMenuButton.Name = "BackToMenuButton";
            BackToMenuButton.Size = new Size(144, 33);
            BackToMenuButton.TabIndex = 4;
            BackToMenuButton.Text = "Back To Menu";
            BackToMenuButton.UseVisualStyleBackColor = false;
            BackToMenuButton.Click += BackToMenuButton_Click;
            // 
            // DateLabelPaper
            // 
            DateLabelPaper.AutoSize = true;
            DateLabelPaper.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            DateLabelPaper.ForeColor = Color.FromArgb(255, 73, 152);
            DateLabelPaper.Location = new Point(71, 328);
            DateLabelPaper.Margin = new Padding(2, 0, 2, 0);
            DateLabelPaper.Name = "DateLabelPaper";
            DateLabelPaper.Size = new Size(56, 25);
            DateLabelPaper.TabIndex = 5;
            DateLabelPaper.Text = "Date";
            // 
            // DateLabelResidual
            // 
            DateLabelResidual.AutoSize = true;
            DateLabelResidual.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            DateLabelResidual.ForeColor = Color.FromArgb(255, 73, 152);
            DateLabelResidual.Location = new Point(328, 328);
            DateLabelResidual.Margin = new Padding(2, 0, 2, 0);
            DateLabelResidual.Name = "DateLabelResidual";
            DateLabelResidual.Size = new Size(56, 25);
            DateLabelResidual.TabIndex = 6;
            DateLabelResidual.Text = "Date";
            // 
            // DateBioLabel
            // 
            DateBioLabel.AutoSize = true;
            DateBioLabel.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            DateBioLabel.ForeColor = Color.FromArgb(255, 73, 152);
            DateBioLabel.Location = new Point(568, 328);
            DateBioLabel.Margin = new Padding(2, 0, 2, 0);
            DateBioLabel.Name = "DateBioLabel";
            DateBioLabel.Size = new Size(56, 25);
            DateBioLabel.TabIndex = 7;
            DateBioLabel.Text = "Date";
            // 
            // PersonPaperLabel
            // 
            PersonPaperLabel.AutoSize = true;
            PersonPaperLabel.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            PersonPaperLabel.ForeColor = Color.FromArgb(47, 62, 131);
            PersonPaperLabel.Location = new Point(62, 363);
            PersonPaperLabel.Margin = new Padding(2, 0, 2, 0);
            PersonPaperLabel.Name = "PersonPaperLabel";
            PersonPaperLabel.Size = new Size(75, 25);
            PersonPaperLabel.TabIndex = 8;
            PersonPaperLabel.Text = "Person";
            // 
            // PersonResidualLabel
            // 
            PersonResidualLabel.AutoSize = true;
            PersonResidualLabel.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            PersonResidualLabel.ForeColor = Color.FromArgb(47, 62, 131);
            PersonResidualLabel.Location = new Point(309, 363);
            PersonResidualLabel.Margin = new Padding(2, 0, 2, 0);
            PersonResidualLabel.Name = "PersonResidualLabel";
            PersonResidualLabel.Size = new Size(75, 25);
            PersonResidualLabel.TabIndex = 9;
            PersonResidualLabel.Text = "Person";
            // 
            // PersonBioLabel
            // 
            PersonBioLabel.AutoSize = true;
            PersonBioLabel.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            PersonBioLabel.ForeColor = Color.FromArgb(47, 62, 131);
            PersonBioLabel.Location = new Point(558, 363);
            PersonBioLabel.Margin = new Padding(2, 0, 2, 0);
            PersonBioLabel.Name = "PersonBioLabel";
            PersonBioLabel.Size = new Size(75, 25);
            PersonBioLabel.TabIndex = 10;
            PersonBioLabel.Text = "Person";
            // 
            // GarbageSchedulePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 238, 245);
            ClientSize = new Size(761, 447);
            Controls.Add(PersonBioLabel);
            Controls.Add(PersonResidualLabel);
            Controls.Add(PersonPaperLabel);
            Controls.Add(DateBioLabel);
            Controls.Add(DateLabelResidual);
            Controls.Add(DateLabelPaper);
            Controls.Add(BackToMenuButton);
            Controls.Add(RecyclingCollectionLabel);
            Controls.Add(pbBioTrash);
            Controls.Add(pbResidualTrash);
            Controls.Add(pbPaperTrash);
            Margin = new Padding(2, 1, 2, 1);
            Name = "GarbageSchedulePage";
            Text = "GarbageSchedulePage";
            FormClosing += AnyForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pbPaperTrash).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbResidualTrash).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBioTrash).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label RecyclingCollectionLabel;
        private PictureBox pbPaperTrash;
        private PictureBox pbResidualTrash;
        private PictureBox pbBioTrash;
        private Button BackToMenuButton;
        private Label DateLabelPaper;
        private Label DateLabelResidual;
        private Label DateBioLabel;
        private Label PersonPaperLabel;
        private Label PersonResidualLabel;
        private Label PersonBioLabel;
    }
}