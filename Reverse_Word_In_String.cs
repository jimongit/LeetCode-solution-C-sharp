using System.Text;
/*
------------------------------
Reverse Words in a String 
------------------------------
Given an input string, reverse the string word by word.
For example,
Given s = "the sky is blue",
return "blue is sky the".

For C programmers: Try to solve it in-place in O(1) space.

Clarification:What constitutes a word?
A sequence of non-space characters constitutes a word.
Could the input string contain leading or trailing spaces?
Yes. However, your reversed string should not contain leading or 
trailing spaces.
How about multiple spaces between two words?
Reduce them to a single space in the reversed string.
 */

namespace LeetCode_Practicing.Medium
{
    public class Reverse_Word_In_String
    {
       public string reverseWord(string s)
        {
            if (s == null) return null;
            StringBuilder result = new StringBuilder();
            bool flag = false;
            for (int i=s.Length-1; i>=0; i--)
            {
                if (char.IsWhiteSpace(s[i]) || i==0)
                {
                                
                    for (int j = i > 0 ? i + 1 : 0; j <s.Length; j++)
                    {
                     
                        if (char.IsWhiteSpace(s[j]))
                        {
                           break;
                        }
                       
                        result.Append(s[j]);
                    }
                    if (flag == false)
                    {
                        result.Append(" ");
                        flag = false;
                    }
                }
            }
            return result.ToString();

        }
    }
}
