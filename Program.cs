using System;

namespace RegeXPatternApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to RegeXpattern Application ");
            Console.WriteLine("Enter your Name ");
            Pattern patternChecker=new Pattern();
            string Name = Console.ReadLine();
            patternChecker.FirstCharCapValidate(Name);
            Console.ReadLine();
        }
    }
}
