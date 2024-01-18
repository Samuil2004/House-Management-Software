namespace House_Management_Software
{
    partial class EventsFromAdminSide
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
            FormClosing += AnyForm_FormClosing;

            lbAllEvents = new ListBox();
            BackToMenuButton = new Button();
            tbInfoForEvent = new TextBox();
            SuspendLayout();
            // 
            // lbAllEvents
            // 
            lbAllEvents.FormattingEnabled = true;
            lbAllEvents.ItemHeight = 32;
            lbAllEvents.Location = new Point(167, 65);
            lbAllEvents.Name = "lbAllEvents";
            lbAllEvents.Size = new Size(466, 580);
            lbAllEvents.TabIndex = 25;
            lbAllEvents.SelectedIndexChanged += lbAllEvents_SelectedIndexChanged;
            // 
            // BackToMenuButton
            // 
            BackToMenuButton.BackColor = Color.FromArgb(47, 62, 131);
            BackToMenuButton.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            BackToMenuButton.ForeColor = Color.FromArgb(236, 238, 245);
            BackToMenuButton.Location = new Point(758, 572);
            BackToMenuButton.Name = "BackToMenuButton";
            BackToMenuButton.Size = new Size(282, 73);
            BackToMenuButton.TabIndex = 24;
            BackToMenuButton.Text = "Back To Menu";
            BackToMenuButton.UseVisualStyleBackColor = false;
            BackToMenuButton.Click += BackToMenuButton_Click;
            // 
            // tbInfoForEvent
            // 
            tbInfoForEvent.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            tbInfoForEvent.Location = new Point(758, 65);
            tbInfoForEvent.Multiline = true;
            tbInfoForEvent.Name = "tbInfoForEvent";
            tbInfoForEvent.ReadOnly = true;
            tbInfoForEvent.Size = new Size(431, 284);
            tbInfoForEvent.TabIndex = 26;
            tbInfoForEvent.Text = "Select an event";
            tbInfoForEvent.TextAlign = HorizontalAlignment.Center;
            // 
            // EventsFromAdminSide
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 238, 245);
            ClientSize = new Size(1414, 953);
            Controls.Add(tbInfoForEvent);
            Controls.Add(lbAllEvents);
            Controls.Add(BackToMenuButton);
            Name = "EventsFromAdminSide";
            Text = "EventsFromAdminSide";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbAllEvents;
        private Button BackToMenuButton;
        private TextBox tbInfoForEvent;
    }
}