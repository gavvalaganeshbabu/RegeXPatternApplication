using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegeXPatternApplication
{
    internal class Pattern
    {
        public const string FirstCharCapPattern = @"(^[A-Z][a-z]{3,8}$)";
        internal void FirstCharCapValidate(string Name)
        {
            Regex regex = new Regex(FirstCharCapPattern);
            bool result = regex.IsMatch(Name);
            if (result == true)
                Console.WriteLine("Entered Name is Valid ");
            else
                Console.WriteLine("Entered Name is Not Valid");
        }
    }
}
