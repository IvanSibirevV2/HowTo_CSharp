using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Component.LINQ_to_Objects.Deferred
{
    /// <summary>
    /// Примеры программных кодов на анонимные типы
    /// https://metanit.com/sharp/tutorial/3.20.php
    /// </summary>
    public static class Test01
    {
        [Component.Diagnostics.Att_TestLast(_year: 2020, _month: 10, _day: 05, _hour: 10, _minute: 20, _second: 0, _millisecond: 0)]
        public static void Do()
        {
            System.Console.WriteLine(typeof(Component.LINQ_to_Objects.Deferred.Test01).ToString());
            ///О том как создать ананимный класс
            ///Анонимные тины обладают только полями дл чтения
            var mySpouse = new {
                FirstName = "Alex"
                , LastName = "Erohin"
            };
            System.Console.WriteLine(mySpouse);
            //Среда позволяет по аналогии создавать анонимные массивы анонимных типов
            (new[]
            {
                new {Name="Tom",age=80},
                new {Name="Bob",age=14}
            })
                .ToList().ForEach(a=>System.Console.WriteLine(a))
            ;
        }
    }
}