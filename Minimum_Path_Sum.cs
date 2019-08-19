/*
------------------------------
Minimum Path Sum 
------------------------------
Given a m x n grid filled with non-negative numbers, find a path 
from top left to bottom right which minimizes the sum of all numbers 
along its path.
Note: You can only move either down or right at any point in time.
*/
using System;
using System.Collections.Generic;
namespace LeetCode_Practicing.Medium
{
    class Minimum_Path_Sum
    {
      public List<int> minPathway(int[][] matrix)
        {
           
           List<int> path = new List<int>();  //  maximum path--matrix.Length + matrix[0] - 2

            for (int i = 0; i < matrix[0].Length - 1; i++) path.Add(0); // 0 for right move
            for (int i = 0; i < matrix.Length-1; i++) path.Add(1);  // 1 for down move
            
            Permutation p = new Permutation();
            List<List<int>> permutationList = p.permutation(path.ToArray());

            int r = 0;// r for rows
            int c = 0; // c for colmun
            int sum = matrix[0][0];
            int min=0;
            List<int> res=new List<int>();
            bool flag = false;
            for (int i = 0; i < permutationList.Count; i++)
            {
                for (int j = 0; j < permutationList[i].Count; j++)
                {
                    if (r == matrix[0].Length - 1 || c== matrix.Length - 1) break;
                    if (permutationList[i][j] == 0) sum += matrix[r][++c];   //move to right by one,add the element value,update colm. pos
                    else if (permutationList[i][j] == 1) sum += matrix[++r][c]; // move to left by one,add the element value, update colm. pos
                }
                if (flag == false) {
                     min = sum;
                    res = permutationList[i];
                    flag = true;
                }
                else if (min < sum)     
                {
                    min = sum;  // update minimum
                    res = permutationList[i]; // set the list as mimimum path
                }
            }

            r = 0;c = 0;
            for (int i = 0; i < res.Count; i++)
            {
                if (res[i] == 0)res[i]= matrix[r][++c];   
                else if (res[i] == 1) res[i]=matrix[++r][c]; 
            }

            return res;
        }
       


    }

   
}
