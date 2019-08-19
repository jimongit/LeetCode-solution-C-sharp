/*
------------------------------
Add Two Numbers 
------------------------------
You are given two non-empty linked lists representing two non-
negative integers. The digits are stored in reverse order and each 
of their nodes contain a single digit. Add the two numbers and 
return it as a linked list.
You may assume the two numbers do not contain any leading zero, 
except the number 0 itself.
Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
Output: 7 -> 0 -> 8
*/
namespace LeetCode_Practicing.Medium
{
    public class Add_Two_Numbers
    {
        public listnode addTwo(listnode l1, listnode l2)
        {
            if (l1 == null && l2 == null) return null;
            if (l1 == null) return l2;
            if (l2 == null) return l1;

            listnode p1=l1;
            listnode p2=l2;
            int countL1=0;
            int countL2=0;
            int sum = 0;

            while(l1!=null)
                {
                countL1++;
               l1= l1.Next;
                }
            while (l1 != null)
            {
                countL2++;
                l2 = l2.Next;
            }

           if (countL1 > countL2)
            {
                while(countL2==countL1){
                    p2.Val = 0;
                    p2 = p2.Next;
                    countL2++;
                }
                p2.Next = l1;
            }
            if (countL2 > countL1)
            {
                while (countL1 == countL2)
                {
                    p1.Val = 0;
                    p1 = p2.Next;
                    countL1++;
                }
                p1.Next = l1;
            }

            listnode addedLst = p1;
            int carry = 0;
            while (p1 != null)
            {
                if (p1.Val + p2.Val + carry > 10)
                {
                    sum = (p1.Val + p2.Val) % 10;
                    carry++;
                }
                else
                {
                    sum = (p1.Val + p2.Val + carry);
                }
                addedLst.Val = sum;
                addedLst = addedLst.Next;
                p1 = p1.Next;
                p2 = p2.Next;
            }
            return addedLst;

        }

    }
}
