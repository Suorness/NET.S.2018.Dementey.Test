namespace Task6.Solution
{
    using System.Collections.Generic;

    public interface IFormula<T>
    {
        IEnumerable<T> CalculateEnumerable(T first, T second, int count);
    }
}
