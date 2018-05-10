using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML_JSON_Task
{
    public class Books
    {
        List<Book> Book;

        public Books()
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
            string Data = File.ReadAllText(path);
            using (StringReader stringReader = new StringReader(Data))
            {
                using (XmlReader xmlReader = XmlReader.Create(stringReader,
                    new XmlReaderSettings() { IgnoreWhitespace = true }))
                {
                    xmlReader.MoveToContent();
                    xmlReader.ReadStartElement("Books");

                    string Bookname = xmlReader.GetAttribute("Bookname");

                    Console.WriteLine("Book: {0} ", Bookname);
                    xmlReader.ReadStartElement("Book");

                    Console.WriteLine("Bookinfo");

                    while (xmlReader.Read())
                    {
                        if (xmlReader.IsStartElement())
                        {
                            //return only when you have START tag
                            switch (xmlReader.Name.ToString())
                            {
                                case "AFirstName":
                                    Console.WriteLine("Name of the Element is : " + xmlReader.ReadString());
                                    break;
                                case "ALastName":
                                    Console.WriteLine("Your Location is : " + xmlReader.ReadString());
                                    break;
                                case "PageCount":
                                    Console.WriteLine("Your Locatiodsdsn is : " + xmlReader.ReadString());
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("________________");
                        }
                    }
                    //string AFname = xmlReader.ReadString();
                    //string ALname = xmlReader.ReadString();

                    //Console.WriteLine("Email address: {0}", AFname);
                }
            }
            //    using (XmlReader reader = XmlReader.Create(path))
            //    {
            //        while (reader.Read())
            //        {
            //            if (reader.IsStartElement())

            //            {
            //                //return only when you have START tag
            //                switch (reader.Name.ToString())
            //                {
            //                    case "Name":
            //                        Console.WriteLine("Name of the Element is : " + reader.ReadString());
            //                        break;
            //                    case "Location":
            //                        Console.WriteLine("Your Location is : " + reader.ReadString());
            //                        break;
            //                }
            //            }
            //            Console.WriteLine("");

            //        }
            //    }
            Console.Read();
        }

        public void SaveToJSON(string path)
        {

        }

        public void ReadFromJSON(string path)
        {

        }
    }
}
