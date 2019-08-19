/*
------------------------------
Rotate List 
------------------------------
Given a list, rotate the list to the right by k places, where k is 
non-negative.
For example:
Given 1->2->3->4->5->NULL and k = 2,
return 4->5->1->2->3->NULL.
 */

namespace LeetCode_Practicing.Medium
{
    public class Rotate_List
    {
        //Two pointers
        // note: the idea is to swap element k steps ahead each other,
        // after swapping, if the total element count is odd middle will left alone and 
        // slow will be exactly at the middle so move the middle to the end by swaping it with the next element
        public listnode rotate (listnode head, int k)
        {
            if (head == null) return null;
            if (k == 0) return head;

            // what if K > head length

            listnode dummy = new listnode(0);
            dummy = head;
            listnode slow=dummy;
            listnode fast=dummy; // after K steps
           
            int count=0;
            while (fast != null)
            {
                if (count > k) break;
              else  {
                    count++;
                    fast = fast.Next; // fast is K steps ahead of slow
                                 
                    }
            }

            while (fast != null)
            {
                int tmp = slow.Val;
                slow.Val = fast.Val;
                fast.Val = tmp;
                slow = slow.Next;
                fast = fast.Next;
            }
             

                if(count%2 > 0)               // if the list is odd, the middle node we left alone
                {
                    while (slow.Next != null) //slow is now at the middle, send the middle node to the last
                    {
                        int tmp2 = slow.Val;
                        slow.Val = slow.Next.Val;
                        slow.Next.Val = tmp2;
                    slow = slow.Next;
                    }
                }

            

            return dummy.Next;



            }

        }
    }

