
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Windows.Forms;


namespace GeoTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //  Radar to get specific address.

        string radarApiUrl = "https://api.radar.io/v1/geocode/reverse?coordinates=";
        string ApiKey = "prj_test_pk_9804a9d5cb5593ee10824fe51558df94e7b37d9e";

        public class AddressResponse
        {
            public AddressData address { get; set; }
            public MetaData meta { get; set; }
        }
        public class MetaData
        {
            public string code { get; set; }
        }
        public class AddressData
        {
            public string countryCode { get; set; }
            public string country { get; set; }
            public string countryFlag { get; set; }
            public string state { get; set; }
            public string stateCode { get; set; }
            public string city { get; set; }
            public string postalCode { get; set; }
            public double latitude { get; set; }
            public double longitude { get; set; }
            public string layer { get; set; }
            public Geometry geometry { get; set; }
            public string dma { get; set; }
            public string dmaCode { get; set; }
        }
        public class Geometry
        {
            public string type { get; set; }
            public double[] coordinates { get; set; }
        }
        private void getLocationButton_Click(object sender, EventArgs e)
        {
            string location = string.Empty;
            string coords = string.Empty;
            var response = fetchLocationByIpAddress();
            if(response.meta.code == "200")
            {
                label2.Text = "Connection: Success";
                label2.Visible = true;
                var address = response.address;
                location += $"Country: {address.country}" + Environment.NewLine;
                location += $"State: {address.state}" + Environment.NewLine;
                location += $"City: {address.city}" + Environment.NewLine;
                location += $"PostalCode: {address.postalCode}" + Environment.NewLine;
                location += $"Latitude: {address.geometry.coordinates[1]}" + Environment.NewLine;
                location += $"Longtitude: {address.geometry.coordinates[0]}" + Environment.NewLine;

                coords = $"{address.geometry.coordinates[1]},{address.geometry.coordinates[0]}";
            
                string foramttedAddress = getAddress(coords);
                location += foramttedAddress;
                showLocationTextBox.Text = location;
            }
            else
            {
                label2.Text = "Connection: Error";
                label2.Visible = true;
            }
           
        }
        private AddressResponse fetchLocationByIpAddress()
        {
            string location = string.Empty;
            var client = new RestClient("https://api.radar.io/v1/geocode/ip" );
            var request = new RestRequest()
            {
                Method = Method.Get
            };
            request.AddHeader("Authorization", ApiKey);
            var response = client.Execute(request);
            var jsonResponse = JsonConvert.DeserializeObject<AddressResponse>(response.Content);
            Console.WriteLine(jsonResponse);
            return jsonResponse;
        }

        private string getAddress(string coord)
        {
            string address = string.Empty;
            var client = new RestClient(radarApiUrl + coord );
            var request = new RestRequest()
            {
                Method = Method.Get
            };
            request.AddHeader("Authorization", ApiKey);
            var response = client.Execute(request);
            var responseObj = JsonConvert.DeserializeObject<JObject>(response.Content);
            var formattedAddress = responseObj["addresses"][0]["formattedAddress"].ToString();
            //Console.WriteLine(responseObj);
            Console.WriteLine(formattedAddress);
            return formattedAddress;
        }
    }
}
