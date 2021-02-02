using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Xml;
using System.Text;
using System.Threading.Tasks;

namespace Component.LINQ_to_XML
{
    public static class Test02
    {
        [Component.Diagnostics.Att_TestLast(_year: 2020, _month: 10, _day: 05, _hour: 10, _minute: 20, _second: 0, _millisecond: 0)]
        public static void Do()
        {
            System.Console.WriteLine(typeof(Component.LINQ_to_XML.Test02).ToString());
            System.Console.WriteLine("using System.Xml;");
            // Объявляю некоторые переменные, которые будут использоваться повторно.
            XmlElement xmlEmployee;//Employee
            XmlAttribute xmlEmployeeType; //EmployeeType
            XmlElement xmlFirstName;
            XmlElement xmlLastName;

            // Сначала я должен построить документ XML.
            XmlDocument xmlDoc = new XmlDocument();

            // Создаю корневой элемент и добавляю его в документ.
            XmlElement xmlEmployees = xmlDoc.CreateElement("Employees");
            xmlDoc.AppendChild(xmlEmployees);

            // Создаю список участников
            xmlEmployee = xmlDoc.CreateElement("Employee");
            xmlEmployeeType = xmlDoc.CreateAttribute("type");
            xmlEmployeeType.InnerText = "Programmer";
            xmlEmployee.Attributes.Append(xmlEmployeeType);
            xmlFirstName = xmlDoc.CreateElement("FirstName");
            xmlFirstName.InnerText = "Alex";
            xmlEmployee.AppendChild(xmlFirstName);
            xmlLastName = xmlDoc.CreateElement("LastName");
            xmlLastName.InnerText = "Erohin";
            xmlEmployee.AppendChild(xmlLastName);
            xmlEmployees.AppendChild(xmlEmployee);

            // Создаю еще одного участника
            xmlEmployee = xmlDoc.CreateElement("Employee");
            xmlEmployeeType = xmlDoc.CreateAttribute("type");
            xmlEmployeeType.InnerText = "Editor";
            xmlEmployee.Attributes.Append(xmlEmployeeType);
            xmlFirstName = xmlDoc.CreateElement("FirstName");
            xmlFirstName.InnerText = "Elena";
            xmlEmployee.AppendChild(xmlFirstName);
            xmlLastName = xmlDoc.CreateElement("LastName");
            xmlLastName.InnerText = "Volkova";
            xmlEmployee.AppendChild(xmlLastName);
            xmlEmployees.AppendChild(xmlEmployee);

            // Выводим на консоль
            xmlDoc.Save(Console.Out); System.Console.WriteLine("");

            //////////////////////////////////////////////////////////////
            System.Console.WriteLine("//////////////////////////////////////////////////////////////");
            System.Console.WriteLine("А теперь то же самое через");
            System.Console.WriteLine("using System.Xml.Linq;");
            System.Console.WriteLine(
                new XElement("Employees",
                    new XElement("Employee",
                        new XAttribute("type", "Programmer")
                        ,new XElement("FirstName", "Alex")
                        ,new XElement("LastName", "Erohin")
                    )
                    ,
                    new XElement("Employee"
                        ,new XAttribute("type", "Editor")
                        ,new XElement("FirstName", "Elena")
                        ,new XElement("LastName", "Volkova")
                    )
                )
            )
            ;
        }
    }
}
