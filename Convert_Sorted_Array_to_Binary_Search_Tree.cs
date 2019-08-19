/*
------------------------------
Convert Sorted Array to Binary Search Tree 
------------------------------
Given an array where elements are sorted in ascending order, convert 
it to a height balanced BST.
*/

namespace LeetCode_Practicing.Medium
{
    public class Convert_Sorted_Array_to_Binary_Search_Tree
    {
        public TreeNode ConvertToBST(int[] arr)
        {
            if (arr == null) return null;
           return convert(arr, 0, arr.Length-1);
        }
         TreeNode convert(int[] arr, int left, int right)
        {
           for (int i = 0; i < arr.Length; i++)
            {
                if (left > right) return null;   //if arr.Length==0
                if (left == right) new TreeNode(arr[left]);

                int mid = left + (right - left) / 2;
                TreeNode root =new TreeNode(mid);

                root.Left = convert(arr, left, mid - 1);
                root.Right = convert(arr, mid + 1, right);
                return root;
            }

            return null;
        }
    }
}