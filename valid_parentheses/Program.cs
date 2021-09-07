using System;

namespace valid_parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new();

            Console.WriteLine(solution.IsValid("(([]){})"));
            Console.WriteLine(solution.IsValid("{[()]}{(}"));
            Console.WriteLine(solution.IsValid("[}"));
            Console.WriteLine(solution.IsValid("[]"));
            Console.WriteLine(solution.IsValid("[]{}()"));
        }
    }
}
