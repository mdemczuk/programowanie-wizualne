using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    public class Books
    {
        public static int BookGlobalID = 1;
        private int bookID, borrowerID;
        private string bookTitle, bookAuthor;

        public int BookID
        {
            get { return bookID; }
            set { bookID = value; }
        }
        public int BorrowerID
        {
            get { return borrowerID; }
            set { borrowerID = value; }
        }
        public string BookTitle
        {
            get { return bookTitle; }
            set { bookTitle = value; }
        }

        public string BookAuthor
        {
            get { return bookAuthor; }
            set { bookAuthor = value; }
        }
    }
}