/*
------------------------------
Plus One 
------------------------------
Given a non-negative integer represented as a non-empty array of 
digits, plus one to the integer.
You may assume the integer do not contain any leading zero, except 
the number 0 itself.
The digits are stored such that the most significant digit is at the 
head of the list.
 */
using System.Collections.Generic;

namespace LeetCode_Practicing.Easy
{
    public class Plus_One
    {
        public List<int> addOne(int[] arr)
        {           
            List<int> res = new List<int>();
            int carry = 0;
            for (int i = arr.Length-1; i >= 0; i--)
            {
                if (arr[i] + 1 > 9)
                {
                    res.Add(0);
                    carry = 1;
                }               
                else
                {
                    res.Add(arr[i] + carry);
                    carry = 0;
                    break;     // the rest digit just append it to the first
                }

            }
            if (carry == 1) res.Add(1);    // think of 9999 as given input
            
            for (int i = 0; i < arr.Length-res.Count; i++)
            {
                res.Add(arr[i]); 
            }
            res.Reverse();
            return res;
        }

      public int[] incrementByOne(int[] arr)
        {
            if (arr == null) return null;
            int carry = 1;
            for (int i =arr.Length-1; i>=0; i--)
            {
                if (arr[i] + carry > 9)
                {
                    arr[i] = 0;
                    carry = 1;
                }
           else {
                    arr[i] = arr[i] + carry;
                    carry = 0;
                }
            }

            if (arr[0] == 0)
            {
                int[] res = new int[arr.Length+1]; // create new array whenever necessary
                res[0] = 1;
                for (int i = 0; i < arr.Length; i++)
                {
                    res[i + 1] = arr[i];
                }
                return res;
            }
            return arr;
        }
    }
}
