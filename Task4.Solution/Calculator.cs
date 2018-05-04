namespace Task4.Solution
{
    using System;
    using System.Collections.Generic;

    public class Calculator
    {
        public double CalculateAverage(List<double> values, IAveragingMethod method)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            if (method == null)
            {
                throw new ArgumentNullException(nameof(method));
            }

            return method.CalculateAverage(values);
        }
    }
}
