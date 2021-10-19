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
        public brandWindow()
        {
            InitializeComponent();
        }

        private void eq1Checked(object sender, RoutedEventArgs e)
        {
            staticClass.SetEquipmentPrice(400);
        }

        private void eq1Unchecked(object sender, RoutedEventArgs e)
        {
            staticClass.SetEquipmentPrice(-400);
        }

        private void eq2Checked(object sender, RoutedEventArgs e)
        {
            staticClass.SetEquipmentPrice(5000);
        }

        private void eq2Unchecked(object sender, RoutedEventArgs e)
        {
            staticClass.SetEquipmentPrice(-5000);
        }

        private void eq3Checked(object sender, RoutedEventArgs e)
        {
            staticClass.SetEquipmentPrice(2800);
        }

        private void eq3Unchecked(object sender, RoutedEventArgs e)
        {
            staticClass.SetEquipmentPrice(-2800);
        }

        private void eq4Checked(object sender, RoutedEventArgs e)
        {
            staticClass.SetEquipmentPrice(3500);
        }

        private void eq4Unchecked(object sender, RoutedEventArgs e)
        {
            staticClass.SetEquipmentPrice(-3500);
        }

        private void InsuranceTextChanged(object sender, TextChangedEventArgs e)
        {
            int iPrice = 0;
            if (!int.TryParse(insurancePolicy.Text, out iPrice))
            {
                iPrice = 0;
            }
            staticClass.SetInsurancePrice(iPrice);
        }

        private void brandResult_Click(object sender, RoutedEventArgs e)
        {
            if (buttonFord.IsChecked == true)
            {
                staticClass.SetBrandPrice(90000);
            }

            if (buttonFerrari.IsChecked == true)
            {
                staticClass.SetBrandPrice(120000);
            }

            if (buttonFiat.IsChecked == true)
            {
                staticClass.SetBrandPrice(70000);
            }

            staticClass.TotalBrandPrice = staticClass.CountBrandPrice();
            brandSum.Content = staticClass.TotalBrandPrice.ToString();

        }

        private void brandReturn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
