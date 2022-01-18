using System;
using System.Windows;

namespace Lab12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ComboBox_Animal.ItemsSource = Enum.GetValues(typeof(Animal));
            ComboBox_Board.ItemsSource = Enum.GetValues(typeof(Board));
        }

        private void Button_Start_Click(object sender, RoutedEventArgs e)
        {
            new BoardWindow(
                (Animal)ComboBox_Animal.SelectedItem,
                (Board)ComboBox_Board.SelectedItem
            ).ShowDialog();
        }
    }
}
