/*
------------------------------
Balanced Binary Tree 
------------------------------
Given a binary tree, determine if it is height-balanced.
For this problem, a height-balanced binary tree is defined as a 
binary tree in which the depth of the two subtrees of every node 
never differ by more than 1.
 */
using System;

namespace LeetCode_Practicing
{
    public class Balanced_BT
    {
        public bool isbalancedTree(TreeNode root)
        {
            return balancedTree(root) != 1;
        }
        public int balancedTree(TreeNode root)
        {
            if (root == null) return 0;
            int leftSum = balancedTree(root.Left);
            if (leftSum == -1) return -1;
            int rightSum = balancedTree(root.Right);
            if (rightSum == -1) return -1;

            if (Math.Abs(leftSum - rightSum) > 1) return -1;
            return Math.Max(leftSum,rightSum) +1;

        }
    }
}
