/*
------------------------------
Summary Ranges 
------------------------------
Given a sorted integer array without duplicates, return the summary 
of its ranges.
For example, given [0,1,2,4,5,7], return ["0->2","4->5","7"].
 */
using System.Collections.Generic;

namespace LeetCode_Practicing.Medium
{
    public class Summary_Range
    {
        public List<string> range(int[] arr)
        {
            if (arr == null) return null;
            string s = "";
            List<string> lst = new List<string>();
            bool flag = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < arr.Length - 2 && arr[i] +1 == arr[i + 1])
                {
                    if (flag == false)
                    {
                        s = s + (arr[i] + "->");
                        flag = true;
                                               
                    }
                }
                else
                {
                    s = s + arr[i];
                    lst.Add(s);
                    s = "";
                    flag = false;
                }               
            }
            return lst;
        }
    }
}
