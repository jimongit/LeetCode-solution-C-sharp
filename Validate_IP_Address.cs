/*
------------------------------
Validate IP Address 
------------------------------
Write a function to check whether an input string is a valid IPv4 
address or IPv6 address or neither.
IPv4 addresses are canonically represented in dot-decimal notation, 
which consists of four decimal numbers, each ranging from 0 to 255, 
separated by dots ("."), e.g.,172.16.254.1;
Besides, leading zeros in the IPv4 is invalid. For example, the 
address 172.16.254.01 is invalid.
IPv6 addresses are represented as eight groups of four hexadecimal 
digits, each group representing 16 bits. The groups are separated by 
colons (":"). For example, the address 
2001:0db8:85a3:0000:0000:8a2e:0370:7334 is a valid one. Also, we 
could omit some leading zeros among four hexadecimal digits and some 
low-case characters in the address to upper-case ones, so 
2001:db8:85a3:0:0:8A2E:0370:7334 is also a valid IPv6 address(Omit 
leading zeros and using upper cases).However, we don't replace a consecutive group of zero value with a 
single empty group using two consecutive colons (::) to pursue 
simplicity. For example, 2001:0db8:85a3::8A2E:0370:7334 is an 
invalid IPv6 address.
Besides, extra leading zeros in the IPv6 is also invalid. For 
example, the address 02001:0db8:85a3:0000:0000:8a2e:0370:7334 is 
invalid.
Note:
You may assume there is no extra space or special characters in the 
input string.
Example 1:
Input: "172.16.254.1"
Output: "IPv4"
Explanation: This is a valid IPv4 address, return "IPv4".
Example 2:
Input: "2001:0db8:85a3:0:0:8A2E:0370:7334"
Output: "IPv6"
Explanation: This is a valid IPv6 address, return "IPv6".
Example 3:
Input: "256.256.256.256"
Output: "Neither"
Explanation: This is neither a IPv4 address nor a IPv6 address
 */
using System.Collections.Generic;
using System.Text;


namespace LeetCode_Practicing.Medium
{
    public class Validate_IP_Address
    {
        public string validate(string address)
        {
            if (address == null) return "Neither";
            string v4 = validIPv4(address);
            string v6 = validIPv6(address);
                      
            if (v4.Equals("IPv4")) return "IPv4";
            else if (v6.Equals("IPv6")) return "IPv6";
            else
            {
                return "Neither";
            }
        }

        private string validIPv4(string address)
        {
            StringBuilder num = new StringBuilder();
            int countDots = 0;
            for (int i = 0; i < address.Length; i++)
            {
                if (address[i].Equals('.')) countDots++;
                if (!char.IsDigit(address[i]) && !address[i].Equals('.')) return "notIP";
                if (i > 0 && address[i].Equals('0') && address[i - 1].Equals('.')) return "notIP";
                if (address[i].Equals('.') || i==address.Length-1)
                {
                    if (num.Length > 0)
                    {
                        if (int.Parse(num.ToString()) > 255 || int.Parse(num.ToString()) < 0) return "notIP";
                        num.Clear();
                    }
                }
                if(char.IsDigit(address[i]))    num.Append(address[i]);

            }
            if (countDots != 3) return "notIP";
            return "IPv4";
        }

        private string validIPv6(string address)
        {
            int countColon = 0;
            List<string> ltrs = new List<string> { "a", "b", "c", "d", "e", "f" };
           
            for (int i = 0; i < address.Length; i++)
            {
                if (char.IsLetter(address[i]))
                {
                    if (!ltrs.Contains(address[i].ToString().ToLower())) return "notIP";
                }
                if (char.IsDigit(address[i]))
                {
                    if (int.Parse(address[i].ToString())<0) return "notIP";
                }

                if (i > 0 && address[i].Equals(':') && address[i - 1].Equals(':')) return "notIP";

               if(address[i].Equals(':')) countColon++;   

            }
            if (countColon != 7) return "notIP";
            return "IPv6";
        }
    }
}

