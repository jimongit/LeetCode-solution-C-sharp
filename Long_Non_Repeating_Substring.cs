/*





*/
using System;
using System.Collections.Generic;

namespace LeetCode_Practicing.Medium
{
    public class Long_Non_Repeating_Substring
    {
        public int lngstSubstring(string str)
        {
         
            int shorter = 0;
            int longer = 0;
            HashSet<Char> set = new HashSet<char>();
              for (int i = 0; i < str.Length; i++)
            {
                if (!set.Add((str[i])))
                {
                    set.Clear(); // once we found duplicate, we clear the set and reset the shorter
                    shorter = 0;
                }
                else
                {
                    set.Add(str[i]);
                    shorter++; 
                   if (shorter > longer) longer = shorter;   // update the longer                 
                }
               
            }
            return longer;
        }
    }
    }

