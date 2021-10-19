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
    /// Interaction logic for engineWindow.xaml
    /// </summary>
    public partial class engineWindow : Window
    {
        public engineWindow()
        {
            InitializeComponent();
            engineSum.Content = string.Empty;
        }


        private void enginePower_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            staticClass.SetEnginePower(4 * (120 + 200 * enginePower.SelectedIndex));
        }


        private void engineResult_Click(object sender, RoutedEventArgs e)
        {
            if (buttonPetrol.IsChecked == true)
            {
                staticClass.SetEnginePrice(1200);
            }

            if (buttonGas.IsChecked == true)
            {
                staticClass.SetEnginePrice(1500);
            }

            if (buttonDiesel.IsChecked == true)
            {
                staticClass.SetEnginePrice(1000);
            }

            if (buttonHybrid.IsChecked == true)
            {
                staticClass.SetEnginePrice(2500);
            }

            staticClass.TotalEnginePrice = staticClass.CountEnginePrice();
            engineSum.Content = staticClass.TotalEnginePrice.ToString();
        }

        private void brandReturn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
