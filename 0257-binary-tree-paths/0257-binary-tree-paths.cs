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
    List<int> lst = new List<int>();
    public IList<string> BinaryTreePaths(TreeNode root) {
        BackTrack(root, root);
        return ans;
    }
    void BackTrack(TreeNode curr, TreeNode root){
        if(curr == null) return;
        if(curr.left == null && curr.right == null) {
            lst.Add(curr.val);
            ans.Add(mapListToString(lst));
            lst.RemoveAt(lst.Count - 1);
            return;
        }
        lst.Add(curr.val);
        BackTrack(curr.left, root);
        BackTrack(curr.right, root);
        lst.RemoveAt(lst.Count - 1);
    }
    string mapListToString(List<int> nums){
        StringBuilder sb = new StringBuilder();
        bool flag = true;
        foreach(var num in nums){
            if(flag){
                sb.Append(num);
                flag = false;
            }else{
                sb.Append("->"+num);
            }
        }
        return sb.ToString();
    }
}
