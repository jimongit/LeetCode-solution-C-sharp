/*
-----------------------
 Search for a Range
 ----------------------
Given a sorted array of integers, find the starting and ending position of a given
target value.
Your algorithm's runtime complexity must be in the order of O(log n).
If the target is not found in the array, return [-1, -1].
For example, Given [5, 7, 7, 8, 8, 10] and target value 8, return [3, 4].
 */

namespace LeetCode_Practicing.Medium
{
    public class Search_Range
    {
        public int[] search(int[] arr, int target)
        {
            if (arr == null) return null;
            if (arr[0] > target) return new int[] { -1, -1 };
            if (arr[0] == target && arr[arr.Length-1]==target) return new int[] { 1, arr.Length}; 
            if (arr.Length == 1 && arr[0] == target) return new int[] { 1, 1};

            int start = BS(arr, target);
            if (start == -1) return new int[] { -1, -1 };
        
            int count = 0;            
            for (int i = start+1; i < arr.Length; i++)
            {
                if (arr[i] == target) count++; // til the last target occurrence // worst case eg- {2,3,3,3,} or {3,3,3,4};
                
            }
            int end = start + count;
            return new int[] { start, end};
            
        }
        private int BS(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left + 1 < right)
            {
                int mid = left + (right - left) / 2;  
                if (arr[mid] < target)  left = mid;
                else   right = mid;
                
            }
            if (arr[left] == target) return left;
            if (arr[right] == target) return right;
            return -1;
        }
     
    }
}
