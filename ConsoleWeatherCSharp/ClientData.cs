using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleWeatherCSharp
{
    public class ClientData
    {
        private string _city;
        private string _key = "bc5f3c4ea12f8a20f5d49ba45071ac67";

        public ClientData(string city)
        {
            _city = city;
        }

        public Uri ApiData()
        {
            Uri apiString = new Uri($"http://api.openweathermap.org/data/2.5/weather?q={_city}&appid={_key}");

            return apiString;
        }
        
    }
}
