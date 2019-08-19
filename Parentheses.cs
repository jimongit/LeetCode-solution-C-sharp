/*
------------------------------
Generate Parentheses 
------------------------------
Given n pairs of parentheses, write a function to generate all 
combinations of well-formed parentheses.
For example, given n = 3, a solution set is:
[
  "((()))",
  "(()())",
  "(())()",
  "()(())",
  "()()()"
]
 */
using System.Collections.Generic;

namespace LeetCode_Practicing.Medium
{
    public class Parentheses
    {
        public List<string> generatePar(int n)
        {
            List<string> result = new List<string>();
                     
            if (n > 0) recGenerate(result, "", n, n);
            return result;                       
        }
       private void recGenerate(List<string> result, string s, int left, int right)
        {
            if (left==0  && right==0) result.Add(s);

            if (left > 0)
                recGenerate(result, s+"(", left - 1, right);

               if (right > 0 && right > left) recGenerate(result, s+")", left, right - 1);

        }
    }
}
