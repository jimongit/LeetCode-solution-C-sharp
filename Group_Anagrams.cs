using System;
using System.Collections.Generic;

/*
------------------------------
Group Anagrams 
------------------------------
Given an array of strings, group anagrams together.
For example, given: ["eat", "tea", "tan", "ate", "nat", "bat"], 
Return:
[
  ["ate", "eat","tea"],
  ["nat","tan"],
  ["bat"]
]
Note: All inputs will be in lower-case.
*/
namespace LeetCode_Practicing.Medium
{
    public class Group_Anagrams
    {
        public HashSet<List<string>> group(string[] str)
        {
            if (str == null||str.Length==1) return null;           
            Dictionary<string, string> group = new Dictionary<string, string>();
             for (int i = 0; i < str.Length; i++)
            {
                char[] s = str[i].ToCharArray();
                Array.Sort(s);
                string d=  string.Join("",s);                
                group.Add(str[i], d);
            }
            HashSet<List<string>> res = new HashSet<List<string>>();
          for (int i = 0; i < str.Length; i++)
            {
           List<string> lst = new List<string>();
                lst.Add(str[i]);
               foreach (string key in group.Keys)
                {
                    if (!lst.Contains(key)) { 
                    if (group[key] == group[lst[0]]) lst.Add(key);
                    }
                }
                res.Add(lst);
            }
            return res;
          
        }
    }
}

