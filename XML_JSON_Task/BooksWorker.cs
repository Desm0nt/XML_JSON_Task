using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML_JSON_Task
{
    public class BooksWorker
    {
        List<Book> Book;

        public BooksWorker()
        {
            Book = new List<Book>();
        }

        public void AddBook(string bookname, string fname, string lname, int pcount, int pyear)
        {
            Book.Add(new Book { Bookname = bookname, AFirstName = fname, ALastName = lname, PageCount = pcount, PublishYear = pcount });
        }

        public void SaveToXML(string path)
        {
            using (XmlWriter writer = XmlWriter.Create(path, new XmlWriterSettings() { Indent = true }))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("books");
                foreach (var b in Book)
                {
                    writer.WriteStartElement("book");
                    writer.WriteAttributeString("bookname", b.Bookname);
                    writer.WriteStartElement("bookinfo");
                    writer.WriteElementString("afirstname", b.AFirstName);
                    writer.WriteElementString("alastname", b.ALastName);
                    writer.WriteElementString("pagecount", b.PageCount.ToString());
                    writer.WriteElementString("publishyear", b.PublishYear.ToString());
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.Flush();
                writer.WriteEndDocument();
            }
        }

        public void ReadFromXML(string path)
        {
            XmlDocument xdc = new XmlDocument();
            xdc.Load(path);
            XmlNodeList xnlNodes = xdc.GetElementsByTagName("book");

            foreach (XmlNode xnlNode in xnlNodes)
            {
                XmlElement element = (XmlElement)xnlNode;

                string Bookname = Convert.ToString(xnlNode.Attributes["bookname"].Value);
                string AFirstName = element.GetElementsByTagName("afirstname")[0].ChildNodes[0].InnerText;
                string ALastName = element.GetElementsByTagName("alastname")[0].ChildNodes[0].InnerText;
                string PageCount = element.GetElementsByTagName("pagecount")[0].ChildNodes[0].InnerText;
                string PublishYear = element.GetElementsByTagName("publishyear")[0].ChildNodes[0].InnerText;
                Console.WriteLine("Book's name: " + Bookname + "\nAuthor: " + AFirstName + " " + ALastName + "\nPage count: " + PageCount + "\nPublish year: " + PublishYear + "\n");
            }

            Console.Read();
        }

        public void SaveToJSON(string path)
        {
            string json = JsonConvert.SerializeObject(Book, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(path, json);      
        }

        public void ReadFromJSON(string path)
        {
            string json = File.ReadAllText(path);
            List<Book> rBook = JsonConvert.DeserializeObject<List<Book>>(json);
            foreach (var b in rBook)
            {
                string Bookname = b.Bookname;
                string AFirstName = b.AFirstName;
                string ALastName = b.ALastName;
                string PageCount = b.PageCount.ToString();
                string PublishYear = b.PublishYear.ToString();
                Console.WriteLine("Book's name: " + Bookname + "\nAuthor: " + AFirstName + " " + ALastName + "\nPage count: " + PageCount + "\nPublish year: " + PublishYear + "\n");
            }

        }
    }
}
