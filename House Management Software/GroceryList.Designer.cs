namespace House_Management_Software
{
    partial class GroceryList
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
            components = new System.ComponentModel.Container();
            GrocaryListGroupBox = new GroupBox();
            DeleteButton = new Button();
            lbGroceryList = new ListBox();
            BoughtButton = new Button();
            ProductLabel = new Label();
            AmountLabel = new Label();
            tbNewProductName = new TextBox();
            nmAmountNewProduct = new NumericUpDown();
            AddNewProductButton = new Button();
            Timer = new System.Windows.Forms.Timer(components);
            CurrentTimeLabel = new Label();
            DescriptionLabel = new Label();
            tbDescription = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            BackToMenuButton = new Button();
            GrocaryListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmAmountNewProduct).BeginInit();
            SuspendLayout();
            // 
            // GrocaryListGroupBox
            // 
            GrocaryListGroupBox.BackColor = Color.FromArgb(236, 238, 245);
            GrocaryListGroupBox.Controls.Add(DeleteButton);
            GrocaryListGroupBox.Controls.Add(lbGroceryList);
            GrocaryListGroupBox.Controls.Add(BoughtButton);
            GrocaryListGroupBox.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            GrocaryListGroupBox.ForeColor = Color.Black;
            GrocaryListGroupBox.Location = new Point(56, 136);
            GrocaryListGroupBox.Name = "GrocaryListGroupBox";
            GrocaryListGroupBox.Size = new Size(950, 590);
            GrocaryListGroupBox.TabIndex = 0;
            GrocaryListGroupBox.TabStop = false;
            GrocaryListGroupBox.Text = "Grocery List";
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.FromArgb(255, 73, 152);
            DeleteButton.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteButton.ForeColor = SystemColors.Control;
            DeleteButton.Location = new Point(739, 71);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(183, 168);
            DeleteButton.TabIndex = 11;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // lbGroceryList
            // 
            lbGroceryList.BackColor = Color.FromArgb(47, 62, 131);
            lbGroceryList.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lbGroceryList.ForeColor = SystemColors.MenuBar;
            lbGroceryList.FormattingEnabled = true;
            lbGroceryList.ItemHeight = 50;
            lbGroceryList.Location = new Point(15, 71);
            lbGroceryList.Name = "lbGroceryList";
            lbGroceryList.Size = new Size(671, 504);
            lbGroceryList.TabIndex = 0;
            // 
            // BoughtButton
            // 
            BoughtButton.BackColor = Color.FromArgb(0, 204, 116);
            BoughtButton.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            BoughtButton.ForeColor = SystemColors.Control;
            BoughtButton.Location = new Point(739, 407);
            BoughtButton.Name = "BoughtButton";
            BoughtButton.Size = new Size(183, 168);
            BoughtButton.TabIndex = 10;
            BoughtButton.Text = "Bought";
            BoughtButton.UseVisualStyleBackColor = false;
            BoughtButton.Click += BoughtButton_Click;
            // 
            // ProductLabel
            // 
            ProductLabel.AutoSize = true;
            ProductLabel.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            ProductLabel.ForeColor = Color.Black;
            ProductLabel.Location = new Point(56, 758);
            ProductLabel.Name = "ProductLabel";
            ProductLabel.Size = new Size(121, 37);
            ProductLabel.TabIndex = 2;
            ProductLabel.Text = "Product:";
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            AmountLabel.ForeColor = Color.Black;
            AmountLabel.Location = new Point(56, 810);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(124, 37);
            AmountLabel.TabIndex = 3;
            AmountLabel.Text = "Amount:";
            // 
            // tbNewProductName
            // 
            tbNewProductName.BackColor = Color.FromArgb(236, 238, 245);
            tbNewProductName.Location = new Point(186, 758);
            tbNewProductName.Name = "tbNewProductName";
            tbNewProductName.Size = new Size(240, 39);
            tbNewProductName.TabIndex = 4;
            tbNewProductName.TextChanged += tbNewProductName_TextChanged;
            // 
            // nmAmountNewProduct
            // 
            nmAmountNewProduct.BackColor = Color.FromArgb(236, 238, 245);
            nmAmountNewProduct.Location = new Point(186, 810);
            nmAmountNewProduct.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmAmountNewProduct.Name = "nmAmountNewProduct";
            nmAmountNewProduct.Size = new Size(240, 39);
            nmAmountNewProduct.TabIndex = 5;
            nmAmountNewProduct.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // AddNewProductButton
            // 
            AddNewProductButton.BackColor = Color.FromArgb(0, 204, 116);
            AddNewProductButton.Location = new Point(513, 792);
            AddNewProductButton.Name = "AddNewProductButton";
            AddNewProductButton.Size = new Size(186, 69);
            AddNewProductButton.TabIndex = 6;
            AddNewProductButton.Text = "Add";
            AddNewProductButton.UseVisualStyleBackColor = false;
            AddNewProductButton.Click += AddNewProductButton_Click;
            // 
            // Timer
            // 
            Timer.Tick += timer1_Tick;
            // 
            // CurrentTimeLabel
            // 
            CurrentTimeLabel.AutoSize = true;
            CurrentTimeLabel.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            CurrentTimeLabel.ForeColor = Color.Red;
            CurrentTimeLabel.Location = new Point(47, 49);
            CurrentTimeLabel.Name = "CurrentTimeLabel";
            CurrentTimeLabel.Size = new Size(0, 59);
            CurrentTimeLabel.TabIndex = 7;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            DescriptionLabel.ForeColor = Color.Black;
            DescriptionLabel.Location = new Point(17, 867);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(164, 37);
            DescriptionLabel.TabIndex = 8;
            DescriptionLabel.Text = "Description:";
            // 
            // tbDescription
            // 
            tbDescription.BackColor = Color.FromArgb(236, 238, 245);
            tbDescription.ForeColor = SystemColors.Desktop;
            tbDescription.Location = new Point(186, 864);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(240, 39);
            tbDescription.TabIndex = 9;
            // 
            // BackToMenuButton
            // 
            BackToMenuButton.BackColor = Color.FromArgb(47, 62, 131);
            BackToMenuButton.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            BackToMenuButton.ForeColor = Color.FromArgb(236, 238, 245);
            BackToMenuButton.Location = new Point(941, 810);
            BackToMenuButton.Name = "BackToMenuButton";
            BackToMenuButton.Size = new Size(298, 77);
            BackToMenuButton.TabIndex = 12;
            BackToMenuButton.Text = "Back To Menu";
            BackToMenuButton.UseVisualStyleBackColor = false;
            BackToMenuButton.Click += BackToMenuButton_Click;
            // 
            // GroceryList
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1414, 953);
            Controls.Add(BackToMenuButton);
            Controls.Add(tbDescription);
            Controls.Add(DescriptionLabel);
            Controls.Add(CurrentTimeLabel);
            Controls.Add(AddNewProductButton);
            Controls.Add(nmAmountNewProduct);
            Controls.Add(tbNewProductName);
            Controls.Add(AmountLabel);
            Controls.Add(ProductLabel);
            Controls.Add(GrocaryListGroupBox);
            Name = "GroceryList";
            Text = "GroceryList";
            FormClosing += AnyForm_FormClosing;
            GrocaryListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmAmountNewProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox GrocaryListGroupBox;
        private ListBox lbGroceryList;
        private Label ProductLabel;
        private Label AmountLabel;
        private TextBox tbNewProductName;
        private NumericUpDown nmAmountNewProduct;
        private Button AddNewProductButton;
        private System.Windows.Forms.Timer Timer;
        private Label CurrentTimeLabel;
        private Label DescriptionLabel;
        private TextBox tbDescription;
        private Button BoughtButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button BackToMenuButton;
        private Button DeleteButton;
    }
}