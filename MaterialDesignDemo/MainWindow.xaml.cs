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
        bool isMaximum = false;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
            this.WindowState = WindowState.Normal;
            this.DragMove();
        }

        private void btnMaximum(object sender, RoutedEventArgs e)
        {
            if (isMaximum)
            {
                this.WindowState = WindowState.Normal;
                isMaximum = false;
            }
            else
            {
                this.WindowState = WindowState.Maximized;
                isMaximum = true;
            }
        }

        private void btnMinimum(object sender, RoutedEventArgs e)
        {
            this.WindowState= WindowState.Minimized;
        }

        private void SwitchToDashbord(object sender, RoutedEventArgs e)
        {

        }

        private void SwitchToSettings(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnDebug_Click(object sender, RoutedEventArgs e)
        {
            MenuList.SelectedItem = null;
        }
    }
}
