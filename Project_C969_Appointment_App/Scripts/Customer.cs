using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_C969_Appointment_App.Database;
using MySqlX.XDevAPI.Common;

namespace Project_C969_Appointment_App.Scripts
{
    public class Customer
    {
   

        // Properties
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int AddressId { get; set; }
        public bool Active { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }


        // Additional properties for related fields
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }

        //TODO -- we may not use this list due to using the SQL database instead.
        public BindingList<Appointment> Appointments { get; set; } = new BindingList<Appointment>(); // List of appointments>


        // Constructor
        //TODO -- We may get rid of some of the properties. We might not have to use things like createDate, createdBy, lastUpdate, lastUpdateBy
        public Customer(int customerId, string customerName, int addressId, bool active, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            CustomerId = customerId;
            CustomerName = customerName;
            AddressId = addressId;
            Active = active;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdateBy = lastUpdateBy;
        }

        // Parameterless constructor
        public Customer()
        {
        }

        // Overloaded Constructor (for adding new customers without specifying ID and timestamps)
        public Customer(string customerName, int addressId, bool active, string createdBy)
        {
            CustomerName = customerName;
            AddressId = addressId;
            Active = active;
            CreateDate = DateTime.Now;
            CreatedBy = createdBy;
            LastUpdate = DateTime.Now;
            LastUpdateBy = createdBy;
        }

