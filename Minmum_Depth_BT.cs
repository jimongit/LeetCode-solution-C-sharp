using System;
/*
------------------------------
Minimum Depth of Binary Tree 
------------------------------
Given a binary tree, find its minimum depth.
The minimum depth is the number of nodes along the shortest path 
from the root node down to the nearest leaf node.
------------------------------
 */

namespace LeetCode_Practicing
{
    public class Minmum_Depth_BT

    {
        public int minmumDepth(TreeNode root)
        {
            if (root == null) return 0;
            int leftSum = minmumDepth(root.Left);
            int rightSum = minmumDepth(root.Right);
            if (leftSum == 0) return rightSum + 1;
            if (rightSum == 0) return leftSum + 1;
            return Math.Min(leftSum, rightSum) + 1;
        }
    }
}
