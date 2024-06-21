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
        TreeNode curr = root;
        IList<int> res = new List<int>();
        Stack<TreeNode> tree = new Stack<TreeNode>();
        
        if(root == null) return res;
        while(tree.Count > 0 || curr != null){
            while(curr != null){
                tree.Push(curr);
                curr = curr.left;
            }
            curr = tree.Pop();
            res.Add(curr.val);
            
            curr = curr.right;
        }
        return res;
    }
}