using Project_C969_Appointment_App.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_C969_Appointment_App
{
    public partial class ReportsScreen : Form
    {

        private BindingList<Appointment> appointments;

        public ReportsScreen()
        {
            InitializeComponent();
            LoadAppointments();
        }

        private void LoadAppointments()
        {
            appointments = Appointment.GetAppointments(Appointment.TimePeriod.All);

        }

        private void scheduleForUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                dvgReports.DataSource = null;
                dvgReports.Columns.Clear();

                var userSchedules = Reports.GetUserSchedules(appointments);
                var scheduleData = new List<dynamic>(); // Changed to List<dynamic> instead of BindingList

                foreach (var scheduleObj in userSchedules)
                {
                    dynamic schedule = scheduleObj;
                    foreach (var appointmentObj in schedule.Appointments)
                    {
                        dynamic appointment = appointmentObj;

                        // Create the schedule entry as a standard object
                        scheduleData.Add(new
                        {
                            UserId = schedule.UserId,
                            AppointmentType = appointment.Type,
                            Start = appointment.Start,  // Capital S for Start
                            End = appointment.End       // Capital E for End
                        });
                    }
                }

                // Convert to DataTable which is likely what other forms are using
                DataTable dt = new DataTable();
                dt.Columns.Add("UserId");
                dt.Columns.Add("AppointmentType");
                dt.Columns.Add("start"); // lowercase to match what AdjustUserTimeZone expects
                dt.Columns.Add("end");   // lowercase to match what AdjustUserTimeZone expects

                foreach (var item in scheduleData)
                {
                    dt.Rows.Add(
                        item.UserId,
                        item.AppointmentType,
                        item.Start,
                        item.End
                    );
                }

                dvgReports.DataSource = dt;

                dvgReports.Columns["UserId"].HeaderText = "User ID";
                dvgReports.Columns["AppointmentType"].HeaderText = "Type";
                dvgReports.Columns["start"].HeaderText = "Start";
                dvgReports.Columns["end"].HeaderText = "End";

                Localization.AdjustToUserTimeZone(this.dvgReports, this);
                dvgReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating user schedules: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void typesByMonthButton_Click(object sender, EventArgs e)
        {
            try
            {
                var appointmentTypesByMonth = Reports.GetAppointmentTypesByMonth(appointments);

                // Ensure appointmentTypesByMonth is strongly typed or correctly cast
                var typesList = appointmentTypesByMonth.Select(report =>
                {
                    dynamic reportDyn = report;
                    var monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(reportDyn.Month);
                    return new
                    {
                        Month = monthName,
                        Type = reportDyn.Type,
                        Count = reportDyn.Count
                    };
                }).ToList();

                // Bind the data to the DataGridView
                dvgReports.DataSource = typesList;
                dvgReports.Columns["Month"].HeaderText = "Month";
                dvgReports.Columns["Type"].HeaderText = "Appointment Type";
                dvgReports.Columns["Count"].HeaderText = "Count";

                // Make the DataGridView visible
                dvgReports.Visible = true;

                dvgReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying appointment types by month: " + ex.Message);
            }
        }

        private void customerHoursButton_Click(object sender, EventArgs e)
        {
            try
            {
                var customerHours = Reports.GetTotalHoursByCustomer(appointments);

                // Ensure customerHours is strongly typed or correctly cast
                var hoursList = customerHours.Select(report =>
                {
                    dynamic reportDyn = report;
                    return new
                    {
                        CustomerName = reportDyn.CustomerName,
                        TotalHours = reportDyn.TotalHours
                    };
                }).ToList();

                // Bind the data to the DataGridView
                dvgReports.DataSource = hoursList;
                dvgReports.Columns["CustomerName"].HeaderText = "Customer Name";
                dvgReports.Columns["TotalHours"].HeaderText = "Total Hours";

                // Make the DataGridView visible
                dvgReports.Visible = true;

                dvgReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying customer hours: " + ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
