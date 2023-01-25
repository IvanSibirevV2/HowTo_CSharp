using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;

namespace Messenger
{
    public class MessengerClass
    {
        public System.Threading.Thread p_Threa =new System.Threading.Thread(()=> { MessengerClass.QWEE(); });
        public static void QWEE() 
        {

            new HttpListener()
                .Set_Prefixes_Add("http://127.0.0.1:8888/connection/", _IsOpen: false)
                .Set_Start()
                .Get_ContextAsync_WhileTrue(a =>
                {
                    Console.WriteLine($"адрес клиента:"+a.Request.RemoteEndPoint+":"+a.Request.Url.ToString().Split('?')[1]);
                    Console.Write("Введите ответ");
                    System.String _strResponse = System.Console.ReadLine();
                    a.Response.Set_Bytes(_strResponse.Get_Encoding_UTF8_Bytes());
                    Console.WriteLine(new HttpClient().GetStringAsync("http://127.0.0.1:8888/connection/?qweBFYUWEFGUYSDADSDFW").GetAwaiter().GetResult());
                }
                )
                .Set_Stop()
            ;
        }
    }
}
