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
            timeZoneLabel = new Label();
            languageLabel = new Label();
            regionLabel = new Label();
            countryLabel = new Label();
            SuspendLayout();
            // 
            // titleText
            // 
            titleText.AutoSize = true;
            titleText.Font = new Font("Segoe UI", 16F);
            titleText.Location = new Point(39, 9);
            titleText.Margin = new Padding(2, 0, 2, 0);
            titleText.Name = "titleText";
            titleText.Size = new Size(297, 37);
            titleText.TabIndex = 2;
            titleText.Text = "Appointment Scheduler";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(103, 83);
            userNameTextBox.Margin = new Padding(2);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(181, 34);
            userNameTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(103, 153);
            passwordTextBox.Margin = new Padding(2);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(181, 34);
            passwordTextBox.TabIndex = 4;
            // 
            // userNameLabel
            // 
            userNameLabel.Location = new Point(103, 45);
            userNameLabel.Margin = new Padding(2, 0, 2, 0);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(180, 36);
            userNameLabel.TabIndex = 5;
            userNameLabel.Text = "Username";
            userNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passwordLabel
            // 
            passwordLabel.Location = new Point(104, 119);
            passwordLabel.Margin = new Padding(2, 0, 2, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(180, 32);
            passwordLabel.TabIndex = 6;
            passwordLabel.Text = "Password";
            passwordLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(128, 191);
            loginButton.Margin = new Padding(2);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(131, 50);
            loginButton.TabIndex = 7;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // userLocationTitleLabel
            // 
            userLocationTitleLabel.AutoSize = true;
            userLocationTitleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userLocationTitleLabel.Location = new Point(118, 265);
            userLocationTitleLabel.Margin = new Padding(2, 0, 2, 0);
            userLocationTitleLabel.Name = "userLocationTitleLabel";
            userLocationTitleLabel.Size = new Size(141, 28);
            userLocationTitleLabel.TabIndex = 8;
            userLocationTitleLabel.Text = "User Location";
            // 
            // timeZoneLabel
            // 
            timeZoneLabel.AutoSize = true;
            timeZoneLabel.Location = new Point(82, 377);
            timeZoneLabel.Margin = new Padding(2, 0, 2, 0);
            timeZoneLabel.Name = "timeZoneLabel";
            timeZoneLabel.Size = new Size(107, 28);
            timeZoneLabel.TabIndex = 24;
            timeZoneLabel.Text = "Time Zone:";
            // 
            // languageLabel
            // 
            languageLabel.AutoSize = true;
            languageLabel.Location = new Point(88, 349);
            languageLabel.Margin = new Padding(2, 0, 2, 0);
            languageLabel.Name = "languageLabel";
            languageLabel.Size = new Size(101, 28);
            languageLabel.TabIndex = 22;
            languageLabel.Text = "Language:";
            // 
            // regionLabel
            // 
            regionLabel.AutoSize = true;
            regionLabel.Location = new Point(112, 321);
            regionLabel.Margin = new Padding(2, 0, 2, 0);
            regionLabel.Name = "regionLabel";
            regionLabel.Size = new Size(77, 28);
            regionLabel.TabIndex = 21;
            regionLabel.Text = "Region:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new Point(103, 293);
            countryLabel.Margin = new Padding(2, 0, 2, 0);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(86, 28);
            countryLabel.TabIndex = 20;
            countryLabel.Text = "Country:";
            // 
            // LoginScreen
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            ClientSize = new Size(385, 414);
            Controls.Add(timeZoneLabel);
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
            Margin = new Padding(2);
            Name = "LoginScreen";
            Text = "Login Screen";
            Load += LoginScreen_Load;
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
        public Label regionLabel;
        public Label languageLabel;

        public Label timeZoneLabel;

        public Label countryLabel;

    }
}
