using EPiServer;
using EPiServer.Core;
using EPiServer.Tracking.Core;
using EPiServer.Web;
using Foundation.Commerce.Customer.ViewModels;
using Mediachase.Commerce.Orders.Managers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Foundation.Demo.Api
{
    public class WeatherService
    {
        private readonly HttpClient _client = new HttpClient();

        private readonly string apiBaseUrl = "https://api.darksky.net/forecast/508cbedd82162c7dc2d4d628c7b85533/25.77427,-80.1918";

        public WeatherService()
        {

        }

        #region Profile Store Api

        public string GetCurrentWeather()
        {
            var request = (HttpWebRequest)WebRequest.Create(apiBaseUrl);

            request.Method = "GET";
            //request.UserAgent = RequestConstants.UserAgentValue;
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;

            var content = string.Empty;
            string data = "";
            using (var response = (HttpWebResponse)request.GetResponse())
            {
                using (var stream = response.GetResponseStream())
                {
                    using (var sr = new StreamReader(stream))
                    {
                        content = sr.ReadToEnd();
                        data = JObject.Parse(content)["currently"]["temperature"].ToString();
                    }
                }
            }

            return data;
        }
        #endregion
    }
}