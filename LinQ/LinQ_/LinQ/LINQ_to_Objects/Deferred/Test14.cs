using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Component.LINQ_to_Objects.Deferred
{
    public static class Test14
    {
        [Component.Diagnostics.Att_TestLast(_year: 2020, _month: 10, _day: 05, _hour: 10, _minute: 20, _second: 0, _millisecond: 0)]
        public static void Do()
        {
            System.Console.WriteLine(typeof(Component.LINQ_to_Objects.Deferred.Test14).ToString());
            /////////////////////////////////////////////////////////////////////
            var _MyArray = new[]
            {
                new {Value = 'A'}
                ,new {Value = 'B'}
                ,new {Value = 'C'}
                ,new {Value = 'D'}
            };
            _MyArray.DefaultIfEmpty().ToList().ForEach(a => System.Console.WriteLine(a));
            //Второе применение DefaultIfEmpty с подсовыванием параметра
            _MyArray
                .Where(a=>a.Value=='q')
                .DefaultIfEmpty(new { Value = 'a' }).ToList().ForEach(a => System.Console.WriteLine(a));
            ;
            System.Console.WriteLine(_MyArray.Where(a => a.Value == 'q').DefaultIfEmpty(new { Value = 'a' }).First());
        }
    }
}
