using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegeXPatternApplication
{
    internal class Pattern
    {
        public const string Last_NamePattern = "^[A-Z][a-zA-Z]*$";
        internal void LastNameValidate(string Last_name)
        {
            Regex regex = new Regex(Last_NamePattern);
            bool result = regex.IsMatch(Last_name);
            if (result == true)
                Console.WriteLine("Entered Last_name is Valid ");
            else
                Console.WriteLine("Entered Last_name is Not Valid");
        }
    }
}
