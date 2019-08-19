/*
------------------------------
Invert Binary Tree 
------------------------------
Invert a binary tree.
     4
   /   \
  2     7
 / \   / \
1   3 6   9
to
     4
   /   \
  7     2
 / \   / \
9   6 3   1
 */

namespace LeetCode_Practicing.Easy
{
    public class Invert_BS
    {
        public TreeNode invert(TreeNode root)
        {
            //Queue<TreeNode> queue = new Queue<TreeNode>();
            //if (root != null)
            //{
            //    queue.Enqueue(root);
            //}
            //while (queue.Count>0)

            //{
            //    TreeNode t = queue.Dequeue();
            //    if (t.Left != null) queue.Enqueue(t.Left);
            //    if (t.Right != null) queue.Enqueue(t.Right);

            //    TreeNode tmp = t.Left;
            //    t.Left = t.Right;
            //    t.Right = tmp;

            //}
            //return root;


            //  recursive

            if (root == null)
            {
                return root;
            }

            helper(root);

            return root;

         }  
        private void helper(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

              TreeNode tmp = root.Left;
                root.Left = root.Right;
                root.Right = tmp;

                helper(root.Left);
                helper(root.Right);
            
        }
        
    }
}
