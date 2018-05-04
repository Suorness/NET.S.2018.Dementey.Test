namespace Task6.Solution
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Generator
    {
        public IEnumerable<T> Calculate<T>(T first, T second, int count, IFormula<T> formula)
        {
            if (formula == null)
            {
                throw new ArgumentNullException(nameof(formula));
            }

            if (count <= 0)
            {
                throw new IndexOutOfRangeException(nameof(count));
            }

            return formula.CalculateEnumerable(first, second, count - 2).ToArray();
        }
    }
}
