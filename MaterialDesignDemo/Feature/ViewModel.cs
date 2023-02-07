using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MaterialDesignDemo.Feature
{
    partial class ViewModel:ObservableObject
    {
        [ObservableProperty]
        string charUrlA;
        [RelayCommand]
        async Task LoadImg(string id = "150")
        {
            await GetImg(@"https://webstatic.mihoyo.com/upload/contentweb/2022/09/27/d978cf1ce85e372971bdcf6add639e8f_5385395843160526652.png");
        }
        async Task<HttpResponseMessage> GetImg(string url)
        {
            HttpRequestMessage httpRequestMessage = new()
            {
                RequestUri = new Uri(url),
                Method = HttpMethod.Get
            };
            var httpc = new HttpClient();
            var response = await httpc.SendAsync(httpRequestMessage);
            return response;
        }
    }
}
