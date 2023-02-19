using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegeXPatternApplication
{
    internal class Pattern
    {
        public const string PasswordPattern = @"([a-z,A-Z,0-9]{8}$)";
        internal void PasswordValidate(string Password)
        {
            Regex regex = new Regex(PasswordPattern);
            bool result = regex.IsMatch(Password);
            if (result == true)
                Console.WriteLine("Entered Password is Accepted ");
            else
                Console.WriteLine("Entered Password is Not Accepted Try Again ");
        }
    }
}
