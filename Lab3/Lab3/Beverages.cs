using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Beverages
    {
        private string itemName;
        private int itemCount;
        private int itemIndex = InxNumber.IndexNumber;
        public string ItemName 
        {
            get { return itemName; } 
            set { itemName = value; } 
        }

        public int ItemCount
        {
            get { return itemCount; }
            set { itemCount = value; }
        }

        public int ItemIndex
        {
            get { return itemIndex; }
            set { itemIndex = value; }
        }

    }
}

    
