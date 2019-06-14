using Newtonsoft.Json.Linq;
using System;
using System.Data;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace WeatherApp
{
    class GetData
    {
        private static string URL, content;
        private static JObject json;
        private static DataTable dt;
        private static HttpWebRequest request;
        private static HttpWebResponse response;
        public static void city_code(string name, DataGridView days)
        {
            URL = "https://www.metaweather.com/api/location/" + name;
            request = (HttpWebRequest)WebRequest.Create(URL);
            response = (HttpWebResponse)request.GetResponse();
            if(response.StatusCode == HttpStatusCode.OK)
            {
                content = new StreamReader(response.GetResponseStream()).ReadToEnd();
                json = JObject.Parse(content);
                dt = json["consolidated_weather"].ToObject<DataTable>();
                // Remove unnecessary fields
                dt.Columns.Remove("id");
                dt.Columns.Remove("created");
                dt.Columns.Remove("weather_state_abbr");
                dt.Columns.Remove("applicable_date");
                days.DataSource = dt;
            }
            else
            {
                Console.WriteLine("There was an error proccesing your request...");
            }
            
        }
    }
}
