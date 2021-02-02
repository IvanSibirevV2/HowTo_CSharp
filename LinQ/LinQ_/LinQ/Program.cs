using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Linq;

namespace Component
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(typeof(Component.Program).ToString());
            ///////////////////////////////////////////
            Component.Diagnostics.TestLast.Do();
            ///////////////////////////////////////////
            System.Console.ReadLine();
        }
    }
}