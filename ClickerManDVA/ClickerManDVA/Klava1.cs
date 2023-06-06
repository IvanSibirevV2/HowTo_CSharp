
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Linq;

namespace System
{
    public partial class Klava
    {    
        public VK VK_A=new VK().Set(_nVirtKey:65,_str:"A");
        public VK VK_B=new VK().Set(_nVirtKey:66,_str:"B");
        public VK VK_C=new VK().Set(_nVirtKey:67,_str:"C");
        public VK VK_D=new VK().Set(_nVirtKey:68,_str:"D");
        public VK VK_E=new VK().Set(_nVirtKey:69,_str:"E");
        public VK VK_F=new VK().Set(_nVirtKey:70,_str:"F");
        public VK VK_G=new VK().Set(_nVirtKey:71,_str:"G");
        public VK VK_H=new VK().Set(_nVirtKey:72,_str:"H");
        public VK VK_I=new VK().Set(_nVirtKey:73,_str:"I");
        public VK VK_J=new VK().Set(_nVirtKey:74,_str:"J");
        public VK VK_K=new VK().Set(_nVirtKey:75,_str:"K");
        public VK VK_L=new VK().Set(_nVirtKey:76,_str:"L");
        public VK VK_M=new VK().Set(_nVirtKey:77,_str:"M");
        public VK VK_N=new VK().Set(_nVirtKey:78,_str:"N");
        public VK VK_O=new VK().Set(_nVirtKey:79,_str:"O");
        public VK VK_P=new VK().Set(_nVirtKey:80,_str:"P");
        public VK VK_Q=new VK().Set(_nVirtKey:81,_str:"Q");
        public VK VK_R=new VK().Set(_nVirtKey:82,_str:"R");
        public VK VK_S=new VK().Set(_nVirtKey:83,_str:"S");
        public VK VK_T=new VK().Set(_nVirtKey:84,_str:"T");
        public VK VK_U=new VK().Set(_nVirtKey:85,_str:"U");
        public VK VK_V=new VK().Set(_nVirtKey:86,_str:"V");
        public VK VK_W=new VK().Set(_nVirtKey:87,_str:"W");
        public VK VK_X=new VK().Set(_nVirtKey:88,_str:"X");
        public VK VK_Y=new VK().Set(_nVirtKey:89,_str:"Y");
        public VK VK_Z=new VK().Set(_nVirtKey:90,_str:"Z");
        public VK VK_Slash=new VK().Set(_nVirtKey:191,_str:"Slash");
        public VK VK_Space=new VK().Set(_nVirtKey:32,_str:"Space");
        public VK VK__0=new VK().Set(_nVirtKey:48,_str:"_0");
        public VK VK__1=new VK().Set(_nVirtKey:49,_str:"_1");
        public VK VK__2=new VK().Set(_nVirtKey:50,_str:"_2");
        public VK VK__3=new VK().Set(_nVirtKey:51,_str:"_3");
        public VK VK__4=new VK().Set(_nVirtKey:52,_str:"_4");
        public VK VK__5=new VK().Set(_nVirtKey:53,_str:"_5");
        public VK VK__6=new VK().Set(_nVirtKey:54,_str:"_6");
        public VK VK__7=new VK().Set(_nVirtKey:55,_str:"_7");
        public VK VK__8=new VK().Set(_nVirtKey:56,_str:"_8");
        public VK VK__9=new VK().Set(_nVirtKey:57,_str:"_9");
        public VK VK_Enter=new VK().Set(_nVirtKey:13,_str:"Enter");
        public VK VK_Mark=new VK().Set(_nVirtKey:222,_str:"Mark");
        public VK VK_Shift=new VK().Set(_nVirtKey:16,_str:"Shift");
        public VK VK_MouseL=new VK().Set(_nVirtKey:1,_str:"MouseL");
        public VK VK_MouseR=new VK().Set(_nVirtKey:2,_str:"MouseR");
        public List<VK> VKS = new List<VK>();
        public Klava()
        {
            this.VKS.Clear();
            this.VKS.Add(this.VK_A.Set(_Sender:this));
            this.VKS.Add(this.VK_B.Set(_Sender:this));
            this.VKS.Add(this.VK_C.Set(_Sender:this));
            this.VKS.Add(this.VK_D.Set(_Sender:this));
            this.VKS.Add(this.VK_E.Set(_Sender:this));
            this.VKS.Add(this.VK_F.Set(_Sender:this));
            this.VKS.Add(this.VK_G.Set(_Sender:this));
            this.VKS.Add(this.VK_H.Set(_Sender:this));
            this.VKS.Add(this.VK_I.Set(_Sender:this));
            this.VKS.Add(this.VK_J.Set(_Sender:this));
            this.VKS.Add(this.VK_K.Set(_Sender:this));
            this.VKS.Add(this.VK_L.Set(_Sender:this));
            this.VKS.Add(this.VK_M.Set(_Sender:this));
            this.VKS.Add(this.VK_N.Set(_Sender:this));
            this.VKS.Add(this.VK_O.Set(_Sender:this));
            this.VKS.Add(this.VK_P.Set(_Sender:this));
            this.VKS.Add(this.VK_Q.Set(_Sender:this));
            this.VKS.Add(this.VK_R.Set(_Sender:this));
            this.VKS.Add(this.VK_S.Set(_Sender:this));
            this.VKS.Add(this.VK_T.Set(_Sender:this));
            this.VKS.Add(this.VK_U.Set(_Sender:this));
            this.VKS.Add(this.VK_V.Set(_Sender:this));
            this.VKS.Add(this.VK_W.Set(_Sender:this));
            this.VKS.Add(this.VK_X.Set(_Sender:this));
            this.VKS.Add(this.VK_Y.Set(_Sender:this));
            this.VKS.Add(this.VK_Z.Set(_Sender:this));
            this.VKS.Add(this.VK_Slash.Set(_Sender:this));
            this.VKS.Add(this.VK_Space.Set(_Sender:this));
            this.VKS.Add(this.VK__0.Set(_Sender:this));
            this.VKS.Add(this.VK__1.Set(_Sender:this));
            this.VKS.Add(this.VK__2.Set(_Sender:this));
            this.VKS.Add(this.VK__3.Set(_Sender:this));
            this.VKS.Add(this.VK__4.Set(_Sender:this));
            this.VKS.Add(this.VK__5.Set(_Sender:this));
            this.VKS.Add(this.VK__6.Set(_Sender:this));
            this.VKS.Add(this.VK__7.Set(_Sender:this));
            this.VKS.Add(this.VK__8.Set(_Sender:this));
            this.VKS.Add(this.VK__9.Set(_Sender:this));
            this.VKS.Add(this.VK_Enter.Set(_Sender:this));
            this.VKS.Add(this.VK_Mark.Set(_Sender:this));
            this.VKS.Add(this.VK_Shift.Set(_Sender:this));
            this.VKS.Add(this.VK_MouseL.Set(_Sender:this));
            this.VKS.Add(this.VK_MouseR.Set(_Sender:this));
        }
        public Klava A{get{this.VK_A.Down().Sleep().Up(); return this;} }
        public Klava B{get{this.VK_B.Down().Sleep().Up(); return this;} }
        public Klava C{get{this.VK_C.Down().Sleep().Up(); return this;} }
        public Klava D{get{this.VK_D.Down().Sleep().Up(); return this;} }
        public Klava E{get{this.VK_E.Down().Sleep().Up(); return this;} }
        public Klava F{get{this.VK_F.Down().Sleep().Up(); return this;} }
        public Klava G{get{this.VK_G.Down().Sleep().Up(); return this;} }
        public Klava H{get{this.VK_H.Down().Sleep().Up(); return this;} }
        public Klava I{get{this.VK_I.Down().Sleep().Up(); return this;} }
        public Klava J{get{this.VK_J.Down().Sleep().Up(); return this;} }
        public Klava K{get{this.VK_K.Down().Sleep().Up(); return this;} }
        public Klava L{get{this.VK_L.Down().Sleep().Up(); return this;} }
        public Klava M{get{this.VK_M.Down().Sleep().Up(); return this;} }
        public Klava N{get{this.VK_N.Down().Sleep().Up(); return this;} }
        public Klava O{get{this.VK_O.Down().Sleep().Up(); return this;} }
        public Klava P{get{this.VK_P.Down().Sleep().Up(); return this;} }
        public Klava Q{get{this.VK_Q.Down().Sleep().Up(); return this;} }
        public Klava R{get{this.VK_R.Down().Sleep().Up(); return this;} }
        public Klava S{get{this.VK_S.Down().Sleep().Up(); return this;} }
        public Klava T{get{this.VK_T.Down().Sleep().Up(); return this;} }
        public Klava U{get{this.VK_U.Down().Sleep().Up(); return this;} }
        public Klava V{get{this.VK_V.Down().Sleep().Up(); return this;} }
        public Klava W{get{this.VK_W.Down().Sleep().Up(); return this;} }
        public Klava X{get{this.VK_X.Down().Sleep().Up(); return this;} }
        public Klava Y{get{this.VK_Y.Down().Sleep().Up(); return this;} }
        public Klava Z{get{this.VK_Z.Down().Sleep().Up(); return this;} }
        public Klava Slash{get{this.VK_Slash.Down().Sleep().Up(); return this;} }
        public Klava Space{get{this.VK_Space.Down().Sleep().Up(); return this;} }
        public Klava _0{get{this.VK__0.Down().Sleep().Up(); return this;} }
        public Klava _1{get{this.VK__1.Down().Sleep().Up(); return this;} }
        public Klava _2{get{this.VK__2.Down().Sleep().Up(); return this;} }
        public Klava _3{get{this.VK__3.Down().Sleep().Up(); return this;} }
        public Klava _4{get{this.VK__4.Down().Sleep().Up(); return this;} }
        public Klava _5{get{this.VK__5.Down().Sleep().Up(); return this;} }
        public Klava _6{get{this.VK__6.Down().Sleep().Up(); return this;} }
        public Klava _7{get{this.VK__7.Down().Sleep().Up(); return this;} }
        public Klava _8{get{this.VK__8.Down().Sleep().Up(); return this;} }
        public Klava _9{get{this.VK__9.Down().Sleep().Up(); return this;} }
        public Klava Enter{get{this.VK_Enter.Down().Sleep().Up(); return this;} }
        public Klava Mark{get{this.VK_Mark.Down().Sleep().Up(); return this;} }
        public Klava Shift{get{this.VK_Shift.Down().Sleep().Up(); return this;} }
        public Klava MouseL{get{this.VK_MouseL.Down().Sleep().Up(); return this;} }
        public Klava MouseR{get{this.VK_MouseR.Down().Sleep().Up(); return this;} }
    }
}

