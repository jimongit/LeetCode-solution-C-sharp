/*
------------------------------
Increasing Triplet Subsequence 
------------------------------
Given an unsorted array return whether an increasing subsequence of 
length 3 exists or not in the array.
Formally the function should:
Return true if there exists i, j, k  
such that arr[i] &lt; arr[j] &lt; arr[k] given 0 &le; i &lt; j &lt; 
k &le; n-1 
else return false.
Your algorithm should run in O(n) time complexity and O(1) space 
complexity.
Examples:
Given [1, 2, 3, 4, 5],
return true.
Given [5, 4, 3, 2, 1],
return false.
*/

namespace LeetCode_Practicing.Medium
{
    public class Increasing_Triplet_Subsquence
    {
       public bool increasingTriple(int[] arr)
        {
            int count = 0;
            bool flag = false;
            for (int i = 0; i<arr.Length; i++)
            {
                if (i > 0 && i<arr.Length-2 && arr[i - 1]>arr[i] && arr[i+1]>arr[i])
                {
                    count++;
                }
                else
                {
                    count = 0;
                    if (count == 3) flag = true;
                }
            }
            return flag == true;
           
        }
    }
}
