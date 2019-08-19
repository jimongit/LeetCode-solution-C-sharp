/*
------------------------------
Permutations
------------------------------
Given a collection of numbers return 
all possible unique permutations.
For example,
[1,2,3] have the following permutations:
[
  [1,2,3],
  [1,3,2],
  [2,1,3],
  [2,3,1],
  [3,1,2],
  [3,2,1]
]
*/
using System.Collections.Generic;
namespace LeetCode_Practicing.Medium
{
    public class Permutation
    {
        bool[] isUsed;
        int len;
        List<int> lst;
        List<List<int>> res;
        public List<List<int>> permutation(int[] arr)
        {
            len = arr.Length;
            lst = new List<int>();
            res = new List<List<int>>();
            isUsed = new bool[len];
            permutate(0, arr);
            return res;
        }

        private void permutate(int index, int[] arr)
        {
            if (index == len)
            {
                res.Add(lst);
                return;
            } 
            for (int i = 0; i < arr.Length; i++)
            {
                if (!isUsed[i])
                {
                    lst.Add(arr[i]);
                    isUsed[i] = true;
                    permutate(index + 1, arr);
                    isUsed[i] = false;
                    lst.Remove(index);
                }
            }


        }
    }
}
