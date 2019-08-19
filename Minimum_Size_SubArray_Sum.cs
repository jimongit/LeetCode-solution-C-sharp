using System;
/*
------------------------------
Minimum Size Subarray Sum 
------------------------------
Given an array of n positive integers and a positive integer s, find 
the minimal length of a contiguous subarray of which the sum ≥ s. If 
there isn't one, return 0 instead.
For example, given the array [2,3,1,2,4,3] and s = 7,
the subarray [4,3] has the minimal length under the problem 
constraint.

More practice:
If you have figured out the O(n) solution, try coding another 
solution of which the time complexity is O(n log n).




*/

namespace LeetCode_Practicing.Medium
{
    public class Minimum_Size_SubArray_Sum
    {
        public int miniSize(int[] arr , int s)
        {
            int i = 0;
            int j = 0;
            int sum = 0;
           int size = int.MaxValue;
            while(i<arr.Length)
            {
                if (arr[i] >= s || arr[j] >= s) return 1;
                while (sum < s)
                {
                       sum += arr[j];
                      if(j +1 < arr.Length) j++;
                   

                }
                if (sum >= s)
                {
                    size = Math.Min(size, (j - i) + 1);
                    sum -= arr[i];                                   
                    i++;
                }
               
               
            }
          
            return size;
        }
    }
}
