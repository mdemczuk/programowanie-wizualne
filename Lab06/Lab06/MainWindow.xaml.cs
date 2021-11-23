using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;
using MessageBox = System.Windows.Forms.MessageBox;
using OpenFileDialog = Microsoft.Win32.OpenFileDialog;
using SaveFileDialog = Microsoft.Win32.SaveFileDialog;

namespace Lab06
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    ///
    public partial class MainWindow : Window
    {
        int globalIndex = 0;
        List<Beverages> beveragesList = new List<Beverages>();
        static string configPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
        Configuration configuration = ConfigurationManager.OpenExeConfiguration(configPath);

        private void load_data(string filePath)
        {
            if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
            {
                globalIndex = 0;
                using (var fileStream = File.OpenRead(filePath))
                {
                    var xmlSerializer = new XmlSerializer(typeof(List<Beverages>));
                    beveragesList = (List<Beverages>)xmlSerializer.Deserialize(fileStream);
                    listView.Items.Clear();
                    beveragesList.ForEach(each => listView.Items.Add(each));
                    listView.Items.Refresh();
                }
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            load_data(configuration.AppSettings.Settings["dataFile"].Value);
        }

        private void button_add_Click(object sender, RoutedEventArgs e)
        {
            WindowAdd window = new WindowAdd();
            window.ShowDialog();

            var beverage = new Beverages { itemName = window.itemName,
                itemCount = window.itemCount, itemIndex = ++globalIndex };

            beveragesList.Add(beverage);
            listView.Items.Add(beverage);
            listView.Items.Refresh();
        }

        private void button_save_Click(object sender, RoutedEventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() ?? true)
            {
                using (var fileStream = File.OpenWrite(saveFileDialog.FileName))
                {
                    var xmlSerializer = new XmlSerializer(typeof(List<Beverages>));
                    xmlSerializer.Serialize(fileStream, beveragesList);
                }
            }
        }

        private void button_read_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() ?? true)
            {
                load_data(openFileDialog.FileName);

                configuration.AppSettings.Settings.Remove("dataFile");
                configuration.AppSettings.Settings.Add("dataFile", openFileDialog.FileName);
                configuration.Save(ConfigurationSaveMode.Modified);
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to save your data?", "Save data", MessageBoxButtons.YesNo);
            if (dialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                button_save_Click(null, null);
            }
        }

        private void textbox_filter_TextChanged(object sender, TextChangedEventArgs e)
        {
            listView.Items.Clear();
            if (string.IsNullOrEmpty(textbox_filter.Text))
            {
                beveragesList.ForEach(each => listView.Items.Add(each));
            }
            else
            {
                foreach (Beverages each in beveragesList)
                {
                    if (each.itemName.Contains(textbox_filter.Text) ||
                        each.itemCount.ToString().Contains(textbox_filter.Text))
                    {
                        listView.Items.Add(each);
                    }   
                }
            }
            listView.Items.Refresh();
        }
    }
}