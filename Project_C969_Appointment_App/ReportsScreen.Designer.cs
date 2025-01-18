namespace Project_C969_Appointment_App
{
    partial class ReportsScreen
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
            typesByMonthButton = new Button();
            scheduleForUserButton = new Button();
            customerHoursButton = new Button();
            dvgReports = new DataGridView();
            label1 = new Label();
            exitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgReports).BeginInit();
            SuspendLayout();
            // 
            // typesByMonthButton
            // 
            typesByMonthButton.Location = new Point(35, 429);
            typesByMonthButton.Name = "typesByMonthButton";
            typesByMonthButton.Size = new Size(129, 83);
            typesByMonthButton.TabIndex = 0;
            typesByMonthButton.Text = "Types By Month";
            typesByMonthButton.UseVisualStyleBackColor = true;
            typesByMonthButton.Click += typesByMonthButton_Click;
            // 
            // scheduleForUserButton
            // 
            scheduleForUserButton.Location = new Point(181, 430);
            scheduleForUserButton.Name = "scheduleForUserButton";
            scheduleForUserButton.Size = new Size(142, 82);
            scheduleForUserButton.TabIndex = 1;
            scheduleForUserButton.Text = "User Schedule";
            scheduleForUserButton.UseVisualStyleBackColor = true;
            scheduleForUserButton.Click += scheduleForUserButton_Click;
            // 
            // customerHoursButton
            // 
            customerHoursButton.Location = new Point(347, 430);
            customerHoursButton.Name = "customerHoursButton";
            customerHoursButton.Size = new Size(142, 82);
            customerHoursButton.TabIndex = 2;
            customerHoursButton.Text = "Total Hours By Customer";
            customerHoursButton.UseVisualStyleBackColor = true;
            customerHoursButton.Click += customerHoursButton_Click;
            // 
            // dvgReports
            // 
            dvgReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgReports.Location = new Point(35, 53);
            dvgReports.Name = "dvgReports";
            dvgReports.RowHeadersWidth = 51;
            dvgReports.Size = new Size(769, 370);
            dvgReports.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(347, 9);
            label1.Name = "label1";
            label1.Size = new Size(120, 41);
            label1.TabIndex = 4;
            label1.Text = "Reports";
            // 
            // exitButton
            // 
            exitButton.Location = new Point(688, 429);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(129, 83);
            exitButton.TabIndex = 5;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // ReportsScreen
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 512);
            Controls.Add(exitButton);
            Controls.Add(label1);
            Controls.Add(dvgReports);
            Controls.Add(customerHoursButton);
            Controls.Add(scheduleForUserButton);
            Controls.Add(typesByMonthButton);
            Name = "ReportsScreen";
            Text = "ReportsScreen";
            ((System.ComponentModel.ISupportInitialize)dvgReports).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button typesByMonthButton;
        private Button scheduleForUserButton;
        private Button customerHoursButton;
        private DataGridView dvgReports;
        private Label label1;
        private Button exitButton;
    }
}