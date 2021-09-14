using System;

namespace merged_two_sorted_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            ListNode l1 = new(5);
            ListNode l2 = new(4, l1);
            ListNode l3 = new(1, l2);
            ListNode la = new(11);
            ListNode lb = new(9, la);
            ListNode lc = new(2, lb);

            ListNode answer = solution.MergeTwoLists(lc, l3);
            
            while (answer.next != null)
            {
                Console.WriteLine(answer.val);
                answer = answer.next;
            }

            Console.WriteLine(answer.val);
        }
    }
}
