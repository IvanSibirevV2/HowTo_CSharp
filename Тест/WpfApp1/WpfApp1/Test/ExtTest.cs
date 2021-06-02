using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class ExtTest
    {
        public static int Show_Console(Cog _Cog)
        {
            if (_Cog.ListCog.Count == 0) { _Cog.UserSet = !_Cog.UserSet;  return 0; }
            while (true)
            { 
                System.Console.WriteLine(_Cog.Name);
                System.Console.WriteLine(_Cog.Notes);
                int i = 0;
                System.Console.WriteLine("[-1] ..");//При вводе -1 -выход из меню
                _Cog.ListCog.ForEach((a) => { System.Console.WriteLine("[" + i + "]["+ a.UserSet+ "]" + a.Name + " " + a.Notes);i++; });
                i = 0;
                do
                {
                    System.Console.WriteLine("Выберете вопрос:");
                } while (!System.Int32.TryParse(System.Console.ReadLine(), out i));
                if (i == -1) return 0;
                if ((i >= 0)&&(i< _Cog.ListCog.Count))Show_Console(_Cog.ListCog[i]);
            }
            return 0;
        }
        /// <summary>
        /// Проверка всего теста теста
        /// </summary>
        public static System.Double CheckTest_Persent(Cog _Cog){return 100*CheckTest_UserSet(_Cog)/ CheckTest_IsTrue(_Cog);}
        /// <summary>
        /// Подсчитать все пользлвательские выборы
        /// </summary>
        public static int CheckTest_UserSet(Cog _Cog)
        {
            if (_Cog.ListCog.Count == 0)
            {if ((_Cog.UserSet ==true)&&(_Cog.IsTrue=true)){ return 1; }else { return 0; }}
            int i = 0;
            _Cog.ListCog.ForEach(a => i = i + CheckTest_UserSet(a));
            return i;
        }
        /// <summary>
        /// Подсчитать все ответы которые программа считает верными
        /// </summary>
        public static int CheckTest_IsTrue(Cog _Cog)
        {
            if (_Cog.ListCog.Count == 0){ if (_Cog.IsTrue) { return 1; } else { return 0; } }
            int i = 0;
            _Cog.ListCog.ForEach(a => i = i + CheckTest_IsTrue(a));
            return i;
        }
        /// <summary> ConsoleApp1.View.AsTest.Test();</summary>
        public static void Test()
        {
            Cog _Cog = Model.DevData.TestMatch.Init();
            ExtTest.Show_Console(_Cog);
            System.Console.WriteLine("Ответ");
            //System.Console.WriteLine(CheckTest_UserSet(_Cog));
            System.Console.WriteLine(CheckTest_Persent(_Cog));
            
        }
    }
}
