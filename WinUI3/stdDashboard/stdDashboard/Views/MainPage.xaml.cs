using Microsoft.UI.Xaml.Controls;
using stdDashboard.Helpers;
using stdDashboard.ViewModels;

namespace stdDashboard.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }
    string SayHello {get
        {
            string s = null;
            DateTime dateTime = new DateTime();
            switch (dateTime.Hour)
            {
                case <= 5:
                    s = "Hello_Down";
                    break;
                case <= 11:
                    s = "Hello_Morning";
                    break;
                case <= 14:
                    s = "Hello_Noon";
                    break;
                case <= 18:
                    s = "Hello_Afternoon";
                    break;
                case <= 22:
                    s = "Hello_Night";
                    break;
                case <= 24:
                    s = "Hello_Down";
                    break;
                default:
                    break;
            }
            return s == null ? "Hello" : s.GetLocalized();
        }
        }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}
