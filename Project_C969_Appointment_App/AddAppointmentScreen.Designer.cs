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
            elapsedTimeValueLabel = new Label();
            titleTextBox = new TextBox();
            titleLabel = new Label();
            viewCalendarButton = new Button();
            descriptionLabel = new Label();
            descriptionTextBox = new RichTextBox();
            locationTextBox = new TextBox();
            locationLabel = new Label();
            contactTextBox = new TextBox();
            contactLabel = new Label();
            urlTextBox = new TextBox();
            urlLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dvgCustomers).BeginInit();
            SuspendLayout();
            // 
            // searchCustomerLabel
            // 
            searchCustomerLabel.AutoSize = true;
            searchCustomerLabel.Location = new Point(654, 594);
            searchCustomerLabel.Name = "searchCustomerLabel";
            searchCustomerLabel.Size = new Size(164, 20);
            searchCustomerLabel.TabIndex = 37;
            searchCustomerLabel.Text = "Search Customer Name";
            // 
            // searchCustomerTextBox
            // 
            searchCustomerTextBox.Location = new Point(631, 564);
            searchCustomerTextBox.Name = "searchCustomerTextBox";
            searchCustomerTextBox.Size = new Size(201, 27);
            searchCustomerTextBox.TabIndex = 85;
            searchCustomerTextBox.TextChanged += searchCustomerTextBox_TextChanged;
            // 
            // dvgCustomers
            // 
            dvgCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgCustomers.Location = new Point(453, 85);
            dvgCustomers.Name = "dvgCustomers";
            dvgCustomers.RowHeadersWidth = 51;
            dvgCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgCustomers.Size = new Size(543, 473);
            dvgCustomers.TabIndex = 86;
            dvgCustomers.CellContentClick += dvgCustomers_CellContentClick;
            // 
            // customersLabel
            // 
            customersLabel.AutoSize = true;
            customersLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customersLabel.Location = new Point(654, 47);
            customersLabel.Name = "customersLabel";
            customersLabel.Size = new Size(166, 41);
            customersLabel.TabIndex = 34;
            customersLabel.Text = "Customers";
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(247, 562);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(116, 45);
            cancelButton.TabIndex = 84;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // addAppointmentButton
            // 
            addAppointmentButton.Location = new Point(107, 562);
            addAppointmentButton.Name = "addAppointmentButton";
            addAppointmentButton.Size = new Size(116, 45);
            addAppointmentButton.TabIndex = 83;
            addAppointmentButton.Text = "Create";
            addAppointmentButton.UseVisualStyleBackColor = true;
            addAppointmentButton.Click += addAppointmentButton_Click;
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new Point(39, 285);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(43, 20);
            typeLabel.TabIndex = 40;
            typeLabel.Text = "Type:";
            // 
            // typeTextBox
            // 
            typeTextBox.Location = new Point(98, 285);
            typeTextBox.Name = "typeTextBox";
            typeTextBox.Size = new Size(258, 27);
            typeTextBox.TabIndex = 77;
            // 
            // customerIdLabel
            // 
            customerIdLabel.AutoSize = true;
            customerIdLabel.Location = new Point(71, 64);
            customerIdLabel.Name = "customerIdLabel";
            customerIdLabel.Size = new Size(27, 20);
            customerIdLabel.TabIndex = 42;
            customerIdLabel.Text = "ID:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(42, 403);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(44, 20);
            dateLabel.TabIndex = 44;
            dateLabel.Text = "Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.Location = new Point(101, 14);
            label4.Name = "label4";
            label4.Size = new Size(285, 38);
            label4.TabIndex = 48;
            label4.Text = "Create Appointment";
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Location = new Point(42, 91);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new Size(52, 20);
            customerNameLabel.TabIndex = 49;
            customerNameLabel.Text = "Name:";
            // 
            // customerIdLabelValue
            // 
            customerIdLabelValue.AutoSize = true;
            customerIdLabelValue.Location = new Point(114, 64);
            customerIdLabelValue.Name = "customerIdLabelValue";
            customerIdLabelValue.Size = new Size(162, 20);
            customerIdLabelValue.TabIndex = 50;
            customerIdLabelValue.Text = "Please Select Customer";
            // 
            // customerNameLabelValue
            // 
            customerNameLabelValue.AutoSize = true;
            customerNameLabelValue.Location = new Point(114, 91);
            customerNameLabelValue.Name = "customerNameLabelValue";
            customerNameLabelValue.Size = new Size(162, 20);
            customerNameLabelValue.TabIndex = 51;
            customerNameLabelValue.Text = "Please Select Customer";
            // 
            // appointmentDatePicker
            // 
            appointmentDatePicker.Location = new Point(100, 403);
            appointmentDatePicker.MinDate = new DateTime(2025, 1, 4, 0, 0, 0, 0);
            appointmentDatePicker.Name = "appointmentDatePicker";
            appointmentDatePicker.Size = new Size(259, 27);
            appointmentDatePicker.TabIndex = 80;
            appointmentDatePicker.ValueChanged += appointmentDatePicker_ValueChanged;
            // 
            // startTimeComboBox
            // 
            startTimeComboBox.FormattingEnabled = true;
            startTimeComboBox.Location = new Point(100, 438);
            startTimeComboBox.Name = "startTimeComboBox";
            startTimeComboBox.Size = new Size(182, 28);
            startTimeComboBox.TabIndex = 81;
            startTimeComboBox.SelectedIndexChanged += timeComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 441);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 56;
            label1.Text = "Start Time:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 473);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 58;
            label2.Text = "End Time:";
            // 
            // endTimeComboBox
            // 
            endTimeComboBox.FormattingEnabled = true;
            endTimeComboBox.Location = new Point(100, 473);
            endTimeComboBox.Name = "endTimeComboBox";
            endTimeComboBox.Size = new Size(182, 28);
            endTimeComboBox.TabIndex = 82;
            endTimeComboBox.SelectedIndexChanged += endTimeComboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 538);
            label3.Name = "label3";
            label3.Size = new Size(275, 20);
            label3.TabIndex = 61;
            label3.Text = "Business Hours: 9AM - 5PM EST, Mon-Fri";
            // 
            // startESTValue
            // 
            startESTValue.AutoSize = true;
            startESTValue.Location = new Point(288, 441);
            startESTValue.Name = "startESTValue";
            startESTValue.Size = new Size(79, 20);
            startESTValue.TabIndex = 66;
            startESTValue.Text = "5555 (EST)";
            // 
            // endESTValue
            // 
            endESTValue.AutoSize = true;
            endESTValue.Location = new Point(288, 473);
            endESTValue.Name = "endESTValue";
            endESTValue.Size = new Size(79, 20);
            endESTValue.TabIndex = 67;
            endESTValue.Text = "5555 (EST)";
            // 
            // elapsedTimeValueLabel
            // 
            elapsedTimeValueLabel.AutoSize = true;
            elapsedTimeValueLabel.Location = new Point(14, 508);
            elapsedTimeValueLabel.Name = "elapsedTimeValueLabel";
            elapsedTimeValueLabel.Size = new Size(125, 20);
            elapsedTimeValueLabel.TabIndex = 59;
            elapsedTimeValueLabel.Text = " Duration:    0:230";
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(99, 114);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(258, 27);
            titleTextBox.TabIndex = 73;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(52, 117);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(41, 20);
            titleLabel.TabIndex = 72;
            titleLabel.Text = "Title:";
            // 
            // viewCalendarButton
            // 
            viewCalendarButton.Location = new Point(160, 352);
            viewCalendarButton.Name = "viewCalendarButton";
            viewCalendarButton.Size = new Size(116, 45);
            viewCalendarButton.TabIndex = 79;
            viewCalendarButton.Text = "View Calendar";
            viewCalendarButton.UseVisualStyleBackColor = true;
            viewCalendarButton.Click += viewCalendarButton_Click;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(4, 150);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(88, 20);
            descriptionLabel.TabIndex = 75;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(98, 147);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(259, 66);
            descriptionTextBox.TabIndex = 74;
            descriptionTextBox.Text = "";
            // 
            // locationTextBox
            // 
            locationTextBox.Location = new Point(98, 219);
            locationTextBox.Name = "locationTextBox";
            locationTextBox.Size = new Size(258, 27);
            locationTextBox.TabIndex = 75;
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new Point(17, 222);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new Size(69, 20);
            locationLabel.TabIndex = 78;
            locationLabel.Text = "Location:";
            // 
            // contactTextBox
            // 
            contactTextBox.Location = new Point(98, 252);
            contactTextBox.Name = "contactTextBox";
            contactTextBox.Size = new Size(258, 27);
            contactTextBox.TabIndex = 76;
            // 
            // contactLabel
            // 
            contactLabel.AutoSize = true;
            contactLabel.Location = new Point(23, 252);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new Size(63, 20);
            contactLabel.TabIndex = 80;
            contactLabel.Text = "Contact:";
            // 
            // urlTextBox
            // 
            urlTextBox.Location = new Point(98, 318);
            urlTextBox.Name = "urlTextBox";
            urlTextBox.Size = new Size(258, 27);
            urlTextBox.TabIndex = 78;
            // 
            // urlLabel
            // 
            urlLabel.AutoSize = true;
            urlLabel.Location = new Point(44, 318);
            urlLabel.Name = "urlLabel";
            urlLabel.Size = new Size(38, 20);
            urlLabel.TabIndex = 82;
            urlLabel.Text = "URL:";
            // 
            // AddAppointmentScreen
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            ClientSize = new Size(1008, 628);
            Controls.Add(urlTextBox);
            Controls.Add(urlLabel);
            Controls.Add(contactTextBox);
            Controls.Add(contactLabel);
            Controls.Add(locationTextBox);
            Controls.Add(locationLabel);
            Controls.Add(descriptionTextBox);
            Controls.Add(descriptionLabel);
            Controls.Add(viewCalendarButton);
            Controls.Add(titleTextBox);
            Controls.Add(titleLabel);
            Controls.Add(endESTValue);
            Controls.Add(startESTValue);
            Controls.Add(label3);
            Controls.Add(elapsedTimeValueLabel);
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
        private Label elapsedTimeValueLabel;
        private TextBox titleTextBox;
        private Label titleLabel;
        private Button viewCalendarButton;
        private Label descriptionLabel;
        private RichTextBox descriptionTextBox;
        private TextBox locationTextBox;
        private Label locationLabel;
        private TextBox contactTextBox;
        private Label contactLabel;
        private TextBox urlTextBox;
        private Label urlLabel;
    }
}