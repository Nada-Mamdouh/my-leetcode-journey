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
    public int SumOfLeftLeaves(TreeNode root) {
        int sum = 0;
        result(root, ref sum);
        return sum;
    }
    
    public void result(TreeNode root, ref int sum){
        if(root == null) return;
        result(root.left,ref sum);
        if(root.left != null && 
           root.left.left == null && 
           root.left.right == null){
            sum+= root.left.val;
        }
        result(root.right,ref sum);
    }
}