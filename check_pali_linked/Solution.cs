using System.Collections.Generic;

namespace check_pali_linked
{
public class Solution
    {
        public Solution()
        {
        }

        //Definition for singly-linked list.
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

        public bool IsPalindrome(ListNode head)
        {
            ListNode temp = head;
            bool check = true;
            List<int> valArray = new List<int>();

            while (temp.next != null)
            {
               valArray.Add(temp.val);
                temp = temp.next; 
            }

            valArray.Add(temp.val);
            int j = valArray.Count - 1;

            for(int i = 0; i < valArray.Count - 1; i++){

                if (valArray[i] != valArray[j]){
                    check  = false;
                    break;
                }
                
                j--;
            } 
            return check;
        }
    }
}