using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegeXPatternApplication
{
    internal class Pattern
    {
        public const string MobileNumberPattern = @"(^[0-9]{10}$)|(^[0-9]{3}-[0-9]{4}-[0-9]{4}$)";
        internal void FirstNameValidate(string MobileNumber)
        {
            Regex regex = new Regex(MobileNumberPattern);
            bool result = regex.IsMatch(MobileNumber);
            if (result == true)
                Console.WriteLine("Entered MobileNumber is Valid ");
            else
                Console.WriteLine("Entered MobileNumber is Not Valid");
        }
    }
}
