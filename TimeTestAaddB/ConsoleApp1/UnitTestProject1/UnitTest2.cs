using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest2
    {
        private struct Conteiner_AddInt32
        {
            public System.Int32 A;
            public System.Int32 B;
            public System.Int32 C;
            public Conteiner_AddInt32 Init()
            {
                this.A = 0;
                this.B = 0;
                this.C = 0;
                return this;
            }
            public Conteiner_AddInt32 Add()
            {
                this.C = this.A + this.B;
                return this;
            }
        }
        [TestMethod]
        public void Int_Add()
        {
            Conteiner_AddInt32 _Con = new Conteiner_AddInt32(){A=0,B=0,C=0 };
            int Summ(int A, int B) => A + B;
            for (int i = 0; i < 100000000; i++)
            {
                _Con.C = _Con.A + _Con.B;
            }
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void Int_Add_Funk()
        {
            Conteiner_AddInt32 _Con = new Conteiner_AddInt32() { A = 0, B = 0, C = 0 };
            int Summ(int A, int B) => A + B;
            for (int i = 0; i < 100000000; i++)
            {
                _Con.C = Summ(_Con.A, _Con.B);
            }
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void Int_Add_Struct_Funk()
        {
            Conteiner_AddInt32 _Con = new Conteiner_AddInt32() { A = 0, B = 0, C = 0 };
            int Summ(int A, int B) => A + B;
            for (int i = 0; i < 100000000; i++)
            {
                _Con.C = Summ(_Con.A, _Con.B);
            }
            Assert.IsTrue(true);
        }
    }
}
