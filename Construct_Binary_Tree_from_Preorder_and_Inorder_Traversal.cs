/*
------------------------------
Construct Binary Tree from Preorder and Inorder Traversal 
------------------------------
Given preorder and inorder traversal of a tree, construct the binary tree.
Note:
You may assume that duplicates do not exist in the tree.
------------------------------
------------------------------
Construct Binary Tree from Inorder and Postorder Traversal 
------------------------------
Given inorder and postorder traversal of a tree, construct the 
binary tree.
Note:
You may assume that duplicates do not exist in the tree.
*/

namespace LeetCode_Practicing.Medium
{
    public class Construct_Binary_Tree_from_Preorder_and_Inorder_Traversal
    {
        public TreeNode ConstructBT(int[] preOrder, int[] inOrder)    // first node of preOrder is root Node, search that node in the inorder list and recursively build left and right from there.
        {
            int preStart = 0;
            int preEnd = preOrder.Length-1;
            int inStart = 0;
            int inEnd = inOrder.Length - 1;
          return  buildTree(preStart, preEnd, inStart, inEnd, preOrder, inOrder);
        }
        TreeNode buildTree(int preStart, int preEnd, int inStart,int inEnd, int[] preOrder,int[]inOrder)  
        {
            if (preStart > preEnd || inStart > inEnd) return null;
            TreeNode root = new TreeNode(preOrder[preStart]);
            int indxSearch= 0;
            for (int i = 0; i < inOrder.Length; i++)
            {
                if (preOrder[preStart] == inOrder[i])
                {
                    indxSearch = i;
                    break;
                }
            }
            root.Left = buildTree(preStart + 1, preStart + (indxSearch - inStart), inStart, indxSearch - 1, preOrder, inOrder);
            root.Right = buildTree((preStart+ (indxSearch-inStart)+1),preEnd, indxSearch+1,inEnd, preOrder,inOrder);
            return root;
        }
    }
}
