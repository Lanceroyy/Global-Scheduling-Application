using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Project_C969_Appointment_App.Scripts;

namespace Project_C969_Appointment_App.Database
{
    public class DatabaseConnection
    {
        public static MySqlConnection mysqlConnection { get; set; }
        public static string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

      
        private static string loginHistoryFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Login_History.txt");

        public static void startConnection()
        {
            try
            {
                mysqlConnection = new MySqlConnection(connectionString);

                //open a connection
                mysqlConnection.Open();


            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        public static void closeConnection()
        {
            try
            {
                if (mysqlConnection != null)
                {
                    mysqlConnection.Close();
                }
                mysqlConnection = null;
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.Message);
            }

        }


        public static void loginToDatabase(string username, string password)
        {
            //Create a Record File of Logins if it doesn't exist
            if (!File.Exists(loginHistoryFile))
            {
                File.Create(loginHistoryFile).Close();
            }

            //The query string is sent to the database with the parameter placeholders (@username and @password)
            string query = "SELECT COUNT(*) FROM user WHERE username = @username AND password = @password";

            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

            using (MySqlConnection mysqlConnection = new MySqlConnection(connectionString))
            {
                try
                {
                    mysqlConnection.Open();
                    MySqlCommand mysqlCommand = new MySqlCommand(query, mysqlConnection);

                    //These method takes the values, and replaces them with actual values.
                    mysqlCommand.Parameters.AddWithValue("@username", username); 
                    mysqlCommand.Parameters.AddWithValue("@password", password);

                    int userCount = Convert.ToInt32(mysqlCommand.ExecuteScalar());

                    //If user exists
                    if (userCount > 0)
                    {
                        if (Localization.DefaultLanguage == "en")
                        {
                            MessageBox.Show("Login successful!");
                        }
                        else if (Localization.DefaultLanguage == "es")
                        {
                            MessageBox.Show("Inicio de sesión exitoso!");
                        }
                      
                        //Open the main screen
                        MainScreen mainScreen = new MainScreen();
                        mainScreen.Show();

                        //Store the username in a universal variable
                        Utils.currentUser = username;
                        Utils.currentUserId = Appointment.GetUserId(username);

                        //Write Successful Login to Record File
                        //File under Project_C969_Appointment_App\bin\Debug\net8.0-windows
                        using (StreamWriter streamWriter = new StreamWriter(loginHistoryFile, true))
                        {
                            streamWriter.WriteLine("Successful Login from " + username + " at " + DateTime.Now);
                        }

                        AppointmentAlerts.CheckForUpcomingAppointments(Utils.currentUserId);
                        
                        //Hide the current login screen
                        LoginScreen loginScreen = Application.OpenForms.OfType<LoginScreen>().FirstOrDefault();
                        if (loginScreen != null)
                        {
                            loginScreen.Hide();
                        }

                        //Application.OpenForms.OfType<LoginScreen>().FirstOrDefault()?.Hide(); //Shorthand version of the above

                    }
                    else
                    {
                        if (Localization.DefaultLanguage == "en")
                        {
                            MessageBox.Show("Invalid username or password.");
                        }
                        else if (Localization.DefaultLanguage == "es")
                        {
                            MessageBox.Show("Nombre de usuario o contraseña inválidos.");
                        }

                        //Write Failed Login to Record File
                        //File under Project_C969_Appointment_App\bin\Debug\net8.0-windows
                        using (StreamWriter streamWriter = new StreamWriter(loginHistoryFile, true))
                        {
                            streamWriter.WriteLine("Failed Login from " + username + " at " + DateTime.Now);
                        }
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("An error occurred: " + exception.Message);
          
                }
            }

            
        }

   



        
    }
}
