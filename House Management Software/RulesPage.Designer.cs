namespace House_Management_Software
{
    partial class RulesPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RulesPage));
            BackToMenuButton = new Button();
            TitleLabel = new Label();
            tabControl1 = new TabControl();
            tpPage1 = new TabPage();
            gbPage1Rules = new GroupBox();
            RulesPage1 = new Label();
            tpPage2 = new TabPage();
            gbPage2Rules = new GroupBox();
            Page2RulesLabel = new Label();
            MenuButton = new Button();
            tabControl1.SuspendLayout();
            tpPage1.SuspendLayout();
            gbPage1Rules.SuspendLayout();
            tpPage2.SuspendLayout();
            gbPage2Rules.SuspendLayout();
            SuspendLayout();
            // 
            // BackToMenuButton
            // 
            BackToMenuButton.BackColor = Color.SkyBlue;
            BackToMenuButton.Location = new Point(370, 795);
            BackToMenuButton.Name = "BackToMenuButton";
            BackToMenuButton.Size = new Size(217, 61);
            BackToMenuButton.TabIndex = 2;
            BackToMenuButton.Text = "Back To Menu";
            BackToMenuButton.UseVisualStyleBackColor = false;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            TitleLabel.ForeColor = Color.FromArgb(255, 73, 152);
            TitleLabel.Location = new Point(372, 20);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(0, 59);
            TitleLabel.TabIndex = 3;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpPage1);
            tabControl1.Controls.Add(tpPage2);
            tabControl1.Location = new Point(14, 82);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1399, 791);
            tabControl1.TabIndex = 4;
            // 
            // tpPage1
            // 
            tpPage1.BackColor = Color.FromArgb(236, 238, 245);
            tpPage1.Controls.Add(gbPage1Rules);
            tpPage1.Location = new Point(8, 46);
            tpPage1.Name = "tpPage1";
            tpPage1.Padding = new Padding(3);
            tpPage1.Size = new Size(1383, 737);
            tpPage1.TabIndex = 0;
            tpPage1.Text = "Page 1";
            // 
            // gbPage1Rules
            // 
            gbPage1Rules.BackColor = Color.FromArgb(236, 238, 245);
            gbPage1Rules.Controls.Add(RulesPage1);
            gbPage1Rules.Controls.Add(BackToMenuButton);
            gbPage1Rules.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            gbPage1Rules.Location = new Point(6, 6);
            gbPage1Rules.Name = "gbPage1Rules";
            gbPage1Rules.Size = new Size(1356, 733);
            gbPage1Rules.TabIndex = 0;
            gbPage1Rules.TabStop = false;
            gbPage1Rules.Text = "Page 1 - Rules";
            // 
            // RulesPage1
            // 
            RulesPage1.BackColor = Color.FromArgb(236, 238, 245);
            RulesPage1.Location = new Point(0, 50);
            RulesPage1.Name = "RulesPage1";
            RulesPage1.Size = new Size(1344, 675);
            RulesPage1.TabIndex = 0;
            RulesPage1.Text = resources.GetString("RulesPage1.Text");
            // 
            // tpPage2
            // 
            tpPage2.Controls.Add(gbPage2Rules);
            tpPage2.Location = new Point(8, 46);
            tpPage2.Name = "tpPage2";
            tpPage2.Padding = new Padding(3);
            tpPage2.Size = new Size(1383, 737);
            tpPage2.TabIndex = 1;
            tpPage2.Text = "Page 2";
            tpPage2.UseVisualStyleBackColor = true;
            // 
            // gbPage2Rules
            // 
            gbPage2Rules.BackColor = Color.FromArgb(236, 238, 245);
            gbPage2Rules.Controls.Add(Page2RulesLabel);
            gbPage2Rules.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            gbPage2Rules.Location = new Point(0, 3);
            gbPage2Rules.Name = "gbPage2Rules";
            gbPage2Rules.Size = new Size(1380, 731);
            gbPage2Rules.TabIndex = 0;
            gbPage2Rules.TabStop = false;
            gbPage2Rules.Text = "Page 2 - Rules";
            // 
            // Page2RulesLabel
            // 
            Page2RulesLabel.BackColor = Color.FromArgb(236, 238, 245);
            Page2RulesLabel.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            Page2RulesLabel.Location = new Point(14, 48);
            Page2RulesLabel.Name = "Page2RulesLabel";
            Page2RulesLabel.Size = new Size(1346, 683);
            Page2RulesLabel.TabIndex = 0;
            Page2RulesLabel.Text = resources.GetString("Page2RulesLabel.Text");
            // 
            // MenuButton
            // 
            MenuButton.BackColor = Color.FromArgb(47, 62, 131);
            MenuButton.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            MenuButton.ForeColor = Color.FromArgb(236, 238, 245);
            MenuButton.Location = new Point(566, 879);
            MenuButton.Name = "MenuButton";
            MenuButton.Size = new Size(249, 63);
            MenuButton.TabIndex = 5;
            MenuButton.Text = "Back To Menu";
            MenuButton.UseVisualStyleBackColor = false;
            MenuButton.Click += MenuButton_Click;
            // 
            // RulesPage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1414, 953);
            Controls.Add(MenuButton);
            Controls.Add(tabControl1);
            Controls.Add(TitleLabel);
            Name = "RulesPage";
            Text = "RulesPage";
            FormClosing += AnyForm_FormClosing;
            tabControl1.ResumeLayout(false);
            tpPage1.ResumeLayout(false);
            gbPage1Rules.ResumeLayout(false);
            tpPage2.ResumeLayout(false);
            gbPage2Rules.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BackToMenuButton;
        private Label TitleLabel;
        private TabControl tabControl1;
        private TabPage tpPage1;
        private TabPage tpPage2;
        private GroupBox gbPage1Rules;
        private Label RulesPage1;
        private GroupBox gbPage2Rules;
        private Label Page2RulesLabel;
        private Button MenuButton;
    }
}