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
    public bool IsCompleteTree(TreeNode root) {
        return BFS(root);
    }
    public bool BFS(TreeNode root){
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        
        while(q.Count > 0){
            var curr = q.Dequeue();
            if(curr == null && q.Count > 0){
                while(q.Count > 0){
                    var inCurr = q.Dequeue();
                    if(inCurr != null) return false;
                }
            }  
            if(curr != null){
                q.Enqueue(curr.left);
                q.Enqueue(curr.right);
            }
            
        }
        return true;
    }
    
}