        public static void AddCustomer(Customer customer, bool autoGenerateCustomerId = false)
        {
            using (var connection = new MySqlConnection(DatabaseConnection.connectionString))
            {
                connection.Open();

                int customerId = customer.CustomerId;

                if (autoGenerateCustomerId)
                {
                    // Fetch the current maximum customerId and increment it
                    using (var command = new MySqlCommand("SELECT MAX(customerId) FROM customer", connection))
                    {
                        var maxId = command.ExecuteScalar() as int? ?? 0;
                        customerId = maxId + 1;
                    }
                }

                // Insert the new customer
                string query = "INSERT INTO customer (customerId, customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                               "VALUES (@CustomerId, @CustomerName, @AddressId, @Active, @CreateDate, @CreatedBy, @LastUpdate, @LastUpdateBy)";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerId", customerId);
                    command.Parameters.AddWithValue("@CustomerName", customer.CustomerName);
                    command.Parameters.AddWithValue("@AddressId", customer.AddressId);
                    command.Parameters.AddWithValue("@Active", customer.Active);
                    command.Parameters.AddWithValue("@CreateDate", customer.CreateDate);
                    command.Parameters.AddWithValue("@CreatedBy", customer.CreatedBy);
                    command.Parameters.AddWithValue("@LastUpdate", customer.LastUpdate);
                    command.Parameters.AddWithValue("@LastUpdateBy", customer.LastUpdateBy);

                    command.ExecuteNonQuery();
                }
            }
        }


        public static void UpdateCustomer(int customerId, string customerName, string address, string address2,
            string cityName, string countryName, string postalCode, string phone, bool active, string lastUpdateBy)
        {
            using (var connection = new MySqlConnection(DatabaseConnection.connectionString))
            {
                try
                {
                    connection.Open();
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Get current customer's addressId
                            int currentAddressId;
                            using (var command = new MySqlCommand(
                                "SELECT addressId FROM customer WHERE customerId = @CustomerId", connection, transaction))
                            {
                                command.Parameters.AddWithValue("@CustomerId", customerId);
                                currentAddressId = Convert.ToInt32(command.ExecuteScalar());
                            }

                            // Get current address's cityId
                            int currentCityId;
                            using (var command = new MySqlCommand(
                                "SELECT cityId FROM address WHERE addressId = @AddressId", connection, transaction))
                            {
                                command.Parameters.AddWithValue("@AddressId", currentAddressId);
                                currentCityId = Convert.ToInt32(command.ExecuteScalar());
                            }

                            // Update or insert country and get countryId
                            int countryId;
                            using (var command = new MySqlCommand(
                                "SELECT countryId FROM country WHERE country = @CountryName", connection, transaction))
                            {
                                command.Parameters.AddWithValue("@CountryName", countryName);
                                var result = command.ExecuteScalar();

                                if (result == null)
                                {
                                    // Insert new country
                                    using (var insertCmd = new MySqlCommand(
                                        "INSERT INTO country (country, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                                        "VALUES (@CountryName, @CreateDate, @CreatedBy, @LastUpdate, @LastUpdateBy); " +
                                        "SELECT LAST_INSERT_ID();", connection, transaction))
                                    {
                                        insertCmd.Parameters.AddWithValue("@CountryName", countryName);
                                        insertCmd.Parameters.AddWithValue("@CreateDate", DateTime.Now);
                                        insertCmd.Parameters.AddWithValue("@CreatedBy", lastUpdateBy);
                                        insertCmd.Parameters.AddWithValue("@LastUpdate", DateTime.Now);
                                        insertCmd.Parameters.AddWithValue("@LastUpdateBy", lastUpdateBy);
                                        countryId = Convert.ToInt32(insertCmd.ExecuteScalar());
                                    }
                                }
                                else
                                {
                                    countryId = Convert.ToInt32(result);
                                }
                            }

                            // Update or insert city
                            using (var command = new MySqlCommand(
                                "UPDATE city SET city = @CityName, countryId = @CountryId, lastUpdate = @LastUpdate, " +
                                "lastUpdateBy = @LastUpdateBy WHERE cityId = @CityId", connection, transaction))
                            {
                                command.Parameters.AddWithValue("@CityName", cityName);
                                command.Parameters.AddWithValue("@CountryId", countryId);
                                command.Parameters.AddWithValue("@CityId", currentCityId);
                                command.Parameters.AddWithValue("@LastUpdate", DateTime.Now);
                                command.Parameters.AddWithValue("@LastUpdateBy", lastUpdateBy);

                                if (command.ExecuteNonQuery() == 0)
                                {
                                    // City doesn't exist, insert new one
                                    using (var insertCmd = new MySqlCommand(
                                        "INSERT INTO city (city, countryId, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                                        "VALUES (@CityName, @CountryId, @CreateDate, @CreatedBy, @LastUpdate, @LastUpdateBy)",
                                        connection, transaction))
                                    {
                                        insertCmd.Parameters.AddWithValue("@CityName", cityName);
                                        insertCmd.Parameters.AddWithValue("@CountryId", countryId);
                                        insertCmd.Parameters.AddWithValue("@CreateDate", DateTime.Now);
                                        insertCmd.Parameters.AddWithValue("@CreatedBy", lastUpdateBy);
                                        insertCmd.Parameters.AddWithValue("@LastUpdate", DateTime.Now);
                                        insertCmd.Parameters.AddWithValue("@LastUpdateBy", lastUpdateBy);
                                        insertCmd.ExecuteNonQuery();
                                    }
                                }
                            }

                            // Update address
                            using (var command = new MySqlCommand(
                                "UPDATE address SET address = @Address, address2 = @Address2, postalCode = @PostalCode, " +
                                "phone = @Phone, lastUpdate = @LastUpdate, lastUpdateBy = @LastUpdateBy " +
                                "WHERE addressId = @AddressId", connection, transaction))
                            {
                                command.Parameters.AddWithValue("@AddressId", currentAddressId);
                                command.Parameters.AddWithValue("@Address", address);
                                command.Parameters.AddWithValue("@Address2", string.IsNullOrEmpty(address2) ? "N/A" : address2);
                                command.Parameters.AddWithValue("@PostalCode", postalCode);
                                command.Parameters.AddWithValue("@Phone", phone);
                                command.Parameters.AddWithValue("@LastUpdate", DateTime.Now);
                                command.Parameters.AddWithValue("@LastUpdateBy", lastUpdateBy);
                                command.ExecuteNonQuery();
                            }

                            // Update customer
                            using (var command = new MySqlCommand(
                                "UPDATE customer SET customerName = @CustomerName, active = @Active, " +
                                "lastUpdate = @LastUpdate, lastUpdateBy = @LastUpdateBy " +
                                "WHERE customerId = @CustomerId", connection, transaction))
                            {
                                command.Parameters.AddWithValue("@CustomerId", customerId);
                                command.Parameters.AddWithValue("@CustomerName", customerName);
                                command.Parameters.AddWithValue("@Active", active);
                                command.Parameters.AddWithValue("@LastUpdate", DateTime.Now);
                                command.Parameters.AddWithValue("@LastUpdateBy", lastUpdateBy);
                                command.ExecuteNonQuery();
                            }

                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            throw new Exception($"Error updating customer data: {ex.Message}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error connecting to database: {ex.Message}");
                }
            }
        }

        public static void UpdateCustomers(Customer customer, string address, string address2, string postalCode, string phone, string cityName, string countryName)
        {
            try
            {
                using (var connection = new MySqlConnection(DatabaseConnection.connectionString))
                {
                    connection.Open();

                    // Step 1: Update or insert city and country, then retrieve the city ID
                    int cityId = AddCityandCountry(cityName, countryName);

                    // Step 2: Update the address
                    string updateAddressQuery = @"
                        UPDATE address
                        SET address = @Address, address2 = @Address2, cityId = @CityId, postalCode = @PostalCode, phone = @Phone,
                            lastUpdate = @LastUpdate, lastUpdateBy = @LastUpdateBy
                        WHERE addressId = @AddressId";

                    using (var addressCommand = new MySqlCommand(updateAddressQuery, connection))
                    {
                        addressCommand.Parameters.AddWithValue("@Address", address);
                        addressCommand.Parameters.AddWithValue("@Address2", address2 ?? "N/A");
                        addressCommand.Parameters.AddWithValue("@CityId", cityId);
                        addressCommand.Parameters.AddWithValue("@PostalCode", postalCode);
                        addressCommand.Parameters.AddWithValue("@Phone", phone);
                        addressCommand.Parameters.AddWithValue("@LastUpdate", DateTime.Now);
                        addressCommand.Parameters.AddWithValue("@LastUpdateBy", Utils.currentUser);
                        addressCommand.Parameters.AddWithValue("@AddressId", customer.AddressId);

                        addressCommand.ExecuteNonQuery();
                    }

                    // Step 3: Update the customer
                    string updateCustomerQuery = @"
                        UPDATE customer
                        SET customerName = @CustomerName, active = @Active, 
                            lastUpdate = @LastUpdate, lastUpdateBy = @LastUpdateBy
                        WHERE customerId = @CustomerId";

                    using (var customerCommand = new MySqlCommand(updateCustomerQuery, connection))
                    {
                        customerCommand.Parameters.AddWithValue("@CustomerId", customer.CustomerId);
                        customerCommand.Parameters.AddWithValue("@CustomerName", customer.CustomerName);
                        customerCommand.Parameters.AddWithValue("@Active", customer.Active);
                        customerCommand.Parameters.AddWithValue("@LastUpdate", DateTime.Now);
                        customerCommand.Parameters.AddWithValue("@LastUpdateBy", Utils.currentUser);

                        customerCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("Customer details updated successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating customer: {ex.Message}");
            }
        }



        public static void DeleteCustomer(int customerId)
        {
                 //Grab the open main screen
            MainScreen mainScreen = Application.OpenForms.OfType<MainScreen>().FirstOrDefault();
            if (mainScreen == null)
            {
                MessageBox.Show("Cannot find the main form. MainScreen is null.");
                return;
            }

            //If no row is selected show message
            if (!mainScreen.dvgCustomers.CurrentRow.Selected)
            {
                MessageBox.Show("Please select a customer to delete.");
                return;
            }

            var confirmationRestult = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            if (confirmationRestult == DialogResult.No)
            {
                return;
            }

            if (confirmationRestult == DialogResult.Yes)
            {

                try
                {
                    string query = "DELETE FROM customer WHERE customerId = @CustomerId";

                    using (var connection = new MySqlConnection(DatabaseConnection.connectionString))
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerId", customerId);

                        connection.Open();
                        command.ExecuteNonQuery();

                        Utils.loadCustomerDataGridView(mainScreen.dvgCustomers);
                        
                        MessageBox.Show("Customer deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex) 
                { 
                    

                    if (ex.Message.Contains("Cannot delete or update a parent row"))
                    {
                        MessageBox.Show("Error deleting customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show("This error most likely occured because the customer has appointments. If so, please delete appointments associated with Customer then try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Error deleting customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
           

        }


        public static BindingList<Customer> GetCustomers(string filter = null)
        {
            var customers = new BindingList<Customer>();

            string query = "SELECT c.*, a.address, a.address2, a.postalCode, a.phone, " +
                           "ci.city, co.country " +
                           "FROM customer c " +
                           "LEFT JOIN address a ON c.addressId = a.addressId " +
                           "LEFT JOIN city ci ON a.cityId = ci.cityId " +
                           "LEFT JOIN country co ON ci.countryId = co.countryId";

            if (!string.IsNullOrEmpty(filter))
            {
                query += $" WHERE customerName LIKE @filter";
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
                            var customer = new Customer
                            {
                                CustomerId = reader.GetInt32("customerId"),
                                CustomerName = reader.GetString("customerName"),
                                AddressId = reader.GetInt32("addressId"),
                                Active = reader.GetBoolean("active"),
                                CreateDate = reader.GetDateTime("createDate"),
                                CreatedBy = reader.GetString("createdBy"),
                                LastUpdate = reader.GetDateTime("lastUpdate"),
                                LastUpdateBy = reader.GetString("lastUpdateBy"),
                                Address = reader.GetString("address"),
                                Address2 = reader.GetString("address2"),
                                PostalCode = reader.GetString("postalCode"),
                                Phone = reader.GetString("phone"),
                                City = reader.GetString("city"),
                                Country = reader.GetString("country")
                            };

                            customers.Add(customer);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving customers: {ex.Message}");
            }

            return customers;
        }

        // Optional: Add a method to get a single customer by ID
        public static Customer GetCustomerById(int customerId)
        {
            string query = "SELECT c.*, a.address, a.address2, a.postalCode, a.phone, " +
                          "ci.city, co.country " +
                          "FROM customer c " +
                          "LEFT JOIN address a ON c.addressId = a.addressId " +
                          "LEFT JOIN city ci ON a.cityId = ci.cityId " +
                          "LEFT JOIN country co ON ci.countryId = co.countryId " +
                          "WHERE c.customerId = @customerId";

            try
            {
                using (var connection = new MySqlConnection(DatabaseConnection.connectionString))
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@customerId", customerId);

                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Customer(
                                reader.GetInt32("customerId"),
                                reader.GetString("customerName"),
                                reader.GetInt32("addressId"),
                                reader.GetBoolean("active"),
                                reader.GetDateTime("createDate"),
                                reader.GetString("createdBy"),
                                reader.GetDateTime("lastUpdate"),
                                reader.GetString("lastUpdateBy")
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving customer: {ex.Message}");
            }

            return null;
        }

        //----------Address Functions----------

        public static int AddAddress(string address, string address2, int cityId, string postalCode, string phone, string createdBy)
        {
            string query = "INSERT INTO address (address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                           "VALUES (@Address, @Address2, @CityId, @PostalCode, @Phone, @CreateDate, @CreatedBy, @LastUpdate, @LastUpdateBy); " +
                           "SELECT LAST_INSERT_ID();";

            using (var connection = new MySqlConnection(DatabaseConnection.connectionString))
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@Address2", address2);
                command.Parameters.AddWithValue("@CityId", cityId);
                command.Parameters.AddWithValue("@PostalCode", postalCode);
                command.Parameters.AddWithValue("@Phone", phone);
                command.Parameters.AddWithValue("@CreateDate", DateTime.Now);
                command.Parameters.AddWithValue("@CreatedBy", createdBy);
                command.Parameters.AddWithValue("@LastUpdate", DateTime.Now);
                command.Parameters.AddWithValue("@LastUpdateBy", createdBy);

                connection.Open();
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        public static void UpdateAddress(int addressId, string address, string address2, int cityId, string postalCode, string phone, string lastUpdateBy)
        {
            string query = "UPDATE address " +
                           "SET address = @Address, address2 = @Address2, cityId = @CityId, postalCode = @PostalCode, phone = @Phone, " +
                           "lastUpdate = @LastUpdate, lastUpdateBy = @LastUpdateBy " +
                           "WHERE addressId = @AddressId";

            using (var connection = new MySqlConnection(DatabaseConnection.connectionString))
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@AddressId", addressId);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@Address2", address2);
                command.Parameters.AddWithValue("@CityId", cityId);
                command.Parameters.AddWithValue("@PostalCode", postalCode);
                command.Parameters.AddWithValue("@Phone", phone);
                command.Parameters.AddWithValue("@LastUpdate", DateTime.Now);
                command.Parameters.AddWithValue("@LastUpdateBy", lastUpdateBy);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }


        public static int AddCityandCountry(string cityName, string countryName)
        {
            int cityId;
            int countryId;

            try
            {
                using (var connection = new MySqlConnection(DatabaseConnection.connectionString))
                {
                    connection.Open();

                    // Check if the city exists
                    string cityQuery = "SELECT cityId FROM city WHERE city = @CityName LIMIT 1";
                    using (var cityCommand = new MySqlCommand(cityQuery, connection))
                    {
                        cityCommand.Parameters.AddWithValue("@CityName", cityName);
                        var result = cityCommand.ExecuteScalar();
                        if (result != null)
                        {
                            return Convert.ToInt32(result); // City exists, return its ID
                        }
                    }

                    // Check if the country exists
                    string countryQuery = "SELECT countryId FROM country WHERE country = @CountryName LIMIT 1";
                    using (var countryCommand = new MySqlCommand(countryQuery, connection))
                    {
                        countryCommand.Parameters.AddWithValue("@CountryName", countryName);
                        var result = countryCommand.ExecuteScalar();
                        countryId = result != null ? Convert.ToInt32(result) : -1;
                    }

                    // If the country doesn't exist, insert it
                    if (countryId == -1)
                    {
                        string insertCountryQuery = "INSERT INTO country (country, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                                                    "VALUES (@CountryName, @CreateDate, @CreatedBy, @LastUpdate, @LastUpdateBy); SELECT LAST_INSERT_ID();";
                        using (var insertCountryCommand = new MySqlCommand(insertCountryQuery, connection))
                        {
                            insertCountryCommand.Parameters.AddWithValue("@CountryName", countryName);
                            insertCountryCommand.Parameters.AddWithValue("@CreateDate", DateTime.Now);
                            insertCountryCommand.Parameters.AddWithValue("@CreatedBy", Utils.currentUser);
                            insertCountryCommand.Parameters.AddWithValue("@LastUpdate", DateTime.Now);
                            insertCountryCommand.Parameters.AddWithValue("@LastUpdateBy", Utils.currentUser);
                            countryId = Convert.ToInt32(insertCountryCommand.ExecuteScalar());
                        }
                    }

                    // Insert the city
                    string insertCityQuery = "INSERT INTO city (city, countryId, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                                             "VALUES (@CityName, @CountryId, @CreateDate, @CreatedBy, @LastUpdate, @LastUpdateBy); SELECT LAST_INSERT_ID();";
                    using (var insertCityCommand = new MySqlCommand(insertCityQuery, connection))
                    {
                        insertCityCommand.Parameters.AddWithValue("@CityName", cityName);
                        insertCityCommand.Parameters.AddWithValue("@CountryId", countryId);
                        insertCityCommand.Parameters.AddWithValue("@CreateDate", DateTime.Now);
                        insertCityCommand.Parameters.AddWithValue("@CreatedBy", Utils.currentUser);
                        insertCityCommand.Parameters.AddWithValue("@LastUpdate", DateTime.Now);
                        insertCityCommand.Parameters.AddWithValue("@LastUpdateBy", Utils.currentUser);
                        cityId = Convert.ToInt32(insertCityCommand.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding city: {ex.Message}");
                return -1; // Return an invalid ID in case of an error
            }

            return cityId;
        }


    }





}



