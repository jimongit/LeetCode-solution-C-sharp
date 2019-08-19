/*
------------------------------
Evaluate Reverse Polish Notation 
------------------------------
Evaluate the value of an arithmetic expression in Reverse Polish 
Notation.
Valid operators are +, -, *, /. Each operand may be an integer or 
another expression.
Some examples:
  ["2", "1", "+", "3", "*"] -> ((2 + 1) * 3) -> 9
  ["4", "13", "5", "/", "+"] -> (4 + (13 / 5)) -> 6
*/
using System;
using System.Collections.Generic;

namespace LeetCode_Practicing.Medium
{
    public class Evaluate_Reverse_Polish_Notation
    {
        public int evaluate(string[] s)
        {
            int result = 0;
            Stack<int> num = new Stack<int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!s[i].Equals('*') && !s[i].Equals('+') && !s[i].Equals('/') && !s[i].Equals('-'))
                {
                    num.Push(int.Parse(s[i])); // assuming the value is a number
                }
                else
                {
                   
                    if (num.Count >= 2)
                    {
                        int first = num.Pop();
                        int second = num.Pop();                       

                        string operation = s[i];
                        switch (operation)
                        {
                            case "+":
                                result = first + second;
                                break;
                            case "-":
                                result = first - second;
                                break;
                            case "*":
                                result = first * second;
                                break;
                            case "/":
                                result = first / second;
                                break;
                            default: throw new Exception("Invalid Operation");
                        }
                    }

                }
            }
            return result;
        }
           
    }
}
