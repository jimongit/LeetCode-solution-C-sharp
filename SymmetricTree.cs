/*
------------------------------
Symmetric Tree 
------------------------------
Given a binary tree, check whether it is a mirror of itself (ie, 
symmetric around its center).
For example, this binary tree [1,2,2,3,4,4,3] is symmetric:
    1
   / \
  2   2
 / \ / \
3  4 4  3
But the following [1,2,2,null,3,null,3]  is not:
    1
   / \
  2   2
   \   \
   3    3
Note:
Bonus points if you could solve it both recursively and iteratively.
*/

using System;
using System.Collections.Generic;

namespace LeetCode_Practicing
{
    public class SymmetricTree
    {
        public bool isSymmetric(TreeNode bT)  // recursive
        {
            if (bT == null) return true;
            return isEqual(bT.Left, bT.Right);
        }
        private bool isEqual(TreeNode n1, TreeNode n2)
        {
            if (n1 == null && n2 == null) return n1 == n2;
            return (n1.Val == n2.Val) && isEqual(n1.Left, n2.Right) && isEqual(n1.Right, n2.Left);
        }


        public bool isSymmetric2(TreeNode root)
        {
            if (root == null) return true;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                List<int> levelElements = new List<int>();
                while (queue.Count > 0)
                {
                    TreeNode head = queue.Dequeue();
                    levelElements.Add(Math.Abs(head.Val)); // math.abs is used, since any given node can have -1 as val and -1 is already representing null
                    if (head.Left == null && head.Right == null) break; // base case
                     if (head.Left != null) queue.Enqueue(head.Left);
                    else levelElements.Add(-1);  // add -1 for null
                     if (head.Right != null) queue.Enqueue(head.Right);
                    else levelElements.Add(-1);  // add -1 for null
                    
                }
                if (!reverse(levelElements).Equals(levelElements)) return false; // for symmmetric tree every level orders are palindromic
            }

            return true;
        }
        private List<int> reverse(List<int> lst)
        {
            int i = 0, j = lst.Count - 1;
            while (i < j)
            {
                int tmp = lst[i];
                lst[i] = lst[j];
                lst[j] = tmp;
                i++;
                j--;
            }
            return lst;
        }
    }
}
