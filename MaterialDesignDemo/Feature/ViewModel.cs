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
    public class Helper
    {
        HttpClient client;
        public void ChangeImg()
        {

        }
        public void GetInfo(string url)
        {
            var httpMessage = new HttpRequestMessage
            {

                Method = HttpMethod.Get
            };
        }
    }
}
