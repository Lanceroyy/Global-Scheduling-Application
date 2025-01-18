namespace Project_C969_Appointment_App
{
    partial class AddCustomerScreen
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
            countryTextBox = new TextBox();
            countryLabel = new Label();
            cityTextBox = new TextBox();
            cityLabel = new Label();
            addressLabel = new Label();
            addressTextBox = new TextBox();
            nameLabel = new Label();
            nameTextBox = new TextBox();
            titleLabel = new Label();
            addCustomerButton = new Button();
            cancelButton = new Button();
            address2Label = new Label();
            address2TextBox = new TextBox();
            postalCodeTextBox = new TextBox();
            postalLabel = new Label();
            phoneTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // countryTextBox
            // 
            countryTextBox.Location = new Point(143, 312);
            countryTextBox.Name = "countryTextBox";
            countryTextBox.Size = new Size(256, 34);
            countryTextBox.TabIndex = 32;
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new Point(42, 312);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(95, 28);
            countryLabel.TabIndex = 33;
            countryLabel.Text = "Country *";
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(143, 272);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(256, 34);
            cityTextBox.TabIndex = 31;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(78, 272);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(59, 28);
            cityLabel.TabIndex = 29;
            cityLabel.Text = "City *";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(42, 109);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(95, 28);
            addressLabel.TabIndex = 28;
            addressLabel.Text = "Address *";
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(143, 106);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(256, 34);
            addressTextBox.TabIndex = 27;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(60, 69);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(77, 28);
            nameLabel.TabIndex = 26;
            nameLabel.Text = "Name *";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(143, 66);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(256, 34);
            nameTextBox.TabIndex = 25;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 14F);
            titleLabel.Location = new Point(184, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(167, 32);
            titleLabel.TabIndex = 35;
            titleLabel.Text = "Add Customer";
            // 
            // addCustomerButton
            // 
            addCustomerButton.Location = new Point(143, 398);
            addCustomerButton.Name = "addCustomerButton";
            addCustomerButton.Size = new Size(116, 48);
            addCustomerButton.TabIndex = 33;
            addCustomerButton.Text = "Add";
            addCustomerButton.UseVisualStyleBackColor = true;
            addCustomerButton.Click += addCustomerButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(283, 398);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(116, 48);
            cancelButton.TabIndex = 34;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // address2Label
            // 
            address2Label.AutoSize = true;
            address2Label.Location = new Point(29, 149);
            address2Label.Name = "address2Label";
            address2Label.Size = new Size(98, 28);
            address2Label.TabIndex = 38;
            address2Label.Text = "Address 2";
            // 
            // address2TextBox
            // 
            address2TextBox.Location = new Point(143, 146);
            address2TextBox.Name = "address2TextBox";
            address2TextBox.Size = new Size(256, 34);
            address2TextBox.TabIndex = 28;
            // 
            // postalCodeTextBox
            // 
            postalCodeTextBox.Location = new Point(143, 189);
            postalCodeTextBox.MaxLength = 10;
            postalCodeTextBox.Name = "postalCodeTextBox";
            postalCodeTextBox.Size = new Size(256, 34);
            postalCodeTextBox.TabIndex = 29;
            postalCodeTextBox.TextChanged += textBox1_TextChanged;
            // 
            // postalLabel
            // 
            postalLabel.AutoSize = true;
            postalLabel.Location = new Point(9, 192);
            postalLabel.Name = "postalLabel";
            postalLabel.Size = new Size(128, 28);
            postalLabel.TabIndex = 40;
            postalLabel.Text = "Postal Code *";
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(143, 229);
            phoneTextBox.MaxLength = 12;
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(256, 34);
            phoneTextBox.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 229);
            label1.Name = "label1";
            label1.Size = new Size(80, 28);
            label1.TabIndex = 42;
            label1.Text = "Phone *";
            // 
            // AddCustomerScreen
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 458);
            Controls.Add(phoneTextBox);
            Controls.Add(label1);
            Controls.Add(postalCodeTextBox);
            Controls.Add(postalLabel);
            Controls.Add(address2TextBox);
            Controls.Add(address2Label);
            Controls.Add(cancelButton);
            Controls.Add(addCustomerButton);
            Controls.Add(titleLabel);
            Controls.Add(countryTextBox);
            Controls.Add(countryLabel);
            Controls.Add(cityTextBox);
            Controls.Add(cityLabel);
            Controls.Add(addressLabel);
            Controls.Add(addressTextBox);
            Controls.Add(nameLabel);
            Controls.Add(nameTextBox);
            Name = "AddCustomerScreen";
            Text = "Add Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox countryTextBox;
        private Label countryLabel;
        private TextBox cityTextBox;
        private Label cityLabel;
        private Label addressLabel;
        private TextBox addressTextBox;
        private Label nameLabel;
        private TextBox nameTextBox;
        private Label titleLabel;
        private Button addCustomerButton;
        private Button cancelButton;
        private Label address2Label;
        private TextBox address2TextBox;
        private TextBox postalCodeTextBox;
        private Label postalLabel;
        private TextBox phoneTextBox;
        private Label label1;
    }
}