using Microsoft.UI.Xaml.Controls;
using stdDashboard.Helpers;
using stdDashboard.ViewModels;
using Windows.Media.Playback;

namespace stdDashboard.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }
    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }

    private void Button_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }
}
