
using System;

namespace two_sum_sorted
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public static ListNode AddNode(int value, ListNode next = null){
            ListNode temp = new ListNode(value);
            return temp;
        }
    }
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode temp;
            var combine_l1 = new System.Text.StringBuilder();
            var combine_l2 = new System.Text.StringBuilder();
           
            temp = l1;
            while (temp.next != null)
            {
                combine_l1.Append(Convert.ToString(temp.val));
                temp = temp.next;
            }

            combine_l1.Append(Convert.ToString(temp.val));
            temp = l2;
            while (temp.next != null)
            {
                combine_l2.Append(Convert.ToString(temp.val));
                temp = temp.next;
            }
            combine_l2.Append(Convert.ToString(temp.val));

            var result = Int32.Parse(combine_l1.ToString()) + Int32.Parse(combine_l2.ToString());

        
            return new ListNode();
        }
    }
}