/*
------------------------------
Combination Sum 
------------------------------
Given a set of candidate numbers (C) (without duplicates) and a 
target number (T), find all unique combinations in C where the 
candidate numbers sums to T. 
The same repeated number may be chosen from C unlimited number of 
times.
Note:
All numbers (including target) will be positive integers.
The solution set must not contain duplicate combinations.
For example, given candidate set [2, 3, 6, 7] and target 7, 
A solution set is: 
[
  [7],
  [2, 2, 3]
]
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode_Practicing.Medium
{
    public class Combination_Sum
    {
        public List<List<int>> sum(int[] arr , int t)
        {
            Array.Sort(arr);
            Dictionary<List<int>,int> result = new Dictionary<List<int>, int>();
          
            for (int n = 0; n < arr.Length; n++)
            {
               for (int i = 0; i < arr.Length; i++)
                {                    
                    List<int> lst = new List<int>();
                    int sum = 0;
                    int j = -1;

                    while (j < i)
                    {
                        j++;
                        if (sum == t)
                        {
                            if (!result.ContainsKey(lst))
                            {
                                result.Add(lst, lst.Count);
                                break;
                            }
                          
                            
                        }
                        else lst.Add(arr[n]);
                        sum += arr[n];


                    }
                    for (int k = i; k < arr.Length && sum <= t; k++)
                    {
                             if (sum == t)
                        {
                            if (!result.ContainsKey(lst))
                            {
                                result.Add(lst, lst.Count);
                                break;
                            }                      
                        }
                        lst.Add(arr[k]);
                        sum += arr[k];


                    }
                  


                }
            }
            return result.Keys.ToList();
        }
    }
}
