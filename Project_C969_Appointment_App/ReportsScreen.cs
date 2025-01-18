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
                // Clear the DataGridView
                dvgReports.DataSource = null;
                dvgReports.Columns.Clear();

                // Fetch the user schedules
                var userSchedules = Reports.GetUserSchedules(appointments);

                // Prepare a binding list for data
                var scheduleData = new BindingList<dynamic>();

                // Process each user schedule
                foreach (var scheduleObj in userSchedules)
                {
                    dynamic schedule = scheduleObj;

                    foreach (var appointmentObj in schedule.Appointments)
                    {
                        dynamic appointment = appointmentObj;

                        // Add each appointment to the binding list
                        scheduleData.Add(new
                        {
                            UserId = schedule.UserId,
                            AppointmentType = appointment.Type,
                            StartTime = appointment.Start,
                            EndTime = appointment.End
                        });
                    }
                }

                // Bind the data to the DataGridView
                dvgReports.DataSource = scheduleData;

                // Optional: Adjust column headers
                dvgReports.Columns["UserId"].HeaderText = "User ID";
                dvgReports.Columns["AppointmentType"].HeaderText = "Type";
                dvgReports.Columns["StartTime"].HeaderText = "Start Time";
                dvgReports.Columns["EndTime"].HeaderText = "End Time";

                dvgReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                // Handle errors gracefully
                MessageBox.Show($"Error generating user schedules: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
