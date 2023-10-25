//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using Google.Apis.Calendar.v3;
//using Google.Apis.Auth;
//using Google.Apis.Services;

//namespace HolidayCalenderWinformApp
//{
//    public partial class HolidayApp : Form
//    {
//        public HolidayApp()
//        {
//            InitializeComponent();
//        }
//        const string ApiKey = "AIzaSyDn1tOIB9Rw80Rn3EX10wMa8bhdJ4QJMPU";
//        const string CalendarId = "en.usa#holiday@group.v.calendar.google.com";
//        private void btnHolidays_Click(object sender, EventArgs e)
//        {
//            const string ApiKey = "AIzaSyDn1tOIB9Rw80Rn3EX10wMa8bhdJ4QJMPU";
//            const string CalendarId = "en.usa#holiday@group.v.calendar.google.com";

//            var service = new CalendarService(new Google.Apis.Services.BaseClientService.Initializer()
//            {
//                ApiKey = ApiKey,
//                ApplicationName = "Api Key Example"
//            });

//            var request = service.Events.List(CalendarId);
//            request.Fields = "items(summary,start,end)";
//            var response =  request.ExecuteAsync();

//            foreach (var item in response.Items)
//            {
//                string startDate = GetDateOrDateTime(item.Start);
//                string endDate = GetDateOrDateTime(item.End);
//                //Console.WriteLine($"Holiday: {item.Summary} start: {startDate} end: {endDate}");
//                Console.WriteLine($"Holiday: {item.Summary}");
//                Console.WriteLine($"start: {startDate}");
//                Console.WriteLine($"end: {endDate}");
//            }

//        }

//        static string GetDateOrDateTime(Google.Apis.Calendar.v3.Data.EventDateTime eventDateTime)
//        {
//            return !string.IsNullOrEmpty(eventDateTime.Date) ? eventDateTime.Date : eventDateTime.DateTime?.ToString("yyyy-MM-dd HH:mm:ss");
//        }



//    }
//}

using System;
using System.Windows.Forms;
using Google.Apis.Calendar.v3;
using Google.Apis.Services;

namespace HolidayCalenderWinformApp
{
    public partial class HolidayApp : Form
    {
        const string ApiKey = "AIzaSyDn1tOIB9Rw80Rn3EX10wMa8bhdJ4QJMPU";
        const string CalendarId = "en.usa#holiday@group.v.calendar.google.com";

        public HolidayApp()
        {
            InitializeComponent();
        }

        private async void btnHolidays_Click(object sender, EventArgs e)
        {
            var service = new CalendarService(new BaseClientService.Initializer()
            {
                ApiKey = ApiKey,
                ApplicationName = "HolidayCalendar" // Sets the application name.
            });

            var request = service.Events.List(CalendarId); // Prepares a request to list events from the specified calendar.
            request.Fields = "items(summary,start,end)"; // Specifies the fields of interest from the events.
            var response = await request.ExecuteAsync(); // Sends the request and awaits the response.

            lstHolidays.Items.Clear(); // Clears existing items from the list view.
            foreach (var item in response.Items)   // Iterates over each event item in the response.
            {
               
                string startDate = GetDateOrDateTime(item.Start); // Extracts start date/time from the event item.
                string endDate = GetDateOrDateTime(item.End); // Extracts end date/time from the event item.

                var listViewItem = new ListViewItem(new[] // Creates a new list view item for the event.
                {
                    item.Summary,
                    startDate,
                    endDate
                });

                lstHolidays.Items.Add(listViewItem); // Adds the new list view item to the list view.
            }
        }

        static string GetDateOrDateTime(Google.Apis.Calendar.v3.Data.EventDateTime eventDateTime)
        {
            return !string.IsNullOrEmpty(eventDateTime.Date) ? eventDateTime.Date : eventDateTime.DateTime?.ToString("yyyy-MM-dd HH:mm:ss");
            // Checks if the event has a date.
            // Returns the date if present.

        }
    }
}

