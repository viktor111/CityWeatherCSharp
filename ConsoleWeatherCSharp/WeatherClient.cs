using System;
using System.Net;
using System.IO;
using System.Web;

namespace ConsoleWeatherCSharp
{
    public class WeatherClient : IWebRequestCreate
    {
        public WeatherClient()
        {
        }

        public WebRequest Create(Uri uri)
        {
            WebRequest request = WebRequest.Create(uri);

            return request;
        }


        public HttpWebResponse Response(WebRequest webRequest)
        {          
            try
            {
                HttpWebResponse response = (HttpWebResponse)webRequest.GetResponse();
                return response;
            }
            catch(WebException e)
            {
                Console.WriteLine("[-] Input city");

                return null;
            }            
            
        }
    }
}
