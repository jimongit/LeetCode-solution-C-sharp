/*
------------------------------
Linked List Cycle 
------------------------------
Given a linked list, determine if it has a cycle in it.
Follow up:
Can you solve it without using extra space?
 */

namespace LeetCode_Practicing.Easy
{
   public class LinkedList_Cycle
    {
        public bool hasCycle(listnode head)
        {
            if (head == null) return false;

            listnode slow = head;
            listnode fast = head;

            while (slow != null && fast.Next!= null) // for cyclic linkedlist neither should be null
            {
                slow = slow.Next;
                fast = fast.Next.Next;
                if (slow == fast) return true;
               
            }
            return false;


            
        }
    }
}
