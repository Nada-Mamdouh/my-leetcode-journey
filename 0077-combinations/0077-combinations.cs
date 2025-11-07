public class Solution {
    IList<IList<int>> ans = new List<IList<int>>();
    public IList<IList<int>> Combine(int n, int k) {
        List<int> nums= new List<int>();
        for(int i=1;i<=n;i++) nums.Add(i);
        backtrack(ref nums, 0,k, new List<int>());
        return ans;
    }
    void backtrack(ref List<int> nums , int start, int k,List<int> lst){
        if(lst.Count == k){
              ans.Add(new List<int>(lst));
              return;
        }
        for(int i=start;i<nums.Count;i++){
            lst.Add(nums[i]);
            backtrack(ref nums, i + 1,k,lst);
            lst.RemoveAt(lst.Count - 1);
        }
    }
}