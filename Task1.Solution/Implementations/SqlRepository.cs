namespace Task1.Solution
{
    using System;

    public class SqlRepository : IRepository
    {
        public void Create(string password)
        {
            Console.WriteLine("Was created");
        }
    }
}
