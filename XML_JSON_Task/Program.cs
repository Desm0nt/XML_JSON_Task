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
            a.ReadFromXML(@"e:\\IBA\\Projects\\XML_JSON_Task\\XML_JSON_Task\\bin\\Debug\\a.xml");
        }
    }
}
