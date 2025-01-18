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

namespace Project_C969_Appointment_App
{
    public partial class AddCustomerScreen : Form
    {
        public AddCustomerScreen()
        {
            InitializeComponent();
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        { 

            
            if(Utils.AreAnyTextFieldsEmpty(this)) return;

            if(!Utils.IsFieldAnInteger(postalCodeTextBox.Text)) return;
            if(!Utils.isValidPhoneNumber(phoneTextBox.Text)) return;
            

            try
            {
                MainScreen mainScreen = Application.OpenForms.OfType<MainScreen>().FirstOrDefault();

                if (mainScreen == null)
                {
                    MessageBox.Show("MainScreen form not found.");
                    
                }

                // Gather customer details
                var customerName = nameTextBox.Text;

                // Gather address details from the form
                var address = addressTextBox.Text;
                var address2 = address2TextBox.Text;

                //If address2 is empty, set it to N/A
                if (string.IsNullOrEmpty(address2TextBox.Text)) address2 = "N/A";
                
                var postalCode = postalCodeTextBox.Text;
                var phone = phoneTextBox.Text;
                
                //Currently logged in user
                var createdBy = Utils.currentUser ;

                //We have to insert country > city > address > customer based on the foreign key constraints
                int cityId = Customer.AddCityandCountry(cityTextBox.Text, countryTextBox.Text);

                // Insert the address and retrieve its ID
                //NOTE: WE HAVE TO MAKE SURE TO INSERT and ADDRESS BEFORE INSERTING CUSTOMER BECAUSE THERE IS A FOREIGN KEY CONSTRAINT on ADDRESS ID
                var addressId = Customer.AddAddress(address, address2, cityId, postalCode, phone, createdBy);

                var newCustomer = new Customer(customerName, addressId, true, createdBy);
                Customer.AddCustomer(newCustomer);

                MessageBox.Show("Customer and address added successfully!");

                Utils.loadCustomerDataGridView(mainScreen.dvgCustomers);

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding customer: {ex.Message}");
            }

        }



        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
