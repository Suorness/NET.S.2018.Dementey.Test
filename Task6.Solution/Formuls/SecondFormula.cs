using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.Solution.Formuls
{
    public class SecondFormula : IFormula<int>
    {
        public IEnumerable<int> CalculateEnumerable(int first, int second, int count)
        {
            var list = new List<int>();
            int a = first;
            int b = second;
            list.Add(a);
            list.Add(b);

            for (int i = 0; i < count; i++)
            {
                var result = 6 * b - 8 * a;
                a = b;
                b = result;
                list.Add(result);
            }

            return list.ToArray();
        }
    }
}
