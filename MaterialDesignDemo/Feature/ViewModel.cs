using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MaterialDesignDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MaterialDesignDemo.Feature
{
    public partial class ViewModel:ObservableObject
    {
        [ObservableProperty]
        MainLable dashBoardText;

        [RelayCommand]
        async Task ChangeMainText()
        {
            try
            {
                var result = await HttpHelper.GetStringAsync(@"https://content-static.mihoyo.com/content/ysCn/getContentList?pageSize=20&pageNum=1&order=asc&channelId=150");
                DashBoardText = new MainLable(result);
            }
            catch (Exception)
            {

                MessageBox.Show("Failed");
            }

        }
        [RelayCommand]
        void ClearMainText()
        {
            DashBoardText = new MainLable("");
        }
    }
}
