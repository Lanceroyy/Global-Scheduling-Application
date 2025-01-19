using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_C969_Appointment_App.Scripts
{
    public class Localization
    {
        //Upon starting up the application set the language to the default language on the device.

        //LAMBDA EXPRESSION
        //Simplifies the code reducing boilerplate code instead of writing a conventiional method. Increases readability.
        public static string DefaultLanguage => CultureInfo.CurrentCulture.TwoLetterISOLanguageName;

        public Localization()
        {

        }

        public void SetDefaultLanguage(LoginScreen loginScreen)
        {
            CultureInfo cultureInfo = CultureInfo.CurrentCulture;

            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;


            //Grab the two letter language code
            string language = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;

            if (loginScreen != null)
            {
                if (language == "en")
                {
                    loginScreen.titleText.Text = "Appointment Scheduler";
                    loginScreen.userNameLabel.Text = "Username";
                    loginScreen.passwordLabel.Text = "Password";
                    loginScreen.loginButton.Text = "Login";
                    loginScreen.Text = "Login Screen";
                    return;
                }

                if (language == "es")
                {
                    loginScreen.titleText.Text = "Programador de citas";
                    loginScreen.userNameLabel.Text = "Nombre de usuario";
                    loginScreen.passwordLabel.Text = "Contraseña";
                    loginScreen.loginButton.Text = "Acceso";
                    loginScreen.Text = "Pantalla de inicio de sesión";

                    return;
                }

                MessageBox.Show("Language not found");
            }
            else
            {
                MessageBox.Show("LoginScreen not found");
            }

            return;
        }


        public void ObtainUserTimeZoneAndLocation(Label countryLabel, Label regionLabel, Label languageLabel, Label timeZoneLabel)
        {
            try
            {
                // Get the local time zone
                TimeZoneInfo timeZone = TimeZoneInfo.Local;

                // Display the time zone name
                timeZoneLabel.Text = timeZone.DaylightName;

                // Obtain location information
                CultureInfo culture = CultureInfo.CurrentCulture;
                RegionInfo region = new RegionInfo(culture.Name);

                countryLabel.Text = region.DisplayName;
                regionLabel.Text = region.Name;
                languageLabel.Text = culture.TwoLetterISOLanguageName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error obtaining user time zone and location: " + ex.Message);
            }
        }

        public static void AdjustToUserTimeZone(DataGridView appTimesDVG, Form form)
        {
            //IF MAIN FORM 
            //FORMAT THE APPOINTMENT GRIDS DIFFERENTLY BASED ON THE FORM
            if (form is MainScreen)
            {
                try
                {
                    // Get the user's local time zone
                    TimeZoneInfo userTimeZone = TimeZoneInfo.Local;

                    foreach (DataGridViewRow row in appTimesDVG.Rows)
                    {
                        if (row.Cells["start"].Value != null && row.Cells["end"].Value != null)
                        {
                            // Parse the start and end times as DateTime
                            if (DateTime.TryParse(row.Cells["start"].Value.ToString(), out DateTime startTime) &&
                                DateTime.TryParse(row.Cells["end"].Value.ToString(), out DateTime endTime))
                            {
                                // Convert the times to the user's time zone
                                DateTime startInUserZone = TimeZoneInfo.ConvertTimeFromUtc(startTime, userTimeZone);
                                DateTime endInUserZone = TimeZoneInfo.ConvertTimeFromUtc(endTime, userTimeZone);

                                // Update the DataGridView with properly formatted localized times
                                row.Cells["start"].Value = startInUserZone.ToString("yyyy-MM-dd hh:mm tt"); // Retain full date and time
                                row.Cells["end"].Value = endInUserZone.ToString("yyyy-MM-dd hh:mm tt");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adjusting times to user time zone: " + ex.Message);
                }

            }

            //FORMAT THE APPOINTMENT GRIDS DIFFERENTLY
            else
            {
                try
                {
                    // Get the user's local time zone
                    TimeZoneInfo userTimeZone = TimeZoneInfo.Local;

                    foreach (DataGridViewRow row in appTimesDVG.Rows)
                    {
                        if (row.Cells["start"].Value != null && row.Cells["end"].Value != null)
                        {
                            // Parse the start and end times as DateTime
                            if (DateTime.TryParse(row.Cells["start"].Value.ToString(), out DateTime startTime) &&
                                DateTime.TryParse(row.Cells["end"].Value.ToString(), out DateTime endTime))
                            {
                                // Convert the times to the user's time zone
                                DateTime startInUserZone = TimeZoneInfo.ConvertTimeFromUtc(startTime, userTimeZone);
                                DateTime endInUserZone = TimeZoneInfo.ConvertTimeFromUtc(endTime, userTimeZone);

                                // Update the DataGridView with properly formatted localized times
                                row.Cells["start"].Value = startInUserZone.ToString("hh:mm tt"); // Retain full date and time
                                row.Cells["end"].Value = endInUserZone.ToString("hh:mm tt");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adjusting times to user time zone: " + ex.Message);
                }
            }
            
        }

    }
}
