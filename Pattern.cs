using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegeXPatternApplication
{
    internal class Pattern
    {
        public const string EmailPattern = @"[a-z]{3,7}.?[a-z0-9]{3,8}@[a-z]{3,8}.(com|org)$";
        internal void FirstNameValidate(string Email)
        {
            Regex regex = new Regex(EmailPattern);
            bool result = regex.IsMatch(Email);
            if (result == true)
                Console.WriteLine("Entered Mail is Valid ");
            else
                Console.WriteLine("Entered Mail is Not Valid");
        }
    }
}
