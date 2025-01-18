# Global Scheduling Application

## Overview  
The Global Scheduling Application is a desktop-based solution developed in C# to meet the scheduling and management needs of a global consulting organization. It incorporates advanced programming features, including database interaction, localization, timezone adjustments, exception handling, and more.

## Features  
1. **User Login**  
   - Determines user location.  
   - Supports message translation into English and one additional language.  
   - Verifies username and password.

2. **Customer Management**  
   - Add, update, and delete customer records.  
   - Validates input fields for completeness and formatting.  
   - Advanced exception handling for database operations.

3. **Appointment Scheduling**  
   - Add, update, and delete appointments linked to customers.  
   - Prevents overlapping appointments.  
   - Ensures appointments are within business hours (9:00 AM - 5:00 PM EST, Monday–Friday).  
   - Exception handling for all appointment operations.

4. **Calendar View**  
   - Monthly calendar with day-specific appointment viewing.

5. **Timezone and Daylight Saving Adjustment**  
   - Automatically adjusts appointment times based on user timezone and daylight saving settings.

6. **Alerts**  
   - Notifies users of appointments within the next 15 minutes upon login.

7. **Reporting**  
   - Generates reports using lambda expressions:
     - Appointment types by month.  
     - User-specific schedules.  
     - Additional custom report.  

8. **Activity Log**  
   - Records login activity (timestamp and username) in a `Login_History.txt` file.

## Technologies  
- **Language**: C#  
- **Database**: MySQL  
- **IDE**: Visual Studio  
- **Framework**: .NET  

## Getting Started  
1. Clone the repository:  
   ```bash
   git clone https://github.com/YourUsername/Global-Scheduling-Application.git

    Open the project in Visual Studio.
    Update database connection settings in the code.
    Build and run the application.

Project Structure

    /SourceCode: Contains the source code files for the application.
    /Database: MySQL scripts and ERD for reference.
    /Documentation: Supporting documents and requirements.
    /ActivityLogs: Login history logs.

Requirements

    .NET Framework
    MySQL Database
    Visual Studio IDE
