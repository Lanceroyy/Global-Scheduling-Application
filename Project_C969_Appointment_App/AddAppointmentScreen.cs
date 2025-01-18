using Project_C969_Appointment_App.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_C969_Appointment_App
{
    public partial class AddAppointmentScreen : Form
    {
        // Create a ComboBox
        private string toEstStringFormat = "h:mm tt" + " (EST)";
        private BindingList<Appointment> appointments; 

        public AddAppointmentScreen()
        {
            InitializeComponent();

        }


        private void AddAppointmentScreen_Load(object sender, EventArgs e)
        {
            //Format the datagridview
            dvgCustomers.DataSource = Customer.GetCustomers();
            Utils.loadCustomerDataGridView(this.dvgCustomers);
            Utils.simpleCustomerDataGridView(this.dvgCustomers);

            //Format the Date and Time
            Utils.PopulateDateTimeComboBox(startTimeComboBox);
            Utils.PopulateDateTimeComboBox(endTimeComboBox);


            TimeZoneInfo estZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time"); //Get Timezone by ID
            DateTime estTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, estZone); //Convert to EST Timezone from UTC


            //Get Value for StartTimeComboBox

            DateTime startTime = (DateTime)startTimeComboBox.SelectedItem;
            DateTime endTime = (DateTime)endTimeComboBox.SelectedItem;

            DateTime startTimeEST = Appointment.convertLocalToEST(startTime);
            DateTime endTimeEST = Appointment.convertLocalToEST(endTime);

            startESTValue.Text = startTimeEST.ToString(toEstStringFormat);
            endESTValue.Text = endTimeEST.ToString(toEstStringFormat);

            Appointment.GetAppointments(Appointment.TimePeriod.All);
            Utils.simpleAppointmentTimesDVG(appTimesDVG);


            LoadAppointments();
            InitializeCalendar();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchCustomerTextBox_TextChanged(object sender, EventArgs e)
        {
            Utils.SearchCustomerDataGridView(dvgCustomers, searchCustomerTextBox.Text);
        }

        private void dvgCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Grab the selected customer from the datagridview and load it into the form
            Customer customer = (Customer)dvgCustomers.SelectedRows[0].DataBoundItem;

            customerIdLabelValue.Text = customer.CustomerId.ToString();
            customerNameLabelValue.Text = customer.CustomerName;
        }

        private void addAppointmentButton_Click(object sender, EventArgs e)
        {   
            //Return if any fields are empty
            if (Utils.AreAnyTextFieldsEmpty(this)) return;

            //Ensure a customer is selected.
            if (dvgCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer from the list");
                return;
            }


            try
            {           
                //Get user id from SQL database
                int userId = Appointment.GetUserId(Utils.currentUser);

                if (userId == -1)
                {
                    MessageBox.Show("User Id not found.");
                    return;
                }

                //Create our appointment object
                Appointment appointment = new Appointment(
                     Convert.ToInt32(customerIdLabelValue.Text), //customerId
                     userId,           //userId
                     "not needed",     //title
                     "not needed",     //description
                     "not needed",     //location
                     "not needed",     //contact
                     typeTextBox.Text, //type
                     "not needed",     //url
                     Utils.ConvertStringToDateTime(appointmentDatePicker, startTimeComboBox),     //start
                     Utils.ConvertStringToDateTime(appointmentDatePicker, endTimeComboBox),     //end
                     DateTime.UtcNow,     //createDate
                     Utils.currentUser,     //createdBy
                     DateTime.UtcNow,     //lastUpdate
                     Utils.currentUser //lastUpdateBy
                     );

                if (appointment == null)
                {
                    MessageBox.Show("Appointment Object is null.");
                    return;
                }

                if (((DateTime)startTimeComboBox.SelectedItem) >= ((DateTime)endTimeComboBox.SelectedItem))
                {
                    MessageBox.Show("Start Time cannot be greater than or equal to End Time.");
                    return;
                }

                // Check if the appointment overlaps with existing ones
                if (Appointment.IsAppointmentOverlapping(appointment.Start, appointment.End, appointment.AppointmentId))
                {
                    MessageBox.Show("The selected time frame overlaps with an existing appointment. Please choose a different time.");
                    return;
                }

                if (!Appointment.IsWithinBusinessHours(appointment.Start, appointment.End))
                {
                    MessageBox.Show("Appointment must be within business hours (9:00 AM - 5:00 PM EST, Mon–Fri).");
                    return;
                }

                //Add the new appointment
                Appointment.AddAppointment(appointment);

                MainScreen mainScreen = Application.OpenForms.OfType<MainScreen>().FirstOrDefault();
                mainScreen.dvgAppointments.DataSource = Appointment.GetAppointments(Appointment.TimePeriod.All);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

           
        }

        private void appointmentDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //Duration of the appointment
            if (endTimeComboBox.SelectedItem != null && startTimeComboBox.SelectedItem != null)
            {
                elaspedTimeValueLabel.Text = "Duration: " + ((DateTime)endTimeComboBox.SelectedItem - (DateTime)startTimeComboBox.SelectedItem).ToString() + " hours.";

                DateTime startTime = (DateTime)startTimeComboBox.SelectedItem;
                DateTime startTimeEST = Appointment.convertLocalToEST(startTime);
                startESTValue.Text = startTimeEST.ToString(toEstStringFormat);

            }
            
        }

        private void endTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //We can use toString() with the format we want
            string dateTimeString = appointmentDatePicker.Value.ToString("yyyy-MM-dd") + " " + ((DateTime)startTimeComboBox.SelectedItem).ToString("HH:mm:ss");
           
            DateTime dateTime = DateTime.Parse(dateTimeString);

            //Duration of the appointment

            if (endTimeComboBox.SelectedItem != null && startTimeComboBox.SelectedItem != null)
            {
                elaspedTimeValueLabel.Text = "Duration: " + ((DateTime)endTimeComboBox.SelectedItem - (DateTime)startTimeComboBox.SelectedItem).ToString() + " hours.";

                DateTime endTime = (DateTime)endTimeComboBox.SelectedItem;
                DateTime endTimeEST = Appointment.convertLocalToEST(endTime);
                endESTValue.Text = endTimeEST.ToString(toEstStringFormat);

            }
            
        }

        private void InitializeCalendar()
        {
            // Handle date changes
            viewAppointmentsCalendar.DateChanged += CalendarAppointments_DateChanged;

            // Populate appointments for the initial date
            PopulateAppointmentsForDate(viewAppointmentsCalendar.SelectionStart);
        }

        private void CalendarAppointments_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Refresh appointments when the selected date changes
            PopulateAppointmentsForDate(e.Start);
        }

        private void PopulateAppointmentsForDate(DateTime date)
        {
            if (appointments == null || appointments.Count == 0)
            {
                MessageBox.Show("No appointments loaded.");
                return;
            }

            // Clear existing rows
            appTimesDVG.Rows.Clear();

            // Filter appointments for the selected date
            var dailyAppointments = appointments
                .Where(appt => appt.Start.Date == date.Date)
                .OrderBy(appt => appt.Start)
                .ToList();

            // Populate DataGridView
            if (dailyAppointments.Count > 0)
            {
                foreach (var appt in dailyAppointments)
                {
                    appTimesDVG.Rows.Add(
                        appt.Start.ToString("hh:mm tt"),  // Start Time
                        appt.End.ToString("hh:mm tt"),    // End Time
                        appt.Type,                        // Appointment Type
                        appt.CustomerName                 // Customer Name
                    );
                }

                Localization.AdjustToUserTimeZone(appTimesDVG);

            }
            else
            {
                // Optionally, show a message row if no appointments exist
                MessageBox.Show("No appointments for this day.");
            }
        }


        private void LoadAppointments()
        {
            appointments = Appointment.GetAppointments(Appointment.TimePeriod.All);
            if (appointments == null)
            {
                appointments = new BindingList<Appointment>();
            }

            // Adjust appointment times to user's time zone
            Localization.AdjustToUserTimeZone(appTimesDVG);
        }
    }
}

