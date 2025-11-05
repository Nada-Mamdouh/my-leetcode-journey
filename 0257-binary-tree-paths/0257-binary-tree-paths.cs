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
    IList<string> ans = new List<string>();
    public IList<string> BinaryTreePaths(TreeNode root) {
        if(root == null) return ans;
        BackTrack(root, "");
        return ans;
    }
    void BackTrack(TreeNode curr, string path){
        if(curr == null) return;
        if(path.Length != 0) path += "->";
        path += curr.val;
        if(curr.left == null && curr.right == null) {
            ans.Add(path);
        }
        BackTrack(curr.left, path);
        BackTrack(curr.right, path);
    }
}
