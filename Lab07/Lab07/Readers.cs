using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    public class Readers
    {
        public static int ReaderGlobalID = 1;
        private int readerID;
        private string readerName, readerSurname;

        public int ReaderID
        {
            get { return readerID; }
            set { readerID = value; }
        }
        public string ReaderName
        {
            get { return readerName; }
            set { readerName = value; }
        }

        public string ReaderSurname
        {
            get { return readerSurname; }
            set { readerSurname = value; }
        }

    }
}
