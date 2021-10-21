using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTK
{
    public static class EXT_TTK
    {
        public static System.String Get_TTK(){return " T T K ";}
    }
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("пРИВЕТ МИР");
            System.Console.WriteLine(TTK.EXT_TTK.Get_TTK());
            System.Console.ReadLine();
        }
    }
}
