using NUnit.Framework;
using TinhThue;
using System;
namespace TestTinhThue
{
    [TestFixture]
    public class PersonalIncomeTaxCalculatorTests
    {
        private PersonalIncomeTaxCalculator calculator;


        [SetUp]
        public void Setup()
        {
            calculator = new PersonalIncomeTaxCalculator();
        }

        [Test]
        public void TestTinhThue_Bac1()
        {
            
            double thuNhap = 10000000;
            int soNguoi = 2;
            double baoHiem = 6;
            double tuThien = 0;

            double thueExpected = 110000; // Giá trị kì vọng (expected result)
            double thueActual = calculator.TinhThue(thuNhap, soNguoi, baoHiem, tuThien);

            Assert.AreEqual(thueExpected, thueActual);
        }

        [Test]
        public void TestTinhThue_Bac2()
        {

            double thuNhap = 20000000;
            int soNguoi = 4;
            double baoHiem = 0;
            double tuThien = 0;

            double thueExpected = 710000; // Giá trị kì vọng (expected result)
            double thueActual = calculator.TinhThue(thuNhap, soNguoi, baoHiem, tuThien);

            Assert.AreEqual(thueExpected, thueActual);
        }

        [Test]
        public void TestTinhThue_Bac3()
        {

            double thuNhap = 30000000;
            int soNguoi = 5;
            double baoHiem = 0;
            double tuThien = 12000000;

            double thueExpected = 710000; // Giá trị kì vọng (expected result)
            double thueActual = calculator.TinhThue(thuNhap, soNguoi, baoHiem, tuThien);

            Assert.AreEqual(thueExpected, thueActual);
        }

       


    }
}
