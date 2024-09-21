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
    bool flag = true;
    public bool IsBalanced(TreeNode root) {
        if(root == null) return true;
        int leftHeight = calcDepth(root.left);
        int rightHeight = calcDepth(root.right);
        return Math.Abs(leftHeight - rightHeight) <= 1 && flag == true;
       
    }
    public int calcDepth(TreeNode root){
        if(root == null) return 0;
        int left = calcDepth(root.left);
        int right = calcDepth(root.right);
        
        if(!(Math.Abs(left - right) <= 1)) flag = false;
        return 1 + Math.Max(left, right);
    }
}