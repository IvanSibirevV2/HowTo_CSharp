
using System;
using System.Collections.Generic;
using System.Text;

using System.Runtime.InteropServices;

namespace System
{
    public class Klava
    {
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vKey);
        [DllImport("user32.dll")]
        private static extern short GetKeyState(int nVirtKey);
        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////
        public Klava Sleep(int _Sleep=50) { System.Threading.Thread.Sleep(_Sleep);return this; }

        public Klava Down(byte nVirtKey) { keybd_event(nVirtKey, 0, 0, 0); return this; }
        public Klava Up(byte nVirtKey) { keybd_event(nVirtKey, 0, 2, 0); return this; }
        public System.Boolean Is(int nVirtKey) { switch (GetKeyState(nVirtKey)) { case -127: return true; break; case -128: return true; break; default: return false; break; } return false; }

        
#region 65 A
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    public Klava VK_A_Down() { keybd_event(65, 0, 0, 0); return this; }
    public Klava VK_A_Up() { keybd_event(65, 0, 2, 0); return this; }
    public System.Boolean VK_A_Is(){return this.Is(65);}
    public Klava VK_A_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.VK_A_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 66 B
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    public Klava VK_B_Down() { keybd_event(66, 0, 0, 0); return this; }
    public Klava VK_B_Up() { keybd_event(66, 0, 2, 0); return this; }
    public System.Boolean VK_B_Is(){return this.Is(66);}
    public Klava VK_B_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.VK_B_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 67 C
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    public Klava VK_C_Down() { keybd_event(67, 0, 0, 0); return this; }
    public Klava VK_C_Up() { keybd_event(67, 0, 2, 0); return this; }
    public System.Boolean VK_C_Is(){return this.Is(67);}
    public Klava VK_C_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.VK_C_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 68 D
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    public Klava VK_D_Down() { keybd_event(68, 0, 0, 0); return this; }
    public Klava VK_D_Up() { keybd_event(68, 0, 2, 0); return this; }
    public System.Boolean VK_D_Is(){return this.Is(68);}
    public Klava VK_D_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.VK_D_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 69 E
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    public Klava VK_E_Down() { keybd_event(69, 0, 0, 0); return this; }
    public Klava VK_E_Up() { keybd_event(69, 0, 2, 0); return this; }
    public System.Boolean VK_E_Is(){return this.Is(69);}
    public Klava VK_E_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.VK_E_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 70 F
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    public Klava VK_F_Down() { keybd_event(70, 0, 0, 0); return this; }
    public Klava VK_F_Up() { keybd_event(70, 0, 2, 0); return this; }
    public System.Boolean VK_F_Is(){return this.Is(70);}
    public Klava VK_F_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.VK_F_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 71 G
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    public Klava VK_G_Down() { keybd_event(71, 0, 0, 0); return this; }
    public Klava VK_G_Up() { keybd_event(71, 0, 2, 0); return this; }
    public System.Boolean VK_G_Is(){return this.Is(71);}
    public Klava VK_G_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.VK_G_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 72 H
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    public Klava VK_H_Down() { keybd_event(72, 0, 0, 0); return this; }
    public Klava VK_H_Up() { keybd_event(72, 0, 2, 0); return this; }
    public System.Boolean VK_H_Is(){return this.Is(72);}
    public Klava VK_H_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.VK_H_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 73 I
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    public Klava VK_I_Down() { keybd_event(73, 0, 0, 0); return this; }
    public Klava VK_I_Up() { keybd_event(73, 0, 2, 0); return this; }
    public System.Boolean VK_I_Is(){return this.Is(73);}
    public Klava VK_I_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.VK_I_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 74 J
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    public Klava VK_J_Down() { keybd_event(74, 0, 0, 0); return this; }
    public Klava VK_J_Up() { keybd_event(74, 0, 2, 0); return this; }
    public System.Boolean VK_J_Is(){return this.Is(74);}
    public Klava VK_J_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.VK_J_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 75 K
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    public Klava VK_K_Down() { keybd_event(75, 0, 0, 0); return this; }
    public Klava VK_K_Up() { keybd_event(75, 0, 2, 0); return this; }
    public System.Boolean VK_K_Is(){return this.Is(75);}
    public Klava VK_K_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.VK_K_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 76 L
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    public Klava VK_L_Down() { keybd_event(76, 0, 0, 0); return this; }
    public Klava VK_L_Up() { keybd_event(76, 0, 2, 0); return this; }
    public System.Boolean VK_L_Is(){return this.Is(76);}
    public Klava VK_L_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.VK_L_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 77 M
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    public Klava VK_M_Down() { keybd_event(77, 0, 0, 0); return this; }
    public Klava VK_M_Up() { keybd_event(77, 0, 2, 0); return this; }
    public System.Boolean VK_M_Is(){return this.Is(77);}
    public Klava VK_M_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.VK_M_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 78 N
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    public Klava VK_N_Down() { keybd_event(78, 0, 0, 0); return this; }
    public Klava VK_N_Up() { keybd_event(78, 0, 2, 0); return this; }
    public System.Boolean VK_N_Is(){return this.Is(78);}
    public Klava VK_N_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.VK_N_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 79 O
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    public Klava VK_O_Down() { keybd_event(79, 0, 0, 0); return this; }
    public Klava VK_O_Up() { keybd_event(79, 0, 2, 0); return this; }
    public System.Boolean VK_O_Is(){return this.Is(79);}
    public Klava VK_O_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.VK_O_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 80 P
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    public Klava VK_P_Down() { keybd_event(80, 0, 0, 0); return this; }
    public Klava VK_P_Up() { keybd_event(80, 0, 2, 0); return this; }
    public System.Boolean VK_P_Is(){return this.Is(80);}
    public Klava VK_P_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.VK_P_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 81 Q
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    public Klava VK_Q_Down() { keybd_event(81, 0, 0, 0); return this; }
    public Klava VK_Q_Up() { keybd_event(81, 0, 2, 0); return this; }
    public System.Boolean VK_Q_Is(){return this.Is(81);}
    public Klava VK_Q_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.VK_Q_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 82 R
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    public Klava VK_R_Down() { keybd_event(82, 0, 0, 0); return this; }
    public Klava VK_R_Up() { keybd_event(82, 0, 2, 0); return this; }
    public System.Boolean VK_R_Is(){return this.Is(82);}
    public Klava VK_R_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.VK_R_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 83 S
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    public Klava VK_S_Down() { keybd_event(83, 0, 0, 0); return this; }
    public Klava VK_S_Up() { keybd_event(83, 0, 2, 0); return this; }
    public System.Boolean VK_S_Is(){return this.Is(83);}
    public Klava VK_S_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.VK_S_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 84 T
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    public Klava VK_T_Down() { keybd_event(84, 0, 0, 0); return this; }
    public Klava VK_T_Up() { keybd_event(84, 0, 2, 0); return this; }
    public System.Boolean VK_T_Is(){return this.Is(84);}
    public Klava VK_T_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.VK_T_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 85 U
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    public Klava VK_U_Down() { keybd_event(85, 0, 0, 0); return this; }
    public Klava VK_U_Up() { keybd_event(85, 0, 2, 0); return this; }
    public System.Boolean VK_U_Is(){return this.Is(85);}
    public Klava VK_U_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.VK_U_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 86 V
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    public Klava VK_V_Down() { keybd_event(86, 0, 0, 0); return this; }
    public Klava VK_V_Up() { keybd_event(86, 0, 2, 0); return this; }
    public System.Boolean VK_V_Is(){return this.Is(86);}
    public Klava VK_V_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.VK_V_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 87 W
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    public Klava VK_W_Down() { keybd_event(87, 0, 0, 0); return this; }
    public Klava VK_W_Up() { keybd_event(87, 0, 2, 0); return this; }
    public System.Boolean VK_W_Is(){return this.Is(87);}
    public Klava VK_W_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.VK_W_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 88 X
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    public Klava VK_X_Down() { keybd_event(88, 0, 0, 0); return this; }
    public Klava VK_X_Up() { keybd_event(88, 0, 2, 0); return this; }
    public System.Boolean VK_X_Is(){return this.Is(88);}
    public Klava VK_X_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.VK_X_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 89 Y
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    public Klava VK_Y_Down() { keybd_event(89, 0, 0, 0); return this; }
    public Klava VK_Y_Up() { keybd_event(89, 0, 2, 0); return this; }
    public System.Boolean VK_Y_Is(){return this.Is(89);}
    public Klava VK_Y_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.VK_Y_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    #region 90 Z
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
    public Klava VK_Z_Down() { keybd_event(90, 0, 0, 0); return this; }
    public Klava VK_Z_Up() { keybd_event(90, 0, 2, 0); return this; }
    public System.Boolean VK_Z_Is(){return this.Is(90);}
    public Klava VK_Z_Is(System.Action<Klava> _f1=null, System.Action<Klava> _f0 = null) 
    {
        System.Boolean _flag = this.VK_Z_Is();
        if (_flag) { if (_f1 != null) _f1(this); } else { if (_f0 != null) _f0(this); }
        return this; 
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////
#endregion
    
        public short VK_Q_Is_() => GetKeyState(81);
        ///////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}

