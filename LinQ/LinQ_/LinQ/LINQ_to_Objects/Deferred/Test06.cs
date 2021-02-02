using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Component.LINQ_to_Objects.Deferred
{
    /// <summary>
    /// Как преобразовать двумерный массив в одномерный массив
    /// </summary>
    public static class Test06
    {
        [Component.Diagnostics.Att_TestLast(_year: 2020, _month: 10, _day: 05, _hour: 10, _minute: 20, _second: 0, _millisecond: 0)]
        public static void Do()
        {
            System.Console.WriteLine(typeof(Component.LINQ_to_Objects.Deferred.Test06).ToString());
            //Разница между Select и SelectMany
            var qwe = (new string[] { "Привет Петя", "Привет Вася", "Привет Кити" });
            qwe.Select((_Value, _Index) => new { Index = _Index, Value = _Value })
                .ToList().ForEach(a => System.Console.WriteLine(a));
            //SelectMany- позволяет массив массивов объединить в один
            qwe.SelectMany(p => p.ToArray())
                .ToList().ForEach(a => System.Console.WriteLine(a));
            ;
        }
    }
}