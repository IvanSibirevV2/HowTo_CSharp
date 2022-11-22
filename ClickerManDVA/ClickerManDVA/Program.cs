using System;

using System.Runtime.InteropServices;

namespace ClickerManDVA
{
    class Program
    {
        static void Main(string[] args)
        {
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

        }
    }
}