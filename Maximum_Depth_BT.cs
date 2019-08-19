/*
------------------------------
Maximum Depth of Binary Tree 
------------------------------
Given a binary tree, find its maximum depth.
The maximum depth is the number of nodes along the longest path from 
the root node down to the farthest leaf node.
*/

using System;
namespace LeetCode_Practicing
{
    public class Maximum_Depth_BT
    {
        public int maxDepth(TreeNode root)
        {
           
            if (root == null) return 0;
            int leftSum = maxDepth(root.Left);
            int rightSum = maxDepth(root.Right);
            return Math.Max(leftSum, rightSum) + 1;
           


            //iterative

            //int levels =0;
            //Queue<TreeNode> queue = new Queue<TreeNode>();
            //queue.Enqueue(root);

            //while (queue.Count > 0)
            //{
            //    int size = queue.Count;
            //    List<int> levelElements = new List<int>();

            //    while (size-- > 0)
            //    {
            //        TreeNode head = queue.Dequeue();
            //        levelElements.Add(head.Val);
            //        if (head.Left != null) queue.Enqueue(head.Left);
            //        if (head.Right != null) queue.Enqueue(head.Right);
            //    }
            //    levels++;
            //}
            //return levels;


        }


    }
}
