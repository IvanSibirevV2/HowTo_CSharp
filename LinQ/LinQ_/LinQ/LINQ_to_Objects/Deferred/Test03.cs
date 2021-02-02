using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Component.LINQ_to_Objects.Deferred
{
    /// <summary>
    /// Пример на тему векторной типизацияи массивов.
    /// </summary>
    public static class Test03
    {
        [Component.Diagnostics.Att_TestLast(_year: 2020, _month: 10, _day: 05, _hour: 10, _minute: 23, _second: 0, _millisecond: 0)]
        public static void Do()
        {
            System.Console.WriteLine(typeof(Component.LINQ_to_Objects.Deferred.Test03).ToString());
            (new string[] { "40", "2012", "176", "5" })
                .Select(s => Int32.Parse(s))
                //Приведение всего массива к типу
                .Cast<System.Object>().Cast<System.Int32>()
                //Или тоже самое
                .OfType<System.Object>().OfType<System.Int32>()
                //Отличае только в том что OfType работает с унаследованием от коллекции а Каст нет
                //Как пишут OfType  обрезает коллекцию в тех случаях когда не может привести к типу
                //А Cast генерит исключение
                .Select(s => s + 1).ToArray()
                .ToList().ForEach(a => Console.Write(a + " "))
            ;
        }
    }
}
