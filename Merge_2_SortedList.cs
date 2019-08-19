/*
------------------------------
Merge Two Sorted Lists 
------------------------------
Merge two sorted linked lists and return it as a new list. The new 
list should be made by splicing together the nodes of the first two 
lists.
 */

namespace LeetCode_Practicing.Easy
{

    public class ListNode
    {
        public int Val;
        public ListNode Next = null;
        public ListNode(int x)
        {
            Val = x;
        }
    }


    public class Merge_2_SortedList
    {

        public listnode merge(listnode l1, listnode l2)
        {
            if (l1 == null && l2 == null) return null;
            else if (l1 == null) return l2;
            else if (l2 == null) return l1;

            listnode head   = new listnode(0);
            listnode dummy = head;

            while (l1 != null && l2 != null)
            {
                if (l1.Val <= l2.Val)
                {
                    dummy.Next = l1;
                    l1 = l1.Next;
                }
                else
                {
                    dummy.Next = l2;
                    l2 = l2.Next;
                }
               dummy = dummy.Next;
            }

            while (l1 != null)   // a's remaining elements
            {
                dummy.Next = l1;
                l1 = l1.Next;
            }
            while (l2 != null)  // b's remaining elements
            {
                dummy.Next = l2;
                l2 = l2.Next;
            }


            return head.Next;
        }
    }
}

