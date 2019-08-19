/*
------------------------------
Remove Duplicates from Sorted List 
------------------------------
Given a sorted linked list, delete all duplicates such that each 
element appear only once.
For example,
Given 1->1->2, return 1->2.
Given 1->1->2->3->3, return 1->2->3.

For example,
Given input array nums = [1,1,2],
Your function should return length = 2, with the first two elements 
of nums being 1 and 2 respectively. It doesn't matter what you leave 
beyond the new length.
 */

namespace LeetCode_Practicing
{
    public class Rem_Duplicates_From_SortedArray
    {
        public int removeDuplicates(int[] a)
        {
           if (a == null || a.Length == 0)
            {
                return 0;
            }
            int j = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != a[j])
                {
                    a[++j] = a[i];
                }
            }
            return j + 1;



        }
    }
}
