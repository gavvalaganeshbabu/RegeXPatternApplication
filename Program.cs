using System;

namespace RegeXPatternApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to RegeXpattern Application ");
            Console.WriteLine("Enter a Last Name ");
            Pattern patternChecker=new Pattern();
            string Last_name=Console.ReadLine();
            patternChecker.FirstNameValidate(Last_name);
            Console.ReadLine();
        }
    }
}
