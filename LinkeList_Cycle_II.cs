/*
------------------------------
Linked List Cycle II 
------------------------------
Given a linked list, return the node where the cycle begins. If 
there is no cycle, return null.
Note: Do not modify the linked list.Follow up:
Can you solve it without using extra space?
*/

namespace LeetCode_Practicing.Easy
{
    public class LinkeList_Cycle_II
    {
      public listnode cycleStartAt(listnode head)
        {

            if (head == null) return null;
            
            listnode slow = head;
            listnode fast = head;

            while (fast != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
                if (fast == slow) 
                {
                    fast = head;
                    while (slow != fast) 
                    {
                        slow = slow.Next;
                        fast = fast.Next;
                    }
                    return slow;
                }
            }        
              
        
            return null;
        }
    }   
}
