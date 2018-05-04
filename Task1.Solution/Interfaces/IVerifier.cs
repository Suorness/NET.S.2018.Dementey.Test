namespace Task1.Solution
{
    using System;

    public interface IVerifier
    {
        Tuple<bool, string> Verify(string password);
    }
}
