/*
------------------------------
Binary Search Tree Iterator 
------------------------------
Implement an iterator over a binary search tree (BST). Your iterator 
will be initialized with the root node of a BST.
Calling next() will return the next smallest number in the BST.
Note: next() and hasNext() should run in average O(1) time and uses 
O(h) memory, where h is the height of the tree.
*/
using System.Collections.Generic;


namespace LeetCode_Practicing.Medium
{
    public class Binary_Search_Tree_Iterator
    {
        TreeNode Node;
        Stack<TreeNode> stack = new Stack<TreeNode>();

        public Binary_Search_Tree_Iterator(TreeNode Root)
        {
            Node = Root;
        }
        public bool HasNext()
        {
            return stack.Count != 0 || Node != null;
        }

        public int next(TreeNode node)
        {
            while (node != null)
            {
                stack.Push(node);
                node = node.Left;
            }
            TreeNode top = stack.Peek();
            stack.Pop();
            Node = node.Right;

            return top.Val;
        }
       
    }
}
