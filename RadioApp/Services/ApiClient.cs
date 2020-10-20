using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using RadioApp.Models;

namespace RadioApp.Services
{
    class ApiClient
    {
        static readonly HttpClient client = new HttpClient();
        
        public async Task<IEnumerable<Station>> GetStationsAsync ()
        {
            HttpResponseMessage response = await client.GetAsync("https://radeoh.app/api/stations");

            response.EnsureSuccessStatusCode();

            var jsonString = await response.Content.ReadAsStringAsync();

            var test =  JsonConvert.DeserializeObject<Station>(jsonString);


            return (IEnumerable<Station>)test;

        }
    }
}
