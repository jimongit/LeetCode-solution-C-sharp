/*
------------------------------
Maximum Subarray 
------------------------------
Find the contiguous subarray within an array (containing at least 
one number) which has the largest sum.
For example, given the array [-2,1,-3,4,-1,2,1,-5,4],
the contiguous subarray [4,-1,2,1] has the largest sum = 6.click to show more practice.
More practice:
If you have figured out the O(n) solution, try coding another 
solution using the divide and conquer approach, which is more 
subtle.
*/

//Note--store the index and value of single maximum element in the arrray and maximum sum of elements
// loop back 
using System.Collections.Generic;

namespace LeetCode_Practicing.Medium
{
    public class Maximum_SubArray
    {
        public List<int> cSubArray(int[] arr)
        {
            int elementSum = arr[0];
            int maxElementSumIndex = 0;
            int indxOfMax = 0;
           
            for (int i = 1; i < arr.Length; i++)
            {             
                if (arr[i] > arr[indxOfMax]) { indxOfMax = i; }
                if (elementSum > arr[maxElementSumIndex]) { maxElementSumIndex = i; }
                elementSum += arr[i];

            }
                        
            int startIndex = maxElementSumIndex;
            int maxSum = arr[maxElementSumIndex];
            int elementAdd = arr[maxElementSumIndex];

                 for (int i= maxElementSumIndex; i>=0; i--)
                {
                if (elementAdd > maxSum)
                {
                    startIndex = i;
                    maxSum = elementAdd;
                }

                elementAdd += arr[i];
            }

            if (maxSum < arr[indxOfMax]) return new List<int> { arr[indxOfMax] };

           List<int> result = new List<int>();
            for (int i=startIndex;i<=maxElementSumIndex;i++)
            {
                result.Add(arr[i]);
            }

            if (maxSum == arr[indxOfMax])
            {
               List<int> r = new List<int>();
                for(int i=0;i<result.Count;i++) { r[i] = result[i]; }
                r.Add(arr[indxOfMax]);
                return r;
            }
            return result;
        }
    }
}
