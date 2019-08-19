/*
------------------------------
Reverse Linked List II 
------------------------------
Reverse a linked list from position m to n. Do it in-place and in 
one-pass.
For example:Given 1->2->3->4->5->NULL, m = 2 and n = 4,
return 1->4->3->2->5->NULL.
Note:
Given m, n satisfy the following condition:
1 ≤ m ≤ n ≤ length of list.
 */

namespace LeetCode_Practicing.Medium
{
    public class Reverse_Linked_List__II
    {
        public listnode reverse(listnode head, int m,int n)
        {
            if ( m == n) return head;
            listnode mPrev = null;
            listnode nAfter = null;
            listnode mPrevPrev = null;
            listnode tmp = head;

            //reverse
            int i = 1;
            while(tmp!=null && i <= n)
            {
                if (n == m - 1) mPrevPrev = tmp;
                if (i == m) mPrev = tmp;
                if (i == n) nAfter = tmp.Next;
            }
            ++i;
            tmp = tmp.Next;

            if (mPrev.Next == null) return head;

            listnode p1 = mPrev;
            listnode p2 = p1.Next;

            while(p1!=null&& p2 != null)
            {
                listnode t = p2.Next;
                p2.Next = p1;
                p1 = p2;
                p2 = t;
            }
            if (mPrevPrev != null) mPrevPrev.Next = p1;      //connecting
            else return p1;

            return head;
           
        }
    }
}
