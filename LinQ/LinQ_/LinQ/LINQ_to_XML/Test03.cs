using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Xml;
using System.Text;
using System.Threading.Tasks;

namespace Component.LINQ_to_XML
{
    public static class Test03
    {
        [Component.Diagnostics.Att_TestLast(_year: 2020, _month: 10, _day: 05, _hour: 10, _minute: 20, _second: 0, _millisecond: 0)]
        public static void Do()
        {
            System.Console.WriteLine(typeof(Component.LINQ_to_XML.Test03).ToString());
            System.Console.WriteLine(new XElement("{http://www.professorweb.ru}" + "Employees"));
            ////////////////////////////////////////////////////////////////////////////////////
            System.Console.WriteLine("/////////////////////////////////////////////////////");
            System.Console.WriteLine(
                new XDocument(
                    new XElement("Employees",
                        // Добавляем пространство имен с префиксом
                        new XAttribute(XNamespace.Xmlns + "linq", (XNamespace )"http://www.professorweb.ru/LINQ"),
                        new XElement("Employee",
                            new XAttribute("type", "Programmer")
                            ,new XElement("FirstName", "Alex")
                            ,new XElement("LastName", "Erohin")
                        )
                        ,
                        new XElement("Employee",
                            new XAttribute("type", "Editor")
                            ,new XElement("FirstName", "Elena")
                            ,new XElement("LastName", "Volkova")
                        )
                    )
                )
            );

        }
    }
}
