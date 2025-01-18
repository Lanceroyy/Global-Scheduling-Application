using MySql.Data.MySqlClient;
using Project_C969_Appointment_App.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_C969_Appointment_App.Scripts
{
    public  class AppointmentAlerts
    {
        public static void CheckForUpcomingAppointments(int userId)
        {
            // Get the current UTC time
            DateTime nowUtc = DateTime.UtcNow;

            // Fetch user's upcoming appointments from the database
            List<Appointment> userAppointments = GetAppointmentsForUser(userId);

            foreach (var appointment in userAppointments)
            {
                // Convert appointment time from UTC to local time
                DateTime appointmentLocalTime = TimeZoneInfo.ConvertTimeFromUtc(appointment.Start, TimeZoneInfo.Local);

                // Check if the appointment is within the next 15 minutes
                if (appointmentLocalTime > DateTime.Now && appointmentLocalTime <= DateTime.Now.AddMinutes(15))
                {
                    // Generate an alert for the user
                    MessageBox.Show(
                        $"You have an appointment scheduled at {appointmentLocalTime:hh:mm tt} today.",
                        "Upcoming Appointment Alert",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    break; // Alert for the first relevant appointment and exit the loop
                }
            }
        }


        public static List<Appointment> GetAppointmentsForUser(int userId)
        {
            // Replace with your database access code
            // Fetch appointments for the user that are scheduled for today or in the future
            string query = "SELECT start FROM appointment WHERE userId = @UserId AND start >= @TodayUtc";

            List<Appointment> appointments = new List<Appointment>();

            using (MySqlConnection connection = new MySqlConnection(DatabaseConnection.connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@TodayUtc", DateTime.UtcNow.Date);
                connection.Open();

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    appointments.Add(new Appointment
                    {
                        Start = (DateTime)reader["start"]
                    });
                }
            }

            return appointments;
        }



    }
}
