using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Component.LINQ_to_XML
{
    public static class Test00
    {
        [Component.Diagnostics.Att_TestLast(_year: 2020, _month: 10, _day: 05, _hour: 10, _minute: 20, _second: 0, _millisecond: 0)]
        public static void Do()
        {
            System.Console.WriteLine(typeof(Component.LINQ_to_XML.Test00).ToString());
#pragma warning disable CS0162
            if (!true) Component.LINQ_to_XML.Test01.Do();
            else if (!true) Component.LINQ_to_XML.Test02.Do();
            else if (!true) Component.LINQ_to_XML.Test03.Do();
            else if (!true) Component.LINQ_to_XML.Test04.Do();
#pragma warning restore CS0162
        }
    }
}
