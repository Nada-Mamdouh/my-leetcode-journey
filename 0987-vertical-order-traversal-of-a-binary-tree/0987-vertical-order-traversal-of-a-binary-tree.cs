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
    SortedDictionary<int, List<(int, int)>> dict = new();
    
    public IList<IList<int>> VerticalTraversal(TreeNode root) {
        IList<IList<int>> ans = new List<IList<int>>();
        Traverse(root, 0,0);
       
        foreach (var kvp in dict) {
            var sortedValues = kvp.Value.OrderBy(x => x.Item1)
                .ThenBy(x => x.Item2).Select(x => x.Item2).ToList();
            ans.Add(sortedValues);
        }
        
        return ans;
    }
    public void Traverse(TreeNode root,int row, int col){
        if(root == null) return;
        if(dict.ContainsKey(col)) dict[(col)].Add((row, root.val));
        else{
            dict.Add((col),new List<(int,int)>(){(row,root.val)});
        }
        Traverse(root.left, row + 1, col -1);
        Traverse(root.right, row + 1, col + 1);
    }
}