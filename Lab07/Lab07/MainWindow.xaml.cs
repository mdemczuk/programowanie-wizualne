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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab07
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Readers> ReadersList = new List<Readers>();
        public List<Books> BooksList = new List<Books>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_borrow_Click(object sender, RoutedEventArgs e)
        {
            foreach (var Book in BooksListview.SelectedItems)
            {
                ((Books)Book).BorrowerID = ((Readers)ReadersListview.SelectedItem).ReaderID;
            }

            BooksListview.Items.Refresh();
        }

        private void button_return_Click(object sender, RoutedEventArgs e)
        {
            foreach (var Book in BooksListview.SelectedItems)
            {
                ((Books)Book).BorrowerID = 0;
            }
            BooksListview.Items.Refresh();

        }

        private void button_addReader_Click(object sender, RoutedEventArgs e)
        {
            addReader newReader = new addReader();
            newReader.ShowDialog();

            Readers Reader = new Readers
            {
                ReaderID = Readers.ReaderGlobalID++,
                ReaderName = newReader.textboxName.Text,
                ReaderSurname = newReader.textboxSurname.Text
            };

            ReadersList.Add(Reader);
            ReadersListview.Items.Add(Reader);
            ReadersListview.Items.Refresh();
        }

        private void button_addBook_Click(object sender, RoutedEventArgs e)
        {
            addBook newBook = new addBook();
            newBook.ShowDialog();

            Books Book = new Books
            {
                BookID = Books.BookGlobalID++,
                BookTitle = newBook.textboxTitle.Text,
                BookAuthor = newBook.textboxAuthor.Text,
                BorrowerID = 0
            };

            BooksList.Add(Book);
            BooksListview.Items.Add(Book);
            BooksListview.Items.Refresh();
        }
    }
}
