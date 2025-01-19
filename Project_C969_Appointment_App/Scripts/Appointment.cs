using MySql.Data.MySqlClient;
using Project_C969_Appointment_App.Database;
using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Project_C969_Appointment_App.Scripts
{
    public class Appointment
    {
        // Properties
        public int AppointmentId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Contact { get; set; }
        public string Type { get; set; }
        public string Url { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }

        private BindingList<Appointment> appointments;

        // Base Constructor
        public Appointment(
            int customerId,
            int userId,
            string title,
            string description,
            string location,
            string contact,
            string type,
            string url,
            DateTime start,
            DateTime end,
            DateTime createDate,
            string createdBy,
            DateTime lastUpdate,
            string lastUpdateBy)
        {
            CustomerId = customerId;
            UserId = userId;
            Title = title;
            Description = description;
            Location = location;
            Contact = contact;
            Type = type;
            Url = url;
            Start = start;
            End = end;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdateBy = lastUpdateBy;
        }



        // Empty Constructor (optional, if needed)
        public Appointment() { }

        public class UserSchedule
        {
            public int UserId { get; set; }
            public List<Appointment> Appointments { get; set; }
        }

        public static void AddAppointment(Appointment appointment)
        {
            try
            {
                //First thing we want to do is write a string query to instert the data into the database
                string query = "INSERT INTO appointment (customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy) "
                             + "VALUES (@CustomerId, @UserId, @Title, @Description, @Location, @Contact, @Type, @Url, @Start, @End, @CreateDate, @CreatedBy, @LastUpdate, @LastUpdateBy)";


                //We have to establish a connection to the database, passing in our connection string
                using (MySqlConnection connection = new MySqlConnection(DatabaseConnection.connectionString))
                {
                    //create an Sql command object passing in the query and the connection
                    MySqlCommand command = new MySqlCommand(query, connection);

                    //Add parameters
                    //We do MySqlCommand.Parameteres and use the AddWithValue method. We then pass in our placeholder and the value)
                    command.Parameters.AddWithValue("@CustomerId", appointment.CustomerId);
                    command.Parameters.AddWithValue("@UserId", appointment.UserId);
                    command.Parameters.AddWithValue("@Title", "not needed");
                    command.Parameters.AddWithValue("@Description", "not needed");
                    command.Parameters.AddWithValue("@Location", "not needed");
                    command.Parameters.AddWithValue("@Contact", "not needed");
                    command.Parameters.AddWithValue("@Type", appointment.Type);
                    command.Parameters.AddWithValue("@Url", "not needed");
                    command.Parameters.AddWithValue("@Start", appointment.Start);
                    command.Parameters.AddWithValue("@End", appointment.End);
                    command.Parameters.AddWithValue("@CreateDate", appointment.CreateDate);
                    command.Parameters.AddWithValue("@CreatedBy", appointment.CreatedBy);
                    command.Parameters.AddWithValue("@LastUpdate", appointment.LastUpdate);
                    command.Parameters.AddWithValue("@LastUpdateBy", appointment.LastUpdateBy);

                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();

                    // Confirm that the operation was successful
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Appointment added successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add the appointment. No rows were affected.");
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error Adding Appointment: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected Error: " + ex.Message);
            }
        }

        public static BindingList<Appointment> GetAppointments(TimePeriod timePeriod, string filter = null)
        {
            var appointments = new BindingList<Appointment>();

            string query;

            if (timePeriod == TimePeriod.All)
            {
                query = "SELECT a.appointmentId, a.customerId, a.userId, a.type, a.start, a.end, " +
                           "a.createDate, a.createdBy, a.lastUpdate, a.lastUpdateBy, " +
                           "c.customerName " +
                           "FROM appointment a " +
                           "LEFT JOIN customer c ON a.customerId = c.customerId";
            }
            else if (timePeriod == TimePeriod.Week)
            {
                query = "SELECT a.appointmentId, a.customerId, a.userId, a.type, a.start, a.end, " +
                                  "a.createDate, a.createdBy, a.lastUpdate, a.lastUpdateBy, " +
                                  "c.customerName " +
                                  "FROM appointment a " +
                                  "LEFT JOIN customer c ON a.customerId = c.customerId " +
                                  "WHERE a.start >= CURDATE() - INTERVAL WEEKDAY(CURDATE()) DAY " +
                                  "AND a.start < CURDATE() - INTERVAL WEEKDAY(CURDATE()) DAY + INTERVAL 7 DAY";

            }
            else if (timePeriod == TimePeriod.Month) 
            {
                query = "SELECT a.appointmentId, a.customerId, a.userId, a.type, a.start, a.end, " +
                              "a.createDate, a.createdBy, a.lastUpdate, a.lastUpdateBy, " +
                              "c.customerName " +
                              "FROM appointment a " +
                              "LEFT JOIN customer c ON a.customerId = c.customerId " +
                              "WHERE MONTH(a.start) = MONTH(CURRENT_DATE()) AND YEAR(a.start) = YEAR(CURRENT_DATE())";
            }
            else
            {

                query = "SELECT a.appointmentId, a.customerId, a.userId, a.type, a.start, a.end, " +
                           "a.createDate, a.createdBy, a.lastUpdate, a.lastUpdateBy, " +
                           "c.customerName " +
                           "FROM appointment a " +
                           "LEFT JOIN customer c ON a.customerId = c.customerId";
            }
   

            if (!string.IsNullOrEmpty(filter))
            {
                query += $" WHERE c.customerName LIKE @filter OR a.type LIKE @filter";
            }

            try
            {
                using (var connection = new MySqlConnection(DatabaseConnection.connectionString))
                using (var command = new MySqlCommand(query, connection))
                {
                    if (!string.IsNullOrEmpty(filter))
                    {
                        command.Parameters.AddWithValue("@filter", $"%{filter}%");
                    }

                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var appointment = new Appointment
                            {
                                AppointmentId = reader.GetInt32("appointmentId"),
                                CustomerId = reader.GetInt32("customerId"),
                                CustomerName = reader.GetString("customerName"), // Include customer name
                                UserId = reader.GetInt32("userId"),
                                Type = reader.GetString("type"),
                                Start = reader.GetDateTime("start"),
                                End = reader.GetDateTime("end"),
                                CreateDate = reader.GetDateTime("createDate"),
                                CreatedBy = reader.GetString("createdBy"),
                                LastUpdate = reader.GetDateTime("lastUpdate"),
                                LastUpdateBy = reader.GetString("lastUpdateBy")
                            };

                            appointments.Add(appointment);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving appointments: {ex.Message}");
            }


            return appointments;
        }

        public static int GetUserId(string username)
        {
            int userId = -1;
            string query = "SELECT userId FROM user WHERE userName = @username";

            try
            {
                using (var connection = new MySqlConnection(DatabaseConnection.connectionString))
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int id))
                    {
                        userId = id;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving userId: {ex.Message}");
            }

            return userId;
        }

        public static bool IsAppointmentOverlapping(DateTime start, DateTime end, int appointmentId)
        {
            string overlapQuery = "SELECT COUNT(*) FROM appointment " +
                                   "WHERE appointmentId != @AppointmentId AND (@Start < end AND @End > start)";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(DatabaseConnection.connectionString))
                {
                    MySqlCommand overlapCommand = new MySqlCommand(overlapQuery, connection);
                    overlapCommand.Parameters.AddWithValue("@AppointmentId", appointmentId);
                    overlapCommand.Parameters.AddWithValue("@Start", start);
                    overlapCommand.Parameters.AddWithValue("@End", end);

                    connection.Open();

                    int overlapCount = Convert.ToInt32(overlapCommand.ExecuteScalar());
                    return overlapCount > 0; // Return true if overlaps exist
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error checking appointment overlap: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error checking appointment overlap: " + ex.Message);
                return false;
            }
        }

        public static Appointment GetAppointment(int appointmentId)
        {
            Appointment appointment = null;

            string query = "SELECT * FROM appointment WHERE appointmentId = @AppointmentId";

            using (var connection = new MySqlConnection(DatabaseConnection.connectionString))
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@AppointmentId", appointmentId);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        appointment = new Appointment
                        {
                            AppointmentId = reader.GetInt32("appointmentId"),
                            CustomerId = reader.GetInt32("customerId"),
                            UserId = reader.GetInt32("userId"),
                            Type = reader.GetString("type"),
                            Start = reader.GetDateTime("start"),
                            End = reader.GetDateTime("end"),
                            CreateDate = reader.GetDateTime("createDate"),
                            CreatedBy = reader.GetString("createdBy"),
                            LastUpdate = reader.GetDateTime("lastUpdate"),
                            LastUpdateBy = reader.GetString("lastUpdateBy")
                        };
                    }
                }
            }

            return appointment;
        }




        //-----------------------TODO BELOW THIS LINE-------------------------


        public static bool IsWithinBusinessHours(DateTime start, DateTime end)
        {
            TimeZoneInfo est = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            DateTime startEST = TimeZoneInfo.ConvertTimeFromUtc(start.ToUniversalTime(), est);
            DateTime endEST = TimeZoneInfo.ConvertTimeFromUtc(end.ToUniversalTime(), est);

            return startEST.TimeOfDay >= TimeSpan.FromHours(9) &&
                   endEST.TimeOfDay <= TimeSpan.FromHours(17) &&
                   startEST.DayOfWeek >= DayOfWeek.Monday &&
                   startEST.DayOfWeek <= DayOfWeek.Friday;
        }


        public static void UpdateAppointment(Appointment appointment, int appointmentId)
        {
            using (var connection = new MySqlConnection(DatabaseConnection.connectionString))
            {
                connection.Open();

                using (var command = new MySqlCommand(
                    "UPDATE appointment SET " +
                    "customerId = @CustomerId, " +
                    "userId = @UserId, " +
                    "type = @Type, " +
                    "start = @Start, " +
                    "end = @End, " +
                    "lastUpdate = @LastUpdate, " +
                    "lastUpdateBy = @LastUpdateBy " +
                    "WHERE appointmentId = @AppointmentId", connection))
                {
                    command.Parameters.AddWithValue("@AppointmentId", appointmentId);
                    command.Parameters.AddWithValue("@CustomerId", appointment.CustomerId);
                    command.Parameters.AddWithValue("@UserId", appointment.UserId);
                    command.Parameters.AddWithValue("@Type", appointment.Type);
                    command.Parameters.AddWithValue("@Start", appointment.Start);
                    command.Parameters.AddWithValue("@End", appointment.End);
                    command.Parameters.AddWithValue("@LastUpdate", appointment.LastUpdate);
                    command.Parameters.AddWithValue("@LastUpdateBy", appointment.LastUpdateBy);

                    command.ExecuteNonQuery();
                }
            }
        }


        public static void DeleteAppointment(int appointmentId)
        {
            try
            {
                string query = "DELETE FROM appointment WHERE appointmentId = @AppointmentId";

                using (var connection = new MySqlConnection(DatabaseConnection.connectionString))
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AppointmentId", appointmentId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Appointment deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting appointment: {ex.Message}");
            }
        }

        public static BindingList<Appointment> GetAppointmentsByDay(DateTime date)
        {
            var appointments = new BindingList<Appointment>();
            string query = "SELECT * FROM appointment WHERE DATE(start) = @Date";

            using (var connection = new MySqlConnection(DatabaseConnection.connectionString))
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Date", date.Date);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Populate appointments list as in other methods
                    }
                }
            }

            return appointments;
        }


        public static DateTime AdjustForTimeZone(DateTime dateTime, string timeZoneId)
        {
            TimeZoneInfo targetZone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
            return TimeZoneInfo.ConvertTime(dateTime, targetZone);
        }


        public static void CheckUpcomingAppointments(int userId)
        {
            string query = "SELECT * FROM appointment WHERE userId = @UserId AND TIMESTAMPDIFF(MINUTE, NOW(), start) BETWEEN 0 AND 15";

            using (var connection = new MySqlConnection(DatabaseConnection.connectionString))
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@UserId", userId);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        MessageBox.Show("You have an appointment within the next 15 minutes!");
                    }
                }
            }
        }

        public static DateTime convertLocalToEST(DateTime localTime)
        {
            TimeZoneInfo est = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            return TimeZoneInfo.ConvertTimeFromUtc(localTime.ToUniversalTime(), est);
        }


        public enum TimePeriod
        {
            All,
            Week,
            Month,
        }

    }
}
