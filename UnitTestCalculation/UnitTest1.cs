using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharedCalculator;

namespace UnitTestCalculation
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Vi opretter objekt af CalculationOperations klasse kun en gang (vi kan bruge den til alle metoder nedenfor, så behøver vi ikke at oprette den flere gange i hver metod) 
        /// i metoden nedenfor og vi skriver også [TestInitialize]
        /// </summary>
        /// 
        private CalculationOperations c;

        [TestInitialize]
        public void Setup()
        {

            c = new CalculationOperations();

        }
        [TestMethod]
        public void TestMethodPlus()
        {

            int p = c.plus(5, 5);
            Assert.AreEqual(10, p);

        }

        [TestMethod]
        public void TestMethodMinus()
        {
            

            int m = c.minus(5, 4);
            Assert.AreEqual(1, m);
        }
        [TestMethod]
        public void TestMethodDivide()
        {

            int d = c.divide(10, 2);
            Assert.AreEqual(5, d);
        }
        [TestMethod]
        public void TestMethodMultiply()
        {

            int m = c.multiply(5, 4);
            Assert.AreEqual(20, m);
        }
    }
}