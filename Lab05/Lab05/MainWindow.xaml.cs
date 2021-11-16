using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Lab05
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public string Sequence;
        public int numberOfKmers;

        public MainWindow()
        {
            InitializeComponent();
        }

        private int PatternCount(string Seq, string Pattern)
        {
            int count = 0;
            for (int i = 0; i < Seq.Length - Pattern.Length; i++)
            {
                if (Seq.Substring(i, Pattern.Length) == Pattern)
                {
                    count++;
                }
            }
            return count;
        }


        private void button_Load_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Select a sequence";
            if (open.ShowDialog() ?? true)
            {
                Sequence = System.IO.File.ReadAllText(open.FileName);
                Sequence = Regex.Replace(Sequence, @"\s+", "");
                textbox_Sequence.Document.Blocks.Clear();
                textbox_Sequence.Document.Blocks.Add(new Paragraph(new Run(Sequence)));
            }
        }

        private void button_Find_Click(object sender, RoutedEventArgs e)
        {
            numberOfKmers = Sequence.Length - 4 + 1;
            string Pattern;
            List<Tuple<string, int>> Patterns = new List<Tuple<string, int>>();
            for(int i = 0; i < Sequence.Length - 4; i++)
            {
                Pattern = Sequence.Substring(i, 4);
                Patterns.Add(new Tuple<string, int>(Pattern, PatternCount(Sequence, Pattern)));
            }

            Patterns = Patterns.Distinct().ToList();
            Patterns = Patterns.OrderByDescending(i => i.Item2).ToList();

            combobox_Choose.Items.Clear();
            foreach (Tuple<string, int> pattern in Patterns)
            {
                textbox_Found.Text += pattern.Item1 + " " + pattern.Item2 + "\n";
                combobox_Choose.Items.Add(pattern.Item1);
            }
        }

        private void combobox_Choose_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var start = textbox_Sequence.Document.ContentStart;
            var end = textbox_Sequence.Document.ContentEnd;
            new TextRange(start, end).ClearAllProperties();


            while (start.CompareTo(end) < 0)
            {
                var pattern = combobox_Choose.SelectedValue.ToString();
                var forwardIndex = start.GetTextInRun(LogicalDirection.Forward).IndexOf(pattern);
                if (forwardIndex >= 0)
                {
                    start = start.GetPositionAtOffset(forwardIndex);
                    if (start != null)
                    {
                        TextRange selection = new TextRange(start, start.GetPositionAtOffset(pattern.Length));
                        selection.ApplyPropertyValue(TextElement.BackgroundProperty, new SolidColorBrush(Colors.PaleVioletRed));
                    }
                }

                start = start.GetNextContextPosition(LogicalDirection.Forward);
            }
        }
    }
    
}
