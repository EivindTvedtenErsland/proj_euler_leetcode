using System;

namespace longest_common_prefix
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new();

            string[] strs_1 = {"flower","flow","flight"};
            string[] strs_2 = {"volvo", "bmw", "ford", "mazda"};
            string[] strs_3 = {"fish","fang","fall"};

            Console.WriteLine(solution.LongestCommonPrefix(strs_1));
            Console.WriteLine(solution.LongestCommonPrefix(strs_2));
            Console.WriteLine(solution.LongestCommonPrefix(strs_3));
        }
    }
}
