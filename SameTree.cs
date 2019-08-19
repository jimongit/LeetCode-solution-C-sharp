/*
------------------------------
Same Tree 
------------------------------
Given two binary trees, write a function to check if they are equal or not.
Two binary trees are considered equal if they are structurally 
identical and the nodes have the same value.
 */

namespace LeetCode_Practicing
{
   
    public class SameTree
    {
        public bool isEqual(TreeNode a, TreeNode b)
        {


               if (a == null && b == null) return true;
              if (a == null || b == null) return false;

            bool result = (a.Val == b.Val) &&
                         isEqual(a.Left, b.Left) &&
                         isEqual(a.Right, b.Right);

            return result;
        }

        //    if (a == null && b == null) return true;
        //    if (a == null || b == null) return false;

        //    List<bool> result = new List<bool>();

        //    int i = 0;
        //    while (a != null)
        //    {
        //        result.Add((a.Val == b.Val) && (a.Left == b.Left) && (a.Right == b.Right));
        //        a = a.Left;
        //        i++;
        //    }
        //    while (a != null)
        //    {
        //        result.Add((a.Val == b.Val) && (a.Left == b.Left) && (a.Right == b.Right));
        //        a = a.Right;
        //        i++;
        //    }

            


        //    foreach( bool rslt in result)
        //    {
        //        if (result.Contains(false)) ;
        //        return false;
        //    }
        //    return true;


        //}


    }
}
