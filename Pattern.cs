using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegeXPatternApplication
{
    internal class Pattern
    {
        public const string FirstCharCapPattern = @"(^[a-z0-9A-Z]{1,8}$)";
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
