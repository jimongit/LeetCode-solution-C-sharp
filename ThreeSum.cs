using System;
using System.Collections.Generic;
/*
------------------------------
3Sum 
------------------------------
Given an array S of n integers, are there elements a, b, c in S such 
that a + b + c = 0? Find all unique triplets in the array which 
gives the sum of zero.
Note: The solution set must not contain duplicate triplets.
For example, given array S = [-1, 0, 1, 2, -1, -4],
A solution set is:
[
  [-1, 0, 1],
  [-1, -1, 2]
]
 */

namespace LeetCode_Practicing.Medium
{
    public class ThreeSum
    {
        public List<int[]> sum(int[] s)
        {
            Array.Sort(s);
            if (s == null || s.Length < 3) return null;
                    
            List<int[]> lst = new List<int[]>();
            
           
            for (int indexA = 0; indexA < s.Length-2; indexA++) // s.Length-2 --- next-indexB, next.next -indexC
            {
                                        
                int indexB = indexA +1;  
                int indexC = s.Length-1; 

                if (indexA > 0 && s[indexA] == s[indexA - 1]) continue;

                while (indexB < indexC)
                {
                    int sum = s[indexA] + s[indexB] + s[indexC];
                    if (sum < 0) indexB++;
                    else if (sum > 0) indexC--;
                    else
                    {
                        lst.Add(new int[] { s[indexA], s[indexB], s[indexC] });
                       
                    }
                    
                    while (s[indexB] == s[indexB + 1]) indexB++;
                    while (s[indexC] == s[indexC - 1]) indexC--;

                    indexB++;
                    indexC--;

                }
                    
                }
    return lst;
            }

          
        
    }
}
