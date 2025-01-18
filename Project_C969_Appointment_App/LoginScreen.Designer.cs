namespace Project_C969_Appointment_App
{
    partial class LoginScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleText = new Label();
            userNameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            userNameLabel = new Label();
            passwordLabel = new Label();
            loginButton = new Button();
            userLocationTitleLabel = new Label();
            countryLabel = new Label();
            regionLabel = new Label();
            languageLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            timeZoneLabel = new Label();
            SuspendLayout();
            // 
            // titleText
            // 
            titleText.AutoSize = true;
            titleText.Font = new Font("Segoe UI", 16F);
            titleText.Location = new Point(105, 4);
            titleText.Name = "titleText";
            titleText.Size = new Size(297, 37);
            titleText.TabIndex = 2;
            titleText.Text = "Appointment Scheduler";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(139, 82);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(220, 34);
            userNameTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(139, 153);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(220, 34);
            passwordTextBox.TabIndex = 4;
            // 
            // userNameLabel
            // 
            userNameLabel.Location = new Point(139, 51);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(220, 28);
            userNameLabel.TabIndex = 5;
            userNameLabel.Text = "Username";
            userNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passwordLabel
            // 
            passwordLabel.Location = new Point(139, 122);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(220, 28);
            passwordLabel.TabIndex = 6;
            passwordLabel.Text = "Password";
            passwordLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(169, 193);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(160, 66);
            loginButton.TabIndex = 7;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // userLocationTitleLabel
            // 
            userLocationTitleLabel.AutoSize = true;
            userLocationTitleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userLocationTitleLabel.Location = new Point(178, 262);
            userLocationTitleLabel.Name = "userLocationTitleLabel";
            userLocationTitleLabel.Size = new Size(141, 28);
            userLocationTitleLabel.TabIndex = 8;
            userLocationTitleLabel.Text = "User Location";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new Point(246, 290);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(82, 28);
            countryLabel.TabIndex = 9;
            countryLabel.Text = "Country";
            // 
            // regionLabel
            // 
            regionLabel.AutoSize = true;
            regionLabel.Location = new Point(246, 318);
            regionLabel.Name = "regionLabel";
            regionLabel.Size = new Size(73, 28);
            regionLabel.TabIndex = 10;
            regionLabel.Text = "Region";
            // 
            // languageLabel
            // 
            languageLabel.AutoSize = true;
            languageLabel.Location = new Point(246, 346);
            languageLabel.Name = "languageLabel";
            languageLabel.Size = new Size(97, 28);
            languageLabel.TabIndex = 11;
            languageLabel.Text = "Language";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(166, 290);
            label1.Name = "label1";
            label1.Size = new Size(86, 28);
            label1.TabIndex = 12;
            label1.Text = "Country:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 318);
            label2.Name = "label2";
            label2.Size = new Size(77, 28);
            label2.TabIndex = 13;
            label2.Text = "Region:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(151, 346);
            label3.Name = "label3";
            label3.Size = new Size(101, 28);
            label3.TabIndex = 14;
            label3.Text = "Language:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(144, 374);
            label4.Name = "label4";
            label4.Size = new Size(108, 28);
            label4.TabIndex = 15;
            label4.Text = "Local Time:";
            // 
            // timeZoneLabel
            // 
            timeZoneLabel.AutoSize = true;
            timeZoneLabel.Location = new Point(246, 374);
            timeZoneLabel.Name = "timeZoneLabel";
            timeZoneLabel.Size = new Size(108, 28);
            timeZoneLabel.TabIndex = 16;
            timeZoneLabel.Text = "Local Time:";
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 404);
            Controls.Add(timeZoneLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(languageLabel);
            Controls.Add(regionLabel);
            Controls.Add(countryLabel);
            Controls.Add(userLocationTitleLabel);
            Controls.Add(loginButton);
            Controls.Add(passwordLabel);
            Controls.Add(userNameLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(userNameTextBox);
            Controls.Add(titleText);
            Name = "LoginScreen";
            Text = "Login Screen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Label titleText;
        private TextBox passwordTextBox;
        public Label userNameLabel;
        public Label passwordLabel;
        public Button loginButton;
        public TextBox userNameTextBox;
        private Label userLocationTitleLabel;
        public Label countryLabel;
        public Label regionLabel;
        public Label languageLabel;
        public Label label1;
        public Label label2;
        public Label label3;
        public Label label4;
        public Label timeZoneLabel;
    }
}
