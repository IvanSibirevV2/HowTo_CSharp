using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace HTTP_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new HttpClient().GetStringAsync("https://www.google.ru/").GetAwaiter().GetResult());
            Console.WriteLine(new HttpClient().GetStringAsync("http://127.0.0.1:8888/connection/?qweBFYUWEFGUYSDADSDFW").GetAwaiter().GetResult());
            System.Console.ReadLine();
        }
    }
}
