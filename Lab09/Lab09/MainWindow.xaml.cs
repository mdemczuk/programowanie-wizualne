using System.IO;
using System.Windows;
using System.Windows.Forms;
using System.Xaml;
using System.Xml.Serialization;
using MessageBox = System.Windows.Forms.MessageBox;
using OpenFileDialog = Microsoft.Win32.OpenFileDialog;
using SaveFileDialog = Microsoft.Win32.SaveFileDialog;

namespace Lab09
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            DialogResult openingWindow = MessageBox.Show("Do you want to open previously written data?", "Open data", MessageBoxButtons.YesNo);
            if (openingWindow == System.Windows.Forms.DialogResult.Yes)
            {
                var openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() ?? true)
                {
                    using (var streamReader = new StreamReader(openFileDialog.FileName))
                    {
                        var data = (string[])XamlServices.Load(openFileDialog.FileName);
                            textbox_Uczelnia.Text = data[0];
                            textbox_Kierunek.Text = data[1];
                            textbox_Zakres.Text = data[2];
                            textbox_Profil.Text = data[3];
                            textbox_Forma.Text = data[4];
                            textbox_Poziom.Text = data[5];
                            textbox_Student1Imie.Text = data[6];
                            textbox_Student1Album.Text = data[7];
                            textbox_Student1Data.Text = data[8];
                            textbox_Student2Imie.Text = data[9];
                            textbox_Student2Album.Text = data[10];
                            textbox_Student2Data.Text = data[11];
                            textbox_Student3Imie.Text = data[12];
                            textbox_Student3Album.Text = data[13];
                            textbox_Student3Data.Text = data[14];
                            textbox_Student4Imie.Text = data[15];
                            textbox_Student4Album.Text = data[16];
                            textbox_Student4Data.Text = data[17];
                            textbox_Tytul.Text = data[18];
                            textbox_TytulAng.Text = data[19];
                            textbox_Dane.Text = data[20];
                            textbox_ZakresPracy.Text = data[21];
                            textbox_Termin.Text = data[22];
                            textbox_Promotor.Text = data[23];
                            textbox_Jednostka.Text = data[24];

                    }
                }
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DialogResult closingWindow = MessageBox.Show("Do you want to save your data?", "Save data", MessageBoxButtons.YesNo);
            if (closingWindow == System.Windows.Forms.DialogResult.Yes)
            {
                var saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() ?? true)
                {
                        XamlServices.Save(saveFileDialog.FileName, new string[]
                        {
                            textbox_Uczelnia.Text,
                            textbox_Kierunek.Text,
                            textbox_Zakres.Text,
                            textbox_Profil.Text,
                            textbox_Forma.Text,
                            textbox_Poziom.Text,
                            textbox_Student1Imie.Text,
                            textbox_Student1Album.Text,
                            textbox_Student1Data.Text,
                            textbox_Student2Imie.Text,
                            textbox_Student2Album.Text,
                            textbox_Student2Data.Text,
                            textbox_Student3Imie.Text,
                            textbox_Student3Album.Text,
                            textbox_Student3Data.Text,
                            textbox_Student4Imie.Text,
                            textbox_Student4Album.Text,
                            textbox_Student4Data.Text,
                            textbox_Tytul.Text,
                            textbox_TytulAng.Text,
                            textbox_Dane.Text,
                            textbox_ZakresPracy.Text,
                            textbox_Termin.Text,
                            textbox_Promotor.Text,
                            textbox_Jednostka.Text,
                        });
                }
            }
        }
    }
}
