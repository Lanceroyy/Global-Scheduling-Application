namespace Project_C969_Appointment_App
{
    partial class ModifyCustomerScreen
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
            phoneTextBox = new TextBox();
            label1 = new Label();
            postalCodeTextBox = new TextBox();
            postalLabel = new Label();
            address2TextBox = new TextBox();
            address2Label = new Label();
            cancelButton = new Button();
            updateCustomerButton = new Button();
            titleLabel = new Label();
            countryTextBox = new TextBox();
            countryLabel = new Label();
            cityTextBox = new TextBox();
            cityLabel = new Label();
            addressLabel = new Label();
            addressTextBox = new TextBox();
            nameLabel = new Label();
            nameTextBox = new TextBox();
            customerIdLabel = new Label();
            activeCheckBox = new CheckBox();
            customerId = new Label();
            SuspendLayout();
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(142, 263);
            phoneTextBox.MaxLength = 12;
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(256, 34);
            phoneTextBox.TabIndex = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 263);
            label1.Name = "label1";
            label1.Size = new Size(80, 28);
            label1.TabIndex = 59;
            label1.Text = "Phone *";
            // 
            // postalCodeTextBox
            // 
            postalCodeTextBox.Location = new Point(142, 223);
            postalCodeTextBox.MaxLength = 10;
            postalCodeTextBox.Name = "postalCodeTextBox";
            postalCodeTextBox.Size = new Size(256, 34);
            postalCodeTextBox.TabIndex = 48;
            // 
            // postalLabel
            // 
            postalLabel.AutoSize = true;
            postalLabel.Location = new Point(8, 226);
            postalLabel.Name = "postalLabel";
            postalLabel.Size = new Size(128, 28);
            postalLabel.TabIndex = 58;
            postalLabel.Text = "Postal Code *";
            // 
            // address2TextBox
            // 
            address2TextBox.Location = new Point(142, 180);
            address2TextBox.Name = "address2TextBox";
            address2TextBox.Size = new Size(256, 34);
            address2TextBox.TabIndex = 47;
            // 
            // address2Label
            // 
            address2Label.AutoSize = true;
            address2Label.Location = new Point(28, 183);
            address2Label.Name = "address2Label";
            address2Label.Size = new Size(98, 28);
            address2Label.TabIndex = 57;
            address2Label.Text = "Address 2";
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(282, 397);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(116, 48);
            cancelButton.TabIndex = 55;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // updateCustomerButton
            // 
            updateCustomerButton.Location = new Point(142, 397);
            updateCustomerButton.Name = "updateCustomerButton";
            updateCustomerButton.Size = new Size(116, 48);
            updateCustomerButton.TabIndex = 54;
            updateCustomerButton.Text = "Update";
            updateCustomerButton.UseVisualStyleBackColor = true;
            updateCustomerButton.Click += updateCustomerButton_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 14F);
            titleLabel.Location = new Point(173, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(200, 32);
            titleLabel.TabIndex = 56;
            titleLabel.Text = "Modify Customer";
            // 
            // countryTextBox
            // 
            countryTextBox.Location = new Point(142, 346);
            countryTextBox.Name = "countryTextBox";
            countryTextBox.Size = new Size(256, 34);
            countryTextBox.TabIndex = 52;
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new Point(41, 346);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(95, 28);
            countryLabel.TabIndex = 53;
            countryLabel.Text = "Country *";
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(142, 306);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(256, 34);
            cityTextBox.TabIndex = 51;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(77, 306);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(59, 28);
            cityLabel.TabIndex = 49;
            cityLabel.Text = "City *";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(41, 143);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(95, 28);
            addressLabel.TabIndex = 46;
            addressLabel.Text = "Address *";
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(142, 140);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(256, 34);
            addressTextBox.TabIndex = 45;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(59, 103);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(77, 28);
            nameLabel.TabIndex = 44;
            nameLabel.Text = "Name *";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(142, 100);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(256, 34);
            nameTextBox.TabIndex = 43;
            // 
            // customerIdLabel
            // 
            customerIdLabel.AutoSize = true;
            customerIdLabel.Location = new Point(16, 63);
            customerIdLabel.Name = "customerIdLabel";
            customerIdLabel.Size = new Size(124, 28);
            customerIdLabel.TabIndex = 61;
            customerIdLabel.Text = "Customer ID:";
            // 
            // activeCheckBox
            // 
            activeCheckBox.AutoSize = true;
            activeCheckBox.Location = new Point(301, 59);
            activeCheckBox.Name = "activeCheckBox";
            activeCheckBox.Size = new Size(97, 32);
            activeCheckBox.TabIndex = 63;
            activeCheckBox.Text = "Active?";
            activeCheckBox.UseVisualStyleBackColor = true;
            // 
            // customerId
            // 
            customerId.AutoSize = true;
            customerId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customerId.Location = new Point(142, 63);
            customerId.Name = "customerId";
            customerId.Size = new Size(48, 28);
            customerId.TabIndex = 64;
            customerId.Text = "234";
            // 
            // ModifyCustomerScreen
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 458);
            Controls.Add(customerId);
            Controls.Add(activeCheckBox);
            Controls.Add(customerIdLabel);
            Controls.Add(phoneTextBox);
            Controls.Add(label1);
            Controls.Add(postalCodeTextBox);
            Controls.Add(postalLabel);
            Controls.Add(address2TextBox);
            Controls.Add(address2Label);
            Controls.Add(cancelButton);
            Controls.Add(updateCustomerButton);
            Controls.Add(titleLabel);
            Controls.Add(countryTextBox);
            Controls.Add(countryLabel);
            Controls.Add(cityTextBox);
            Controls.Add(cityLabel);
            Controls.Add(addressLabel);
            Controls.Add(addressTextBox);
            Controls.Add(nameLabel);
            Controls.Add(nameTextBox);
            Name = "ModifyCustomerScreen";
            Text = "Modify Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox phoneTextBox;
        private Label label1;
        private TextBox postalCodeTextBox;
        private Label postalLabel;
        private TextBox address2TextBox;
        private Label address2Label;
        private Button cancelButton;
        private Button updateCustomerButton;
        private Label titleLabel;
        private TextBox countryTextBox;
        private Label countryLabel;
        private TextBox cityTextBox;
        private Label cityLabel;
        private Label addressLabel;
        private TextBox addressTextBox;
        private Label nameLabel;
        private TextBox nameTextBox;
        private Label customerIdLabel;
        private CheckBox activeCheckBox;
        private Label customerId;
    }
}