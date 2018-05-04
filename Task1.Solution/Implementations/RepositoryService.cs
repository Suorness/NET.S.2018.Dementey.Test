namespace Task1.Solution
{
    using System;

    public class RepositoryService
    {
        private IRepository _repository;


        public RepositoryService(IRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public Tuple<bool, string> TryCreate(string password, params IVerifier[] verifiers)
        {
            var result = VerifyPassword(password, verifiers);
            if (result.Item1)
            {
                _repository.Create(password);
            }

            return result;
        }

        protected virtual Tuple<bool, string> VerifyPassword(string password, params IVerifier[] verifiers)
        {
            if (ReferenceEquals(password, null))
            {
                throw new ArgumentNullException($"{password} is null arg");
            }

            if (password == string.Empty)
            {
                return Tuple.Create(false, $"{password} is empty ");
            }

            if (password.Length <= 7)
            {
                return Tuple.Create(false, $"{password} length too short");
            }

            if (password.Length >= 15)
            {
                return Tuple.Create(false, $"{password} length too long");
            }

            if (!ReferenceEquals(verifiers, null))
            {
                foreach (var verifier in verifiers)
                {
                    var result = verifier.Verify(password);
                    if (!result.Item1)
                    {
                        return result;
                    }
                }
            }

            return Tuple.Create(true, "Password is Ok. User was created");
        }
    }
}
