/*
------------------------------
Reverse Linked List ------------------------------
Reverse a singly linked list.
click to show more hints.
Hint:
A linked list can be reversed either iteratively or recursively. 
Could you implement both?
 */

namespace LeetCode_Practicing.Easy
{
   public class Reverse_LinkedList
    {
       public listnode reverse (listnode head)
        {
            listnode prev = null;
            listnode curr = head;
            listnode nxt = head;

            while (curr != null)
            {
                nxt = curr.Next;
                curr.Next = prev;

                prev = curr;
                curr = nxt;
            }
            return prev;
        }
    }
}
