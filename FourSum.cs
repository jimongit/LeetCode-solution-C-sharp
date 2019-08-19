using System;
using System.Collections.Generic;
/*
------------------------------
4Sum 
------------------------------
Given an array S of n integers, are there elements a, b, c, and d in 
S such that a + b + c + d = target? Find all unique quadruplets in 
the array which gives the sum of target.
Note: The solution set must not contain duplicate quadruplets.
For example, given array S = [1, 0, -1, 0, -2, 2], and target = 0.
A solution set is:
[
  [-1,  0, 0, 1],
  [-2, -1, 1, 2],
  [-2,  0, 0, 2]
]
*/

namespace LeetCode_Practicing.Medium
{
   public class FourSum
    {
        public List<int[]> sum (int[] s)
        {
            if (s == null && s.Length < 4) return new List<int[]> {};

            Array.Sort(s);
            Dictionary<int[],int> threeSum = new Dictionary<int[], int>();
            List<int[]> foursum = new List<int[]>();

               int indexA = 0;
               int indexB = 0;
               int indexC = 0;
            int sum;
            for (indexA = 0; indexA < s.Length-2; indexA++)
            {
                if (indexA > 0 && s[indexA] <= s[indexA - 1]) continue;
                for (indexB=indexA+1;indexB<s.Length;indexB++)
                {
                    for (indexC = indexB + 1; indexC < s.Length; indexC++)
                    {
                         sum = s[indexA] + s[indexB] + s[indexC];
                        threeSum.Add(new int[] { s[indexA], s[indexB], s[indexC] }, sum);
                      
                    }
                  
                }


            }

            foreach(int[] kys in threeSum.Keys)                                 
            {
                for (int i = 0; i < s.Length; i++) // look for a possible fourth element in the array
                {
                    if(kys[2]<s[i] && kys[0] + kys[1] + kys[2] + s[i] == 0)   // last elements in the current key, the whole elements & fourth element
                    {                                                         
                        foursum.Add(new int[] { kys[0], kys[1], kys[2], s[i] });
                    }
                }
            }

            

            return foursum;
        

        }
    }
}
