/*
------------------------------
Longest Palindromic Substring 
------------------------------
Given a string s, find the longest palindromic substring in s. You 
may assume that the maximum length of s is 1000.
Example:
Input: "babad"
Output: "bab"
Note: "aba" is also a valid answer.
Example:
Input: "cbbd"
Output: "bb"
*/
using System.Text;


namespace LeetCode_Practicing.Medium
{
    public class Longest_Palindromic_Substring
    {
        public string palSubstring(string s)
        {
            if (s == null) return string.Empty;
            if (s.Length == 1) return string.Empty;
                    

            StringBuilder lngPal = new StringBuilder();
            StringBuilder tmp = new StringBuilder();
            int i = 0;
            int j = s.Length-1;
                                
            while (i != s.Length && j > 0)
                
            {
                if (s[i] == s[j])
                {
                    tmp.Append(s[i]);
             
                }
                else 
                {
                    if (tmp.ToString().Length > lngPal.ToString().Length)
                    {
                        lngPal.Clear();
                        lngPal.Append(tmp.ToString());
                       
                    }
                    
                    tmp.Clear();


                }
                i++;
                j--;
               
             }
            return lngPal.ToString();
        }
    }
}
