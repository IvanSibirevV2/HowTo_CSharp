using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Component.LINQ_to_Objects.Deferred
{
    public static class Test12
    {
        [Component.Diagnostics.Att_TestLast(_year: 2020, _month: 10, _day: 05, _hour: 10, _minute: 20, _second: 0, _millisecond: 0)]
        public static void Do()
        {
            System.Console.WriteLine(typeof(Component.LINQ_to_Objects.Deferred.Test12).ToString());
            /////////////////////////////////////////////////////////////////////
            System.Console.WriteLine("Distinct");
            System.Console.WriteLine("Удаление одинаковых объектов");
            new[] { 1, 10, 5, 8, 5, 1, 12, 5, 9, 9, 2 }
                .Distinct().ToList().ForEach(a => System.Console.WriteLine(a))
            ;
            /////////////////////////////////////////////////////////////////////
            System.Console.WriteLine("/////////////////////////////////////////////////////////////////////");
            System.Console.WriteLine("Distinct");
            System.Console.WriteLine("По списку объектов");
            System.Console.WriteLine("Теперь то же самое но через наш компанатор");
            var _UserS = new LTC[] {
                new LTC{id=0, Value= 0}
                ,new LTC{id=0, Value= 0}
                ,new LTC{id=1,Value=0 }
                ,new LTC{id=1,Value=3 }
                ,new LTC{id=1,Value=5 }
                ,new LTC{id=2,Value=0 }
            }
            ;
            _UserS.Distinct().ToList().ForEach(a => System.Console.WriteLine(a.Get_Anonimys()));
            System.Console.WriteLine("Похоже что работает оно через хешкод");
            _UserS.Distinct(new LTC_EqualityComparer()).ToList().ForEach(a => System.Console.WriteLine(a.Get_Anonimys()));
        }
        /// <summary>LocalTestClass</summary>
        public class LTC
        {
            public System.Int32 id = 0;
            public System.Int32 Value = 0;
            public dynamic Get_Anonimys() => new { id = this.id, Value = this.Value };
        }
        public class LTC_EqualityComparer : IEqualityComparer<LTC>
        {
            public bool Equals(LTC x, LTC y) => (x.id == y.id) && (x.Value == y.Value);
            public int GetHashCode(LTC obj) => obj.GetHashCode();
        }
    }
}
