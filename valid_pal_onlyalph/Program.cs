using System;

namespace valid_pal_onlyalph
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            
            Console.WriteLine(solution.IsPalindrome("A man, a plan, a canal: Panama"));
            Console.WriteLine(solution.IsPalindrome("fee +ee+ -.f  "));
        }
    }
}
