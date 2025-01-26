using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project_C969_Appointment_App.Scripts
{
    public static class Reports
    {
        //LAMBDA EXPRESSIONS FOR PART A7

        public static IEnumerable<object> GetAppointmentTypesByMonth(BindingList<Appointment> appointments) =>
            appointments
                .GroupBy(a => new { a.Start.Month, a.Type })
                .Select(g => new { Month = g.Key.Month, Type = g.Key.Type, Count = g.Count() });

        public static IEnumerable<object> GetUserSchedules(BindingList<Appointment> appointments) =>
            appointments
                .GroupBy(a => a.UserId)
                .Select(g => new { UserId = g.Key, Appointments = g.ToList() });

        public static IEnumerable<object> GetTotalHoursByCustomer(BindingList<Appointment> appointments) =>
            appointments
                .GroupBy(a => a.CustomerName)
                .Select(g => new { CustomerName = g.Key, TotalHours = g.Sum(a => (a.End - a.Start).TotalHours) });



    }
}
