using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Component.LINQ_to_Objects.Deferred
{
    /// <summary>
    /// Пример, аналония с обработкой System.String, но только с массивами
    /// </summary>
    public static class Test07
    {
        [Component.Diagnostics.Att_TestLast(_year: 2020, _month: 10, _day: 05, _hour: 10, _minute: 20, _second: 0, _millisecond: 0)]
        public static void Do()
        {
            
            System.Console.WriteLine(typeof(Component.LINQ_to_Objects.Deferred.Test07).ToString());
            var _qwe = (new string[] {
                "Nissan"
                , "Chevrolet"
                , "Aston Martin"                
                , "Alfa Romeo"
                , "Chrysler"
                , "Dodge"
                , "BMW"
                , "Ferrari"
                , "Audi"
                , "Bentley"
                , "Ford"
                , "Lexus"
                , "Mercedes"
                , "Toyota"
                , "Volvo"
                , "Subaru"
                , "Жигули :)"
            })
            ;
            //Изымаем первые 5 элементов
            _qwe.Take(5).ToList().ForEach(a=> System.Console.WriteLine(a));
            System.Console.WriteLine("");
            //Копирует элементы пока условие выполняется, 
            //И не влият если что останется в хвосте, всеравно не войдет
            _qwe.TakeWhile(s => s.Length < 10).ToList()
                .ForEach(a => System.Console.WriteLine(a))
            ;
            System.Console.WriteLine("");
            //Пропустить первые 5 элементов
            _qwe.Skip(5).ToList()
                .ForEach(a => System.Console.WriteLine(a))
            ;
            System.Console.WriteLine("--------");
            //Пропускать элементы пока условие выполняется...
            _qwe.SkipWhile(s => !s.StartsWith("A")).ToList()
                .ForEach(a => System.Console.WriteLine(a))
            ;
            System.Console.WriteLine("");
            //
        }
    }
}