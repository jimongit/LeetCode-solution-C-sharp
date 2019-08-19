/*
------------------------------
Majority Element 
------------------------------
Given an array of size n, find the majority element. The majority 
element is the element that appears more than &lfloor; n/2 &rfloor; 
times.
You may assume that the array is non-empty and the majority element 
always exist in the array.
 */

namespace LeetCode_Practicing.Easy
{
    public class Majority_Element
    {
        public int major(int[] arr)
        {                 
            int count = 0;
            int major = 0;
            foreach (int val in arr)
            {
                if (count == 0)
                {
                    major = val;
                    count = 1;
                    continue;
                }
                if (major == val) count++;
                else count--;
            }
            return major;
            
          
        }
    }
}
