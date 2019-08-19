using System;
/*
--------------------------------
Kth Largest Element in an Array 
--------------------------------
Find the kth largest element in an unsorted array. Note that it is 
the kth largest element in the sorted order, not the kth distinct 
element.
For example,
Given [3,2,1,5,6,4] and k = 2, return 5.
Note: 
You may assume k is always valid, 1 ≤ k ≤ array's length.
*/

namespace LeetCode_Practicing.Medium
{
    public class Kth_Largest_element_in_Array
    {
        public int kthElement(int[] arr,int k)
        {
          if (arr == null || k==0) return -1;
            Array.Sort(arr);
          for (int i = arr.Length-1; i>=0; i--)
            {
                if (i > 0 && arr[i - 1] == arr[i])
                {
                    k++;  // duplicates don't count eg-{1,2,2,4,5,7,7} 
                    continue;   
                }
                else return arr[arr.Length - k]; // kth element from the sorted array is the kth largest element          

            }
            return -1;
        }

        
    }
}
