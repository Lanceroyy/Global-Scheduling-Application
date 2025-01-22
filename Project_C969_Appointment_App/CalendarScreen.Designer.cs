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
            viewAppointmentsCalendar.Location = new Point(19, 127);
            viewAppointmentsCalendar.Margin = new Padding(7);
            viewAppointmentsCalendar.Name = "viewAppointmentsCalendar";
            viewAppointmentsCalendar.TabIndex = 68;
            // 
            // viewAppointmentsLabel
            // 
            viewAppointmentsLabel.AutoSize = true;
            viewAppointmentsLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewAppointmentsLabel.Location = new Point(310, 9);
            viewAppointmentsLabel.Margin = new Padding(2, 0, 2, 0);
            viewAppointmentsLabel.Name = "viewAppointmentsLabel";
            viewAppointmentsLabel.Size = new Size(218, 30);
            viewAppointmentsLabel.TabIndex = 70;
            viewAppointmentsLabel.Text = "View Appointments";
            // 
            // appointmentTimesDVG
            // 
            appointmentTimesDVG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            appointmentTimesDVG.Location = new Point(332, 76);
            appointmentTimesDVG.Margin = new Padding(2);
            appointmentTimesDVG.Name = "appointmentTimesDVG";
            appointmentTimesDVG.RowHeadersWidth = 51;
            appointmentTimesDVG.Size = new Size(512, 312);
            appointmentTimesDVG.TabIndex = 71;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(67, 312);
            exitButton.Margin = new Padding(2);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(109, 53);
            exitButton.TabIndex = 72;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // CalendarScreen
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(855, 414);
            Controls.Add(exitButton);
            Controls.Add(appointmentTimesDVG);
            Controls.Add(viewAppointmentsLabel);
            Controls.Add(viewAppointmentsCalendar);
            Margin = new Padding(2);
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