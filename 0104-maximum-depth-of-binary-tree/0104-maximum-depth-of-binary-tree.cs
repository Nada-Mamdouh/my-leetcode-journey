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
    public int MaxDepth(TreeNode root) {
        return DFS(root);
    }
    public int DFS(TreeNode node){
        if(node == null) return 0;
        int leftLen = DFS(node.left);
        int rightLen = DFS(node.right);
        int val =  Math.Max(leftLen, rightLen) + 1;
        return val;
    }
   
}