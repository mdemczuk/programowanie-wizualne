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
                using (FileStream fileWriter = new FileStream(dialog.FileName, FileMode.OpenOrCreate))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Beverages[]));
                    serializer.Serialize(fileWriter, listView.Items.OfType<Beverages>().ToList().ToArray());
                }
            }
        }

        private void button_read_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() ?? true)
            {
                using (FileStream fileReader = new FileStream(dialog.FileName, FileMode.OpenOrCreate))
                {
                    InxNumber.IndexNumber = 1;
                    listView.Items.Clear();
                    XmlSerializer deserializer = new XmlSerializer(typeof(List<Beverages>));
                    foreach (Beverages item in (List<Beverages>)deserializer.Deserialize(fileReader))
                    {
                        listView.Items.Add(item);
                        InxNumber.IndexNumber++;
                    }
                    listView.Items.Refresh();
                }
                listView.Items.Refresh();
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to save your data?", "Save data", MessageBoxButtons.YesNo);
            switch (dialogResult)
            {
                case System.Windows.Forms.DialogResult.Yes:
                    SaveFileDialog dialog = new SaveFileDialog();
                    if (dialog.ShowDialog() ?? true)
                    {
                        using (FileStream fileWriter = new FileStream(dialog.FileName, FileMode.OpenOrCreate))
                        {
                            XmlSerializer serializer = new XmlSerializer(typeof(List<Beverages>));
                            serializer.Serialize(fileWriter, listView.Items.OfType<List<Beverages>>().ToList().ToArray());
                        }
                    }
                    break;
                case System.Windows.Forms.DialogResult.No:
                    break;
            }
        }
    }
}