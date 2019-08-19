/*
------------------------------
Valid Parentheses 
------------------------------
Given a string containing just the characters '(', ')', '{', '}', 
'[' and ']', determine if the input string is valid.
The brackets must close in the correct order, "()" and "()[]{}" are 
all valid but "(]" and "([)]" are not.
*/
namespace LeetCode_Practicing
{
    public class Valid_Parentheses
    {
        public bool isValidPar(string str)
        {
            if (str.Length % 2 > 0) return false;
             string temp="";
            
           for (int i = 0; i < str.Length; i++)
            {
                 
                if (i==0 || i % 2 == 0)
                {
                    temp = str.Substring(i, 2);
                    if (temp == "{}" || temp == "()" || temp == "[]") continue;
                    else return false;
                }
              
               
            }
            return  true;
        }
    }
}
