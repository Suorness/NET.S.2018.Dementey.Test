using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Solution.SecondWay
{
    public delegate double CalcDelegate(List<double> value);

    public class CalculatorWithDelegate
    {

        public double CalculateAverage(List<double> values, CalcDelegate calcDelegate)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            if (calcDelegate == null)
            {
                throw new ArgumentNullException(nameof(calcDelegate));
            }

            return calcDelegate(values);
        }
    }
}
