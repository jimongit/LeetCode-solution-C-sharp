/*
------------------------------
Excel Sheet Column Title 
------------------------------
Given a positive integer, return its corresponding column title as 
appear in an Excel sheet.
For example:
    1 -> A
    2 -> B
    3 -> C
    ...
    26 -> Z
    27 -> AA
    28 -> AB 
Credits:Special thanks to @ifanchu for adding this problem and 
creating all test cases.
 */

namespace LeetCode_Practicing.Easy
{
    public class Excel_Sheet_ColnTitle
    {
        public string title(int cNum)
        {
            string r = "";
           while (cNum > 0)
            {
               cNum--;
                r = ((char)cNum % 26 + 'A').ToString() + r;
                cNum /= 26;
                               
            }
            
                           
            return r;
            
            }
    }
}
