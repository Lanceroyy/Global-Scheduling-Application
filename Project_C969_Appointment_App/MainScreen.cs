using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Project_C969_Appointment_App.Database;
using Project_C969_Appointment_App.Scripts; //This using line grabs the folder that the scripts are located in

namespace Project_C969_Appointment_App
{
    public partial class MainScreen : Form
    {
        // public static MainScreen? instance;

        public MainScreen()
        {
            InitializeComponent();
            // instance = this;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            dvgCustomers.DataSource = Customer.GetCustomers();
            Utils.loadCustomerDataGridView(this.dvgCustomers);
            Utils.simpleCustomerDataGridView(this.dvgCustomers);

            dvgAppointments.DataSource = Appointment.GetAppointments(Appointment.TimePeriod.All);
            Utils.loadAppointmentDataGridView(this.dvgAppointments);
            Utils.simpleAppointmentDataGridView(this.dvgAppointments);

            var mainScreen = this;
            Localization.AdjustToUserTimeZone(this.dvgAppointments, mainScreen);
        }


        private void MainScreen_FormClosing(object sender, FormClosingEventArgs formClosingEvent)
        {
            // Show confirmation box to exit

            if (formClosingEvent.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit",
                                                  MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Close the form
                    Application.Exit();
                }
                else
                {
                    // Cancel the form closing event
                    formClosingEvent.Cancel = true;
                }
            }

        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            //Open Add Customer Screen
            AddCustomerScreen addCustomerScreen = new AddCustomerScreen();
            addCustomerScreen.Show();
        }

        private void deleteCustomerButton_Click(object sender, EventArgs e)
        {

            if (dvgCustomers.SelectedRows.Count > 0)
            {
                Customer.DeleteCustomer(Convert.ToInt32(dvgCustomers.SelectedRows[0].Cells[0].Value));
            }
            else
            {
                MessageBox.Show("Please select a customer to modify.");
            }


        }

        private void modifyCustomerButton_Click(object sender, EventArgs e)
        {
            if (dvgCustomers.SelectedRows.Count > 0)
            {
                var selectedCustomer = (Customer)dvgCustomers.SelectedRows[0].DataBoundItem;


                var modifyForm = new ModifyCustomerScreen(selectedCustomer);

                //ShowDialog, makes it so the previous form cannot be interacted with until closed
                //No code after ShowDialog will run until the form is closed
                modifyForm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Please select a customer to modify.");
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit",
                                  MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Close the form
                Application.Exit();
            }
            else
            {
                // Cancel the form closing event
                return;
            }
        }

        private void searchCustomerButton_Click(object sender, EventArgs e)
        {
            Utils.SearchCustomerDataGridView(dvgCustomers, searchCustomerTextBox.Text);
        }

        private void searchCustomerTextBox_TextChanged(object sender, EventArgs e)
        {
            Utils.SearchCustomerDataGridView(dvgCustomers, searchCustomerTextBox.Text);
        }

 


        private void testButton_Click(object sender, EventArgs e)
        {
           
            AppointmentAlerts.CheckForUpcomingAppointments(1);

        }


        private void simpleViewButton_Click(object sender, EventArgs e)
        {

            Utils.simpleCustomerDataGridView(dvgCustomers);


        }

        private void detailedViewButton_Click(object sender, EventArgs e)
        {
            Utils.detailedCustomerDataGridViews(dvgCustomers);

        }

        private void detailedAppointmentDataViewButton_Click(object sender, EventArgs e)
        {
            Utils.detailedAppointmentDataGridView(dvgAppointments);

        }

        private void simpleAppointmentDataViewButton_Click(object sender, EventArgs e)
        {
            Utils.simpleAppointmentDataGridView(dvgAppointments);

        }

        private void addAppointmentButton_Click(object sender, EventArgs e)
        {
            //Open Add Customer Screen
            AddAppointmentScreen addAppointmentScreen = new AddAppointmentScreen();
            addAppointmentScreen.Show();
        }

        private void viewAllButton_Click(object sender, EventArgs e)
        {
            Appointment.GetAppointments(Appointment.TimePeriod.All);
            dvgAppointments.DataSource = Appointment.GetAppointments(Appointment.TimePeriod.All);
            Localization.AdjustToUserTimeZone(this.dvgAppointments, this);
        }

        private void viewWeekButton_Click(object sender, EventArgs e)
        {
            Appointment.GetAppointments(Appointment.TimePeriod.Week);
            dvgAppointments.DataSource = Appointment.GetAppointments(Appointment.TimePeriod.Week);
            Localization.AdjustToUserTimeZone(this.dvgAppointments, this);

        }

        private void viewMonthButton_Click(object sender, EventArgs e)
        {
            Appointment.GetAppointments(Appointment.TimePeriod.Month);
            dvgAppointments.DataSource = Appointment.GetAppointments(Appointment.TimePeriod.Month);
            Localization.AdjustToUserTimeZone(this.dvgAppointments, this);

        }

        private void reportsButton_Click(object sender, EventArgs e)
        {
            //Open Add Customer Screen
            ReportsScreen reportsScreen = new ReportsScreen();
            reportsScreen.Show();
        }

        private void deleteAppointmentButton_Click(object sender, EventArgs e)
        {
            if (dvgAppointments.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please select an appointment to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this appointment?", "Delete Appointment", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                return;
            }

            Appointment.DeleteAppointment(Convert.ToInt32(dvgAppointments.SelectedRows[0].Cells[0].Value));

            //Refresh the datagridview
            dvgAppointments.DataSource = Appointment.GetAppointments(Appointment.TimePeriod.All);
        }

        private void modifyAppointmentButton_Click(object sender, EventArgs e)
        {
            if (dvgAppointments.SelectedRows.Count > 0)
            {
                // Retrieve the selected appointment from the DataGridView
                var selectedAppointment = (Appointment)dvgAppointments.SelectedRows[0].DataBoundItem;

                int appointmentId = selectedAppointment.AppointmentId;
                int customerId = selectedAppointment.CustomerId;

                // Pass the selected appointment and appointment ID to the modify form
                var modifyForm = new ModifyAppointmentScreen(selectedAppointment, appointmentId);

                // Show the modify form as a dialog
                modifyForm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Please select a customer to modify.");
            }
        }


        private void calendarButton_Click(object sender, EventArgs e)
        {
            CalendarScreen calendar = new CalendarScreen();
            calendar.Show();
        }

        private void searchAppointmentTextBox_TextChanged(object sender, EventArgs e)
        {
            Utils.SearchCustomerDataGridView(dvgAppointments, searchAppointmentTextBox.Text);
        }
    }
}
