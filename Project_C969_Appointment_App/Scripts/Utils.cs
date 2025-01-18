using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_C969_Appointment_App.Scripts
{

    public static class Utils   //A Class for Utility Functions used throughout the application
    {

        public static string currentUser;
        public static int currentUserId;

        //If I Have a Public Static Class, make sure the members are also static

        public static bool AreAnyTextFieldsEmpty(Form form)
        {
            bool hasEmptyFields = false; // Track if there are any empty fields

            // Iterate through all controls in the form
            foreach (Control control in form.Controls)
            {
                if (control is TextBox textBox)
                {
                    //Trim Leading and Trailing White Space
                    textBox.Text = textBox.Text.Trim();

                    // Skip specific text boxes that are not required
                    if (textBox.Name == "address2TextBox" || textBox.Name == "searchCustomerTextBox")
                        continue;

                    // Check if the text box is empty
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        hasEmptyFields = true; // Mark that an empty field was found
                        textBox.BackColor = Color.LightPink; // Highlight the empty field (optional)
                    }
                    else
                    {
                        textBox.BackColor = SystemColors.Window; // Reset background color (optional)
                    }


                }
            }

            // Show a message box if there are any empty fields
            if (hasEmptyFields)
            {
                MessageBox.Show("Please fill in the required fields.");
            }

            return hasEmptyFields;
        }


        public static bool IsFieldAnInteger(string input)
        {
            int result;

            // Try parsing the sanitized input
            if (int.TryParse(input, out result))
            {
                return true;
            }
            else
            {
                MessageBox.Show($"Please enter a valid number. '{input}' is not a valid number/integer.");
                return false;
            }
        }


        public static bool isValidPhoneNumber(string phoneNumber)
        {
             int digitCount = phoneNumber.Count(char.IsDigit);

            //Check if the input is a valid phone number
            if (digitCount != 10)
            {
                MessageBox.Show("Please enter a 10 digit phone number. Ex: '123-456-7890'");
                return false;
            }

            if (phoneNumber.Any(character => !char.IsDigit(character) && character != '-'))
            {
                MessageBox.Show("Please enter a valid phone number. Ex: '123-456-7890'");
                return false;
            }

            return true;
        }

        public static bool checkForSelectedRow(DataGridView dataGridView)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
                return false;
            }
        }

        //-----------------------DataGrid Functions-----------------------
        public static void loadCustomerDataGridView(DataGridView customersDataGridView)
        {
            try
            {
                // Get the list of appointments
                var customers = Customer.GetCustomers();

                // Convert to BindingList
                var customerBindingList = new BindingList<Customer>(customers);

                // Create a binding source
                var customerBindingSource = new BindingSource();
                customerBindingSource.DataSource = customerBindingList;

                // Clear existing bindings and set new data source
                customersDataGridView.DataSource = null;
                customersDataGridView.DataSource = customerBindingSource;

                // Format columns

                foreach(DataGridViewColumn column in customersDataGridView.Columns)
                {
                    column.Visible = true;
                    
                }

                customersDataGridView.ClearSelection();
            }   
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading DataGridView: {ex.Message}");
            }

            customersDataGridView.ClearSelection();


        }

        public static void loadAppointmentDataGridView(DataGridView appointmentsDataGridView)
        {

            try
            {
                // Get the list of appointments
                var appointments = Appointment.GetAppointments(Appointment.TimePeriod.All);

 
                var appointmentBindingList = new BindingList<Appointment>(appointments);

                // Create a binding source
                var customerBindingSource = new BindingSource();
                customerBindingSource.DataSource = appointmentBindingList;

                // Clear existing bindings and set new data source
                appointmentsDataGridView.DataSource = null;
                appointmentsDataGridView.DataSource = customerBindingSource;

                // Format columns

                foreach (DataGridViewColumn column in appointmentsDataGridView.Columns)
                {
                    column.Visible = true;

                }

                appointmentsDataGridView.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading DataGridView: {ex.Message}");
            }

            appointmentsDataGridView.ClearSelection();

        }

        public static void simpleCustomerDataGridView(DataGridView customersDataGridView)
        {
            // Customers DataGridView
            customersDataGridView.AutoGenerateColumns = false; // Prevent auto-generating columns

            // Allow column resizing
            customersDataGridView.AllowUserToResizeColumns = true;

            // Disable automatic column resizing so users can resize manually
            customersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // Clear any existing columns
            customersDataGridView.Columns.Clear();

            // Define columns
            customersDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CustomerId",
                HeaderText = "ID",
                Name = "CustomerId",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });

            customersDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CustomerName",
                HeaderText = "Name",
                Name = "CustomerName",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            customersDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PostalCode",
                HeaderText = "Postal Code",
                Name = "PostalCode",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });

            customersDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Phone",
                HeaderText = "Phone Number",
                Name = "Phone",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });

            customersDataGridView.ClearSelection();
        }

        public static void simpleAppointmentDataGridView(DataGridView appointmentsDataGridView)
        {
            // Customers DataGridView
            appointmentsDataGridView.AutoGenerateColumns = false; // Prevent auto-generating columns

            // Allow column resizing
            appointmentsDataGridView.AllowUserToResizeColumns = true;

            // Disable automatic column resizing so users can resize manually
            appointmentsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // Clear any existing columns
            appointmentsDataGridView.Columns.Clear();

            // Define columns
            appointmentsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "AppointmentId",
                HeaderText = "Appoint\nID",
                Name = "AppointmentId",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                
            });

            appointmentsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CustomerName",
                HeaderText = "Name",
                Name = "CustomerName",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            appointmentsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "type",
                HeaderText = "Type",
                Name = "type",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            appointmentsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "start",
                HeaderText = "Start",
                Name = "start",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            appointmentsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "end",
                HeaderText = "End",
                Name = "end",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            appointmentsDataGridView.ClearSelection();

        }

        public static void detailedAppointmentDataGridView(DataGridView appointmentsDataGridView)
        {
            // Customers DataGridView
            appointmentsDataGridView.AutoGenerateColumns = false; // Prevent auto-generating columns

            // Allow column resizing
            appointmentsDataGridView.AllowUserToResizeColumns = true;

            // Disable automatic column resizing so users can resize manually
            appointmentsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // Clear any existing columns
            appointmentsDataGridView.Columns.Clear();

            // Define columns
            appointmentsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "AppointmentId",
                HeaderText = "Appoint-ID",
                Name = "AppointmentId",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });

            appointmentsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CustomerId",
                HeaderText = "Cust-ID",
                Name = "CustomerId",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            appointmentsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CustomerName",
                HeaderText = "Name",
                Name = "CustomerName",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            appointmentsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "userId",
                HeaderText = "User-ID",
                Name = "userId",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            appointmentsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "type",
                HeaderText = "Type",
                Name = "type",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            appointmentsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "start",
                HeaderText = "Start",
                Name = "start",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            appointmentsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "end",
                HeaderText = "End",
                Name = "end",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            appointmentsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "createDate",
                HeaderText = "Created",
                Name = "createDate",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            appointmentsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "lastUpdate",
                HeaderText = "Last Update",
                Name = "lastUpdate",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            appointmentsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "lastUpdateBy",
                HeaderText = "Last Update By",
                Name = "lastUpdateBy",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });


            appointmentsDataGridView.ClearSelection();

        }

        public static void detailedCustomerDataGridViews(DataGridView customersDataGridView)
        {
            // Customers DataGridView
            customersDataGridView.AutoGenerateColumns = false; // Prevent auto-generating columns

            // Allow column resizing
            customersDataGridView.AllowUserToResizeColumns = true;
            

            // Set all desired columns for detailed view
            customersDataGridView.Columns.Clear();


            customersDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CustomerId",
                HeaderText = "ID",
                Name = "CustomerId",
            });

            customersDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CustomerName",
                HeaderText = "Name",
                Name = "CustomerName",
            });

            customersDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "AddressId",
                HeaderText = "Address ID",
                Name = "AddressId",
                
            });

            customersDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Address",
                HeaderText = "Address",
                Name = "Address",
            });

            customersDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Address2",
                HeaderText = "Address 2",
                Name = "Address2",
            });

            customersDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PostalCode",
                HeaderText = "Postal Code",
                Name = "PostalCode",
            });

            customersDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "City",
                HeaderText = "City",
                Name = "City",
            });

            customersDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Country",
                HeaderText = "Country",
                Name = "Country",
            });

            customersDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Phone",
                HeaderText = "Phone Number",
                Name = "Phone",
            });

            customersDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Active",
                HeaderText = "Active",
                Name = "Active",
            });

            customersDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CreateDate",
                HeaderText = "Create Date",
                Name = "CreateDate",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "g" } // Format as General date/time
            });

            customersDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CreatedBy",
                HeaderText = "Created By",
                Name = "CreatedBy",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "g" } // Format as General date/time
            });

            customersDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "LastUpdate",
                HeaderText = "Last Update",
                Name = "LastUpdate",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "g" } // Format as General date/time
            });

            customersDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "LastUpdateBy",
                HeaderText = "Last Updated By",
                Name = "LastUpdateBy",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "g" } // Format as General date/time
            });

            // Allows full manual resizing
            customersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            customersDataGridView.ClearSelection();

        }

        public static void simpleAppointmentTimesDVG(DataGridView appointmentsDataGridView)
        {
            // Customers DataGridView
            appointmentsDataGridView.AutoGenerateColumns = false; // Prevent auto-generating columns

            // Allow column resizing
            appointmentsDataGridView.AllowUserToResizeColumns = true;

            // Disable automatic column resizing so users can resize manually
            appointmentsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // Clear any existing columns
            appointmentsDataGridView.Columns.Clear();

            // Define columns

            appointmentsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "start",
                HeaderText = "Start",
                Name = "start",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            appointmentsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "end",
                HeaderText = "End",
                Name = "end",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            appointmentsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "type",
                HeaderText = "Type",
                Name = "type",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
   

            appointmentsDataGridView.ClearSelection();

        }

        public static void SearchCustomerDataGridView(DataGridView customerDataGridView, string searchText)
        {
            try
            {
                var customers = Customer.GetCustomers(searchText);
                customerDataGridView.DataSource = new BindingList<Customer>(customers);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching appointments: " + ex.Message);
            }
        }

        public static void SearchAppointmentDataGridView(DataGridView appointmentsDataGridView, string searchText)
        {
            try
            {
                if (string.IsNullOrEmpty(searchText))
                {
                    // Show all rows if search text is empty
                    var appointments = Appointment.GetAppointments(Appointment.TimePeriod.All); //TODO -- Replace with real customer ID or Change Method
                    appointmentsDataGridView.DataSource = new BindingList<Appointment>(appointments);
                    return;
                }

                // Get the current data source and handle both List<T> and BindingList<T>
                IEnumerable<Appointment> currentAppointments;
                if (appointmentsDataGridView.DataSource is List<Appointment> appointmentsList)
                {
                    currentAppointments = appointmentsList;
                }
                else if (appointmentsDataGridView.DataSource is BindingList<Appointment> appointmentsBindingList)
                {
                    currentAppointments = appointmentsBindingList.ToList();
                }
                else
                {
                    throw new InvalidOperationException("Unexpected data source type");
                }

                // Filter the appointments
                var filteredAppointments = currentAppointments
                    .Where(a => a.Title.ToLower()
                        .Contains(searchText.ToLower()))
                    .ToList();

                // Create new BindingList with filtered results
                appointmentsDataGridView.DataSource = new BindingList<Appointment>(filteredAppointments);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching appointments: " + ex.Message);
            }
        }

    

