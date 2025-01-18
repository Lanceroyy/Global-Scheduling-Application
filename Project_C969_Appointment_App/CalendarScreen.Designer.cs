namespace Project_C969_Appointment_App
{
    partial class CalendarScreen

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
            viewAppointmentsCalendar = new MonthCalendar();
            viewAppointmentsLabel = new Label();
            appointmentTimesDVG = new DataGridView();
            exitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)appointmentTimesDVG).BeginInit();
            SuspendLayout();
            // 
            // viewAppointmentsCalendar
            // 
            viewAppointmentsCalendar.Location = new Point(23, 169);
            viewAppointmentsCalendar.Name = "viewAppointmentsCalendar";
            viewAppointmentsCalendar.TabIndex = 68;
            // 
            // viewAppointmentsLabel
            // 
            viewAppointmentsLabel.AutoSize = true;
            viewAppointmentsLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewAppointmentsLabel.Location = new Point(364, 9);
            viewAppointmentsLabel.Name = "viewAppointmentsLabel";
            viewAppointmentsLabel.Size = new Size(277, 38);
            viewAppointmentsLabel.TabIndex = 70;
            viewAppointmentsLabel.Text = "View Appointments";
            // 
            // appointmentTimesDVG
            // 
            appointmentTimesDVG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            appointmentTimesDVG.Location = new Point(315, 71);
            appointmentTimesDVG.Name = "appointmentTimesDVG";
            appointmentTimesDVG.RowHeadersWidth = 51;
            appointmentTimesDVG.Size = new Size(663, 416);
            appointmentTimesDVG.TabIndex = 71;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(82, 416);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(133, 71);
            exitButton.TabIndex = 72;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // CalendarScreen
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 498);
            Controls.Add(exitButton);
            Controls.Add(appointmentTimesDVG);
            Controls.Add(viewAppointmentsLabel);
            Controls.Add(viewAppointmentsCalendar);
            Name = "CalendarScreen";
            Text = "Calendar";
            Load += CalendarScreen_Load;
            ((System.ComponentModel.ISupportInitialize)appointmentTimesDVG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MonthCalendar viewAppointmentsCalendar;
        private Label viewAppointmentsLabel;
        private DataGridView appointmentTimesDVG;
        private Button exitButton;
    }
}