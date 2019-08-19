using System.Collections.Generic;
/*
------------------------------
Majority Element II 
------------------------------
Given an integer array of size n, find all elements that appear more 
than n/3 times. The algorithm should run in linear 
time and in O(1) space.
*/


namespace LeetCode_Practicing.Medium
{
   public class Majority_Element_II
    {
      public List<int> majorityElements(int[] arr, int n)
        {
            List<int> lst = new List<int>();
            int len = n/ 3; //always there are only one or two elements whose count is > len // Moore's Voting Algorithm
            int major1 = 0, major2 = 0;
            int count1= int.MaxValue, count2 = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] == major1) count1++;
                else if (arr[i] == major2) count2++;
                else if (count1 == 0)
                {
                    count1++;
                    arr[i] = major1;
                }
                else if(count2==0)
                {
                    count2++;
                    arr[i] = major2;
                }
                else
                {
                    count1--;
                    count2--;
                }
            }
            count1 = 0;
            count2 = 0;
            for (int i = 0; i < n; i++)
            {
                if (count1 == arr[i]) count1++;
                else if (count2 == arr[i]) count2++;
                if(count1>len) lst.Add(major1);
                if(count2>len) lst.Add(major2);

            }
            return lst;

        }
    }
}
