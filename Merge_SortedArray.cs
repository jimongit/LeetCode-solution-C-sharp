/*
------------------------------
Merge Sorted Array 
------------------------------
Given two sorted integer arrays nums1 and nums2, merge nums2 into 
nums1 as one sorted array.
Note:
You may assume that nums1 has enough space (size that is greater or 
equal to m + n) to hold additional elements from nums2. The number 
of elements initialized in nums1 and nums2 are m and n respectively.
 */

namespace LeetCode_Practicing
{
    public class Merge_SortedArray
    {
        public int[] merge( int[]num1, int[] num2)
        {
                    
            int endOfNum1=num1.Length;
            bool flag = false;
            for (int i = 0; i < num1.Length+num2.Length; i++)
            {
                if (i == endOfNum1-2 && flag == false) i = 0; flag = true;
                if (num1[i] <= num2[i]) num1[endOfNum1 + 1] = num1[i]; num2[endOfNum1 + 2] = num2[i];
                if (num1[i] <= num2[i]) num2[endOfNum1 + 1] = num2[i]; num1[endOfNum1 + 2] = num1[i];                
                
            }
                           
            return num1;
        }
    }
}
