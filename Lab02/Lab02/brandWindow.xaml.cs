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
using System.Windows.Shapes;

namespace Lab02
{
    /// <summary>
    /// Interaction logic for brandWindow.xaml
    /// </summary>
    public partial class brandWindow : Window
    {
        public brandWindow(MainWindow mainWindow)
        {
            InitializeComponent();
        }



        private void brandReturn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
