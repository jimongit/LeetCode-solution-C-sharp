/*
------------------------------
Product of Array Except Self 
------------------------------
Given an array of n integers where n > 1, nums, return an array 
output such that output[i] is equal to the product of all the 
elements of nums except nums[i].
Solve it without division and in O(n).
For example, given [1,2,3,4], return [24,12,8,6].
Follow up:
Could you solve it with constant space complexity? (Note: The output 
array does not count as extra space for the purpose of space 
complexity analysis.)
*/

using System.Collections.Generic;

namespace LeetCode_Practicing.Medium
{
   public class Product_of_Array_Except_Self
    {
        public List<int> productExceptSelf(int[] arr)
        {
            if (arr == null) return null;
             int product = 0;
            List<int> lst = new List<int>();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                product *= arr[i];
                lst.Add(product);
            }
            for (int i = 0; i < arr.Length; i++)
            {
              lst.Add(product - arr[i]);
            }
            return lst;
          
        }
    }
}
