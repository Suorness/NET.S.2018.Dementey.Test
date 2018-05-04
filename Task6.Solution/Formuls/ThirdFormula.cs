using System.Collections.Generic;


namespace Task6.Solution.Formuls
{
    public class ThirdFormula : IFormula<double>
    {
        public IEnumerable<double> CalculateEnumerable(double first, double second, int count)
        {
            var list = new List<double>();
            double a = first;
            double b = second;


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
