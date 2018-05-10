using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_JSON_Task
{
    class Books
    {
        List<Book> Book;

        Books()
        {
            Book = new List<Book>();
        }

        public void AddBook(string bookname, string fname, string lname, int pcount, int pyear)
        {
            Book.Add(new Book { Bookname = bookname, AFirstName = fname, ALastName = lname, PageCount = pcount, PublishYear = pcount });
        }

        public void SaveToXML(string path)
        {

        }

        public void ReadFromXML(string path)
        {

        }

        public void SaveToJSON(string path)
        {

        }

        public void ReadFromJSON(string path)
        {

        }
    }
}
