using Microsoft.UI.Xaml.Controls;

using stdDashboard.ViewModels;

namespace stdDashboard.Views;

public sealed partial class MyIdeasPage : Page
{
    public MyIdeasViewModel ViewModel
    {
        get;
    }

    public MyIdeasPage()
    {
        ViewModel = App.GetService<MyIdeasViewModel>();
        InitializeComponent();
    }
}
