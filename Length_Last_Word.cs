/*
------------------------------
Length of Last Word 
------------------------------
Given a string s consists of upper/lower-case alphabets and empty 
space characters ' ', return the length of last word in the string.
If the last word does not exist, return 0.
Note: A word is defined as a character sequence consists of non-
space characters only.
For example, 
Given s = "Hello World",
return 5.
 */

namespace LeetCode_Practicing
{
    public class Length_Last_Word
    {
        
        public int lenLastWord(string s)
        {
            if (s == null || s.Length == 0) return 0;
            s.Trim();
            int count = 0;
          for (int i = s.Length-1; i>=0; i--)
            {
                count++;
                if (char.IsWhiteSpace(s[i])) break;
            }
            return count;
                     
        }
    }
}
