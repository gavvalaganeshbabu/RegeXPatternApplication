using System;

namespace RegeXPatternApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to RegeXpattern Application ");
            Console.WriteLine("Enter Password ");
            Pattern patternChecker=new Pattern();
            string Password = Console.ReadLine();
            patternChecker.PasswordValidate(Password);
            Console.ReadLine();
        }
    }
}
