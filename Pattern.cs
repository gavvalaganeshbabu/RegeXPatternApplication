using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegeXPatternApplication
{
    internal class Pattern
    {
        public const string Last_NamePattern = "^[A-Z][a-zA-Z]*$";
        internal void FirstNameValidate(string First_name)
        {
            Regex regex = new Regex(Last_NamePattern);
            bool result = regex.IsMatch(First_name);
            if (result == true)
                Console.WriteLine("Entered Last_name is Valid ");
            else
                Console.WriteLine("Entered Last_name is Not Valid");
        }
    }
}
