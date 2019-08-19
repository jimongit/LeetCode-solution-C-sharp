using System.Collections.Generic;
/*

*/


namespace LeetCode_Practicing.Medium
{
    public class Linked_List_Components
    {
        public int connectedG(listnode head,int[]G)
        {
            if (head == null || G == null) return -1;
            HashSet<int> setG = new HashSet<int>();
            foreach (int val in G) setG.Add(val);
            int count = 0;
            bool exist = false;
            while (head != null)
            {
                if (setG.Contains(head.Val))
                {
                    if (!exist)
                    {
                        exist = true;
                        count++;
                    }
                }
                else exist = false;
                head = head.Next;

            }
            return count;
        }

    }
}
