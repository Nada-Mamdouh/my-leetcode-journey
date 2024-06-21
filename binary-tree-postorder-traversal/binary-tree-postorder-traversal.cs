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
    public IList<int> PostorderTraversal(TreeNode root) {
        Stack<TreeNode> s1 = new Stack<TreeNode>();
        Stack<TreeNode> s2 = new Stack<TreeNode>();
        IList<int> lst = new List<int>();
        
        if(root == null) return lst;
        s1.Push(root);
        while(s1.Count > 0){
            TreeNode current = s1.Pop();
            s2.Push(current);
            
            if(current.left != null){
                s1.Push(current.left);
            }
            if(current.right != null){
                s1.Push(current.right);
            }
        }
        
        while(s2.Count > 0){
            TreeNode current = s2.Pop();
            lst.Add(current.val);
        }
        return lst;
    }
}