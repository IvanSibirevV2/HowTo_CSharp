using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Component.LINQ_to_Objects.Deferred
{
    
    public static class Test13
    {
        [Component.Diagnostics.Att_TestLast(_year: 2020, _month: 10, _day: 05, _hour: 10, _minute: 20, _second: 0, _millisecond: 0)]
        public static void Do()
        {
            System.Console.WriteLine(typeof(Component.LINQ_to_Objects.Deferred.Test13).ToString());

            /////////////////////////////////////////////////////////////////////
            var _MyArray = new[] 
            {
                new {Value = 'A'}
                ,new {Value = 'B'}
                ,new {Value = 'C'}
                ,new {Value = 'D'}
            }
            ;
            var _first = _MyArray.Take(2);
            var _second = _MyArray.Skip(1);
            var _SelectMany = new[] { _first, _second }.SelectMany(a => a);

            System.Console.Write("_MyArray=");
            _MyArray.ToList().ForEach(a =>System.Console.Write(a));System.Console.WriteLine("");
            System.Console.Write("_first=");
            _first.ToList().ForEach(a => System.Console.Write(a));System.Console.WriteLine("");
            System.Console.Write("_second=");
            _second.ToList().ForEach(a => System.Console.Write(a));System.Console.WriteLine("");
            System.Console.Write("_SelectMany=");
            _SelectMany.ToList().ForEach(a => System.Console.Write(a));System.Console.WriteLine("");
            //Обьединение множеств
            var _Union = _first.Union(_second);
            System.Console.Write("_Union=");
            _Union.ToList().ForEach(a => System.Console.Write(a)); System.Console.WriteLine("");
            //Пересечение множеств
            var _Intersect = _MyArray.Take(3).Intersect(_MyArray.Skip(1));
            System.Console.Write("_Intersect=");
            _Intersect.ToList().ForEach(a => System.Console.Write(a)); System.Console.WriteLine("");
            //Исключение множеств. Исключить все элементы множества B из всех элементов множества А
            System.Console.Write("_Except=");
            var _Except =_MyArray.Take(3).Except(_MyArray.Skip(1));
            _Except.ToList().ForEach(a => System.Console.Write(a)); System.Console.WriteLine("");
            //Вывод
            //Как видно из примера _SelectMany просто делает один список
            //_Union объединяет и обрезает
        }
    }
}
