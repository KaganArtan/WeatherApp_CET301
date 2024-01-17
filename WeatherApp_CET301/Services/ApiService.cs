using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WeatherApp_CET301.Models;

namespace WeatherApp_CET301.Services
{
    public static class ApiService
    {
        public static async Task<Root> GetWeather(double latitude , double longitude)
        {
            var HttpClient = new HttpClient();
            var response = await HttpClient.GetStringAsync(string.Format("https://api.openweathermap.org/data/2.5/forecast?lat={0}&lon={1}&units=metric&appid=55600d5097e9da0e7405b83aeb66123c", latitude, longitude));
            return JsonConvert.DeserializeObject<Root>(response);
        }
        public static async Task<Root> GetWeatherByCity(string city)
        {
            var HttpClient = new HttpClient();
            var response = await HttpClient.GetStringAsync(string.Format("https://api.openweathermap.org/data/2.5/forecast?q={0}&units=metric&appid=55600d5097e9da0e7405b83aeb66123c", city));
            return JsonConvert.DeserializeObject<Root>(response);
        }
    }
}
