/*
------------------------------
Binary Tree Inorder Traversal 
------------------------------
Given a binary tree, return the inorder traversal of its nodes' 
values.
For example:
Given binary tree [1,null,2,3],
   1
    \
     2
    /
   3
return [1,3,2].
Note: Recursive solution is trivial, could you do it iteratively?
*/
using System.Collections.Generic;


namespace LeetCode_Practicing.Medium
{
   public class Binary_Tree_Preorder_Traversal
    {
        public List<int> transverse(TreeNode root)
        {
            if (root == null) return new List<int> { };
            return helper_transverse(root,new List<int>());
        }
      
        public List<int> helper_transverse(TreeNode root,List<int> lst)   // recursive
        {
             while (root != null)
            {
                lst.Add(root.Val);
                helper_transverse(root.Left, lst);
                helper_transverse(root.Right, lst);
            }
            return lst;
        }

        public List<int> helper_transverse(TreeNode root) // iterative
        {
            List<int> lst = new List<int>();

            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Count!=0)
            {
                TreeNode current = stack.Pop();
                lst.Add(current.Val);
               if(current.Left!= null) stack.Push(root.Left);
               if(current.Right!=null) stack.Push(root.Right);
                
            }
            return lst;     
        }

    }
}
