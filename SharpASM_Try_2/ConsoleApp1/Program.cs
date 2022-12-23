using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Binarysharp.Assemblers.Fasm;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 8; ;
            int b = 5;
            int c = 0;
            //c = a + b;
            IntPtr start = new IntPtr(0x1000);
            Binarysharp.Assemblers.Fasm.FasmNet _fasm = new FasmNet();
            _fasm.AddLine("use64");
            _fasm.AddLine("mov eax,{0}",a);
            _fasm.AddLine("mov ebx,{0}", b);
            _fasm.AddLine("add eax,ebx");
            _fasm.AddLine("retn");
            _fasm.Assemble().ToList().ForEach(d => System.Console.WriteLine(d.ToString() + ";"));

           // System.Console.WriteLine("c="+c);
            System.Console.ReadLine();
        }
    }
}
