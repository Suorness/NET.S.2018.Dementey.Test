namespace Task4.Solution.AveregeMethod
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AveregeMean : IAveragingMethod
    {
        public double CalculateAverage(List<double> values)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            return values.Sum() / values.Count;
        }
    }
}
