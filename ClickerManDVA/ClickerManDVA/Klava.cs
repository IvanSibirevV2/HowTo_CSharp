
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
    /// <summary>A_Down</summary><returns></returns>
    public Klava VK_A_Down() { keybd_event(65, 0, 0, 0); return this; }
    /// <summary>A_Up</summary><returns></returns>
    public Klava VK_A_Up() { keybd_event(65, 0, 2, 0); return this; }
    /// <summary>_Is_A_Down</summary><returns></returns>
    public System.Boolean VK_A_Is(){return this.Is(65);}
    /// <summary>if(A_Is ){_f1();}else{_f0);}</summary><returns></returns>
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
    /// <summary>B_Down</summary><returns></returns>
    public Klava VK_B_Down() { keybd_event(66, 0, 0, 0); return this; }
    /// <summary>B_Up</summary><returns></returns>
    public Klava VK_B_Up() { keybd_event(66, 0, 2, 0); return this; }
    /// <summary>_Is_B_Down</summary><returns></returns>
    public System.Boolean VK_B_Is(){return this.Is(66);}
    /// <summary>if(B_Is ){_f1();}else{_f0);}</summary><returns></returns>
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
    /// <summary>C_Down</summary><returns></returns>
    public Klava VK_C_Down() { keybd_event(67, 0, 0, 0); return this; }
    /// <summary>C_Up</summary><returns></returns>
    public Klava VK_C_Up() { keybd_event(67, 0, 2, 0); return this; }
    /// <summary>_Is_C_Down</summary><returns></returns>
    public System.Boolean VK_C_Is(){return this.Is(67);}
    /// <summary>if(C_Is ){_f1();}else{_f0);}</summary><returns></returns>
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
    /// <summary>D_Down</summary><returns></returns>
    public Klava VK_D_Down() { keybd_event(68, 0, 0, 0); return this; }
    /// <summary>D_Up</summary><returns></returns>
    public Klava VK_D_Up() { keybd_event(68, 0, 2, 0); return this; }
    /// <summary>_Is_D_Down</summary><returns></returns>
    public System.Boolean VK_D_Is(){return this.Is(68);}
    /// <summary>if(D_Is ){_f1();}else{_f0);}</summary><returns></returns>
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
    /// <summary>E_Down</summary><returns></returns>
    public Klava VK_E_Down() { keybd_event(69, 0, 0, 0); return this; }
    /// <summary>E_Up</summary><returns></returns>
    public Klava VK_E_Up() { keybd_event(69, 0, 2, 0); return this; }
    /// <summary>_Is_E_Down</summary><returns></returns>
    public System.Boolean VK_E_Is(){return this.Is(69);}
    /// <summary>if(E_Is ){_f1();}else{_f0);}</summary><returns></returns>
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
    /// <summary>F_Down</summary><returns></returns>
    public Klava VK_F_Down() { keybd_event(70, 0, 0, 0); return this; }
    /// <summary>F_Up</summary><returns></returns>
    public Klava VK_F_Up() { keybd_event(70, 0, 2, 0); return this; }
    /// <summary>_Is_F_Down</summary><returns></returns>
    public System.Boolean VK_F_Is(){return this.Is(70);}
    /// <summary>if(F_Is ){_f1();}else{_f0);}</summary><returns></returns>
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
    /// <summary>G_Down</summary><returns></returns>
    public Klava VK_G_Down() { keybd_event(71, 0, 0, 0); return this; }
    /// <summary>G_Up</summary><returns></returns>
    public Klava VK_G_Up() { keybd_event(71, 0, 2, 0); return this; }
    /// <summary>_Is_G_Down</summary><returns></returns>
    public System.Boolean VK_G_Is(){return this.Is(71);}
    /// <summary>if(G_Is ){_f1();}else{_f0);}</summary><returns></returns>
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
    /// <summary>H_Down</summary><returns></returns>
    public Klava VK_H_Down() { keybd_event(72, 0, 0, 0); return this; }
    /// <summary>H_Up</summary><returns></returns>
    public Klava VK_H_Up() { keybd_event(72, 0, 2, 0); return this; }
    /// <summary>_Is_H_Down</summary><returns></returns>
    public System.Boolean VK_H_Is(){return this.Is(72);}
    /// <summary>if(H_Is ){_f1();}else{_f0);}</summary><returns></returns>
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
    /// <summary>I_Down</summary><returns></returns>
    public Klava VK_I_Down() { keybd_event(73, 0, 0, 0); return this; }
    /// <summary>I_Up</summary><returns></returns>
    public Klava VK_I_Up() { keybd_event(73, 0, 2, 0); return this; }
    /// <summary>_Is_I_Down</summary><returns></returns>
    public System.Boolean VK_I_Is(){return this.Is(73);}
    /// <summary>if(I_Is ){_f1();}else{_f0);}</summary><returns></returns>
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
    /// <summary>J_Down</summary><returns></returns>
    public Klava VK_J_Down() { keybd_event(74, 0, 0, 0); return this; }
    /// <summary>J_Up</summary><returns></returns>
    public Klava VK_J_Up() { keybd_event(74, 0, 2, 0); return this; }
    /// <summary>_Is_J_Down</summary><returns></returns>
    public System.Boolean VK_J_Is(){return this.Is(74);}
    /// <summary>if(J_Is ){_f1();}else{_f0);}</summary><returns></returns>
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
    /// <summary>K_Down</summary><returns></returns>
    public Klava VK_K_Down() { keybd_event(75, 0, 0, 0); return this; }
    /// <summary>K_Up</summary><returns></returns>
    public Klava VK_K_Up() { keybd_event(75, 0, 2, 0); return this; }
    /// <summary>_Is_K_Down</summary><returns></returns>
    public System.Boolean VK_K_Is(){return this.Is(75);}
    /// <summary>if(K_Is ){_f1();}else{_f0);}</summary><returns></returns>
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
    /// <summary>L_Down</summary><returns></returns>
    public Klava VK_L_Down() { keybd_event(76, 0, 0, 0); return this; }
    /// <summary>L_Up</summary><returns></returns>
    public Klava VK_L_Up() { keybd_event(76, 0, 2, 0); return this; }
    /// <summary>_Is_L_Down</summary><returns></returns>
    public System.Boolean VK_L_Is(){return this.Is(76);}
    /// <summary>if(L_Is ){_f1();}else{_f0);}</summary><returns></returns>
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
    /// <summary>M_Down</summary><returns></returns>
    public Klava VK_M_Down() { keybd_event(77, 0, 0, 0); return this; }
    /// <summary>M_Up</summary><returns></returns>
    public Klava VK_M_Up() { keybd_event(77, 0, 2, 0); return this; }
    /// <summary>_Is_M_Down</summary><returns></returns>
    public System.Boolean VK_M_Is(){return this.Is(77);}
    /// <summary>if(M_Is ){_f1();}else{_f0);}</summary><returns></returns>
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
    /// <summary>N_Down</summary><returns></returns>
    public Klava VK_N_Down() { keybd_event(78, 0, 0, 0); return this; }
    /// <summary>N_Up</summary><returns></returns>
    public Klava VK_N_Up() { keybd_event(78, 0, 2, 0); return this; }
    /// <summary>_Is_N_Down</summary><returns></returns>
    public System.Boolean VK_N_Is(){return this.Is(78);}
    /// <summary>if(N_Is ){_f1();}else{_f0);}</summary><returns></returns>
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
    /// <summary>O_Down</summary><returns></returns>
    public Klava VK_O_Down() { keybd_event(79, 0, 0, 0); return this; }
    /// <summary>O_Up</summary><returns></returns>
    public Klava VK_O_Up() { keybd_event(79, 0, 2, 0); return this; }
    /// <summary>_Is_O_Down</summary><returns></returns>
    public System.Boolean VK_O_Is(){return this.Is(79);}
    /// <summary>if(O_Is ){_f1();}else{_f0);}</summary><returns></returns>
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
    /// <summary>P_Down</summary><returns></returns>
    public Klava VK_P_Down() { keybd_event(80, 0, 0, 0); return this; }
    /// <summary>P_Up</summary><returns></returns>
    public Klava VK_P_Up() { keybd_event(80, 0, 2, 0); return this; }
    /// <summary>_Is_P_Down</summary><returns></returns>
    public System.Boolean VK_P_Is(){return this.Is(80);}
    /// <summary>if(P_Is ){_f1();}else{_f0);}</summary><returns></returns>
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
    /// <summary>Q_Down</summary><returns></returns>
    public Klava VK_Q_Down() { keybd_event(81, 0, 0, 0); return this; }
    /// <summary>Q_Up</summary><returns></returns>
    public Klava VK_Q_Up() { keybd_event(81, 0, 2, 0); return this; }
    /// <summary>_Is_Q_Down</summary><returns></returns>
    public System.Boolean VK_Q_Is(){return this.Is(81);}
    /// <summary>if(Q_Is ){_f1();}else{_f0);}</summary><returns></returns>
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
    /// <summary>R_Down</summary><returns></returns>
    public Klava VK_R_Down() { keybd_event(82, 0, 0, 0); return this; }
    /// <summary>R_Up</summary><returns></returns>
    public Klava VK_R_Up() { keybd_event(82, 0, 2, 0); return this; }
    /// <summary>_Is_R_Down</summary><returns></returns>
    public System.Boolean VK_R_Is(){return this.Is(82);}
    /// <summary>if(R_Is ){_f1();}else{_f0);}</summary><returns></returns>
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
    /// <summary>S_Down</summary><returns></returns>
    public Klava VK_S_Down() { keybd_event(83, 0, 0, 0); return this; }
    /// <summary>S_Up</summary><returns></returns>
    public Klava VK_S_Up() { keybd_event(83, 0, 2, 0); return this; }
    /// <summary>_Is_S_Down</summary><returns></returns>
    public System.Boolean VK_S_Is(){return this.Is(83);}
    /// <summary>if(S_Is ){_f1();}else{_f0);}</summary><returns></returns>
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
    /// <summary>T_Down</summary><returns></returns>
    public Klava VK_T_Down() { keybd_event(84, 0, 0, 0); return this; }
    /// <summary>T_Up</summary><returns></returns>
    public Klava VK_T_Up() { keybd_event(84, 0, 2, 0); return this; }
    /// <summary>_Is_T_Down</summary><returns></returns>
    public System.Boolean VK_T_Is(){return this.Is(84);}
    /// <summary>if(T_Is ){_f1();}else{_f0);}</summary><returns></returns>
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
    /// <summary>U_Down</summary><returns></returns>
    public Klava VK_U_Down() { keybd_event(85, 0, 0, 0); return this; }
    /// <summary>U_Up</summary><returns></returns>
    public Klava VK_U_Up() { keybd_event(85, 0, 2, 0); return this; }
    /// <summary>_Is_U_Down</summary><returns></returns>
    public System.Boolean VK_U_Is(){return this.Is(85);}
    /// <summary>if(U_Is ){_f1();}else{_f0);}</summary><returns></returns>
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
    /// <summary>V_Down</summary><returns></returns>
    public Klava VK_V_Down() { keybd_event(86, 0, 0, 0); return this; }
    /// <summary>V_Up</summary><returns></returns>
    public Klava VK_V_Up() { keybd_event(86, 0, 2, 0); return this; }
    /// <summary>_Is_V_Down</summary><returns></returns>
    public System.Boolean VK_V_Is(){return this.Is(86);}
    /// <summary>if(V_Is ){_f1();}else{_f0);}</summary><returns></returns>
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
    /// <summary>W_Down</summary><returns></returns>
    public Klava VK_W_Down() { keybd_event(87, 0, 0, 0); return this; }
    /// <summary>W_Up</summary><returns></returns>
    public Klava VK_W_Up() { keybd_event(87, 0, 2, 0); return this; }
    /// <summary>_Is_W_Down</summary><returns></returns>
    public System.Boolean VK_W_Is(){return this.Is(87);}
    /// <summary>if(W_Is ){_f1();}else{_f0);}</summary><returns></returns>
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
    /// <summary>X_Down</summary><returns></returns>
    public Klava VK_X_Down() { keybd_event(88, 0, 0, 0); return this; }
    /// <summary>X_Up</summary><returns></returns>
    public Klava VK_X_Up() { keybd_event(88, 0, 2, 0); return this; }
    /// <summary>_Is_X_Down</summary><returns></returns>
    public System.Boolean VK_X_Is(){return this.Is(88);}
    /// <summary>if(X_Is ){_f1();}else{_f0);}</summary><returns></returns>
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
    /// <summary>Y_Down</summary><returns></returns>
    public Klava VK_Y_Down() { keybd_event(89, 0, 0, 0); return this; }
    /// <summary>Y_Up</summary><returns></returns>
    public Klava VK_Y_Up() { keybd_event(89, 0, 2, 0); return this; }
    /// <summary>_Is_Y_Down</summary><returns></returns>
    public System.Boolean VK_Y_Is(){return this.Is(89);}
    /// <summary>if(Y_Is ){_f1();}else{_f0);}</summary><returns></returns>
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
    /// <summary>Z_Down</summary><returns></returns>
    public Klava VK_Z_Down() { keybd_event(90, 0, 0, 0); return this; }
    /// <summary>Z_Up</summary><returns></returns>
    public Klava VK_Z_Up() { keybd_event(90, 0, 2, 0); return this; }
    /// <summary>_Is_Z_Down</summary><returns></returns>
    public System.Boolean VK_Z_Is(){return this.Is(90);}
    /// <summary>if(Z_Is ){_f1();}else{_f0);}</summary><returns></returns>
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

