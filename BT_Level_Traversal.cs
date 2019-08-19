/*

 */
using System.Collections.Generic;

namespace LeetCode_Practicing
{
    public class BT_Level_Traversal
    {
        public List<List<int>> BottomUpOrder(TreeNode root)
        {
            List<List<int>> levelOrder = new List<List<int>>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

           while(queue.Count > 0)
            {
                List<int> level = new List<int>();
                int size = queue.Count;
                while (size-- > 0)
                {
                    TreeNode head = queue.Dequeue();
                    level.Add(head.Val);
                    if (head.Left != null) queue.Enqueue(head.Left);
                    if (head.Right != null) queue.Enqueue(head.Right);
                }
                levelOrder.Add(level);
               
               }
            levelOrder.Reverse();
            return levelOrder;


        }
    }
}
