using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Component.LINQ_to_Objects.Deferred
{
    /// <summary>
    /// Пример на ограничения результатов запроса
    /// </summary>
    public static class Test04
    {
        [Component.Diagnostics.Att_TestLast(_year: 2020, _month: 10, _day: 05, _hour: 10, _minute: 23, _second: 0, _millisecond: 1)]
        public static void Do()
        {
            System.Console.WriteLine(typeof(Component.LINQ_to_Objects.Deferred.Test04).ToString());
            //System.Console.WriteLine("Component.LINQ_to_Objects.Test01.Do();");
            (new string[] {
                    "Бавария"
                    , "Боруссия"
                    , "Реал Мадрид"
                    , "Манчестер Сити"
                    , "ПСЖ"
                    , "Барселона"
                })
                    .Where(t => t.ToUpper().StartsWith("Б"))
                    .OrderBy(t => t)
                    .ToList().ForEach(a => Console.WriteLine(a))
                ;
        }
    }
}
