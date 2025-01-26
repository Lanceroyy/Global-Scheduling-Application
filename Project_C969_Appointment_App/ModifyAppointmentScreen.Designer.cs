namespace Project_C969_Appointment_App
{
    partial class ModifyAppointmentScreen
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
            updateAppointmentButton = new Button();
            startESTValue = new Label();
            endESTValue = new Label();
            label3 = new Label();
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
            endTimeComboBox = new ComboBox();
            label2 = new Label();
            elapsedTimeValueLabel = new Label();
            urlTextBox = new TextBox();
            urlLabel = new Label();
            contactTextBox = new TextBox();
            contactLabel = new Label();
            locationTextBox = new TextBox();
            locationLabel = new Label();
            descriptionTextBox = new RichTextBox();
            descriptionLabel = new Label();
            viewCalendarButton = new Button();
            titleTextBox = new TextBox();
            titleLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dvgCustomers).BeginInit();
            SuspendLayout();
            // 
            // searchCustomerLabel
            // 
            searchCustomerLabel.AutoSize = true;
            searchCustomerLabel.Location = new Point(554, 459);
            searchCustomerLabel.Margin = new Padding(2, 0, 2, 0);
            searchCustomerLabel.Name = "searchCustomerLabel";
            searchCustomerLabel.Size = new Size(164, 20);
            searchCustomerLabel.TabIndex = 37;
            searchCustomerLabel.Text = "Search Customer Name";
            // 
            // searchCustomerTextBox
            // 
            searchCustomerTextBox.Location = new Point(531, 430);
            searchCustomerTextBox.Margin = new Padding(2);
            searchCustomerTextBox.Name = "searchCustomerTextBox";
            searchCustomerTextBox.Size = new Size(208, 27);
            searchCustomerTextBox.TabIndex = 99;
            searchCustomerTextBox.TextChanged += searchCustomerTextBox_TextChanged;
            // 
            // dvgCustomers
            // 
            dvgCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgCustomers.Location = new Point(392, 64);
            dvgCustomers.Margin = new Padding(2);
            dvgCustomers.Name = "dvgCustomers";
            dvgCustomers.RowHeadersWidth = 51;
            dvgCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgCustomers.Size = new Size(497, 362);
            dvgCustomers.TabIndex = 100;
            dvgCustomers.CellContentClick += dvgCustomers_CellContentClick;
            // 
            // customersLabel
            // 
            customersLabel.AutoSize = true;
            customersLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customersLabel.Location = new Point(554, 21);
            customersLabel.Margin = new Padding(2, 0, 2, 0);
            customersLabel.Name = "customersLabel";
            customersLabel.Size = new Size(166, 41);
            customersLabel.TabIndex = 34;
            customersLabel.Text = "Customers";
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(237, 571);
            cancelButton.Margin = new Padding(2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(95, 36);
            cancelButton.TabIndex = 98;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // updateAppointmentButton
            // 
            updateAppointmentButton.Location = new Point(122, 571);
            updateAppointmentButton.Margin = new Padding(2);
            updateAppointmentButton.Name = "updateAppointmentButton";
            updateAppointmentButton.Size = new Size(95, 36);
            updateAppointmentButton.TabIndex = 97;
            updateAppointmentButton.Text = "Update";
            updateAppointmentButton.UseVisualStyleBackColor = true;
            updateAppointmentButton.Click += updateAppointmentButton_Click;
            // 
            // startESTValue
            // 
            startESTValue.AutoSize = true;
            startESTValue.Location = new Point(259, 439);
            startESTValue.Margin = new Padding(2, 0, 2, 0);
            startESTValue.Name = "startESTValue";
            startESTValue.Size = new Size(79, 20);
            startESTValue.TabIndex = 66;
            startESTValue.Text = "5555 (EST)";
            // 
            // endESTValue
            // 
            endESTValue.AutoSize = true;
            endESTValue.Location = new Point(259, 476);
            endESTValue.Margin = new Padding(2, 0, 2, 0);
            endESTValue.Name = "endESTValue";
            endESTValue.Size = new Size(79, 20);
            endESTValue.TabIndex = 67;
            endESTValue.Text = "5555 (EST)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 548);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(275, 20);
            label3.TabIndex = 61;
            label3.Text = "Business Hours: 9AM - 5PM EST, Mon-Fri";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new Point(46, 273);
            typeLabel.Margin = new Padding(2, 0, 2, 0);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(43, 20);
            typeLabel.TabIndex = 40;
            typeLabel.Text = "Type:";
            // 
            // typeTextBox
            // 
            typeTextBox.Location = new Point(104, 273);
            typeTextBox.Margin = new Padding(2);
            typeTextBox.Name = "typeTextBox";
            typeTextBox.Size = new Size(258, 27);
            typeTextBox.TabIndex = 91;
            // 
            // customerIdLabel
            // 
            customerIdLabel.AutoSize = true;
            customerIdLabel.Location = new Point(70, 48);
            customerIdLabel.Margin = new Padding(2, 0, 2, 0);
            customerIdLabel.Name = "customerIdLabel";
            customerIdLabel.Size = new Size(27, 20);
            customerIdLabel.TabIndex = 42;
            customerIdLabel.Text = "ID:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(46, 399);
            dateLabel.Margin = new Padding(2, 0, 2, 0);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(44, 20);
            dateLabel.TabIndex = 44;
            dateLabel.Text = "Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.Location = new Point(90, 6);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(296, 38);
            label4.TabIndex = 48;
            label4.Text = "Update Appointment";
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Location = new Point(46, 79);
            customerNameLabel.Margin = new Padding(2, 0, 2, 0);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new Size(52, 20);
            customerNameLabel.TabIndex = 49;
            customerNameLabel.Text = "Name:";
            // 
            // customerIdLabelValue
            // 
            customerIdLabelValue.AutoSize = true;
            customerIdLabelValue.Location = new Point(103, 48);
            customerIdLabelValue.Margin = new Padding(2, 0, 2, 0);
            customerIdLabelValue.Name = "customerIdLabelValue";
            customerIdLabelValue.Size = new Size(162, 20);
            customerIdLabelValue.TabIndex = 50;
            customerIdLabelValue.Text = "Please Select Customer";
            // 
            // customerNameLabelValue
            // 
            customerNameLabelValue.AutoSize = true;
            customerNameLabelValue.Location = new Point(105, 79);
            customerNameLabelValue.Margin = new Padding(2, 0, 2, 0);
            customerNameLabelValue.Name = "customerNameLabelValue";
            customerNameLabelValue.Size = new Size(162, 20);
            customerNameLabelValue.TabIndex = 51;
            customerNameLabelValue.Text = "Please Select Customer";
            // 
            // appointmentDatePicker
            // 
            appointmentDatePicker.Location = new Point(105, 399);
            appointmentDatePicker.Margin = new Padding(2);
            appointmentDatePicker.Name = "appointmentDatePicker";
            appointmentDatePicker.Size = new Size(213, 27);
            appointmentDatePicker.TabIndex = 94;
            appointmentDatePicker.ValueChanged += appointmentDatePicker_ValueChanged;
            // 
            // startTimeComboBox
            // 
            startTimeComboBox.FormattingEnabled = true;
            startTimeComboBox.Location = new Point(105, 437);
            startTimeComboBox.Margin = new Padding(2);
            startTimeComboBox.Name = "startTimeComboBox";
            startTimeComboBox.Size = new Size(150, 28);
            startTimeComboBox.TabIndex = 95;
            startTimeComboBox.SelectedIndexChanged += timeComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 437);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 56;
            label1.Text = "Start Time:";
            // 
            // endTimeComboBox
            // 
            endTimeComboBox.FormattingEnabled = true;
            endTimeComboBox.Location = new Point(105, 476);
            endTimeComboBox.Margin = new Padding(2);
            endTimeComboBox.Name = "endTimeComboBox";
            endTimeComboBox.Size = new Size(150, 28);
            endTimeComboBox.TabIndex = 96;
            endTimeComboBox.SelectedIndexChanged += endTimeComboBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 476);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 58;
            label2.Text = "End Time:";
            // 
            // elapsedTimeValueLabel
            // 
            elapsedTimeValueLabel.AutoSize = true;
            elapsedTimeValueLabel.Location = new Point(12, 517);
            elapsedTimeValueLabel.Margin = new Padding(2, 0, 2, 0);
            elapsedTimeValueLabel.Name = "elapsedTimeValueLabel";
            elapsedTimeValueLabel.Size = new Size(133, 20);
            elapsedTimeValueLabel.TabIndex = 59;
            elapsedTimeValueLabel.Text = " Duration:      0:230";
            // 
            // urlTextBox
            // 
            urlTextBox.Location = new Point(104, 306);
            urlTextBox.Name = "urlTextBox";
            urlTextBox.Size = new Size(258, 27);
            urlTextBox.TabIndex = 92;
            // 
            // urlLabel
            // 
            urlLabel.AutoSize = true;
            urlLabel.Location = new Point(50, 306);
            urlLabel.Name = "urlLabel";
            urlLabel.Size = new Size(38, 20);
            urlLabel.TabIndex = 95;
            urlLabel.Text = "URL:";
            // 
            // contactTextBox
            // 
            contactTextBox.Location = new Point(104, 240);
            contactTextBox.Name = "contactTextBox";
            contactTextBox.Size = new Size(258, 27);
            contactTextBox.TabIndex = 90;
            // 
            // contactLabel
            // 
            contactLabel.AutoSize = true;
            contactLabel.Location = new Point(29, 240);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new Size(63, 20);
            contactLabel.TabIndex = 93;
            contactLabel.Text = "Contact:";
            // 
            // locationTextBox
            // 
            locationTextBox.Location = new Point(104, 207);
            locationTextBox.Name = "locationTextBox";
            locationTextBox.Size = new Size(258, 27);
            locationTextBox.TabIndex = 89;
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new Point(23, 210);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new Size(69, 20);
            locationLabel.TabIndex = 91;
            locationLabel.Text = "Location:";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(104, 135);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(259, 66);
            descriptionTextBox.TabIndex = 88;
            descriptionTextBox.Text = "";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(10, 138);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(88, 20);
            descriptionLabel.TabIndex = 89;
            descriptionLabel.Text = "Description:";
            // 
            // viewCalendarButton
            // 
            viewCalendarButton.Location = new Point(166, 340);
            viewCalendarButton.Name = "viewCalendarButton";
            viewCalendarButton.Size = new Size(116, 45);
            viewCalendarButton.TabIndex = 93;
            viewCalendarButton.Text = "View Calendar";
            viewCalendarButton.UseVisualStyleBackColor = true;
            viewCalendarButton.Click += viewCalendarButton_Click;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(105, 102);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(258, 27);
            titleTextBox.TabIndex = 87;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(58, 105);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(41, 20);
            titleLabel.TabIndex = 86;
            titleLabel.Text = "Title:";
            // 
            // ModifyAppointmentScreen
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            ClientSize = new Size(900, 618);
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
            Controls.Add(updateAppointmentButton);
            Controls.Add(searchCustomerLabel);
            Controls.Add(searchCustomerTextBox);
            Controls.Add(dvgCustomers);
            Controls.Add(customersLabel);
            Margin = new Padding(2);
            Name = "ModifyAppointmentScreen";
            Text = "Modify Appointment Screen";
            Load += ModifyAppointmentScreen_Load;
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
        private Button updateAppointmentButton;
        private Label startESTValue;
        private Label endESTValue;
        private Label label3;
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
        private ComboBox endTimeComboBox;
        private Label label2;
        private Label elapsedTimeValueLabel;
        private TextBox urlTextBox;
        private Label urlLabel;
        private TextBox contactTextBox;
        private Label contactLabel;
        private TextBox locationTextBox;
        private Label locationLabel;
        private RichTextBox descriptionTextBox;
        private Label descriptionLabel;
        private Button viewCalendarButton;
        private TextBox titleTextBox;
        private Label titleLabel;
    }
}