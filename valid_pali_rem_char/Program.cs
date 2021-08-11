using System;

namespace valid_pal_onlyalph
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            
            Console.WriteLine(solution.ValidPalindrome("aabbvcaa"));
            Console.WriteLine(solution.ValidPalindrome("aabbcaa"));
        }
    }
}
