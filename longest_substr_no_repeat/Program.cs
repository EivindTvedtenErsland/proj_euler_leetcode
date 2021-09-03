using System;

namespace longest_substr_no_repeat
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new();

            Console.WriteLine(solution.LengthOfLongestSubstring("dvdf"));
            Console.WriteLine(solution.LengthOfLongestSubstring("bbbb"));   
            Console.WriteLine(solution.LengthOfLongestSubstring("asdgfggh"));
            Console.WriteLine(solution.LengthOfLongestSubstring("pwwkew"));
            Console.WriteLine(solution.LengthOfLongestSubstring(""));
            Console.WriteLine(solution.LengthOfLongestSubstring(" "));
        }
    }
}
