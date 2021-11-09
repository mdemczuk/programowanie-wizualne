using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
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
        public int RotateValue = 0;
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
            RotateValue += 90;
            RotateTransform rotateTransform = new RotateTransform(RotateValue);
            imgPhoto.RenderTransform = rotateTransform;

        }

        private void optionC_Click(object sender, RoutedEventArgs e)
        {
            var dObject = new DataObject(DataFormats.Bitmap, imgPhoto.Source, true);
            var bitmap = dObject.GetData("System.Drawing.Bitmap") as System.Drawing.Bitmap;

            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    System.Drawing.Color getColor = bitmap.GetPixel(x, y);
                    if((getColor.R < 50) && (getColor.G < 150) && (getColor.B < 50))
                    {
                        System.Drawing.Color whiteColor = System.Drawing.Color.White;
                        bitmap.SetPixel(x, y, whiteColor);
                    } 
                }
            }

            MemoryStream mStream = new MemoryStream();
            ((System.Drawing.Bitmap)bitmap).Save(mStream, System.Drawing.Imaging.ImageFormat.Bmp);
            BitmapImage bImage = new BitmapImage();
            bImage.BeginInit();
            mStream.Seek(0, SeekOrigin.Begin);
            bImage.StreamSource = mStream;
            bImage.EndInit();

            imgPhoto.Source = bImage;
        }

        private void optionD_Click(object sender, RoutedEventArgs e)
        {
            var dObject = new DataObject(DataFormats.Bitmap, imgPhoto.Source, true);
            var bitmap = dObject.GetData("System.Drawing.Bitmap") as System.Drawing.Bitmap;

            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    System.Drawing.Color neg = bitmap.GetPixel(x, y);
                    neg = System.Drawing.Color.FromArgb(255, (255 - neg.R), (255 - neg.G), (255 - neg.B));
                    bitmap.SetPixel(x, y, neg);
                }
            }

            MemoryStream mStream = new MemoryStream();
            ((System.Drawing.Bitmap)bitmap).Save(mStream, System.Drawing.Imaging.ImageFormat.Bmp);
            BitmapImage bImage = new BitmapImage();
            bImage.BeginInit();
            mStream.Seek(0, SeekOrigin.Begin);
            bImage.StreamSource = mStream;
            bImage.EndInit();

            imgPhoto.Source = bImage;
        }
    }
}
