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
            Books a = new Books();
            a.AddBook("NewAmazingBook", "Unnamed", "Player", 222, 1998);
            a.AddBook("Random Book", "Zero", "One", 5435, 2007);
            a.AddBook("The secret story", "Player", "1", 3, 2018);


            a.SaveToJSON(@"K:\\IBA\\Projects\\XML_JSON_Task\\XML_JSON_Task\\bin\\Debug\\a.json");
            Console.WriteLine("\nReading from JSON\n");
            a.ReadFromJSON(@"K:\\IBA\\Projects\\XML_JSON_Task\\XML_JSON_Task\\bin\\Debug\\a.json");
            a.SaveToXML(@"K:\\IBA\\Projects\\XML_JSON_Task\\XML_JSON_Task\\bin\\Debug\\a.xml");
            Console.WriteLine("\nReading from XML\n");
            a.ReadFromXML(@"K:\\IBA\\Projects\\XML_JSON_Task\\XML_JSON_Task\\bin\\Debug\\a.xml");
        }
    }
}
