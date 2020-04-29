using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // https://leetcode.com/problems/same-tree/
    /*
    Given two binary trees, write a function to check if they are the same or not.

Two binary trees are considered the same if they are structurally identical and the nodes have the same value.

Example 1:

Input:     1         1
          / \       / \
         2   3     2   3

        [1,2,3],   [1,2,3]

Output: true
Example 2:

Input:     1         1
          /           \
         2             2

        [1,2],     [1,null,2]

Output: false
Example 3:

Input:     1         1
          / \       / \
         2   1     1   2

        [1,2,1],   [1,1,2]

Output: false
    */
  
    public class Solution
    {

        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
                return true;

            if (p == null || q == null)
                return false;

            if (p.val != q.val)
                return false;
            
            if (!IsSameTree(p.left, q.left))
                return false;

            if (!IsSameTree(p.right, q.right))
                return false;

            return true;
        }
    }
}
