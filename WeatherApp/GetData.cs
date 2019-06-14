using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp
{
    class GetData
    {
        public static void city_name(string name, DataGridView days)
        {
            string URL = "https://www.metaweather.com/api/location/" + name;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string content = new StreamReader(response.GetResponseStream()).ReadToEnd();
            var jsc = JObject.Parse(content);
            DataTable dt = jsc["consolidated_weather"].ToObject<DataTable>();
            days.DataSource = dt;
        }
    }
}
