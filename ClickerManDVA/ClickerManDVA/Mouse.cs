
using System;
using System.Collections.Generic;
using System.Text;

using System.Runtime.InteropServices;

namespace System
{
    public partial class Mouse
    {
        public Mouse() { }
        public Mouse(Klava Sender) { this.p_Klava = Sender; }
        public Klava p_Klava = null;
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public int p_SleepTime = 50;
        public Mouse Sleep(System.Nullable<int> _Sleep = null)
        {
            if (_Sleep != null) this.p_SleepTime = _Sleep.Value;
            System.Threading.Thread.Sleep(this.p_SleepTime);
            return this;
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        [DllImport("User32.Dll")]
        private static extern long SetCursorPos(int x, int y);
        public Mouse Set_CursorPos(XY _XY) { SetCursorPos(_XY.X, _XY.Y); return this; }
        public delegate My_Set_CursorPos My_Set_CursorPos(int _X, int _Y);
        public My_Set_CursorPos Set_CursorPosM(int _X = 0, int _Y = 0) { SetCursorPos(_X, _Y); this.Sleep(); return Set_CursorPosM; }
        public Mouse Set_CursorPos(int _X = 0, int _Y = 0) { SetCursorPos(_X, _Y); this.Sleep(); return this; }
        /// <summary> System.Mouse.Test_Set_CursorPos(); /// </summary>
        public static void Test_Set_CursorPos()
        {
            new Mouse().Sleep(500).Set_CursorPosM(50, 50)(100, 100)(150, 150)(200, 200);
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        [StructLayout(LayoutKind.Sequential)]
        public struct XY { public int X; public int Y; }
        [DllImport("User32.Dll")]
        private static extern bool GetCursorPos(out XY lpPoint);
        public XY Get_CursorPos { get { XY _PointInter = new XY(); GetCursorPos(out _PointInter); return _PointInter; } }
        /// <summary> System.Mouse.Test_GetCursorPos(); /// </summary>
        public static void Test_GetCursorPos()
        {
            XY _PointInter = new Mouse().Get_CursorPos;
            System.Console.WriteLine(_PointInter.X.ToString() + ";" + _PointInter.Y.ToString());
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////
        public Mouse Move(XY _DXY) { this.Set_CursorPos(new XY() { X = this.Get_CursorPos.X + _DXY.X, Y = this.Get_CursorPos.Y + _DXY.Y }); return this; }
        public delegate My_Move My_Move(int _X, int _Y);
        public My_Move MoveM(int DX = 0, int DY = 0) { this.Set_CursorPos(this.Get_CursorPos.X + DX, this.Get_CursorPos.Y + DY); return MoveM; }
        public Mouse Move(int DX = 0, int DY = 0) { this.Set_CursorPos(this.Get_CursorPos.X + DX, this.Get_CursorPos.Y + DY); return this; }
        /// <summary> System.Mouse.Test_Move(); /// </summary>
        public static void Test_Move()
        {
            new Mouse()
               .Sleep(50)
               .MoveM
               (+50, 0)(0, +50)(-50, 0)(0, -50)
               (+50, 0)(0, +50)(-50, 0)(0, -50)
               (+50, 0)(0, +50)(-50, 0)(0, -50)
               (+50, 0)(0, +50)(-50, 0)(0, -50)
               (+50, 0)(0, +50)(-50, 0)(0, -50)
               (+50, 0)(0, +50)(-50, 0)(0, -50)
               (+50, 0)(0, +50)(-50, 0)(0, -50)
               (+50, 0)(0, +50)(-50, 0)(0, -50)
               (+50, 0)(0, +50)(-50, 0)(0, -50)
               (+50, 0)(0, +50)(-50, 0)(0, -50)
               (+50, 0)(0, +50)(-50, 0)(0, -50)
               (+50, 0)(0, +50)(-50, 0)(0, -50)
               (+50, 0)(0, +50)(-50, 0)(0, -50)
               (+50, 0)(0, +50)(-50, 0)(0, -50)
               (+50, 0)(0, +50)(-50, 0)(0, -50)
               (+50, 0)(0, +50)(-50, 0)(0, -50)
               (+50, 0)(0, +50)(-50, 0)(0, -50)
               (+50, 0)(0, +50)(-50, 0)(0, -50)
               (+50, 0)(0, +50)(-50, 0)(0, -50)
               (+50, 0)(0, +50)(-50, 0)(0, -50)
           ;
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        private enum MouseEvent
        {
            MOUSEEVENTF_LEFTDOWN = 0x02,
            MOUSEEVENTF_LEFTUP = 0x04,
            MOUSEEVENTF_RIGHTDOWN = 0x08,
            MOUSEEVENTF_RIGHTUP = 0x10,
        }
        /// <summary>Left_Down</summary>
        public Mouse L_Down() { mouse_event((int)MouseEvent.MOUSEEVENTF_LEFTDOWN, this.Get_CursorPos.X, this.Get_CursorPos.Y, 0, 0); this.Sleep(); return this; }
        /// <summary>Left_Up</summary>
        public Mouse L_Up() { mouse_event((int)MouseEvent.MOUSEEVENTF_LEFTUP, this.Get_CursorPos.X, this.Get_CursorPos.Y, 0, 0); this.Sleep(); return this; }
        /// <summary>L_Down_Up</summary>
        public Mouse L { get { this.L_Down().L_Up(); return this; } }
        /// <summary>Right_Down</summary>
        public Mouse R_Down() { mouse_event((int)MouseEvent.MOUSEEVENTF_RIGHTDOWN, this.Get_CursorPos.X, this.Get_CursorPos.Y, 0, 0); this.Sleep(); return this; }
        /// <summary>Right_Up</summary>
        public Mouse R_Up() { mouse_event((int)MouseEvent.MOUSEEVENTF_RIGHTUP, this.Get_CursorPos.X, this.Get_CursorPos.Y, 0, 0); this.Sleep(); return this; }
        /// <summary>R_Down_Up</summary>
        public Mouse R { get { this.R_Down().R_Up(); return this; } }
        /// <summary> System.Mouse.Test_SuperClickManiak(); /// </summary>
        public static void Test_SuperClickManiak()
        {
            new Klava().p_Mouse
                .Set_CursorPos(1919, 1058).L
                .Set_CursorPos((int)1919 / 2, (int)1058 / 2).R
                .Move(+50, +100).Move(0, +75)//.Move(0, -5)
                .Sleep(1000).Sleep(50).Move(+400, +30)
                .L
                .p_Klava
                .Sleep(1000).Sleep(50)
                .S.H.U.T.D.O.W.N.Space.Slash.S.Space.Slash.T.Space._1._0
                .Space.Slash.C.Space.VK_Shift.Down().Sender.Mark.VK_Shift.Up().Sender
                .A.N.Y.T.H.I.N.G.Space.E.L.S.E
                .VK_Shift.Down().Sender.Mark.VK_Shift.Up().Sender.P
                .Enter.Enter
                .p_Mouse
                .Set_CursorPos((int)1919 / 2, (int)1058 / 2)
                .L.L
                .Sleep(1000)
            ;
            System.Console.WriteLine(new Mouse().Get_CursorPos.X.ToString() + ";" + new Mouse().Get_CursorPos.Y.ToString());
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////
        public System.Boolean R_Is() { return this.p_Klava.VK_MouseR.Is(); }
        public System.Boolean L_Is() { return this.p_Klava.VK_MouseL.Is(); }
       /*
        public Mouse R_Is(System.Action<Mouse> _f1 = null, System.Action<Mouse> _f0 = null)
        { this.p_Klava.VK_MouseR.Is(); return this; }
        public Mouse L_Is(System.Action<Mouse> _f1 = null, System.Action<Mouse> _f0 = null)
        { this.p_Klava.MouseL_Is(_f1: x => { _f1(x.p_Sender.p_Mouse); }, _f0: x => { _f0(x.p_Sender.p_Mouse); }); return this; }
        */
        /// <summary> System.Mouse.Test_LR_Is();//Не наводите курсор мыши на консоль во время теста /// </summary>
        public static void Test_LR_Is()
        {
            /*
            new Klava().p_Mouse
                .L_Is(_f1: x => System.Console.WriteLine("L_Is - true"), _f0: x => System.Console.WriteLine("L_Is - false"))
                .L_Down()
                .L_Is(_f1: x => System.Console.WriteLine("L_Is - true"), _f0: x => System.Console.WriteLine("L_Is - false"))
                .L_Up()
                .L_Is(_f1: x => System.Console.WriteLine("L_Is - true"), _f0: x => System.Console.WriteLine("L_Is - false"))
                .R_Is(_f1: x => System.Console.WriteLine("R_Is - true"), _f0: x => System.Console.WriteLine("R_Is - false"))
                .R_Down()
                .R_Is(_f1: x => System.Console.WriteLine("R_Is - true"), _f0: x => System.Console.WriteLine("R_Is - false"))
                .R_Up()
                .R_Is(_f1: x => System.Console.WriteLine("R_Is - true"), _f0: x => System.Console.WriteLine("R_Is - false"))
            ;
            */
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}

