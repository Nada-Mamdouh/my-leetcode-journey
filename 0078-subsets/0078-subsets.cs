public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
       var result = new List<IList<int>>();
       Backtrack(nums, 0, new List<int>(), result);
       return result;
    }
    void Backtrack(int[] nums, int idx, List<int> current,List<IList<int>> result){
        if(idx == nums.Length){
            result.Add(new List<int>(current));
            return;
        }
        current.Add(nums[idx]);
        Backtrack(nums,idx+1,current,result);
        current.RemoveAt(current.Count - 1);
        Backtrack(nums,idx+1,current,result);
    }
    
}