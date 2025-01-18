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

        private void connectButton_Click(object sender, EventArgs e)
        {
            //Get connection string
            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

            //Make connection
            MySqlConnection? myConnection = null;
            try
            {
                myConnection = new MySqlConnection(connectionString);

                //open a connection
                myConnection.Open();
                MessageBox.Show("Connection Open");
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                if (myConnection != null)
                {
                    myConnection.Close();
                }
            }
        }

        private void checkConnectionButton_Click(object sender, EventArgs e)
        {
            MySqlConnection myConnection = DatabaseConnection.mysqlConnection;

            if (myConnection.State == System.Data.ConnectionState.Open)
            {
                MessageBox.Show("Connection Open");
            }

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string userName = userNameTextBox.Text;
            string password = passwordTextBox.Text;

            DatabaseConnection.loginToDatabase(userName, password);
        }


    }
}
