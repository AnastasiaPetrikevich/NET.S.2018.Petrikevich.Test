using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Solution
{
    public class PasswordCheckerService
    {
        private IRepository repository;
        private IEnumerable<IVerifier> verifiersList;
        private SqlRepository sqlRepository;
        private List<IVerifier> list;

        public PasswordCheckerService(IRepository repository, IEnumerable<IVerifier> verifiersList)
        {
            this.repository = repository;
            this.verifiersList = verifiersList;
        }

        public Tuple<bool, string> VerifyPassword(string password)
        {
            if (password == null)
            {
                throw new ArgumentNullException(nameof(password));
            }

            foreach (var item in verifiersList)
            {
                var flag = item.PasswordVerification(password);
                if (!flag.Item1)
                {
                    return flag;
                }
            }

            repository.Create(password);

            return Tuple.Create(true, "Password is Ok. User was created");
        }

    }
}
