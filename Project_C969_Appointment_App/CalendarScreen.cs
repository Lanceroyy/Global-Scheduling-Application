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
    public partial class CalendarScreen : Form
    {
        // Create a ComboBox
        private BindingList<Appointment> appointments;

        public CalendarScreen()
        {
            InitializeComponent();

        }


        private void CalendarScreen_Load(object sender, EventArgs e)
        {

            //Format the Date and Time

            // TimeZoneInfo estZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time"); //Get Timezone by ID
            //  DateTime estTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, estZone); //Convert to EST Timezone from UTC


            //Get Value for StartTimeComboBox


            Appointment.GetAppointments(Appointment.TimePeriod.All);
            Utils.simpleAppointmentTimesDVG(appointmentTimesDVG);

            LoadAppointments();

            InitializeCalendar();

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
            appointmentTimesDVG.Rows.Clear();

            // Filter appointments for the selected date
            var dailyAppointments = appointments
                .Where(appt => appt.Start.Date == date.Date)
                .OrderBy(appt => appt.Start)
                .ToList();

            // Populate DataGridView
            if (dailyAppointments.Count > 0)
            {
                foreach (var appointment in dailyAppointments)
                {
                    appointmentTimesDVG.Rows.Add(
                        appointment.Start.ToString("hh:mm tt"),  // Start Time
                        appointment.End.ToString("hh:mm tt"),    // End Time
                        appointment.Type,                        // Appointment Type
                        appointment.CustomerName                 // Customer Name
                    );
                }

                Localization.AdjustToUserTimeZone(this.appointmentTimesDVG);


            }
            else
            {
                // Optionally, show a message row if no appointments exist
                //MessageBox.Show("No appointments for this day.");

                appointmentTimesDVG.Rows.Add("No appointments for this day.");
            }
        }



        private void LoadAppointments()
        {
            appointments = Appointment.GetAppointments(Appointment.TimePeriod.All);
            if (appointments == null)
            {
                appointments = new BindingList<Appointment>();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

