using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;
using System.Net.Http;
using System.IO;

namespace HTTP_lab8
{
    public static class Ext_HttpListener
    {
        public static System.Net.HttpListener Set_Prefixes_Add(this System.Net.HttpListener _this, string _str = "http://127.0.0.1:8888/connection/", System.Boolean _IsOpen = false)
        {
            _this.Prefixes.Add(_str);
            if (_IsOpen) System.Diagnostics.Process.Start(_str);
            return _this;
        }
        /// <summary>
        /// Начинаем фоном прослушивать входящие подключения
        /// </summary>
        /// <param name="_this"></param>
        /// <returns></returns>
        public static System.Net.HttpListener Set_Start(this System.Net.HttpListener _this)
        { _this.Start(); return _this; }
        public static System.Net.HttpListener Set_Stop(this System.Net.HttpListener _this)
        { _this.Stop(); return _this; }
        public static System.Net.HttpListener Get_ContextAsync(this System.Net.HttpListener _this, System.Action<HttpListenerContext> A)
        { A(_this.GetContextAsync().GetAwaiter().GetResult()); return _this; }
        public static System.Net.HttpListener Get_ContextAsync_WhileTrue(this System.Net.HttpListener _this, System.Action<HttpListenerContext> A)
        { while (true) _this.Get_ContextAsync(A); return _this; }
    }
    public static class Ext_String
    {
        public static byte[] Get_Encoding_UTF8_Bytes(this System.String _this) { return Encoding.UTF8.GetBytes(_this); }
    }
    public static class Ext_HttpListenerResponse
    {
        public static System.Net.HttpListenerResponse Set_Bytes(this System.Net.HttpListenerResponse _this, byte[] _Bytes)
        {
            _this.ContentLength64 = _Bytes.Length;
            Stream output = _this.OutputStream;
            output.WriteAsync(_Bytes, 0, _Bytes.Length);
            output.FlushAsync();
            return _this;
        }
    }
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            //Main_start_messenger_A();
            //Main_start_messenger_B();

            System.Threading.Tasks.Task _TaskA = new Task(() =>
                    new HttpListener()
                   .Set_Prefixes_Add("http://127.0.0.1:8881/connection/", _IsOpen: false)
                   .Set_Start()
                   .Get_ContextAsync_WhileTrue(a => {
                    //Console.WriteLine($"адрес клиента:" + a.Request.RemoteEndPoint + ":" + a.Request.Url.ToString().Split('?')[1]);
                    //this.TextBoxA.Text += "\n"+ "адрес клиента:" + a.Request.RemoteEndPoint + ":" + a.Request.Url.ToString().Split('?')[1];
                    System.String _strResponse = "222";
                        Dispatcher.InvokeAsync(() => this.TextBoxA.Text += _strResponse);
                        
                    a.Response.Set_Bytes(_strResponse.Get_Encoding_UTF8_Bytes());
                })
            );
            _TaskA.Start();
            System.Threading.Tasks.Task _TaskB = new Task(() =>
                    new HttpListener()
                   .Set_Prefixes_Add("http://127.0.0.2:8882/connection/", _IsOpen: false)
                   .Set_Start()
                   .Get_ContextAsync_WhileTrue(a => {
                       //Console.WriteLine($"адрес клиента:" + a.Request.RemoteEndPoint + ":" + a.Request.Url.ToString().Split('?')[1]);
                       //this.TextBoxA.Text += "\n"+ "адрес клиента:" + a.Request.RemoteEndPoint + ":" + a.Request.Url.ToString().Split('?')[1];
                       System.String _strResponse = "111";
                       Dispatcher.InvokeAsync(() => this.TextBoxB.Text += _strResponse);

                       a.Response.Set_Bytes(_strResponse.Get_Encoding_UTF8_Bytes());
                   })
            );
            _TaskB.Start();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // this.TextBoxA.Text+=

            new HttpClient().GetStringAsync("http://127.0.0.2:8882/connection/").GetAwaiter().GetResult();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            new HttpClient().GetStringAsync("http://127.0.0.1:8881/connection/").GetAwaiter().GetResult();
        }
    }
}
