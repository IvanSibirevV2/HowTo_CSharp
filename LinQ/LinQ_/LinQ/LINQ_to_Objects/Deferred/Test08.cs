using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Component.LINQ_to_Objects.Deferred
{
    /// <summary>
    /// Ещё один пример на сортировку массивов
    /// </summary>
    public static class Test08
    {
        [Component.Diagnostics.Att_TestLast(_year: 2020, _month: 10, _day: 05, _hour: 10, _minute: 20, _second: 0, _millisecond: 0)]
        public static void Do()
        {
            System.Console.WriteLine(typeof(Component.LINQ_to_Objects.Deferred.Test08).ToString());
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
            //сОРТИРОВАКА ПО АЛФАФИТУ
            _qwe.OrderBy(a => a)
                .ToList().ForEach(a => System.Console.WriteLine(a))
            ;
            System.Console.WriteLine("");
            //Сортировка по длинне текста
            _qwe.OrderBy(a => a.Length)
                .ToList().ForEach(a => System.Console.WriteLine(a))
            ;
            System.Console.WriteLine("");
            //Обратная сортировка
            _qwe.OrderByDescending(a => a.Length)
                .ToList().ForEach(a => System.Console.WriteLine(a))
            ;
            System.Console.WriteLine("");
            //Если залезть в интроспкцию, то тогда там увидете что можно подсовывать свой интерфейс ICompaer
            //Реализуйте свой брутальный сортировщик...
            //Обратная сортировка
            //Чтобы сделать чепочку сортировок для второго и третьего используются ThenBy
            //Работает как сортировка внутри соритровку
            //ТО есть внутри однотипной сортировки по одному парамеру можно ещё и дополнительно отсортировать и по другому парамтру
            //Как-то так/ наверное.
        }
    }
}