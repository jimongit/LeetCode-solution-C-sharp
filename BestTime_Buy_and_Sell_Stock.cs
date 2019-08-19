
/*
------------------------------
Best Time to Buy and Sell Stock 
------------------------------
Say you have an array for which the ith element is the price of a 
given stock on day i.
If you were only permitted to complete at most one transaction (ie, 
buy one and sell one share of the stock), design an algorithm to 
find the maximum profit.
Example 1:
Input: [7, 1, 5, 3, 6, 4]
Output: 5
max. difference = 6-1 = 5 (not 7-1 = 6, as selling price needs to be 
larger than buying price)

Example 2:
Input: [7, 6, 4, 3, 1]
Output: 0
In this case, no transaction is done, i.e. max profit = 0.
 */
using System;

namespace LeetCode_Practicing.Easy
{
   public class BestTime_Buy_and_Sell_Stock
    {
        public int BestTime(int[] arr)
        {
            int result = 0;
            if (arr == null || arr.Length <= 1) return result;
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > min)
                {
                    result = Math.Max(result, arr[i] - min); // while tracking the minimum value calculate max difference
                }
                else
                {
                    min = arr[i];  // another minimum
                }
            }
            return result;
        }
    }
}
