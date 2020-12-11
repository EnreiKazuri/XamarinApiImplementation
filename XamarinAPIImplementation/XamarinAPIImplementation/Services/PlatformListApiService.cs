using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using XamarinAPIImplementation.Models;

namespace XamarinAPIImplementation.Services
{
    class PlatformListApiService : IPlatformListApiService
    {
        private Random _random = new Random();
        public async Task<Result> GetPlatform()
        {
            Result platforms = null;
            var client = new HttpClient();
            var response = await client.GetAsync("https://api.rawg.io/api/platforms?key=7b8dd461e6ef42df8e64b4964852ce00");

            if (response.IsSuccessStatusCode)
            {
                int rand = _random.Next(10);
                var platformList = JsonConvert.DeserializeObject<Example>(await response.Content.ReadAsStringAsync());

                platforms = platformList.Results[rand];
            }
            return platforms;
        }
    }
}
