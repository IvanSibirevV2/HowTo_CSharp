using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Component.LINQ_to_Objects.Deferred
{
    /// <summary>
    /// Пример Join (Декартово произведение массивов).
    /// Пример GroupJoin (Объединение таблиц по аналогии с SQL)
    /// </summary>
    public static class Test10
    {
        [Component.Diagnostics.Att_TestLast(_year: 2020, _month: 10, _day: 05, _hour: 10, _minute: 20, _second: 0, _millisecond: 0)]
        public static void Do()
        {
            System.Console.WriteLine(typeof(Component.LINQ_to_Objects.Deferred.Test10).ToString());
            var _UserS = new[] {
                new {id=0,Login="000" }
                , new {id=0,Login="000" }
                , new {id=1,Login="Tarli" }
                , new {id=2,Login="Sam" }
                , new {id=3,Login="Kent"}
                , new {id=4,Login="Tirrel"}
            }
            ;
            var _TelephoneS = new[] {
                new {User_id=0,Number="0-000-000-00-00"}
                , new {User_id=0,Number="0-000-000-00-00"}
                , new {User_id=1,Number="8-088-888-88-01"}
                , new {User_id=2,Number="8-808-888-88-02"}
                , new {User_id=3,Number="8-880-888-88-03"}
                , new {User_id=4,Number="8-888-088-88-04"}
            }
            ;
            /////////////////////////////////////////////////////////////////////
            //Как видете там декартово произведение записей...
            
            _UserS
                .Join(_TelephoneS
                    , __UserS => __UserS.id //Первичный ключ одной таблици
                    , __TelephoneS => __TelephoneS.User_id //Вторичный ключ другой таблици
                    , (__UserS, __TelephoneS) => new{id = __UserS.id,Login = __UserS.Login, Number = __TelephoneS.Number}
                )
                .ToList().ForEach(a=>System.Console.WriteLine(a))
            ;
            System.Console.WriteLine("");
            /////////////////////////////////////////////////////////////////////
            //Посмотрите __TelephoneS - выступает как массив для группировки, по этому заюзать можете сами
            _UserS
                .GroupJoin(_TelephoneS
                    , __UserS => __UserS.id //Первичный ключ одной таблици
                    , __TelephoneS => __TelephoneS.User_id //Вторичный ключ другой таблици
                    , (__UserS, __TelephoneS) => new { id = __UserS.id, Login = __UserS.Login, options = __TelephoneS.ToList()[0].Number }
                )
                .ToList().ForEach(a => System.Console.WriteLine(a))
            ;
            System.Console.WriteLine("");
            /////////////////////////////////////////////////////////////////////
        }
    }
}
