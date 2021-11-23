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

namespace Lab06
{
    /// <summary>
    /// Interaction logic for WindowAdd.xaml
    /// </summary>
    public partial class WindowAdd : Window
    {
        public string itName;
        public int itCount;
        MainWindow List;

        public WindowAdd(MainWindow mainWindow)
        {
            InitializeComponent();
            List = mainWindow;
        }

        private void NameTextChanged(object sender, TextChangedEventArgs e)
        {
            itName = textbox_name.Text;
        }

        private void CountTextChanged(object sender, TextChangedEventArgs e)
        {
            if (!int.TryParse(textbox_count.Text, out itCount))
            {
                itCount = 0;
            }
        }

        private void button_add_item_Click(object sender, RoutedEventArgs e)
        {
            InxNumber.IndexNumber += 1;
            Beverages AddBeverage = new Beverages();
            AddBeverage.ItemName = itName;
            AddBeverage.ItemCount = itCount;
            List.listView.Items.Add(AddBeverage);

            this.Close();
        }
    }
}
