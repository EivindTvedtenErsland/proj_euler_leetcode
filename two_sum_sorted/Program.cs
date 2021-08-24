using System;

namespace two_sum_sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            
            ListNode node_3 = new ListNode(5);
            ListNode node_2 = new ListNode(7, node_3);
            ListNode node_1 = new ListNode(3, node_2);

            ListNode node_3_b = new ListNode(2);
            ListNode node_2_b = new ListNode(2, node_3_b);
            ListNode node_1_b = new ListNode(1, node_2_b);

            solution.AddTwoNumbers(node_1, node_1_b);

            Console.WriteLine("Hello World!");
        }
    }
}
