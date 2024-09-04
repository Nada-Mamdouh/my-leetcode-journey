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
    public int MinDepth(TreeNode root) {
        if(root == null) return 0;
        int left = 1 + MinDepth(root.left);
        int right = 1 + MinDepth(root.right);
        Console.WriteLine("left from inside "+left);
        Console.WriteLine("right from inside "+right);
        if(left == 1 && right == 1) return 1;
        else if(left == 1) return right;
        else if(right == 1) return left;
        else{
            return Math.Min(left, right);
        }
    }
    // public int GetNodesCount(TreeNode root){
    //     if(root == null) return 0;
    //     int left = 1 + GetNodesCount(root.left);
    //     int right = 1 + GetNodesCount(root.right);
    //     Console.WriteLine("left from inside "+left);
    //     Console.WriteLine("right from inside "+right);
    //     return Math.Min(left, right);
    // }
}