using System;

namespace alien_dict
{
    class Program
    {
        static void Main(string[] args)
        {
            string order = "hlabcdefgijkmnopqrstuvwxyz";
            string[] words = { "hello", "leetcode" };
            

            Solution solution = new();

            Console.WriteLine(solution.IsAlienSorted(words, order));

            words = new string[] { "Apple", "App" };

            Console.WriteLine(solution.IsAlienSorted(words, order));
            
            order = "zkgwaverfimqxbnctdplsjyohu";
            words = new string[] { "fxasxpc", "dfbdrifhp", "nwzgs", "cmwqriv", "ebulyfyve", 
                                    "miracx", "sxckdwzv", "dtijzluhts", "wwbmnge", "qmjwymmyox" };
            
            Console.WriteLine(solution.IsAlienSorted(words, order));
        }
    }
}
