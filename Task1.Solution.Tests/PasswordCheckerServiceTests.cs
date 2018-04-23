using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task1.Solution.Tests
{
    public class PasswordCheckerServiceTests
    {
        [TestFixture]
        public class PasswordTest
        {
            [TestCase("ABC123de45", ExpectedResult = "(True, Password is Ok. User was created)")]
            [TestCase("12345678", ExpectedResult = "(False, 12345678 hasn't alphanumerical chars)")]
            [TestCase("AbCdEfGh", ExpectedResult = "(False, AbCdEfGh hasn't digits)")]
            [TestCase("AbCdEfGh12345678", ExpectedResult = "(False, AbCdEfGh12345678 length too long)")]
            [TestCase("12ab", ExpectedResult = "(False, 12ab length too short)")]
            public string VerifyPassword_Result(string password)
            {
                List<IVerifier> verifiers = new List<IVerifier>();
                verifiers.Add(new MinLengthPasswordVerifier());
                verifiers.Add(new MaxLengthPasswordVerifier());
                verifiers.Add(new NumbersPasswordVerifier());
                verifiers.Add(new LetterPasswordVerifier());
                PasswordCheckerService service =
                    new PasswordCheckerService(new SqlRepository(), verifiers);

                return service.VerifyPassword(password).ToString();
            }
        }
    }
}
