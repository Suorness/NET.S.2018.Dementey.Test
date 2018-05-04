namespace Task4.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using NUnit.Framework;
    using Task4.Solution;
    using Task4.Solution.AveregeMethod;
    using Task4.Solution.SecondWay;

    [TestFixture]
    public class TestCalculator
    {
        private readonly List<double> values = new List<double> { 10, 5, 7, 15, 13, 12, 8, 7, 4, 2, 9 };

        [Test]
        public void Test_AverageByMean()
        {
            Calculator calculator = new Calculator();

            double expected = 8.3636363;

            double actual = calculator.CalculateAverage(values, new AveregeMean());

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMean_delegate()
        {
            var calculator = new CalculatorWithDelegate();

            double expected = 8.3636363;

            CalcDelegate calcDelegate = delegate (List<double> values)
            {
                if (values == null)
                {
                    throw new ArgumentNullException(nameof(values));
                }
                return values.Sum() / values.Count;
            };

            var actual = calculator.CalculateAverage(values, calcDelegate);
            

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMedian()
        {
            Calculator calculator = new Calculator();

            double expected = 8.0;

            double actual = calculator.CalculateAverage(values, new AverageMedian());

            Assert.AreEqual(expected, actual, 0.000001);
        }
    }
}