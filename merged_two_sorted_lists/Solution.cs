using System.Collections.Generic;

namespace merged_two_sorted_lists
{

    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

     public class Solution
     {
          public ListNode MergeTwoLists(ListNode l1, ListNode l2)
          {
               if (l1 == null) return l2;
               if (l2 == null) return l1;

               if (l1.val <= l2.val)
               {
                    return new ListNode(l1.val, MergeTwoLists(l1.next, l2));
               }
               else
               {
                    return new ListNode(l2.val, MergeTwoLists(l1, l2.next));
               }
          }

     }
}

/*

 public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            // This answer doesn't fulfill the "The list should be made by splicing together the nodes of the first two lists"
            // criteria, not to mention inefficient
            ListNode head = new();
            List<int> sortedList = new();

            while (l1.next != null)
            {
                sortedList.Add(l1.val);
                l1 = l1.next;
            }
            sortedList.Add(l1.val);

            while (l2.next != null)
            {
                sortedList.Add(l2.val);
                l2 = l2.next;
            }
            sortedList.Add(l2.val);
            
            sortedList.Sort();

            for (int i = 0; i < sortedList.Count; i++)
            {
                ListNode temp = new();
                if (i == 0)
                {
                    temp.val = sortedList[i];
                    temp.next = null;
                    head = temp;
                }
                else
                {
                    temp.val = sortedList[i];
                    temp.next = head;
                    head = temp;          
                }
            }

            return head;
        }

        */