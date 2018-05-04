namespace Task1.Console
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Task1.Console.Verifiers;
    using Task1.Solution;

    class Program
    {
        static void Main(string[] args)
        {
            IRepository repository = new SqlRepository();
            RepositoryService repositoryService = new RepositoryService(repository);
            IVerifier verifier1 = new CustomVerifier("1");
            IVerifier verifier2 = new CustomVerifier("2");

            string password = "123455555";
            var result = repositoryService.TryCreate(password);
            Console.WriteLine(result.Item2);

            string password1 = "12345";
            result = repositoryService.TryCreate(password1);
            Console.WriteLine(result.Item2);

            string password2 = "12345555552222222222255";
            result = repositoryService.TryCreate(password2);
            Console.WriteLine(result.Item2);

            string password3 = "";
            result = repositoryService.TryCreate(password3);
            Console.WriteLine(result.Item2);

            string password4 = null;
            try
            {
                result = repositoryService.TryCreate(password4);
                Console.WriteLine(result.Item2);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
          
            string password5 = "123455555";
            result = repositoryService.TryCreate(password5, verifier1);
            Console.WriteLine(result.Item2);

            result = repositoryService.TryCreate(password5, verifier1, verifier2);
            Console.WriteLine(result.Item2);
            Console.ReadLine();

        }
    }
}
