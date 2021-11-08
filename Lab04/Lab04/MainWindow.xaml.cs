using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
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


namespace Lab04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        public int ScaleXVal = -1;
        private void upload_button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            open.Title = "Select a picture";
            if (open.ShowDialog() ?? true)
            {
                imgPhoto.Source = new BitmapImage(new Uri(open.FileName, UriKind.RelativeOrAbsolute));
            }
        }

        private void optionA_Click(object sender, RoutedEventArgs e)
        {

            imgPhoto.RenderTransformOrigin = new System.Windows.Point(0.5, 0.5);
            ScaleTransform flipTrans = new ScaleTransform();
            if (ScaleXVal == -1)
            {
                flipTrans.ScaleX = -1;
                ScaleXVal = 1;
            }
            else
            {
                flipTrans.ScaleX = 1;
                ScaleXVal = -1;
            }
            imgPhoto.RenderTransform = flipTrans;
        }

        private void optionB_Click(object sender, RoutedEventArgs e)
        {
            TransformedBitmap transformBmp = new TransformedBitmap();
            transformBmp.BeginInit();

        }
    }
}
