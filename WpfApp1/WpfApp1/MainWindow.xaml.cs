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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Windows.Threading.DispatcherTimer dispTimer = new System.Windows.Threading.DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            dispTimer.Tick += Current_Time;
            dispTimer.Interval = TimeSpan.FromMilliseconds(1);
            dispTimer.Tick += Current_Time;
            dispTimer.Start();
        }

        private void Current_Time(object sender, EventArgs e)
        {
            timer.Content = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 stopwatchWindow = new Window1();
            stopwatchWindow.Show();
        }
    }
}
