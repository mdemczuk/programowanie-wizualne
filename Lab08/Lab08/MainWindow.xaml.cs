using CsvHelper;
using CsvHelper.Configuration.Attributes;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows;

namespace Lab08
{
    public class Airport
    {
        [Index(0)]
        public string city { get; set; }

        [Index(1)]
        public string voivodeship { get; set; }

        [Index(2)]
        public string code1 { get; set; }

        [Index(3)]
        public string code2 { get; set; }

        [Index(4)]
        public string airportName { get; set; }

        [Index(5)]
        public string numofpassengers { get; set; }

        [Index(6)]
        public string change { get; set; }
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Airport> airports;

        public MainWindow()
        {
            InitializeComponent();

            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() ?? true)
            {
                using (var streamReader = new StreamReader(openFileDialog.FileName, Encoding.UTF8))
                {
                    using (var csv = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                    {
                        airports = new List<Airport>(csv.GetRecords<Airport>());
                        airports.ForEach(airport => AirportsListview.Items.Add(airport));
                    }
                }
            }
        }

        private void buttonDetails_Click(object sender, RoutedEventArgs e)
        {
            var airport = (Airport)AirportsListview.SelectedItem;

            string buffer = "";
            if (checkCode1.IsChecked == true)
                buffer += checkCode1.Content + ": " + airport.code1 + "\n";

            if (checkCode2.IsChecked == true)
                buffer += checkCode2.Content + ": " + airport.code2 + "\n";

            if (checkPassengers.IsChecked == true)
                buffer += checkPassengers.Content + ": " + airport.numofpassengers + "\n";

            if (checkVoivodeship.IsChecked == true)
                buffer += checkVoivodeship.Content + ": " + airport.voivodeship + "\n";

            if (checkCity.IsChecked == true)
                buffer += checkCity.Content + ": " + airport.city + "\n";
        
            detailsWindow Info = new detailsWindow(buffer);
            Info.ShowDialog();
        }
    }
}
