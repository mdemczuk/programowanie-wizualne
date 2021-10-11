using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        System.Windows.Threading.DispatcherTimer dispTimer = new System.Windows.Threading.DispatcherTimer();
        DateTime date_time = new DateTime();
        public Window1()
        {
            InitializeComponent();
            dispTimer.Tick += Current_Time;
            dispTimer.Interval = TimeSpan.FromMilliseconds(1);
        }
        private void Current_Time(object sender, EventArgs e)
        {
            date_time = date_time.AddSeconds(1);
            stopwatch.Content = date_time.ToString("HH:mm:ss");
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            dispTimer.Start();
        }

        private void stop_Click(object sender, RoutedEventArgs e)
        {
            dispTimer.Stop();
        }
    }
}