//----------------------------------DateTime Methods----------------------------------------------

        public static void formatDateTimePickers(DateTimePicker datePicker)
        {
            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.CustomFormat = "MM/dd/yyyy";

            DateTime myDate = datePicker.Value.Date;

            //Get only the date part
            myDate = myDate.Date;
        }

        public static void PopulateDateTimeComboBox(ComboBox timeComboBox)
        {
            // Initialize the ComboBox
            timeComboBox.DropDownStyle = ComboBoxStyle.DropDownList; // Optional: restrict to only listed values
            timeComboBox.Width = 150;
           // Controls.Add(timeComboBox);

            // Define the start and end times
            DateTime startTime = DateTime.Today.AddHours(8); // 8 AM
            DateTime endTime = DateTime.Today.AddHours(20); // 8 PM

            // Generate a list of DateTime values with 30-minute intervals
            List<DateTime> dateTimeValues = new List<DateTime>();
            DateTime currentTime = startTime;

            while (currentTime <= endTime)
            {
                dateTimeValues.Add(currentTime);
                currentTime = currentTime.AddMinutes(30);
            }

            // Populate the ComboBox with the formatted DateTime values
            timeComboBox.DataSource = dateTimeValues;
            timeComboBox.DisplayMember = "TimeOfDay"; // Display the time part only

        }

        public static void PopulateDateTimeComboBoxTEST2(ComboBox timeComboBox)
        {
            // Initialize the ComboBox
            timeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            timeComboBox.AutoSize = true;

            // Define EST business hours (9 AM - 5 PM EST)
            // Specify DateTimeKind.Unspecified to avoid conversion issues
            DateTime estStartTime = DateTime.SpecifyKind(
                DateTime.Today.AddHours(9),
                DateTimeKind.Unspecified
            ); // 9 AM EST

            DateTime estEndTime = DateTime.SpecifyKind(
                DateTime.Today.AddHours(17),
                DateTimeKind.Unspecified
            );  // 5 PM EST

            // Get timezone info
            TimeZoneInfo estZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            TimeZoneInfo localZone = TimeZoneInfo.Local;

            // Convert EST times to local time
            DateTime localStartTime = TimeZoneInfo.ConvertTime(
                TimeZoneInfo.ConvertTimeToUtc(estStartTime, estZone),
                localZone
            );

            DateTime localEndTime = TimeZoneInfo.ConvertTime(
                TimeZoneInfo.ConvertTimeToUtc(estEndTime, estZone),
                localZone
            );

            // Generate a list of DateTime values with 30-minute intervals in local time
            List<DateTime> dateTimeValues = new List<DateTime>();
            DateTime currentTime = localStartTime;

            while (currentTime <= localEndTime)
            {
                dateTimeValues.Add(currentTime);
                currentTime = currentTime.AddMinutes(30);
            }

            // Populate the ComboBox with the formatted DateTime values
            timeComboBox.DataSource = dateTimeValues;
            timeComboBox.DisplayMember = "TimeOfDay"; // Display the time part only

            // Optional: Add tooltip to show EST time
            timeComboBox.Format += (s, e) =>
            {
                if (e.ListItem != null)
                {
                    DateTime localTime = (DateTime)e.ListItem;
                    DateTime estTime = TimeZoneInfo.ConvertTime(localTime, localZone, estZone);
                    e.Value = $"{localTime.ToString("HH:mm")} ({estTime.ToString("HH:mm")} EST)";
                }
            };
        }

        public static void PopulateDateTimeComboBoxTEST(ComboBox timeComboBox)
        {
            // Initialize the ComboBox
            timeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            // Define business hours in EST
            TimeZoneInfo estTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            DateTime estStartTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 9, 0, 0); // 9:00 AM EST
            DateTime estEndTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 17, 0, 0); // 5:00 PM EST

            // Convert EST times to the local time zone
            DateTime localStartTime = TimeZoneInfo.ConvertTime(estStartTime, estTimeZone, TimeZoneInfo.Local);
            DateTime localEndTime = TimeZoneInfo.ConvertTime(estEndTime, estTimeZone, TimeZoneInfo.Local);

            // Generate a list of 30-minute intervals
            List<DateTime> dateTimeValues = new List<DateTime>();
            DateTime currentTime = localStartTime;

            while (currentTime < localEndTime)
            {
                dateTimeValues.Add(currentTime);
                currentTime = currentTime.AddMinutes(30);
            }

            // Bind the ComboBox to the list of times
            timeComboBox.DataSource = dateTimeValues;
            timeComboBox.DisplayMember = "HH:mm tt"; // Display time in 12-hour format
        }




        public static string convertDateTimetoString(DateTimePicker datePicker, ComboBox timeComboBox, Label timeLabelValue)
        {
            //We can use toString() with the format we want
            string dateTimeString = datePicker.Value.ToString("yyyy-MM-dd") + " " + ((DateTime)timeComboBox.SelectedItem).ToString("HH:mm:ss");

            timeLabelValue.Text = dateTimeString;

            return dateTimeString;
        }

        public static DateTime ConvertStringToDateTime(DateTimePicker datePicker, ComboBox timeComboBox)
        {
            try
            {
                // Combine date and time into a single string
                string dateTimeString = datePicker.Value.ToString("yyyy-MM-dd") + " " + ((DateTime)timeComboBox.SelectedItem).ToString("HH:mm:ss");

                // Parse the string into a DateTime object
                DateTime localDateTime = DateTime.Parse(dateTimeString);

                // Convert local time to UTC
                DateTime utcDateTime = TimeZoneInfo.ConvertTimeToUtc(localDateTime);

                return utcDateTime;
            }
            catch (Exception ex)
            {
                throw new Exception("Error converting date and time: " + ex.Message);
            }
        }
    }



    //NOTE TO SELF --

    //INTERFACES: These are like abstract classes, but they are used to define a contract for a class.
    //For example, interfaces are more for functionality than for data. (EX: methods, events etc.)

    //ABSTRACT CLASS: These are like interfaces, but are used more for defining data.
    //For example, defining constructs, and properties.

    interface FormsInterface
    {
        private bool AreAnyTextFieldsEmpty(Form form)
        {
            // Get all text boxes on the form
            foreach (Control control in form.Controls)
            {
                if (control is TextBox textBox)
                {
                    // Check if the text box is empty
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        return true; // Return true if any text box is empty
                    }
                }
            }
            return false; // Return false if no text boxes are empty
        }
    }
}
