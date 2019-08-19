using System.Collections.Generic;
/*
------------------------------
Binary Tree Level Order Traversal 
------------------------------
Given a binary tree, return the level order traversal of its nodes' 
values. (ie, from left to right, level by level).
For example:
Given binary tree [3,9,20,null,null,15,7],
    3
   / \
  9  20
    /  \
   15   7

   return its level order traversal as:
[
  [3],
  [9,20],
  [15,7]
]

 */

namespace LeetCode_Practicing
{
    public class BT_TreeLevel_OrderTransveral
    {
        // iterative approach
        public List<List<int>> ilevelOrders(TreeNode root)
        {
            List<List<int>> levelOrders = new List<List<int>>();

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int size = queue.Count;
                List<int> levelElements = new List<int>();

                while (size-- > 0)
                {
                    TreeNode head = queue.Dequeue();
                    levelElements.Add(head.Val);
                    if (head.Left != null) queue.Enqueue(head.Left);
                    if (head.Right != null) queue.Enqueue(head.Right);
                }
                levelOrders.Add(levelElements);
            }
            return levelOrders;

        }
             // recursive
             
     
                  

              
                
                
                            
            
        
    }
}
