using System;

using System.Runtime.InteropServices;

namespace ClickerManDVA
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            (new System.Klava())
                .VK_Q_Is(x => System.Console.WriteLine("true"), x => System.Console.WriteLine("false"))
                .Sleep()
                .VK_Q_Down()
                .Sleep()
                .VK_Q_Is(x => System.Console.WriteLine("true"), x => System.Console.WriteLine("false"))
                .Sleep()
                .VK_Q_Up()
                .VK_Q_Is(x => System.Console.WriteLine("true"), x => System.Console.WriteLine("false"))
            ;
            */
            System.Threading.Tasks.Task _Task= new System.Threading.Tasks.Task(() =>{
                while (true)
                {
                    System.Threading.Thread.Sleep(50);
                    (new System.Klava())
                        .VK_A_Is(_f0: a => { }, _f1: a => System.Console.WriteLine("A"))
                        .VK_B_Is(_f0: a => { }, _f1: a => System.Console.WriteLine("B"))
                        .VK_C_Is(_f0: a => { }, _f1: a => System.Console.WriteLine("C"))
                        .VK_D_Is(_f0: a => { }, _f1: a => System.Console.WriteLine("D"))
                        .VK_E_Is(_f0: a => { }, _f1: a => System.Console.WriteLine("E"))
                    ;
                }
            });
            _Task.Start();
            while (true)
            {
                System.Console.WriteLine("!!!!!!!!!!!!!!!");
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}