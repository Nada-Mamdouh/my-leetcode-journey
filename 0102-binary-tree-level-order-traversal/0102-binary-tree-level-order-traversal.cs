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
        var q = new Queue<TreeNode>();
        IList<IList<int>> ans = new List<IList<int>>();
        if(root == null) return ans;
        q.Enqueue(root);

        while(q.Count > 0){
            int levelsize = q.Count;
            List<int> level = new List<int>();
            for(int i = 0;i<levelsize;i++){
                TreeNode curr = q.Dequeue();
                level.Add(curr.val);
                if(curr.left != null) q.Enqueue(curr.left);
                if(curr.right != null) q.Enqueue(curr.right);
            }
            ans.Add(level);
        }
        return ans;

    }
}