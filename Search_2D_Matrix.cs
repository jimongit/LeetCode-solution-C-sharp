/*
------------------------------
Search a 2D Matrix 
------------------------------
Write an efficient algorithm that searches for a value in an m x n 
matrix. This matrix has the following properties:
Integers in each row are sorted from left to right.
The first integer of each row is greater than the last integer of 
the previous row.
For example,
Consider the following matrix:
[
  [1,   3,  5,  7],
  [10, 11, 16, 20],  [23, 30, 34, 50]
]
Given target = 3, return true.
 */

namespace LeetCode_Practicing.Medium
{
   public class Search_2D_Matrix
    {
        public bool search(int[][]matrix, int target)
        {
            if (matrix == null) return false;
            
          
          return rowHelper(matrix, matrix.Length, target);
            

        }
        bool rowHelper(int[][] matrix, int len, int target)
        {
                       
           
             int left = 0;
             int right = len-1;
             int midRow = left + (right - left)/ 2;
             int midRowVal = matrix[midRow][0];

            for (int i = 0; i < matrix.Length; i++)
            {           
                if (midRowVal == target) return true;
                if (target < midRowVal && target >= left) // target  between midRow -1 and midRow
                {

                return columHelper(matrix, midRow - 1, target); 
                }

                if(target > midRowVal && target <= right)// target inside the between midRow and midRow+1
                {
                  return columHelper(matrix, midRow, target); 
                }
                if (target > right && i == matrix.Length - 1)  // target in the last Row and Column > 0
                {
                    return columHelper(matrix, midRow + 1, target);
                }

                if (target > right) right= midRow - 1;
                else left= midRow + 1;
            }


            return false;
        }
        bool columHelper(int[][] matrix, int currentRow, int target)
        {            
            int left = 0;
            int right = matrix[0].Length-1;
            int colmMid;
            int mid;

            while (left<=right)          
            {
                colmMid = left + (right - left) / 2;
                 mid = matrix[currentRow][colmMid];

                if (mid == target) return true;
                if (target > mid) right = colmMid-1;
                else left = colmMid +1;
            }
            return false;
        }
        
    }
}
