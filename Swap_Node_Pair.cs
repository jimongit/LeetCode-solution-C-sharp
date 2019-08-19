/*
------------------------------
Merge k Sorted Lists 
------------------------------
Merge k sorted linked lists and return it as one sorted list. 
Analyze and describe its complexity.
 */

namespace LeetCode_Practicing.Medium
{
    public class Swap_Node_Pair
    {
        public listnode swap(listnode head)
        {
            if (head == null || head.Next == null)return head;

            listnode dummy = new listnode(0);
            dummy.Next = head;
            listnode cur = dummy;

            while(cur.Next!=null && cur.Next.Next != null)
            {
                listnode tmp1 = cur;
                cur = cur.Next;
                tmp1.Next = cur.Next;


                listnode tmp2 = cur.Next.Next;
                cur.Next.Next = cur;
                cur.Next = tmp2;
            }
            return dummy.Next;
                            
        }
       
    }
}
