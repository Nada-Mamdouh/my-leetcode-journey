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
    public int KthSmallest(TreeNode root, int k) {
        int r = k;
        List<int> data = new List<int>();
        GETKthEle(root,ref data);
        return data[k-1];
        
    }
    
    public void GETKthEle(TreeNode root, ref List<int> data){
        if(root == null) return;
        
        GETKthEle(root.left, ref data);
        data.Add(root.val);
        GETKthEle(root.right, ref data);
    }
   
    
}