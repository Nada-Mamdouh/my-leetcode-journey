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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        Queue<TreeNode> currentLevelQ = new Queue<TreeNode>();
        Queue<TreeNode> nextLevelQ = new Queue<TreeNode>();
        IList<IList<int>> res = new List<IList<int>>();
        
        if(root == null) return res;
        currentLevelQ.Enqueue(root);
        
        while(currentLevelQ.Count > 0){
            IList<int> subres = new List<int>();
            
            while(currentLevelQ.Count > 0){
                TreeNode curr = currentLevelQ.Dequeue();
                
                if(curr.left != null){
                    nextLevelQ.Enqueue(curr.left);
                }
                if(curr.right != null){
                    nextLevelQ.Enqueue(curr.right);
                }
                subres.Add(curr.val);
            }
            res.Add(subres);
            
            //swap:
            Queue<TreeNode> tmp = currentLevelQ;
            currentLevelQ = nextLevelQ;
            nextLevelQ = tmp;
        }
        
        
        
        return res;
    }
}