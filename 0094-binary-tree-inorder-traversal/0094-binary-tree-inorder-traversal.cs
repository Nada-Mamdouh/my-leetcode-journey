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
    public IList<int> InorderTraversal(TreeNode root) {
        IList<int> ans = new List<int>();
        DFS_IN(root, ref ans);
        return ans;
    }
    public void DFS_IN(TreeNode root, ref IList<int> tmp){
        if(root == null) return;
        DFS_IN(root.left, ref tmp);
        tmp.Add(root.val);
        DFS_IN(root.right, ref tmp);
    }
}