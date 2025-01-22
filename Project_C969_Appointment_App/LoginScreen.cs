using MySql.Data.MySqlClient;
using Project_C969_Appointment_App.Database;
using Project_C969_Appointment_App.Scripts;
using System.Configuration;

namespace Project_C969_Appointment_App
{
    public partial class LoginScreen : Form
    {
        private Localization localization;

        public LoginScreen()
        {
            InitializeComponent();

            localization = new Localization();
            localization.SetDefaultLanguage(this);
            localization.ObtainUserTimeZoneAndLocation(countryLabel, regionLabel, languageLabel, timeZoneLabel);

            StartPosition = FormStartPosition.CenterScreen;

        }



        private void loginButton_Click(object sender, EventArgs e)
        {
            string userName = userNameTextBox.Text;
            string password = passwordTextBox.Text;

            DatabaseConnection.loginToDatabase(userName, password);
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
