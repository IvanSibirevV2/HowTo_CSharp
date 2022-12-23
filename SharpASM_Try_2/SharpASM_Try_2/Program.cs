using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Binarysharp.Assemblers.Fasm;
namespace SharpASM_Try_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (false)
            {
                System.Console.WriteLine("FasmNet.GetVersion=" + FasmNet.GetVersion());
            }
            else if (false)
            {
                FasmNet.Assemble("use32\nretn").ToList().ForEach(a => System.Console.WriteLine(a.ToString() + ";"));
            }
            else if (false)
            {
                FasmNet.Assemble("use64\nmov rax,4").ToList().ForEach(a => System.Console.WriteLine(a.ToString() + ";"));
            }
            else if (false)
            {
                FasmNet.Assemble("use64\nmov rax,4\npush rax").ToList().ForEach(a => System.Console.WriteLine(a.ToString() + ";"));
            }
            else if (false)
            {
                FasmNet.Assemble("use64\nmov rax,4\nretn").ToList().ForEach(a => System.Console.WriteLine(a.ToString() + ";"));
            }
            else if (!false)
            {
                FasmNet.Assemble(
@"use64
mov rax,5
retn"
                ).ToList().ForEach(a => System.Console.WriteLine(a.ToString() + ";"));
            }
            System.Console.ReadLine();
        }
    }
}
