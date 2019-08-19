/*
------------------------------
Two Sum 
------------------------------
Given an array of integers, return indices of the two numbers such 
that they add up to a specific target.
You may assume that each input would have exactly one solution, and 
you may not use the same element twice.
Example:
Given nums = [2, 7, 11, 15], target = 9,
Because nums[0] + nums[1] = 2 + 7 = 9,
return [0, 1].
 */
using System.Collections.Generic;

namespace LeetCode_Practicing.Medium
{
    public class TwoSum
    {
        public int[] twoSum(int[] arr, int target)
        {
            if (arr == null) return null;
         
            Dictionary<int, int> lst = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                lst.Add(arr[i],i);
            }
            int[] result = new int[2];
            for (int i = 0; i < arr.Length; i++)
            {
                int newTarget = target - arr[i]; 
                
                if (lst.ContainsValue(newTarget)&& i>lst[newTarget])
                {
                    result[0] = lst[newTarget] + 1;
                    result[1] = i + 1;
                    return result;
                                    
                }


            }

            return null;
        }
    }
}

