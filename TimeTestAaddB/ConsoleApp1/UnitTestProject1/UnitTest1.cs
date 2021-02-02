using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void Int_Add()
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int Summ(int A, int B) => A + B;
            for (int i = 0; i < 100000000; i++)
            {
                c = a + b;
            }
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void Int_Add_Funk()
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int Summ(int A, int B) => A + B;
            for (int i = 0; i < 100000000; i++)
            {
                c = Summ(a,b);
            }
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void Double_Add()
        {
            System.Double a = 0;
            System.Double b = 0;
            System.Double c = 0;
            System.Double Summ(System.Double A, System.Double B) => A + B;
            for (int i = 0; i < 100000000; i++)
            {
                c = a+b;
            }
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void Double_Add_Funk()
        {
            System.Double a = 0;
            System.Double b = 0;
            System.Double c = 0;
            System.Double Summ(System.Double A, System.Double B) => A + B;
            for (int i = 0; i < 100000000; i++)
            {
                c = Summ(a,b);
            }
            Assert.IsTrue(true);
        }
    }
}
