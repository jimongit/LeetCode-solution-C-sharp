/*
------------------------------
Compare Version Numbers 
------------------------------
Compare two version numbers version1 and version2.
If version1 &gt; version2 return 1, if version1 &lt; version2 return 
-1, otherwise return 0.
You may assume that the version strings are non-empty and contain 
only digits and the . character.
The . character does not represent a decimal point and is used to 
separate number sequences.
For instance, 2.5 is not "two and a half" or "half way to version 
three", it is the fifth second-level revision of the second first-
level revision.
Here is an example of version numbers ordering:
0.1 &lt; 1.1 &lt; 1.2 &lt; 13.37
Credits:Special thanks to @ts for adding this problem and creating 
all test cases.

 */

namespace LeetCode_Practicing.Easy
{
   public class Compare_Version
    {
        public int compare(string ver1, string ver2)
        {
            if (ver1==null && ver2==null) return 0;
            if (ver1 == null || ver2 == null) return ver1 == null ? -1 : 1;
            string[] arrayVer1 = ver1.Split('.');
            string[] arrayVer2 =ver2.Split('.');
            string version1 = string.Join("", arrayVer1);
            string version2 = string.Join("", arrayVer2);
            int intVer1 = int.Parse(version1);
            int intVer2 = int.Parse(version2);

            if (intVer1 > intVer2) return 1;
            else if (intVer1 < intVer2) return -1;

            return 0;
            



        }
        }
    }

