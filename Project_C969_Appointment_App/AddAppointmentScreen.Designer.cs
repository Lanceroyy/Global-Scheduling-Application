namespace Project_C969_Appointment_App
{
    partial class AddAppointmentScreen
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
            searchCustomerLabel = new Label();
            searchCustomerTextBox = new TextBox();
            dvgCustomers = new DataGridView();
            customersLabel = new Label();
            cancelButton = new Button();
            addAppointmentButton = new Button();
            typeLabel = new Label();
            typeTextBox = new TextBox();
            customerIdLabel = new Label();
            dateLabel = new Label();
            label4 = new Label();
            customerNameLabel = new Label();
            customerIdLabelValue = new Label();
            customerNameLabelValue = new Label();
            appointmentDatePicker = new DateTimePicker();
            startTimeComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            endTimeComboBox = new ComboBox();
            label3 = new Label();
            startESTValue = new Label();
            endESTValue = new Label();
            viewAppointmentsCalendar = new MonthCalendar();
            viewAppointmentsLabel = new Label();
            appTimesDVG = new DataGridView();
            elaspedTimeValueLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dvgCustomers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)appTimesDVG).BeginInit();
            SuspendLayout();
            // 
            // searchCustomerLabel
            // 
            searchCustomerLabel.AutoSize = true;
            searchCustomerLabel.Location = new Point(471, 14);
            searchCustomerLabel.Name = "searchCustomerLabel";
            searchCustomerLabel.Size = new Size(216, 28);
            searchCustomerLabel.TabIndex = 37;
            searchCustomerLabel.Text = "Search Customer Name";
            // 
            // searchCustomerTextBox
            // 
            searchCustomerTextBox.Location = new Point(454, 45);
            searchCustomerTextBox.Name = "searchCustomerTextBox";
            searchCustomerTextBox.Size = new Size(267, 34);
            searchCustomerTextBox.TabIndex = 36;
            searchCustomerTextBox.TextChanged += searchCustomerTextBox_TextChanged;
            // 
            // dvgCustomers
            // 
            dvgCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgCustomers.Location = new Point(453, 85);
            dvgCustomers.Name = "dvgCustomers";
            dvgCustomers.RowHeadersWidth = 51;
            dvgCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgCustomers.Size = new Size(742, 482);
            dvgCustomers.TabIndex = 35;
            dvgCustomers.CellContentClick += dvgCustomers_CellContentClick;
            // 
            // customersLabel
            // 
            customersLabel.AutoSize = true;
            customersLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customersLabel.Location = new Point(727, 41);
            customersLabel.Name = "customersLabel";
            customersLabel.Size = new Size(166, 41);
            customersLabel.TabIndex = 34;
            customersLabel.Text = "Customers";
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(259, 612);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(116, 48);
            cancelButton.TabIndex = 39;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // addAppointmentButton
            // 
            addAppointmentButton.Location = new Point(119, 612);
            addAppointmentButton.Name = "addAppointmentButton";
            addAppointmentButton.Size = new Size(116, 48);
            addAppointmentButton.TabIndex = 38;
            addAppointmentButton.Text = "Create";
            addAppointmentButton.UseVisualStyleBackColor = true;
            addAppointmentButton.Click += addAppointmentButton_Click;
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new Point(58, 321);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(53, 28);
            typeLabel.TabIndex = 40;
            typeLabel.Text = "Type";
            // 
            // typeTextBox
            // 
            typeTextBox.Location = new Point(117, 321);
            typeTextBox.Name = "typeTextBox";
            typeTextBox.Size = new Size(258, 34);
            typeTextBox.TabIndex = 41;
            // 
            // customerIdLabel
            // 
            customerIdLabel.AutoSize = true;
            customerIdLabel.Location = new Point(76, 226);
            customerIdLabel.Name = "customerIdLabel";
            customerIdLabel.Size = new Size(35, 28);
            customerIdLabel.TabIndex = 42;
            customerIdLabel.Text = "ID:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(58, 374);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(53, 28);
            dateLabel.TabIndex = 44;
            dateLabel.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.Location = new Point(101, 176);
            label4.Name = "label4";
            label4.Size = new Size(285, 38);
            label4.TabIndex = 48;
            label4.Text = "Create Appointment";
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Location = new Point(46, 268);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new Size(68, 28);
            customerNameLabel.TabIndex = 49;
            customerNameLabel.Text = "Name:";
            // 
            // customerIdLabelValue
            // 
            customerIdLabelValue.AutoSize = true;
            customerIdLabelValue.Location = new Point(116, 226);
            customerIdLabelValue.Name = "customerIdLabelValue";
            customerIdLabelValue.Size = new Size(212, 28);
            customerIdLabelValue.TabIndex = 50;
            customerIdLabelValue.Text = "Please Select Customer";
            // 
            // customerNameLabelValue
            // 
            customerNameLabelValue.AutoSize = true;
            customerNameLabelValue.Location = new Point(118, 268);
            customerNameLabelValue.Name = "customerNameLabelValue";
            customerNameLabelValue.Size = new Size(212, 28);
            customerNameLabelValue.TabIndex = 51;
            customerNameLabelValue.Text = "Please Select Customer";
            // 
            // appointmentDatePicker
            // 
            appointmentDatePicker.Location = new Point(116, 374);
            appointmentDatePicker.MinDate = new DateTime(2025, 1, 4, 0, 0, 0, 0);
            appointmentDatePicker.Name = "appointmentDatePicker";
            appointmentDatePicker.Size = new Size(259, 34);
            appointmentDatePicker.TabIndex = 52;
            appointmentDatePicker.ValueChanged += appointmentDatePicker_ValueChanged;
            // 
            // startTimeComboBox
            // 
            startTimeComboBox.FormattingEnabled = true;
            startTimeComboBox.Location = new Point(116, 424);
            startTimeComboBox.Name = "startTimeComboBox";
            startTimeComboBox.Size = new Size(182, 36);
            startTimeComboBox.TabIndex = 54;
            startTimeComboBox.SelectedIndexChanged += timeComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 427);
            label1.Name = "label1";
            label1.Size = new Size(100, 28);
            label1.TabIndex = 56;
            label1.Text = "Start Time";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 479);
            label2.Name = "label2";
            label2.Size = new Size(92, 28);
            label2.TabIndex = 58;
            label2.Text = "End Time";
            // 
            // endTimeComboBox
            // 
            endTimeComboBox.FormattingEnabled = true;
            endTimeComboBox.Location = new Point(116, 476);
            endTimeComboBox.Name = "endTimeComboBox";
            endTimeComboBox.Size = new Size(182, 36);
            endTimeComboBox.TabIndex = 57;
            endTimeComboBox.SelectedIndexChanged += endTimeComboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 581);
            label3.Name = "label3";
            label3.Size = new Size(366, 28);
            label3.TabIndex = 61;
            label3.Text = "Business Hours: 9AM - 5PM EST, Mon-Fri";
            // 
            // startESTValue
            // 
            startESTValue.AutoSize = true;
            startESTValue.Location = new Point(304, 427);
            startESTValue.Name = "startESTValue";
            startESTValue.Size = new Size(104, 28);
            startESTValue.TabIndex = 66;
            startESTValue.Text = "5555 (EST)";
            // 
            // endESTValue
            // 
            endESTValue.AutoSize = true;
            endESTValue.Location = new Point(304, 476);
            endESTValue.Name = "endESTValue";
            endESTValue.Size = new Size(104, 28);
            endESTValue.TabIndex = 67;
            endESTValue.Text = "5555 (EST)";
            // 
            // viewAppointmentsCalendar
            // 
            viewAppointmentsCalendar.Location = new Point(453, 618);
            viewAppointmentsCalendar.Name = "viewAppointmentsCalendar";
            viewAppointmentsCalendar.TabIndex = 68;
            // 
            // viewAppointmentsLabel
            // 
            viewAppointmentsLabel.AutoSize = true;
            viewAppointmentsLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewAppointmentsLabel.Location = new Point(668, 574);
            viewAppointmentsLabel.Name = "viewAppointmentsLabel";
            viewAppointmentsLabel.Size = new Size(277, 38);
            viewAppointmentsLabel.TabIndex = 70;
            viewAppointmentsLabel.Text = "View Appointments";
            // 
            // appTimesDVG
            // 
            appTimesDVG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            appTimesDVG.Location = new Point(747, 618);
            appTimesDVG.Name = "appTimesDVG";
            appTimesDVG.RowHeadersWidth = 51;
            appTimesDVG.Size = new Size(448, 245);
            appTimesDVG.TabIndex = 71;
            // 
            // elaspedTimeValueLabel
            // 
            elaspedTimeValueLabel.AutoSize = true;
            elaspedTimeValueLabel.Location = new Point(10, 527);
            elaspedTimeValueLabel.Name = "elaspedTimeValueLabel";
            elaspedTimeValueLabel.Size = new Size(151, 28);
            elaspedTimeValueLabel.TabIndex = 59;
            elaspedTimeValueLabel.Text = " Duration: 0:230";
            // 
            // AddAppointmentScreen
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1207, 869);
            Controls.Add(appTimesDVG);
            Controls.Add(viewAppointmentsLabel);
            Controls.Add(viewAppointmentsCalendar);
            Controls.Add(endESTValue);
            Controls.Add(startESTValue);
            Controls.Add(label3);
            Controls.Add(elaspedTimeValueLabel);
            Controls.Add(label2);
            Controls.Add(endTimeComboBox);
            Controls.Add(label1);
            Controls.Add(startTimeComboBox);
            Controls.Add(appointmentDatePicker);
            Controls.Add(customerNameLabelValue);
            Controls.Add(customerIdLabelValue);
            Controls.Add(customerNameLabel);
            Controls.Add(label4);
            Controls.Add(dateLabel);
            Controls.Add(customerIdLabel);
            Controls.Add(typeTextBox);
            Controls.Add(typeLabel);
            Controls.Add(cancelButton);
            Controls.Add(addAppointmentButton);
            Controls.Add(searchCustomerLabel);
            Controls.Add(searchCustomerTextBox);
            Controls.Add(dvgCustomers);
            Controls.Add(customersLabel);
            Name = "AddAppointmentScreen";
            Text = "Add Appointment Screen";
            Load += AddAppointmentScreen_Load;
            ((System.ComponentModel.ISupportInitialize)dvgCustomers).EndInit();
            ((System.ComponentModel.ISupportInitialize)appTimesDVG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label searchCustomerLabel;
        private TextBox searchCustomerTextBox;
        public DataGridView dvgCustomers;
        private Label customersLabel;
        private Button cancelButton;
        private Button addAppointmentButton;
        private Label typeLabel;
        private TextBox typeTextBox;
        private Label customerIdLabel;
        private Label dateLabel;
        private Label label4;
        private Label customerNameLabel;
        private Label customerIdLabelValue;
        private Label customerNameLabelValue;
        private DateTimePicker appointmentDatePicker;
        private ComboBox startTimeComboBox;
        private Label label1;
        private Label label2;
        private ComboBox endTimeComboBox;
        private Label label3;
        private Label startESTValue;
        private Label endESTValue;
        private MonthCalendar viewAppointmentsCalendar;
        private Label viewAppointmentsLabel;
        private DataGridView appTimesDVG;
        private Label elaspedTimeValueLabel;
    }
}