using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using prtest8;

namespace volumeTests
{
    [TestClass]
    public class volumeTests1
    {
        [TestMethod]
        public void Reactan_5_7()
        {
            double a = 5;
            double b = 7;
            double rez = 125;
            volume g = new volume();
            double rez2 = g.Reactan(a, b);
            Assert.AreEqual(rez,rez2);
        }
        [TestMethod]
        public void Reactan_10_12()
        {
            double a = 10;
            double b = 12;
            double rez = 1000;
            volume g = new volume();
            double rez2 = g.Reactan(a, b);
            Assert.AreEqual(rez, rez2);
        }
        [TestMethod]
        public void Reactan_2_4()
        {
            double a = 2;
            double b = 4;
            double rez = 8;
            volume g = new volume();
            double rez2 = g.Reactan(a, b);
            Assert.AreEqual(rez, rez2);
        }
        [TestMethod]
        public void Reactan_8_12()
        {
            double a = 8;
            double b = 12;
            double rez = 512;
            volume g = new volume();
            double rez2 = g.Reactan(a, b);
            Assert.AreEqual(rez, rez2);
        }
        [TestMethod]
        public void Reactan_3_12()
        {
            double a = 3;
            double b = 12;
            double rez = 27;
            volume g = new volume();
            double rez2 = g.Reactan(a, b);
            Assert.AreEqual(rez, rez2);
        }

        [TestMethod]
        public void parallelepiped_4_2_3()
        {
            int a = 4;
            int b = 2;
            int h = 3;
            double rez = 24;
            volume g = new volume();
            double rez2 = g.parallelepiped(a, b, h);
            Assert.AreEqual(rez, rez2);
        }
        [TestMethod]
        public void parallelepiped_2_2_2()
        {
            int a = 2;
            int b = 2;
            int h = 2;
            double rez = 8;
            volume g = new volume();
            double rez2 = g.parallelepiped(a, b, h);
            Assert.AreEqual(rez, rez2);
        }
        [TestMethod]
        public void parallelepiped_10_12_5()
        {
            int a = 10;
            int b = 12;
            int h = 5;
            double rez = 600;
            volume g = new volume();
            double rez2 = g.parallelepiped(a, b, h);
            Assert.AreEqual(rez, rez2);
        }
        [TestMethod]
        public void parallelepiped_7_2_4()
        {
            int a = 7;
            int b = 2;
            int h = 4;
            double rez = 56;
            volume g = new volume();
            double rez2 = g.parallelepiped(a, b, h);
            Assert.AreEqual(rez, rez2);
        }
        [TestMethod]
        public void parallelepiped_8_10_3()
        {
            int a = 8;
            int b = 10;
            int h = 3;
            double rez = 240;
            volume g = new volume();
            double rez2 = g.parallelepiped(a, b, h);
            Assert.AreEqual(rez, rez2);
        }
    }
}
