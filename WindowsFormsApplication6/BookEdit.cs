using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication6
{
    public class BookEdit
    {
        public BookEdit()
        {
        }

        private int _ISBN;
        public int ISBN
        {
            get { return _ISBN; }
            set { _ISBN = value; }
        }

        private string _bookName;
        public string BookName
        {
            get { return _bookName; }
            set { _bookName = value; }
        }

        private string _author;
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        private int _year;
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        private int _language;
        public int Language
        {
            get { return _language; }
            set { _language = value; }
        }

        private int _category;
        public int Category
        {
            get { return _category; }
            set { _category = value; }
        }

        private int _quantity;
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public override string ToString()
        {
            return ISBN.ToString();
        }
    }
}
