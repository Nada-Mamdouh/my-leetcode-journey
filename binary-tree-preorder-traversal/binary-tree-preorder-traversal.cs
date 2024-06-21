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
    public IList<int> PreorderTraversal(TreeNode root) {
        Stack<TreeNode> treeStack = new Stack<TreeNode>();
        IList<int> res = new List<int>();
        
        if(root == null) return res;
        treeStack.Push(root);
        while(treeStack.Count > 0){
            TreeNode curr = treeStack.Pop();
            res.Add(curr.val);
            
            if(curr.right != null){
                treeStack.Push(curr.right);
            }
            if(curr.left != null){
                treeStack.Push(curr.left);
            }
            
        }
        return res;
    }
}