using System;
using System.Collections.Generic;

namespace check_pali_linked
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Solution.ListNode> listOfNodes = new List<Solution.ListNode> ();

            Solution.ListNode node1 = new Solution.ListNode(4);
            Solution.ListNode node2 = new Solution.ListNode(5);
            Solution.ListNode node3 = new Solution.ListNode(5);
            //Solution.ListNode node4 = new Solution.ListNode(4);

            node1.next = node2;
            node2.next = node3;
            //node3.next = node4;

            Solution mySolution = new Solution();

            Console.Write(mySolution.IsPalindrome(node1));
        
        }
    }
}

