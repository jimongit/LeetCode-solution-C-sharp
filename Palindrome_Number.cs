/*
------------------------------
Palindrome Number 
------------------------------
Determine whether an integer is a palindrome. Do this without extra 
space.
click to show spoilers.
Some hints:
Could negative integers be palindromes? (ie, -1)
If you are thinking of converting the integer to string, note the 
restriction of using extra space.
You could also try reversing an integer. However, if you have solved 
the problem "Reverse Integer", you know that the reversed integer 
might overflow. How would you handle such case?
There is a more generic way of solving this problem.
 */

namespace LeetCode_Practicing.Easy
{
   public class Palindrome_Number
    {
        public bool Palindrome(int num)

        {             
            if (num < 0) return false;

            int result = 0;
            int x = num;
            while (x!=0)
            {
             result = result * 10 + (x % 10);
                x /= 10;                            
            }          
         
            if (result == num) return true;
            return false;
           
        }
    }
}
