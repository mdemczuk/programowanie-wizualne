using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace Lab12
{
    public enum Animal
    {
        Mouse,
        Fish,
        Cat,
        Coccodrillo
    }

    public enum Board
    {
        Easy = 3,
        Medium,
        Hard
    }

    /// <summary>
    /// Interaction logic for PlanszaWindow.xaml
    /// </summary>
    public partial class BoardWindow : Window
    {
        DispatcherTimer timer;
        private Animal animal;

        public BoardWindow(Animal _animal, Board _board)
        {
            InitializeComponent();

            animal = _animal;

            var sizeOfBoard = (int)_board;
            var position = new Random().Next(0, sizeOfBoard * sizeOfBoard);

            for (var i = 0; i < sizeOfBoard; i++)
            {
                Grid_Board.ColumnDefinitions.Add(new ColumnDefinition());
                Grid_Board.RowDefinitions.Add(new RowDefinition());
                for (var j = 0; j < sizeOfBoard; j++)
                {
                    var button = new Button();
                    button.SetValue(Grid.ColumnProperty, i);
                    button.SetValue(Grid.RowProperty, j);
                    button.Tag = i * sizeOfBoard + j == position ? true : false;
                    button.Click += Button_Click;
                    Grid_Board.Children.Add(button);
                }
            }

            timer = new DispatcherTimer();
            timer.Tick += new EventHandler(Handler_OutOfTime);
            timer.Interval = new TimeSpan(0, 0, 3);
            timer.Start();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            Grid_Board.Children.Remove(button);
            if ((bool)button.Tag == true)
            {
                timer.Stop();

                var bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                string projectDir = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName;
                bitmapImage.UriSource = new Uri(System.IO.Path.Combine(projectDir, animal.ToString() + ".jpg"));
                bitmapImage.EndInit();

                var image = new Image();
                image.Source = bitmapImage;
                image.SetValue(Grid.ColumnProperty, button.GetValue(Grid.ColumnProperty));
                image.SetValue(Grid.RowProperty, button.GetValue(Grid.RowProperty));
                Grid_Board.Children.Add(image);

                new ResultWindow(animal, Reason.Win).ShowDialog();
                Close();
            }
        }

        private void Handler_OutOfTime(object sender, EventArgs e)
        {
            timer.Stop();
            new ResultWindow(animal, Reason.OutOfTime).ShowDialog();
            Close();
        }
    }
}
