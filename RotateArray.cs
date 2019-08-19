/*
------------------------------
Rotate Array 
------------------------------
Rotate an array of n elements to the right by k steps.
For example, with n = 7 and k = 3, the array [1,2,3,4,5,6,7] is 
rotated to [5,6,7,1,2,3,4]. 
Note:
Try to come up as many solutions as you can, there are at least 3 
different ways to solve this problem.
[show hint]
Hint:
Could you do it in-place with O(1) extra space?
 */

namespace LeetCode_Practicing
{
    public class RotateArray
    {
        public int[] rotate (int[] a,int k)
        {
          

            if (a == null || a.Length == 0) return null;
            if (a.Length == 1 || k == 0 || k == a.Length) return a;

            int temp;
            int i=0;
            while (i < a.Length-(k+1))

            {      
                    temp = a[i + k+1];
                    a[i + k+1] = a[i];
                    a[i] = temp;
                i++;
                
                }
            if (a.Length % 2>0)
            {
                while (i >= a.Length / 2 && i < a.Length-1)
                {
                    temp = a[i];
                    a[i] = a[i + 1];
                    a[i + 1] = temp;
                    i++;

                }
            }
               return a;
           


            }
           
        
    }
}
