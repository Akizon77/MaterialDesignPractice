using MaterialDesignDemo.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MaterialDesignDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /*bool isMaximum = false;*/
        public MainWindow()
        {
            InitializeComponent();
        }
/*        public void SizeSetToNormal()
        {
            this.WindowState = WindowState.Normal;
            isMaximum = false;
            //btnSettings.Margin = new Thickness(0, this.Height - 550, 0, 0);
        }
        public void SizeSetToMax()
        {
            this.WindowState = WindowState.Maximized;
            isMaximum = true;
            //btnSettings.Margin = new Thickness(0, this.Height - 740, 0, 0);
        }*/

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RenderPages.Children.Clear();
            RenderPages.Children.Add(new DashBoard());
            MenuList.SelectedItem = DashBoardList;
        }

        private void btnDebug_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

/*            SizeSetToNormal()*/;
            this.DragMove();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnMaximum(object sender, RoutedEventArgs e)
        {
            /*if (isMaximum) SizeSetToNormal();
            else SizeSetToMax();*/
        }

        private void btnMinimum(object sender, RoutedEventArgs e)
        {
            /*this.WindowState = WindowState.Minimized;*/
        }

        private void SwitchToDashbord(object sender, RoutedEventArgs e)
        {
            RenderPages.Children.Clear();
            RenderPages.Children.Add(new DashBoard());
        }

        private void SwitchToSettings(object sender, RoutedEventArgs e)
        {
            RenderPages.Children.Clear();
            RenderPages.Children.Add(new Settings());
        }

        private void SwitchToMyProjects(object sender, RoutedEventArgs e)
        {
            RenderPages.Children.Clear();
            RenderPages.Children.Add(new MyProjects());
        }

        private void SwitchToAnalysis(object sender, RoutedEventArgs e)
        {
            RenderPages.Children.Clear();
            RenderPages.Children.Add(new Analysis());
        }

        private void SwitchToInfo(object sender, RoutedEventArgs e)
        {
            RenderPages.Children.Clear();
            RenderPages.Children.Add(new Info());
        }
    }
}
