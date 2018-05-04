namespace Task6.Solution.Formuls
{
    using System.Collections.Generic;

    public class ThirdFormula : IFormula<double>
    {
        public IEnumerable<double> CalculateEnumerable(double first, double second, int count)
        {
            var list = new List<double>();
            double a = first;
            double b = second;
            list.Add(a);
            list.Add(b);

            for (int i = 0; i < count; i++)
            {
                var result = b + a / b;
                a = b;
                b = result;
                list.Add(result);
            }

            return list.ToArray();
        }
    }
}
