using Project_C969_Appointment_App.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_C969_Appointment_App
{
    public partial class ModifyCustomerScreen : Form
    {
        private Customer _customer;

        public ModifyCustomerScreen(Customer customer)
        {
            InitializeComponent();
            _customer = customer;

            PopulateFields();
        }

        private void PopulateFields()
        {

            

            customerId.Text = _customer.CustomerId.ToString();
            nameTextBox.Text = _customer.CustomerName;
            addressTextBox.Text = _customer.Address;
            address2TextBox.Text = _customer.Address2;
            postalCodeTextBox.Text = _customer.PostalCode;
            phoneTextBox.Text = _customer.Phone;
            cityTextBox.Text = _customer.City;
            countryTextBox.Text = _customer.Country;

            if (_customer.Active)
            {
                activeCheckBox.Checked = true;
            }
            else
            {
                activeCheckBox.Checked = false;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateCustomerButton_Click(object sender, EventArgs e)
        {
            if (Utils.AreAnyTextFieldsEmpty(this)) return;
            if (!Utils.IsFieldAnInteger(postalCodeTextBox.Text)) return;
            if (!Utils.isValidPhoneNumber(phoneTextBox.Text)) return;

            try
            {
                Customer.UpdateCustomer(
                    customerId: _customer.CustomerId,
                    customerName: nameTextBox.Text,
                    address: addressTextBox.Text,
                    address2: address2TextBox.Text,
                    cityName: cityTextBox.Text,
                    countryName: countryTextBox.Text,
                    postalCode: postalCodeTextBox.Text,
                    phone: phoneTextBox.Text,
                    active: activeCheckBox.Checked,
                    lastUpdateBy: Utils.currentUser
                );

                MessageBox.Show("Customer updated successfully!");

                MainScreen mainScreen = Application.OpenForms.OfType<MainScreen>().FirstOrDefault();
                if (mainScreen != null)
                {
                    Utils.loadCustomerDataGridView(mainScreen.dvgCustomers);
                    Utils.loadAppointmentDataGridView(mainScreen.dvgAppointments);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating customer: {ex.Message}");
            }
        }
    }
}
