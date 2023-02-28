using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace System
{
    public class VK_Sleep : VK
    {
        public VK_Sleep()
        {
            this.Act = a => { System.Threading.Thread.Sleep(50); };
        }
    }
    public class VK
    {
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vKey);
        [DllImport("user32.dll")]
        private static extern short GetKeyState(int nVirtKey);
        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        public VK Down() { keybd_event(nVirtKey, 0, 0, 0); return this; }
        public VK Up() { keybd_event(nVirtKey, 0, 2, 0); return this; }
        public VK Sleep(int _Sleep = 50) { System.Threading.Thread.Sleep(_Sleep); return this; }
        public static System.Boolean f = false;
        public System.Boolean Is()
        {
            switch (GetKeyState(nVirtKey)) 
            {
                case -127: //return true; break;
                case -128:
                   // if (f != true) if(this.Sender!=null) this.Sender.HistoryVKS.Add(new VK().Set(_this: this,_TimeSpan: this.Sender.DateTimeStart - System.DateTime.Now, _Act: a => a.Down()));//Записть нажатия
                    f = true;
                    return f; break;
                default:
                   // if (f != false) if (this.Sender != null) this.Sender.HistoryVKS.Add(new VK().Set(_this: this, _TimeSpan: this.Sender.DateTimeStart - System.DateTime.Now, _Act: a => a.Up()));//запись отжатия
                    f = false;
                    return false; break;
            }
            return false; 
        }
        
        public byte nVirtKey = 65;//A
        public string Str = "A"; 
        public System.TimeSpan TimeSpan;
        public Klava Sender =null;
        public System.Action<VK> Act =null;
        public VK() { }
        public VK Set(
            VK _this=null
            , System.Nullable<byte> _nVirtKey = null
            , System.String _str = null
            , System.Nullable<System.TimeSpan> _TimeSpan = null
            , Klava _Sender = null
            , System.Action<VK> _Act = null
        )
        {
            if (_this != null) 
                this.Set(_this: null
                    , _nVirtKey: _this.nVirtKey
                    , _str: _this.Str
                    , _TimeSpan: _this.TimeSpan
                    , _Sender: _this.Sender
                    , _Act: _this.Act
                    );
            if (_nVirtKey != null) this.nVirtKey = _nVirtKey.Value;
            if (_str != null) this.Str = _str;
            if (_TimeSpan != null) this.TimeSpan = _TimeSpan.Value;
            if (_Sender != null) this.Sender = _Sender;
            if (_Act != null) this.Act = _Act;
            return this;
        }
    }
}
