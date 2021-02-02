using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Component.LINQ_to_Objects.Deferred
{
    /// <summary>
    /// Прмер, два способа объединения списков
    /// </summary>
    public static class Test09
    {
        [Component.Diagnostics.Att_TestLast(_year: 2020, _month: 10, _day: 05, _hour: 10, _minute: 20, _second: 0, _millisecond: 0)]
        public static void Do()
        {
            System.Console.WriteLine(typeof(Component.LINQ_to_Objects.Deferred.Test09).ToString());
            var _qwe = (new string[]{
                "Alfa Romeo"
                , "Aston Martin"
                , "Audi"
                , "Nissan"
                , "Chevrolet"
                ,  "Chrysler"
                , "Dodge"
                , "BMW"
                , "Ferrari"
                ,"Bentley"
                , "Ford"
                , "Lexus"
                , "Mercedes"
                , "Toyota"
                , "Volvo"
                , "Subaru"
                , "Жигули :)"
            })
            ;
            //Первый способ объединения списков
            _qwe.Take(5).Concat(_qwe.Skip(5))
                .ToList().ForEach(a => System.Console.WriteLine(a))
            ;
            System.Console.WriteLine("");
            //Второй способ объединения списков
            new[] {
                _qwe.Take(5)
                , _qwe.Skip(5)
            }
                .SelectMany(s => s)
                .ToList().ForEach(a => System.Console.WriteLine(a))
            ;
            System.Console.WriteLine("");
        }
    }
}
