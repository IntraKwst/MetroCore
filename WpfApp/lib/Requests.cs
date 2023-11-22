using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp
{
    internal static class Requests
    {
        private static string _baseUrl = @"http://localhost:5266/";

        internal static async Task<ResponseT> GetRequest<ResponseT>(string url)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(_baseUrl + url);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<ResponseT>(content);
                }
                else
                {
                    throw new Exception();
                }
            }
        }
    }
}
