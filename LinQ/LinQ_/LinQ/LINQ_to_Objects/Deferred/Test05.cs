using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Component.LINQ_to_Objects.Deferred
{
    /// <summary>
    /// Пример на тему использования анонимных типов в вопросах векторной типизации массивов.
    /// </summary>
    public static class Test05
    {
        [Component.Diagnostics.Att_TestLast(_year: 2020, _month: 10, _day: 05, _hour: 10, _minute: 20, _second: 0, _millisecond: 0)]
        public static void Do()
        {
            System.Console.WriteLine(typeof(Component.LINQ_to_Objects.Deferred.Test05).ToString());

            var qwe = (new string[] { "Привет Петя", "Привет Вася", "Привет Кити" });
            qwe.ToList().ForEach(a => System.Console.WriteLine(a));
            //Использование анонимных типов в Select
            qwe.Select(_Value => new {Value= _Value, Length = _Value.Length })
                .ToList().ForEach(a => System.Console.WriteLine(a));
            //Использование индексированного Select и анонимных типов
            qwe.Select((_Value, _Index) => new { Index = _Index, Value = _Value })
                .ToList().ForEach(a => System.Console.WriteLine(a));
            //Использование индексированного Select
            //SelectMany
        }
    }
}