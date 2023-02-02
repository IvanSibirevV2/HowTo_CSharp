
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Linq;

namespace System
{
    public partial class Klava
    {    
        public VK VK_A=new VK(65);
        public VK VK_B=new VK(66);
        public VK VK_C=new VK(67);
        public VK VK_D=new VK(68);
        public VK VK_E=new VK(69);
        public VK VK_F=new VK(70);
        public VK VK_G=new VK(71);
        public VK VK_H=new VK(72);
        public VK VK_I=new VK(73);
        public VK VK_J=new VK(74);
        public VK VK_K=new VK(75);
        public VK VK_L=new VK(76);
        public VK VK_M=new VK(77);
        public VK VK_N=new VK(78);
        public VK VK_O=new VK(79);
        public VK VK_P=new VK(80);
        public VK VK_Q=new VK(81);
        public VK VK_R=new VK(82);
        public VK VK_S=new VK(83);
        public VK VK_T=new VK(84);
        public VK VK_U=new VK(85);
        public VK VK_V=new VK(86);
        public VK VK_W=new VK(87);
        public VK VK_X=new VK(88);
        public VK VK_Y=new VK(89);
        public VK VK_Z=new VK(90);
        public List<VK> VKS = new List<VK>();
        public Klava()
        {
            this.VKS.Clear();
            this.VKS.Add(this.VK_A);
            this.VKS.Add(this.VK_B);
            this.VKS.Add(this.VK_C);
            this.VKS.Add(this.VK_D);
            this.VKS.Add(this.VK_E);
            this.VKS.Add(this.VK_F);
            this.VKS.Add(this.VK_G);
            this.VKS.Add(this.VK_H);
            this.VKS.Add(this.VK_I);
            this.VKS.Add(this.VK_J);
            this.VKS.Add(this.VK_K);
            this.VKS.Add(this.VK_L);
            this.VKS.Add(this.VK_M);
            this.VKS.Add(this.VK_N);
            this.VKS.Add(this.VK_O);
            this.VKS.Add(this.VK_P);
            this.VKS.Add(this.VK_Q);
            this.VKS.Add(this.VK_R);
            this.VKS.Add(this.VK_S);
            this.VKS.Add(this.VK_T);
            this.VKS.Add(this.VK_U);
            this.VKS.Add(this.VK_V);
            this.VKS.Add(this.VK_W);
            this.VKS.Add(this.VK_X);
            this.VKS.Add(this.VK_Y);
            this.VKS.Add(this.VK_Z);
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
    }
}

