/*
------------------------------
Single Number 
------------------------------
Given an array of integers, every element appears twice except for 
one. Find that single one.
Note:
Your algorithm should have a linear runtime complexity. Could you implement it without using extra memory?

*/

using System.Collections.Generic;
namespace LeetCode_Practicing.Easy
{
    public class Single_Number
    {
        public int find(int[] arr)  // O(1) space
        {
            int result = 0;
            foreach (var el in arr)
            {
                result ^= el;
            }
            return result;
        }

        public int singleNum(int[] arr)  // O(n) space
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
             
            for (int i = 0; i < arr.Length; i++)
            {
              if (dic.ContainsKey(arr[i]))   //found duplicate key, update the value(count)
                    dic[arr[i]]=2;
                else dic.Add(arr[i], 1);       // add new
                
            }
            foreach (int key in dic.Keys)
            {
                if (dic[key] == 1) return key;  // all values are 2, except one
            }
            return -1;

        }
    }
}
