using System.Collections.Generic;
/*
------------------------------
Min Stack 
------------------------------
Design a stack that supports push, pop, top, and retrieving the 
minimum element in constant time.
push(x) -- Push element x onto stack.
pop() -- Removes the element on top of the stack.
top() -- Get the top element.
getMin() -- Retrieve the minimum element in the stack.

Example:
MinStack minStack = new MinStack();
minStack.push(-2);
minStack.push(0);
minStack.push(-3);
minStack.getMin();   --> Returns -3.
minStack.pop();
minStack.top();      --> Returns 0.
minStack.getMin();   --> Returns -2.
 */

namespace LeetCode_Practicing.Easy
{
       public class Min_Stack
    {
        private class element
        {
            public int value;
            public int min;

        }               
       private Stack<int> st = new Stack<int>();
       private element el = new element();
        public void push(int newElement)
        {
           //element el = new element();  
            el.value = newElement;
            if(st.Count ==0) { el.min = newElement; }
            else
            {
                int val = st.Peek();
                if (newElement > val) { el.min = val; }
                else el.min = newElement;
            }
            st.Push(el.value);

        }
        public void Pop()
        {
        if(st==null)  return;
          st.Pop();
                             
        }
        public int Top()
        {
            return st.Peek();
        }
        public int getMin()
        {
            return el.min;
          
        }
    }
}
