using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace SalonAppCalendarAPI
{
    public partial class SalonApp : Form
    {
        private CalendarService calendarService;
        const string ApiKey = "AIzaSyAEyRaL86wvCx6tnhDNG0uFszR88YQAlP0";
        const string CalendarId = "c_d0c0e1201545ed198a4a7c768361ef4bb11bdb5f9d41e523138382558e3ff8a2@group.calendar.google.com";
        public SalonApp()
        {
            InitializeComponent();
            // calendarService = AuthenticateWithGoogle();
            //calendarService = btnAuthenticate_Click();
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

        }

        private async void btnLoadEvents_Click(object sender, EventArgs e)
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

        private void lstHolidays_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


    //private CalendarService AuthenticateWithGoogle()
    //{
    //    UserCredential credential;
    //    using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
    //    {
    //        string credPath = "token.json";
    //        credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
    //            GoogleClientSecrets.FromStream(stream).Secrets,
    //            new[] { CalendarService.Scope.Calendar },
    //            "user",
    //            CancellationToken.None,
    //            new FileDataStore(credPath, true)).Result;
    //    }

    //    // Create Google Calendar API service.
    //    var service = new CalendarService(new BaseClientService.Initializer()
    //    {
    //        HttpClientInitializer = credential,
    //        ApiKey = ApiKey,
    //        ApplicationName = "SalonCalendarIntegration",
    //    });

    //    var request = service.Events.List(CalendarId); // Prepares a request to list events from the specified calendar.
    //    request.Fields = "items(summary,start,end)"; // Specifies the fields of interest from the events.
    //    var response =  request.ExecuteAsync(); // Sends the request and awaits the response.


    //    return service;


    //private void CreateEvent(string summary, DateTime dateTime)
    //{
    //    Event newEvent = new Event()
    //    {
    //        Summary = summary,
    //        Start = new EventDateTime()
    //        {
    //            DateTimeDateTimeOffset = dateTime,
    //            TimeZone = "UTC",
    //        },
    //        End = new EventDateTime()
    //        {
    //            DateTimeDateTimeOffset = dateTime.AddHours(1),
    //            TimeZone = "UTC",
    //        },
    //    };

    //    EventsResource.InsertRequest request = calendarService.Events.Insert(newEvent, "primary");
    //    Event createdEvent = request.Execute();
    //    MessageBox.Show("Event created: " + createdEvent.HtmlLink);
    //}
    //private void textBox1_TextChanged(object sender, EventArgs e)
    //{

    //}


    //lstHolidays.Items.Clear(); // Clears existing items from the list view.
    //foreach (var item in response.Items)   // Iterates over each event item in the response.
    //{

    //    string startDate = GetDateOrDateTime(item.Start); // Extracts start date/time from the event item.
    //    string endDate = GetDateOrDateTime(item.End); // Extracts end date/time from the event item.

    //    var listViewItem = new ListViewItem(new[] // Creates a new list view item for the event.
    //    {
    //        item.Summary,
    //        startDate,
    //        endDate
    //    });

    //    lstHolidays.Items.Add(listViewItem); // Adds the new list view item to the list view.
}

