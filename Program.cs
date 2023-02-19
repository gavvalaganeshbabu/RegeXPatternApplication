using System;

namespace RegeXPatternApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to RegeXpattern Application ");
            Console.WriteLine("Enter your Mobile Number ");
            Pattern patternChecker=new Pattern();
            string MobileNumber = Console.ReadLine();
            patternChecker.FirstNameValidate(MobileNumber);
            Console.ReadLine();
        }
    }
}
