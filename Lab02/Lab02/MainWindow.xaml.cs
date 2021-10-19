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

namespace Lab02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void engine_Click(object sender, RoutedEventArgs e)
        {
            engineWindow eWindow = new engineWindow();
            eWindow.Show();
        }

        private void brand_Click(object sender, RoutedEventArgs e)
        {
            brandWindow bWindow = new brandWindow();
            bWindow.Show();
        }

        private void result_Click(object sender, RoutedEventArgs e)
        {
            total_price.Content = staticClass.CountTotalPrice().ToString();
        }

        //total_price.Content = staticClass.TotalPrice;

    }
}
