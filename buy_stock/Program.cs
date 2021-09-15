using System;

namespace buy_stock
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            // Should give 7 (Buy at 1; Sell at 8)
            Console.WriteLine(solution.MaxProfit(new int[]{1,2,7,5,3,8}));

            // Should give 1 (Buy at 4; Sell at 5)
            Console.WriteLine(solution.MaxProfit(new int[]{4,5,3,2,0,0}));

            Console.WriteLine(solution.MaxProfit(new int[]{7,1,5,3,6,4}));
        }
    }
}
