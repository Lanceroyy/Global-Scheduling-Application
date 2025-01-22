namespace Project_C969_Appointment_App
{
    partial class MainScreen
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
            viewLabel = new Label();
            viewAllButton = new Button();
            viewWeekButton = new Button();
            viewMonthButton = new Button();
            addAppointmentButton = new Button();
            modifyAppointmentButton = new Button();
            deleteAppointmentButton = new Button();
            modifyCustomerButton = new Button();
            addCustomerButton = new Button();
            deleteCustomerButton = new Button();
            customersLabel = new Label();
            appointmentsLabel = new Label();
            exitButton = new Button();
            customerBindingSource = new BindingSource(components);
            dvgCustomers = new DataGridView();
            reportsButton = new Button();
            bindingSource1 = new BindingSource(components);
            searchCustomerTextBox = new TextBox();
            searchCustomerLabel = new Label();
            dvgAppointments = new DataGridView();
            label1 = new Label();
            searchAppointmentTextBox = new TextBox();
            simpleViewButton = new Button();
            detailedCustomerViewButton = new Button();
            label2 = new Label();
            detailedAppointmentDataViewButton = new Button();
            simpleAppointmentDataViewButton = new Button();
            calendarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgCustomers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgAppointments).BeginInit();
            SuspendLayout();
            // 
            // viewLabel
            // 
            viewLabel.AutoSize = true;
            viewLabel.Font = new Font("Segoe UI", 14F);
            viewLabel.Location = new Point(140, 339);
            viewLabel.Name = "viewLabel";
            viewLabel.Size = new Size(53, 25);
            viewLabel.TabIndex = 2;
            viewLabel.Text = "View";
            // 
            // viewAllButton
            // 
            viewAllButton.Location = new Point(359, 639);
            viewAllButton.Name = "viewAllButton";
            viewAllButton.Size = new Size(100, 50);
            viewAllButton.TabIndex = 3;
            viewAllButton.Text = "All";
            viewAllButton.UseVisualStyleBackColor = true;
            viewAllButton.Click += viewAllButton_Click;
            // 
            // viewWeekButton
            // 
            viewWeekButton.Location = new Point(464, 639);
            viewWeekButton.Name = "viewWeekButton";
            viewWeekButton.Size = new Size(100, 50);
            viewWeekButton.TabIndex = 4;
            viewWeekButton.Text = "Week";
            viewWeekButton.UseVisualStyleBackColor = true;
            viewWeekButton.Click += viewWeekButton_Click;
            // 
            // viewMonthButton
            // 
            viewMonthButton.Location = new Point(570, 639);
            viewMonthButton.Name = "viewMonthButton";
            viewMonthButton.Size = new Size(100, 50);
            viewMonthButton.TabIndex = 5;
            viewMonthButton.Text = "Month";
            viewMonthButton.UseVisualStyleBackColor = true;
            viewMonthButton.Click += viewMonthButton_Click;
            // 
            // addAppointmentButton
            // 
            addAppointmentButton.Location = new Point(13, 423);
            addAppointmentButton.Name = "addAppointmentButton";
            addAppointmentButton.Size = new Size(122, 45);
            addAppointmentButton.TabIndex = 6;
            addAppointmentButton.Text = "Add";
            addAppointmentButton.UseVisualStyleBackColor = true;
            addAppointmentButton.Click += addAppointmentButton_Click;
            // 
            // modifyAppointmentButton
            // 
            modifyAppointmentButton.Location = new Point(14, 504);
            modifyAppointmentButton.Name = "modifyAppointmentButton";
            modifyAppointmentButton.Size = new Size(122, 45);
            modifyAppointmentButton.TabIndex = 7;
            modifyAppointmentButton.Text = "Update";
            modifyAppointmentButton.UseVisualStyleBackColor = true;
            modifyAppointmentButton.Click += modifyAppointmentButton_Click;
            // 
            // deleteAppointmentButton
            // 
            deleteAppointmentButton.Location = new Point(14, 579);
            deleteAppointmentButton.Name = "deleteAppointmentButton";
            deleteAppointmentButton.Size = new Size(122, 45);
            deleteAppointmentButton.TabIndex = 8;
            deleteAppointmentButton.Text = "Delete";
            deleteAppointmentButton.UseVisualStyleBackColor = true;
            deleteAppointmentButton.Click += deleteAppointmentButton_Click;
            // 
            // modifyCustomerButton
            // 
            modifyCustomerButton.Location = new Point(13, 165);
            modifyCustomerButton.Name = "modifyCustomerButton";
            modifyCustomerButton.Size = new Size(122, 45);
            modifyCustomerButton.TabIndex = 9;
            modifyCustomerButton.Text = "Update";
            modifyCustomerButton.UseVisualStyleBackColor = true;
            modifyCustomerButton.Click += modifyCustomerButton_Click;
            // 
            // addCustomerButton
            // 
            addCustomerButton.Location = new Point(13, 86);
            addCustomerButton.Name = "addCustomerButton";
            addCustomerButton.Size = new Size(122, 45);
            addCustomerButton.TabIndex = 10;
            addCustomerButton.Text = "Add";
            addCustomerButton.UseVisualStyleBackColor = true;
            addCustomerButton.Click += addCustomerButton_Click;
            // 
            // deleteCustomerButton
            // 
            deleteCustomerButton.Location = new Point(13, 244);
            deleteCustomerButton.Name = "deleteCustomerButton";
            deleteCustomerButton.Size = new Size(122, 45);
            deleteCustomerButton.TabIndex = 11;
            deleteCustomerButton.Text = "Delete";
            deleteCustomerButton.UseVisualStyleBackColor = true;
            deleteCustomerButton.Click += deleteCustomerButton_Click;
            // 
            // customersLabel
            // 
            customersLabel.AutoSize = true;
            customersLabel.Font = new Font("Segoe UI", 18F);
            customersLabel.Location = new Point(510, 38);
            customersLabel.Name = "customersLabel";
            customersLabel.Size = new Size(127, 32);
            customersLabel.TabIndex = 12;
            customersLabel.Text = "Customers";
            // 
            // appointmentsLabel
            // 
            appointmentsLabel.AutoSize = true;
            appointmentsLabel.Font = new Font("Segoe UI", 18F);
            appointmentsLabel.Location = new Point(485, 376);
            appointmentsLabel.Name = "appointmentsLabel";
            appointmentsLabel.Size = new Size(165, 32);
            appointmentsLabel.TabIndex = 14;
            appointmentsLabel.Text = "Appointments";
            // 
            // exitButton
            // 
            exitButton.Location = new Point(867, 639);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(100, 50);
            exitButton.TabIndex = 15;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(Scripts.Customer);
            // 
            // dvgCustomers
            // 
            dvgCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgCustomers.Location = new Point(140, 86);
            dvgCustomers.Name = "dvgCustomers";
            dvgCustomers.RowHeadersVisible = false;
            dvgCustomers.RowHeadersWidth = 51;
            dvgCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgCustomers.Size = new Size(827, 203);
            dvgCustomers.TabIndex = 16;
            // 
            // reportsButton
            // 
            reportsButton.Location = new Point(442, 312);
            reportsButton.Name = "reportsButton";
            reportsButton.Size = new Size(122, 45);
            reportsButton.TabIndex = 18;
            reportsButton.Text = "Reports";
            reportsButton.UseVisualStyleBackColor = true;
            reportsButton.Click += reportsButton_Click;
            // 
            // searchCustomerTextBox
            // 
            searchCustomerTextBox.Location = new Point(727, 49);
            searchCustomerTextBox.Name = "searchCustomerTextBox";
            searchCustomerTextBox.Size = new Size(240, 29);
            searchCustomerTextBox.TabIndex = 20;
            searchCustomerTextBox.TextChanged += searchCustomerTextBox_TextChanged;
            // 
            // searchCustomerLabel
            // 
            searchCustomerLabel.AutoSize = true;
            searchCustomerLabel.Location = new Point(764, 18);
            searchCustomerLabel.Name = "searchCustomerLabel";
            searchCustomerLabel.Size = new Size(175, 21);
            searchCustomerLabel.TabIndex = 21;
            searchCustomerLabel.Text = "Search Customer Name";
            // 
            // dvgAppointments
            // 
            dvgAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgAppointments.Location = new Point(140, 423);
            dvgAppointments.Name = "dvgAppointments";
            dvgAppointments.RowHeadersVisible = false;
            dvgAppointments.RowHeadersWidth = 51;
            dvgAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgAppointments.Size = new Size(827, 201);
            dvgAppointments.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(766, 352);
            label1.Name = "label1";
            label1.Size = new Size(158, 21);
            label1.TabIndex = 25;
            label1.Text = "Search Name or Type";
            // 
            // searchAppointmentTextBox
            // 
            searchAppointmentTextBox.Location = new Point(718, 383);
            searchAppointmentTextBox.Name = "searchAppointmentTextBox";
            searchAppointmentTextBox.Size = new Size(249, 29);
            searchAppointmentTextBox.TabIndex = 24;
            searchAppointmentTextBox.TextChanged += searchAppointmentTextBox_TextChanged;
            // 
            // simpleViewButton
            // 
            simpleViewButton.Location = new Point(140, 42);
            simpleViewButton.Name = "simpleViewButton";
            simpleViewButton.Size = new Size(94, 41);
            simpleViewButton.TabIndex = 28;
            simpleViewButton.Text = "Simple";
            simpleViewButton.UseVisualStyleBackColor = true;
            simpleViewButton.Click += simpleViewButton_Click;
            // 
            // detailedCustomerViewButton
            // 
            detailedCustomerViewButton.Location = new Point(240, 42);
            detailedCustomerViewButton.Name = "detailedCustomerViewButton";
            detailedCustomerViewButton.Size = new Size(94, 41);
            detailedCustomerViewButton.TabIndex = 29;
            detailedCustomerViewButton.Text = "Detailed";
            detailedCustomerViewButton.UseVisualStyleBackColor = true;
            detailedCustomerViewButton.Click += detailedViewButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(140, 7);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 30;
            label2.Text = "View";
            // 
            // detailedAppointmentDataViewButton
            // 
            detailedAppointmentDataViewButton.Location = new Point(240, 374);
            detailedAppointmentDataViewButton.Name = "detailedAppointmentDataViewButton";
            detailedAppointmentDataViewButton.Size = new Size(94, 41);
            detailedAppointmentDataViewButton.TabIndex = 31;
            detailedAppointmentDataViewButton.Text = "Detailed";
            detailedAppointmentDataViewButton.UseVisualStyleBackColor = true;
            detailedAppointmentDataViewButton.Click += detailedAppointmentDataViewButton_Click;
            // 
            // simpleAppointmentDataViewButton
            // 
            simpleAppointmentDataViewButton.Location = new Point(140, 374);
            simpleAppointmentDataViewButton.Name = "simpleAppointmentDataViewButton";
            simpleAppointmentDataViewButton.Size = new Size(94, 41);
            simpleAppointmentDataViewButton.TabIndex = 32;
            simpleAppointmentDataViewButton.Text = "Simple";
            simpleAppointmentDataViewButton.UseVisualStyleBackColor = true;
            simpleAppointmentDataViewButton.Click += simpleAppointmentDataViewButton_Click;
            // 
            // calendarButton
            // 
            calendarButton.Location = new Point(570, 312);
            calendarButton.Name = "calendarButton";
            calendarButton.Size = new Size(122, 45);
            calendarButton.TabIndex = 33;
            calendarButton.Text = "Calendar";
            calendarButton.UseVisualStyleBackColor = true;
            calendarButton.Click += calendarButton_Click;
            // 
            // MainScreen
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(990, 702);
            Controls.Add(calendarButton);
            Controls.Add(simpleAppointmentDataViewButton);
            Controls.Add(detailedAppointmentDataViewButton);
            Controls.Add(label2);
            Controls.Add(detailedCustomerViewButton);
            Controls.Add(simpleViewButton);
            Controls.Add(label1);
            Controls.Add(searchAppointmentTextBox);
            Controls.Add(dvgAppointments);
            Controls.Add(searchCustomerLabel);
            Controls.Add(searchCustomerTextBox);
            Controls.Add(reportsButton);
            Controls.Add(dvgCustomers);
            Controls.Add(exitButton);
            Controls.Add(appointmentsLabel);
            Controls.Add(customersLabel);
            Controls.Add(deleteCustomerButton);
            Controls.Add(addCustomerButton);
            Controls.Add(modifyCustomerButton);
            Controls.Add(deleteAppointmentButton);
            Controls.Add(modifyAppointmentButton);
            Controls.Add(addAppointmentButton);
            Controls.Add(viewMonthButton);
            Controls.Add(viewWeekButton);
            Controls.Add(viewAllButton);
            Controls.Add(viewLabel);
            Name = "MainScreen";
            Text = "Main Screen";
            FormClosing += MainScreen_FormClosing;
            Load += MainScreen_Load;
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgCustomers).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgAppointments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label viewLabel;
        private Button viewAllButton;
        private Button viewWeekButton;
        private Button viewMonthButton;
        private Button addAppointmentButton;
        private Button modifyAppointmentButton;
        private Button deleteAppointmentButton;
        private Button modifyCustomerButton;
        private Button addCustomerButton;
        private Button deleteCustomerButton;
        private Label customersLabel;
        private Label appointmentsLabel;
        private Button exitButton;
        private BindingSource customerBindingSource;
        public DataGridView dvgCustomers;
        private Button reportsButton;
        private BindingSource bindingSource1;
        private TextBox searchCustomerTextBox;
        private Label searchCustomerLabel;
        public DataGridView dvgAppointments;
        private Label label1;
        private TextBox searchAppointmentTextBox;
        private Button simpleViewButton;
        private Button detailedCustomerViewButton;
        private Label label2;
        private Button detailedAppointmentDataViewButton;
        private Button simpleAppointmentDataViewButton;
        private Button calendarButton;
    }
}