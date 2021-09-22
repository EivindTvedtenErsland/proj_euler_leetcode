using System;

namespace max_subarray
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new();            
            int [] nums = {-2,1,-3,4,-1,2,1,-5,4};

            Console.WriteLine(solution.MaxSubArray(nums));

            nums = new int [] {25,-23,3,5,7,-11,3,-6};

            Console.WriteLine(solution.MaxSubArray(nums));
        }
    }
}
