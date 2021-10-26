using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Lab3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    static class InxNumber
    {
        public static int IndexNumber = 0;
    }

    public partial class MainWindow : Window
    {
      
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, RoutedEventArgs e)
        {
            WindowAdd aWindow = new WindowAdd(this);
            aWindow.Show();
        }

        private void button_save_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() ?? true)
            {
                using (StreamWriter streamWriter = new StreamWriter(dialog.FileName))
                {
                    foreach (Beverages beverage in listView.Items)
                    {
                        streamWriter.WriteLine("{0};{1};{2}", beverage.ItemName, beverage.ItemIndex, beverage.ItemCount);
                    }
                }
            }
        }

        private void button_read_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() ?? true)
            {
                InxNumber.IndexNumber = 1;
                listView.Items.Clear();
                foreach (string line in File.ReadAllLines(dialog.FileName))
                {
                    string[] RowSplitted = line.Split(';');
                    int Count = int.Parse(RowSplitted[2]);
                    listView.Items.Add(new Beverages { ItemName = RowSplitted[0], ItemIndex = InxNumber.IndexNumber++, ItemCount = Count });
                }
                listView.Items.Refresh();
            }
        }
    }
}
