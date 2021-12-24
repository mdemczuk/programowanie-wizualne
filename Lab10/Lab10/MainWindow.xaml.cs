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


namespace Lab10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    class Song
    {
        public string Name { get; set; }
        public string FilePath { get; set; }
    }

    public partial class MainWindow : Window
    {
        private MediaPlayer mediaPlayer = new MediaPlayer();

        public MainWindow()
        {
            string projectDir = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName;
            string songsDir = System.IO.Path.Combine(projectDir, "songs");

            InitializeComponent();
            ListBox_Songs.Items.Add(new Song { Name = "Song 1", FilePath = System.IO.Path.Combine(songsDir, "song1.mp3") });
            ListBox_Songs.Items.Add(new Song { Name = "Song 2", FilePath = System.IO.Path.Combine(songsDir, "song2.mp3") });
            ListBox_Songs.Items.Add(new Song { Name = "Song 3", FilePath = System.IO.Path.Combine(songsDir, "song3.mp3") });
            ListBox_Songs.Items.Add(new Song { Name = "The Best Song", FilePath = System.IO.Path.Combine(songsDir, "bestsong.mp3") });

            ListBox_Songs.Items.Refresh();
        }

        private void Button_Play_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Open(new Uri(((Song)ListBox_Songs.SelectedItem).FilePath));
            mediaPlayer.Play();
        }

        private void Button_Stop_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Stop();
        }
    }
}
