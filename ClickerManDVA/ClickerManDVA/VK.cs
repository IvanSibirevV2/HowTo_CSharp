﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace System
{
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

        public class Zona51
        {
            public System.DateTime p_DTN = System.DateTime.Now;
            public Action Act = ()=>{};
            public Zona51() { }
            public Zona51(Action _Act) {this.Act= _Act; }
        }
        public List<Zona51> zona51s = new List<Zona51>();

        public static System.Boolean f = false;
        public System.Boolean Is_()
        {
            switch (GetKeyState(nVirtKey)) 
            {
                case -127: //return true; break;
                case -128:
                    if (f != true) this.zona51s.Add(new Zona51(() => this.Down())) ; //запись нажатия
                    f = true;
                    return f; break;
                default:
                    if (f != false) this.zona51s.Add(new Zona51(() => this.Up()));//запись отжатия
                    f = false;
                    return false; break;
            } 
            return false; 
        }
        
        public byte nVirtKey = 65;//A
        public string Str = "A"; 
        public System.DateTime _dateTime = System.DateTime.Now;
        public VK() { }
        public VK(byte _nVirtKey) { this.nVirtKey = _nVirtKey; }

        public VK(string _str, byte _nVirtKey) { this.nVirtKey = _nVirtKey;this.Str = _str; }

    }
}
