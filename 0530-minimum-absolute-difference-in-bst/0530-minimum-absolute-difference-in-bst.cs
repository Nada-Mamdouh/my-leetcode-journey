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
     List<int> aux = new();
    public int GetMinimumDifference(TreeNode root) {
        int min = int.MaxValue;
        DFS(root);
        for(int i = 0;i<aux.Count - 1;i++){
            int diff = Math.Abs(aux[i] - aux[i+1]);
            min = Math.Min(diff, min);
        }
        return min;
    }
    public void DFS(TreeNode root){
        if(root == null) return;
        DFS(root.left);
        aux.Add(root.val);
        DFS(root.right);
    }
}