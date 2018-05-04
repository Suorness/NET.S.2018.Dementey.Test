using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task6.Solution;
using Task6.Solution.Formuls;

namespace Task6.Tests
{
    [TestFixture]
    public class CustomEnumerableTests
    {
        [Test]
        public void Generator_ForSequence1()
        {
            int[] expected = {1, 1, 2, 3, 5, 8, 13, 21, 34, 55};

            var generator = new Generator();
            var sumForml = new SumFormula();

            var res = generator.Calculate(1, 1, 10, sumForml);

            Assert.AreEqual(expected, res);
        }

        [Test]
        public void Generator_ForSequence2()
        {
            int[] expected = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };
            var generator = new Generator();
            var formula = new SecondFormula();

            var res = generator.Calculate(1, 2, expected.Length, formula);

            Assert.AreEqual(expected, res);
        }

        [Test]
        public void Generator_ForSequence3()
        {
            double[] expected = { 1, 2, 2.5, 3.3, 4.05757575757576, 4.87086926018965, 5.70389834408211, 6.55785277425587, 7.42763417076325, 8.31053343902137 };

            var generator = new Generator();
            var formula = new ThirdFormula();
            double tolerance = 0.000001d;

            var res = generator.Calculate(1, 2, expected.Length, formula).ToArray();

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.That(res[i], Is.InRange(expected[i] - tolerance, expected[i] + tolerance));
            }
        }
    }
}
