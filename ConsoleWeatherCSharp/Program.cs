using System;
using System.IO;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ConsoleWeatherCSharp
{
   public class Program
   {
       public static void Main()
       {
            while (true)
            {
                Console.WriteLine("Input city");
                Console.Write("> ");

                string city = Console.ReadLine();

                WeatherClient weatherClient = new WeatherClient();
                ClientData clientData = new ClientData(city);

                Uri apiString = clientData.ApiData();

                WebRequest web = weatherClient.Create(apiString);

                WebResponse res = weatherClient.Response(web);


                Stream data = res.GetResponseStream();

                StreamReader reader = new StreamReader(data);

                string resParsed = reader.ReadToEnd();

                Console.WriteLine(resParsed);
                
                data.Close();
                reader.Close();
                res.Close();

            }       
       }
   }
}
