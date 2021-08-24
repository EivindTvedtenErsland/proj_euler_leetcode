using System;

namespace two_sum
{
    class Program
    {
        static public void PrintAnswer(int [] array){
            foreach(int a in array){
                Console.WriteLine(a);
            }
        }
        static void Main(string[] args)
        {   
            int[] testsum_1 = {1,2,3,4};
            int[] testsum_2 = {1,43,5,5,56,13};

            Solution solution = new Solution();

            int[] answer = solution.TwoSum(testsum_1, 7);
            int[] answer_2 = solution.TwoSum(testsum_2, 10);
            PrintAnswer(answer);
            PrintAnswer(answer_2);
        }
    }
}
