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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        if(root == null) return new List<IList<int>>();
        IList<IList<int>> ans = new List<IList<int>>();
        Queue<TreeNode> q = new Queue<TreeNode>();
        int level = 0;
        
        q.Enqueue(root);
        while(q.Count > 0){
            IList<int> res = new List<int>();
            var qCount = q.Count;
            
            for(int i = 0;i<qCount;i++){
                var curr = q.Dequeue(); 
                if(curr != null) {
                    res.Add(curr.val);
                    if(curr.left != null ) q.Enqueue(curr.left);
                    if(curr.right != null) q.Enqueue(curr.right);
                }
            }
            if(level % 2 != 0) ReverseList(res);
            level++;
            ans.Add(res);
        } 
        
        return ans;
    }
    
    public IList<int> ReverseList(IList<int> data){
        int j = 0, i = data.Count - 1;
        while(i > j){
            int tmp = data[i];
            data[i] = data[j];
            data[j] = tmp;
            j++;
            i--;
        }
        return data;
    }
    
}