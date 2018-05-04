using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Tests
{
    using Task2.Solution;

    public static class Program
    {
        public static void Main()
        {
            FileGenerator fileGenerator1 = new RandomBytesFileGenerator();
            FileGenerator fileGenerator2 = new RandomCharsFileGenerator();

            fileGenerator1.GenerateFiles(1, 10);
            fileGenerator2.GenerateFiles(1, 10);
        }
    }
}
