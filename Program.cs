using System;

namespace RegeXPatternApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to RegeXpattern Application ");
            Console.WriteLine("Enter a First Name ");
            Pattern patternChecker=new Pattern();
            string First_name=Console.ReadLine();
            patternChecker.FirstNameValidate(First_name);
            Console.ReadLine();
        }
    }
}
