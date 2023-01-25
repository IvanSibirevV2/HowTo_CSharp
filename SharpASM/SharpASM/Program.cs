using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpASM
{
    public class Dog
    {
        public System.String name = "Chip";
        public int kg = 6;
        /// <summary>
        /// маршрут собаки в киллометрах
        /// </summary>
        public List<System.Int32> marshrut = new List<System.Int32>() { 1, 2, 3 };
        
        public void WriteLine() 
        {
            System.Console.WriteLine(this.kg);


            foreach (var H in this.marshrut)
            {
                System.Console.Write(H.ToString() + ";");
            }
            System.Console.WriteLine();
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            SharpASM.Dog name = new SharpASM.Dog();
            System.Console.ReadLine();
        }
    }
}
