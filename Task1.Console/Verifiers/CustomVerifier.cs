namespace Task1.Console.Verifiers
{
    using System;
    using Task1.Solution;
    public class CustomVerifier : IVerifier
    {
        private readonly string CheckString;

        public CustomVerifier(string checkString)
        {
            CheckString = checkString ?? throw new ArgumentNullException(nameof(checkString));
        }
        public Tuple<bool, string> Verify(string password)
        {
            if (password.Contains(CheckString))
            {
                return Tuple.Create(false, $"{password} contain {CheckString}");
            }

            return Tuple.Create(true, "Password is Ok. User was created");
        }
    }
}
