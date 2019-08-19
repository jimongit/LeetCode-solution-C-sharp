using System;
/*
------------------------------
3Sum Closest 
------------------------------
Given an array S of n integers, find three integers in S such that 
the sum is closest to a given number, target. Return the sum of the 
three integers. You may assume that each input would have exactly 
one solution.    For example, given array S = {-1 2 1 -4}, and target = 1.
    The sum that is closest to the target is 2. (-1 + 2 + 1 = 2).
 */

namespace LeetCode_Practicing.Medium
{
    public class ThreeSum_Closest
    {
        public int sumClosest(int[] s, int target)
        {
            
            Array.Sort(s);

            int closest=0;
            for (int i = 0; i < s.Length && i < 3; i++) closest += s[i];

           
            for (int i = 0; i < s.Length - 2; i++)
            {
                int j = i + 1;
                int k = s.Length - 1;

                if (i > 0 && s[i] + s[i - 1] == target) continue; // alreadly equal to target

                while (j < k)
                {
                    int sum = s[i] + s[j] + s[k];
                    if (Math.Abs(target- sum) < Math.Abs(target-closest)) closest = sum;
                    {
                        if (sum == target) return closest;
                        
                    }                   
                     if (sum > target)  k--;
                    else
                        j++;

                    while (s[j] == s[j + 1]) j++;
                    while (s[k] == s[k - 1]) k--;
                    j++;
                    k--;
                }

            }
            return closest;
        }
    }
}
