/*
------------------------------
Pascal's Triangle 
------------------------------
Given numRows, generate the first numRows of Pascal's triangle.
For example, given numRows = 5,
Return
[
     [1],
    [1,1],
   [1,2,1],
  [1,3,3,1],
 [1,4,6,4,1]
]
 */
using System.Collections.Generic;
using System.Linq;


namespace LeetCode_Practicing
{
    public class PascalTriangle
    {
       public List<int[]> generatePascalTriangle(int nRows)

        {
            if (nRows == 0) return null;
            Dictionary<int, int[]> lst = new Dictionary<int, int[]>();
            int[] first = new int[1] { 1 };
            int[] second = new int[2] { 1, 1 };
            lst.Add(first.Length, first); lst.Add(second.Length, second);
            if (nRows == 2) return lst.Values.ToList();

             int count =2;
                       
            while (count != nRows)
            {
                int[] pre = lst[count];
                int[] intArray = new int[count+1];
                intArray[0] = 1; intArray[count] = 1;

                
                for (int i = count - 1; i >= 1 ; i--)
                  {

                    if ((pre[i] + pre[i - 1]) > 9)
                        
                        {
                         intArray[i+1] = (pre[i] + pre[i - 1]) - 10;
                         // ++intArray[i-1];

                         }
                    else
                    intArray[i] = pre[i] + pre[i - 1];
                    
                   }
                count++;
                lst.Add(intArray.Length, intArray);
            }
            return lst.Values.ToList();
            
        }
    }
}
