namespace House_Management_Software
{
    partial class EventPage
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
            BackToMenuButton = new Button();
            TitleLabel = new Label();
            DescriptionLabel = new Label();
            DateTimeLabel = new Label();
            tbTitleOfEvent = new TextBox();
            tbDescriptionOfEvent = new TextBox();
            DatePicker = new DateTimePicker();
            AddEventButton = new Button();
            lbAllEvents = new ListBox();
            tbInfoForEvent = new TextBox();
            CancelEventButton = new Button();
            SuspendLayout();
            // 
            // BackToMenuButton
            // 
            BackToMenuButton.BackColor = Color.FromArgb(47, 62, 131);
            BackToMenuButton.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            BackToMenuButton.ForeColor = Color.White;
            BackToMenuButton.Location = new Point(534, 858);
            BackToMenuButton.Name = "BackToMenuButton";
            BackToMenuButton.Size = new Size(280, 83);
            BackToMenuButton.TabIndex = 13;
            BackToMenuButton.Text = "Back To Menu";
            BackToMenuButton.UseVisualStyleBackColor = false;
            BackToMenuButton.Click += BackToMenuButton_Click;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            TitleLabel.Location = new Point(44, 106);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(77, 37);
            TitleLabel.TabIndex = 14;
            TitleLabel.Text = "Title:";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            DescriptionLabel.Location = new Point(44, 176);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(164, 37);
            DescriptionLabel.TabIndex = 15;
            DescriptionLabel.Text = "Description:";
            // 
            // DateTimeLabel
            // 
            DateTimeLabel.AutoSize = true;
            DateTimeLabel.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            DateTimeLabel.Location = new Point(44, 296);
            DateTimeLabel.Name = "DateTimeLabel";
            DateTimeLabel.Size = new Size(201, 37);
            DateTimeLabel.TabIndex = 16;
            DateTimeLabel.Text = "Date and Time:";
            // 
            // tbTitleOfEvent
            // 
            tbTitleOfEvent.BackColor = Color.FromArgb(236, 238, 245);
            tbTitleOfEvent.Location = new Point(226, 107);
            tbTitleOfEvent.Name = "tbTitleOfEvent";
            tbTitleOfEvent.Size = new Size(200, 39);
            tbTitleOfEvent.TabIndex = 17;
            tbTitleOfEvent.TextChanged += tbTitleOfEvent_TextChanged;
            // 
            // tbDescriptionOfEvent
            // 
            tbDescriptionOfEvent.BackColor = Color.FromArgb(236, 238, 245);
            tbDescriptionOfEvent.Location = new Point(226, 177);
            tbDescriptionOfEvent.Multiline = true;
            tbDescriptionOfEvent.Name = "tbDescriptionOfEvent";
            tbDescriptionOfEvent.Size = new Size(461, 94);
            tbDescriptionOfEvent.TabIndex = 18;
            tbDescriptionOfEvent.TextChanged += tbDescriptionOfEvent_TextChanged;
            // 
            // DatePicker
            // 
            DatePicker.CustomFormat = "yyyy-MM-dd HH:mm";
            DatePicker.Format = DateTimePickerFormat.Custom;
            DatePicker.Location = new Point(287, 297);
            DatePicker.Name = "DatePicker";
            DatePicker.Size = new Size(339, 39);
            DatePicker.TabIndex = 19;
            DatePicker.Value = new DateTime(2024, 1, 11, 12, 0, 0, 0);
            // 
            // AddEventButton
            // 
            AddEventButton.BackColor = Color.FromArgb(0, 204, 116);
            AddEventButton.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            AddEventButton.ForeColor = Color.White;
            AddEventButton.Location = new Point(226, 391);
            AddEventButton.Name = "AddEventButton";
            AddEventButton.Size = new Size(211, 86);
            AddEventButton.TabIndex = 20;
            AddEventButton.Text = "Add Event";
            AddEventButton.UseVisualStyleBackColor = false;
            AddEventButton.Click += AddEventButton_Click;
            // 
            // lbAllEvents
            // 
            lbAllEvents.BackColor = Color.FromArgb(236, 238, 245);
            lbAllEvents.FormattingEnabled = true;
            lbAllEvents.ItemHeight = 32;
            lbAllEvents.Location = new Point(918, 65);
            lbAllEvents.Name = "lbAllEvents";
            lbAllEvents.Size = new Size(466, 484);
            lbAllEvents.TabIndex = 21;
            lbAllEvents.SelectedIndexChanged += lbAllEvents_SelectedIndexChanged;
            // 
            // tbInfoForEvent
            // 
            tbInfoForEvent.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            tbInfoForEvent.Location = new Point(918, 578);
            tbInfoForEvent.Multiline = true;
            tbInfoForEvent.Name = "tbInfoForEvent";
            tbInfoForEvent.ReadOnly = true;
            tbInfoForEvent.Size = new Size(466, 363);
            tbInfoForEvent.TabIndex = 22;
            tbInfoForEvent.Text = "Select an event";
            tbInfoForEvent.TextAlign = HorizontalAlignment.Center;
            // 
            // CancelEventButton
            // 
            CancelEventButton.BackColor = Color.FromArgb(255, 73, 152);
            CancelEventButton.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            CancelEventButton.ForeColor = SystemColors.Control;
            CancelEventButton.Location = new Point(687, 502);
            CancelEventButton.Name = "CancelEventButton";
            CancelEventButton.Size = new Size(174, 143);
            CancelEventButton.TabIndex = 23;
            CancelEventButton.Text = "Cancel Event";
            CancelEventButton.UseVisualStyleBackColor = false;
            CancelEventButton.Click += CancelEventButton_Click;
            // 
            // EventPage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1414, 953);
            Controls.Add(CancelEventButton);
            Controls.Add(tbInfoForEvent);
            Controls.Add(lbAllEvents);
            Controls.Add(AddEventButton);
            Controls.Add(DatePicker);
            Controls.Add(tbDescriptionOfEvent);
            Controls.Add(tbTitleOfEvent);
            Controls.Add(DateTimeLabel);
            Controls.Add(DescriptionLabel);
            Controls.Add(TitleLabel);
            Controls.Add(BackToMenuButton);
            Name = "EventPage";
            Text = "EventPage";
            FormClosing += AnyForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackToMenuButton;
        private Label TitleLabel;
        private Label DescriptionLabel;
        private Label DateTimeLabel;
        private TextBox tbTitleOfEvent;
        private TextBox tbDescriptionOfEvent;
        private DateTimePicker DatePicker;
        private Button AddEventButton;
        private ListBox lbAllEvents;
        private TextBox tbInfoForEvent;
        private Button CancelEventButton;
    }
}