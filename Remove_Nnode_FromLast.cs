/*
------------------------------
Remove Nth Node From End of List 
------------------------------
Given a linked list, remove the nth node from the end of list and 
return its head.For example,
   Given linked list: 1->2->3->4->5, and n = 2.
   After removing the second node from the end, the linked list 
becomes 1->2->3->5.
Note:
Given n will always be valid.
Try to do this in one pass.
 */

namespace LeetCode_Practicing
{

    public class listnode
        
    {
        public int Val;
        public listnode Next=null;
        public listnode(int x)
        {
            Val = x;
        }
    }
      

   public class Remove_Nnode_FromLast
    {
        public listnode removeNthElementFromLast(listnode LK, int n)
        {
            if (LK == null) return null;
            if (n == 0) return LK;

            listnode pre = new listnode(0);
            pre.Next = LK;
            listnode R1=pre;
            listnode R2=pre;

            int i = 0;
            while (i < n)
            {
                R1 = R1.Next;
                i++;
            }
            while (R1 != null)
            {
                R1 = R1.Next;
                R2 = R2.Next;
            }
            R2.Next = R2.Next.Next;
            
            return LK;
        }

       

        
    }

   

       
}

