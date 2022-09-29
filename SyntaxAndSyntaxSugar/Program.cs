using System;

namespace SyntaxAndSyntaxSugar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inferred typing, string interpolation, and the ternary operator

            var answer = 10;

            var response = (answer < 9)? $"{answer}is less than 9." : $"{answer} is greater than or equal to 9.";
            Console.WriteLine(response);
        }
    }
}
