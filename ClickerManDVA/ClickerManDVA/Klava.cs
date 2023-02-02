using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.InteropServices;

namespace System
{
    public partial class Klava
    {
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vKey);
        [DllImport("user32.dll")]
        private static extern short GetKeyState(int nVirtKey);
        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public Klava Sleep(int _Sleep = 50) { System.Threading.Thread.Sleep(_Sleep); return this; }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////
        public System.Boolean IsOllVK() { return this.VKS.Select(a => a.Is()).Aggregate((a, b) => a && b); }
        public Klava ClearHistoryOfKeyPres() { this.VKS.ForEach(a => a.HistoryOfKeyPres.Clear()); return this; }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////
        public List<HistoryVKGranula> HistoryVKS = new List<HistoryVKGranula>();
        public Klava Record(int _Seconds=20 ) 
        {
            ;
            this.ClearHistoryOfKeyPres();
            this.HistoryVKS.Clear();
         //   System.Threading.Tasks.Task _Task = new System.Threading.Tasks.Task(() => {
                System.DateTime DateTimeStart = System.DateTime.Now;
                while (((System.TimeSpan)(System.DateTime.Now- DateTimeStart)).Seconds< _Seconds)
                {
                    System.Threading.Thread.Sleep(50);
                    this.IsOllVK();
                }
           // });
            this.VKS.ForEach(a => this.HistoryVKS.AddRange(a.HistoryOfKeyPres));
            ;
            return this;
        }
        public Klava HistoryExecute() 
        {
            if (this.HistoryVKS.Count() == 0) return this;
            this.HistoryVKS.Sort((a,b)=> {
                System.TimeSpan _TimeSpan = a.p_DTN - b.p_DTN;

                if (_TimeSpan > System.TimeSpan.Zero) return 1;
                if (_TimeSpan==System.TimeSpan.Zero) return 0;
                if (_TimeSpan < System.TimeSpan.Zero) return -1;
                return -1;
                
            });
            this.HistoryVKS.ForEach(a=> { a.Act(); });
            return this;
        }
        /// <summary> System.Klava.Test_Record_HistoryExecute();</summary>
        public static void Test_Record_HistoryExecute() 
        {
            (new Klava())
                .Record(10)
                .HistoryExecute()
            ;
        }
    }
}