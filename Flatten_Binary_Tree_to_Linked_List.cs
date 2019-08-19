/*
------------------------------
Flatten Binary Tree to Linked List 
------------------------------
Given a binary tree, flatten it to a linked list in-place.
For example,
Given
         1
        / \
       2   5
      / \   \
     3   4   6
The flattened tree should look like:
   1
    \
     2
      \
       3
        \
         4
          \
           5 
            \
             6
*/

namespace LeetCode_Practicing.Medium
{
   public class Flatten_Binary_Tree_to_Linked_List
    {
        public TreeNode flatten(TreeNode root)
        {
            if (root == null) return null;
            return flat(root);
        }
       public TreeNode flat(TreeNode root)
        {
            TreeNode leftTail = flat(root.Left);
            TreeNode rightTail = flat(root.Right);
            if (root.Left != null)
            {
               leftTail.Right = root.Left;
                root.Right = root.Left;
                root.Left = null;
            }
            if (rightTail != null) return rightTail;
            if (leftTail != null) return leftTail;
            return root;
        }

        // to do : also implement it in queue, level order traveral
    }
}
