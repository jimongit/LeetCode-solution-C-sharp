using System.Collections.Generic;
/*
------------------------------
Longest Common Prefix 
------------------------------
Write a function to find the longest common prefix string amongst an 
array of strings.
 */

namespace LeetCode_Practicing
{
    public class Longest_Cmn_Prefix
    {
       public string lngCommonPrefix (string[] aStr)

        {
            HashSet<string> set = new HashSet<string>();
            string indexOfLongest = "";
            foreach (string str in aStr)
            {
             for (int i = 1; i <= str.Length; i++)
                {
                    string strToAdd = str.Substring(0, i);
                    if (!set.Add(strToAdd) && strToAdd.Length > indexOfLongest.Length)
                        indexOfLongest = strToAdd;
                    else set.Add(strToAdd);   
                }
            }
        
              return  indexOfLongest;
          
            
        }
    }
}
