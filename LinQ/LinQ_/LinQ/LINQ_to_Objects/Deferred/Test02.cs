using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//////////////////////////////////////////////////////

namespace Component.LINQ_to_Objects.Deferred
{
    /// <summary>
    /// Пример прямой и обратной сортировки.
    /// </summary>
    public static class Test02
    {
        [Component.Diagnostics.Att_TestLast(_year: 2020, _month: 10, _day: 05, _hour: 10, _minute: 21, _second: 0, _millisecond: 0)]
        public static void Do()
        {
            System.Console.WriteLine(typeof(Component.LINQ_to_Objects.Deferred.Test02).ToString());
            (new []
                {
                    new {Value_Int32=4,Value_String="str4"}
                    ,new{Value_Int32 = 4,Value_String = "str4" }
                }
            )
                .OrderBy(a => a.Value_Int32)
                .ThenBy(a => a.Value_String)
                //.OrderByDescending(a => a.p_Int32)
                .ToList().ForEach(a => System.Console.WriteLine(a))
            ;
        }
        
    }
}