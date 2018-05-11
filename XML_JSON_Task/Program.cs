using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_JSON_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            BooksWorker a = new BooksWorker();
            a.AddBook("NewAmazingBook", "Unnamed", "Player", 222, 1998);
            a.AddBook("Random Book", "Zero", "One", 5435, 2007);
            a.AddBook("The secret story", "Player", "1", 3, 2018);


            a.SaveToJSON(AppDomain.CurrentDomain.BaseDirectory + "a.json");
            Console.WriteLine("\nReading from JSON\n");
            a.ReadFromJSON(AppDomain.CurrentDomain.BaseDirectory + "a.json");
            a.SaveToXML(AppDomain.CurrentDomain.BaseDirectory + "a.xml");
            Console.WriteLine("\nReading from XML\n");
            a.ReadFromXML(AppDomain.CurrentDomain.BaseDirectory + "a.xml");
        }
    }
}
