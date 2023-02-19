using System;

namespace RegeXPatternApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to RegeXpattern Application ");
            Console.WriteLine("Enter a Email Name ");
            Pattern patternChecker=new Pattern();
            string Email=Console.ReadLine();
            patternChecker.EmailValidate(Email);
            Console.ReadLine();
        }
    }
}
