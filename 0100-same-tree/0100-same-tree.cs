/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if(p == null && q != null || p != null && q == null) return false;
        if(p == null && q == null) return true;
        bool left = IsSameTree(p.left, q.left);
        bool right = IsSameTree(p.right, q.right);
        return p.val == q.val && left && right;
    }
    
}