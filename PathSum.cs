/*
------------------------------
Triangle 
------------------------------
Given a triangle, find the minimum path sum from top to bottom. Each 
step you may move to adjacent numbers on the row below.
For example, given the following triangle
[
     [2],
     [3,4],
    [6,5,7],
   [4,1,8,3]
]
The minimum path sum from top to bottom is 11 (i.e., 2 + 3 + 5 + 1 = 
11).
Note:
Bonus point if you are able to do this using only O(n) extra space, 
where n is the total number of rows in the triangle.

 */

using System.Collections.Generic;

namespace LeetCode_Practicing
{
    public class PathSum
    {
        //recursive
        public bool pathSum(TreeNode root, int sum)
        {
            // if (root == null) return false;
            //if (root.Left == null && root.Right == null && sum == 0) return true;
            // return  pathSum(root.Left, sum) || pathSum(root.Right, sum);


            // }

            // iterative
            if (root == null) return false;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            Queue<int> sums = new Queue<int>();
            queue.Enqueue(root);
            sums.Enqueue(sum);
            while (queue.Count > 0)
            {
                int value = sums.Dequeue();
                TreeNode head  = queue.Dequeue();
                if (head.Left == null && head.Right == null && head.Val == value)
                {
                    return true;
                }
                if (head.Left != null)
                {
                    queue.Enqueue(head.Left);
                    sums.Enqueue(value - head.Val);
                }
                if (head.Right != null)
                {
                    queue.Enqueue(head.Right);
                    sums.Enqueue(value - head.Val);
                }
            }
            return false;



        }
    }
}
