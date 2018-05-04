using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.Solution.Formuls
{
    public class SumFormula : IFormula<int>
    {
        public IEnumerable<int> CalculateEnumerable(int first, int second, int count)
        {
            var list = new List<int>();
            int a = first;
            int b = second;
            

            for (int i = 0; i < count; i++)
            {
                var result = a + b;
                a = b;
                b = result;
                list.Add(result);
            }

            return list.ToArray();
        }
    }
}
