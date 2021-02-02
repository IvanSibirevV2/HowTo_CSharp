using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Component.LINQ_to_Objects.Deferred
{
    /// <summary>
    /// Пример, группировка массивов по указанному параметру ананимного типа
    /// </summary>
    public static class Test11
    {
        [Component.Diagnostics.Att_TestLast(_year: 2020, _month: 10, _day: 05, _hour: 10, _minute: 20, _second: 0, _millisecond: 0)]
        public static void Do()
        {
            System.Console.WriteLine(typeof(Component.LINQ_to_Objects.Deferred.Test11).ToString());
            
            var _UserS = new LTC[] {
                new LTC{id=0, Value= 0}
                ,new LTC{id=1,Value=0 }
                ,new LTC{id=1,Value=3 }
                ,new LTC{id=1,Value=5 }
                ,new LTC{id=2,Value=0 }
            }
            ;
            /////////////////////////////////////////////////////////////////////
            //Создает список из контейнеров группировок
            _UserS
                //.GroupBy(a => a.p_id)
                .GroupBy(a => a.id)
                .ToList().ForEach(a =>{a.ToList().ForEach(b => System.Console.WriteLine(b.Get_Anonimys()));System.Console.WriteLine("");})
            ;
            /////////////////////////////////////////////////////////////////////
            System.Console.WriteLine("/////////////////////////////////////////////////////////////////////");
            System.Console.WriteLine("Группировка согласно нашему механизму сравнения объектов");
            _UserS.GroupBy(a => a, new LTC_EqualityComparer())
                .ToList().ForEach(a => { a.ToList().ForEach(b => System.Console.WriteLine(b.Get_Anonimys())); System.Console.WriteLine(""); })
            ;
            /////////////////////////////////////////////////////////////////////
            //Там куча типизированных и смешанных группировок , в общем смотрите сами...
            System.Console.WriteLine("/////////////////////////////////////////////////////////////////////");
            System.Console.WriteLine("Группировка с лямбдой формирования новой последовательности");
            _UserS.GroupBy(a => a, a=> new { Value = a.Value })
                .ToList().ForEach(a => { a.ToList().ForEach(b => System.Console.WriteLine(b)); System.Console.WriteLine(""); })
            ;
            System.Console.WriteLine("/////////////////////////////////////////////////////////////////////");
            System.Console.WriteLine("Группировка с лямбдой формирования новой последовательности и нашем компоратором");
            _UserS.GroupBy(a => a, a => a, new LTC_EqualityComparer())
                .ToList().ForEach(a => { a.ToList().ForEach(b => System.Console.WriteLine(b.Get_Anonimys())); System.Console.WriteLine(""); })
            ;
        }
        /// <summary>LocalTestClass</summary>
        public class LTC
        {
            public System.Int32 id = 0;
            public System.Int32 Value = 0;
            public dynamic Get_Anonimys()=>new { id = this.id,Value =this.Value};
        }
        public class LTC_EqualityComparer : IEqualityComparer<LTC>
        {
            public bool Equals(LTC x, LTC y) =>(x.id==y.id)&&(x.Value==y.Value);
            public int GetHashCode(LTC obj) => obj.GetHashCode();
        }
    }
}
