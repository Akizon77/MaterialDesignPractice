using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MaterialDesignDemo.Feature
{
    public class HttpHelper
    {
        public static async Task<HttpResponseMessage> GetResponseAsync(string url,HttpMethod ?httpMethod = null)
        {
            var client = new HttpClient();
            var httpMessage = new HttpRequestMessage
            {
                RequestUri = new Uri(url),
                Method = httpMethod ?? HttpMethod.Get,
            };
            var response = await client.SendAsync(httpMessage);
            response.EnsureSuccessStatusCode();
            return response;
        }
        public static async Task<string> GetStringAsync(string url,HttpMethod httpMethod = null)
        {
            var httpResponseMessage = await GetResponseAsync(url,httpMethod);
            httpResponseMessage.EnsureSuccessStatusCode();
            return await httpResponseMessage.Content.ReadAsStringAsync();
        }
/*        public async Task<Image> GetImageAsync(string url)
        {
            return new Image();
        }*/
    }
}
