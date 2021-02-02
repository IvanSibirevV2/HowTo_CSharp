using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///////////////////////////////////////////
////////////////////////////////////////////
namespace T4
{
    class Program
    {

        static void Main(string[] args)
        {
            System.Console.WriteLine("nfhjasdgjhd");
            T4.RuntimeTextTemplate1.Test();
            //T4.RuntimeTextTemplate1.Test();
            /*
            System.Threading.Tasks.Task _Task_1 = null;
            _Task_1 = System.Threading.Tasks.Task.Run(() => {
                for (int i = 0; i < 10; i++)
                {
                    System.Threading.Thread.Sleep(1000);
                    System.Console.WriteLine("Task_1" + i);
                }
            });
            System.Threading.Tasks.Task _Task_2 = null;
            _Task_2 = System.Threading.Tasks.Task.Run(() => {
                for (int i = 0; i < 10; i++)
                {
                    System.Threading.Thread.Sleep(1000);
                    System.Console.WriteLine("Task_2" + i);
                }
            });
            _Task_1.Wait();
            _Task_2.Wait();
            */
            System.Console.ReadLine();
            
        }
    }
}