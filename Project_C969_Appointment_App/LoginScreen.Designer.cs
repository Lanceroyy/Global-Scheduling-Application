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
            titleText.Location = new Point(88, 13);
            titleText.Name = "titleText";
            titleText.Size = new Size(297, 37);
            titleText.TabIndex = 2;
            titleText.Text = "Appointment Scheduler";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(126, 91);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(220, 34);
            userNameTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(126, 162);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(220, 34);
            passwordTextBox.TabIndex = 4;
            // 
            // userNameLabel
            // 
            userNameLabel.Location = new Point(126, 60);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(220, 28);
            userNameLabel.TabIndex = 5;
            userNameLabel.Text = "Username";
            userNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passwordLabel
            // 
            passwordLabel.Location = new Point(126, 131);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(220, 28);
            passwordLabel.TabIndex = 6;
            passwordLabel.Text = "Password";
            passwordLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(156, 219);
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
            userLocationTitleLabel.Location = new Point(166, 288);
            userLocationTitleLabel.Name = "userLocationTitleLabel";
            userLocationTitleLabel.Size = new Size(141, 28);
            userLocationTitleLabel.TabIndex = 8;
            userLocationTitleLabel.Text = "User Location";
            // 
            // timeZoneLabel
            // 
            timeZoneLabel.AutoSize = true;
            timeZoneLabel.Location = new Point(101, 416);
            timeZoneLabel.Name = "timeZoneLabel";
            timeZoneLabel.Size = new Size(107, 28);
            timeZoneLabel.TabIndex = 24;
            timeZoneLabel.Text = "Time Zone:";
            // 
            // languageLabel
            // 
            languageLabel.AutoSize = true;
            languageLabel.Location = new Point(107, 388);
            languageLabel.Name = "languageLabel";
            languageLabel.Size = new Size(101, 28);
            languageLabel.TabIndex = 22;
            languageLabel.Text = "Language:";
            // 
            // regionLabel
            // 
            regionLabel.AutoSize = true;
            regionLabel.Location = new Point(131, 360);
            regionLabel.Name = "regionLabel";
            regionLabel.Size = new Size(77, 28);
            regionLabel.TabIndex = 21;
            regionLabel.Text = "Region:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new Point(126, 332);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(86, 28);
            countryLabel.TabIndex = 20;
            countryLabel.Text = "Country:";
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 461);
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
