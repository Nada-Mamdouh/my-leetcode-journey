/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if(root == null) return root;
        if(root.val == p.val || root.val == q.val) return root;
        TreeNode left = null;
        TreeNode right = null;
        if(root.left != null){
            left = LowestCommonAncestor(root.left, p, q);
        }
        if(root.right != null){
            right = LowestCommonAncestor(root.right, p, q);
        }
        if(left != null && right != null) return root;
        else if(left == null && right != null) return right;
        else if(left != null && right == null) return left;
        return null;
    }
    
   
}