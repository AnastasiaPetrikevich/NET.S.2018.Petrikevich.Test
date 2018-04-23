using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Solution
{
    public class NullPasswordVerifier : IVerifier
    {
        public Tuple<bool, string> PasswordVerification(string password)
        {
            if (password == null)
                throw new ArgumentException($"{password} is null arg");

            return Tuple.Create(true, "Password is Ok. User was created");
        }
    }

    public class EmptyPasswordVerifier : IVerifier
    {
        public Tuple<bool, string> PasswordVerification(string password)
        {
            if (password == string.Empty)
                return Tuple.Create(false, $"{password} is empty ");

            return Tuple.Create(true, "Password is Ok. User was created");
        }
    }

    public class MinLengthPasswordVerifier : IVerifier
    {
        private const int minPasswordLength = 7;

        public Tuple<bool, string> PasswordVerification(string password)
        {
            // check if length more than 7 chars 
            if (password.Length <= minPasswordLength)
                return Tuple.Create(false, $"{password} length too short");

            return Tuple.Create(true, "Password is Ok. User was created");
        }
    }

    public class MaxLengthPasswordVerifier : IVerifier
    {

        private const int maxPasswordLength = 15;

        public Tuple<bool, string> PasswordVerification(string password)
        {
            // check if length more than 10 chars for admins
            if (password.Length >= maxPasswordLength)
                return Tuple.Create(false, $"{password} length too long");

            return Tuple.Create(true, "Password is Ok. User was created");
        }
    }

    public class LetterPasswordVerifier : IVerifier
    {
        public Tuple<bool, string> PasswordVerification(string password)
        {
            // check if password conatins at least one alphabetical character 
            if (!password.Any(char.IsLetter))
                return Tuple.Create(false, $"{password} hasn't alphanumerical chars");

            return Tuple.Create(true, "Password is Ok. User was created");
        }
    }

    public class NumbersPasswordVerifier : IVerifier
    {
        public Tuple<bool, string> PasswordVerification(string password)
        {

            // check if password conatins at least one digit character 
            if (!password.Any(char.IsNumber))
                return Tuple.Create(false, $"{password} hasn't digits");

            return Tuple.Create(true, "Password is Ok. User was created");
        }
    }

}
