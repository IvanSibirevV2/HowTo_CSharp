using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Component.LINQ_to_Objects.Deferred
{
    public static class Test15
    {
        [Component.Diagnostics.Att_TestLast(_year: 2020, _month: 10, _day: 05, _hour: 10, _minute: 20, _second: 0, _millisecond: 0)]
        public static void Do()
        {
            System.Console.WriteLine(typeof(Component.LINQ_to_Objects.Deferred.Test15).ToString());
            /////////////////////////////////////////////////////////////////////
            Enumerable.Range(1, 100).ToList().ForEach(a=>System.Console.Write("<"+a+">"));
            Enumerable.Repeat(new { Value="Привет мир"},6).ToList().ForEach(a => System.Console.WriteLine(a));
            System.Console.WriteLine("Enumerable.Empty<System.String>().Count=" + Enumerable.Empty<System.String>().Count().ToString());
        }
    }
}
