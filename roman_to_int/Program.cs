using System;

namespace roman_to_int
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new();

           
            Console.WriteLine(solution.RomanToInt("IV"));
            Console.WriteLine(solution.RomanToInt("VI"));
            Console.WriteLine(solution.RomanToInt("IX"));
            Console.WriteLine(solution.RomanToInt("MCMXCIV"));
        }
    }
}
