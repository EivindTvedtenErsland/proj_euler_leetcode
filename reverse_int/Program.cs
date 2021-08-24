using System;

namespace reverse_int
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new();

            Console.WriteLine(solution.Reverse(-321));
            Console.WriteLine(solution.Reverse(0));
            Console.WriteLine(solution.Reverse(1534236469));
            Console.WriteLine(solution.Reverse(-2147483648));
            Console.WriteLine(solution.Reverse(-3456));
            Console.WriteLine(solution.Reverse(74354));
        }
    }
}
