public class Solution {
    IList<IList<int>> ans = new List<IList<int>>();
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        Array.Sort(candidates);
        findCombinations(ref candidates, target, 0, new List<int>());
        return ans;
    }
    void findCombinations(ref int[] nums, int target, int idx, List<int> ds){
        if(target == 0){
            ans.Add(new List<int>(ds));
            return;
        }
        for(int i = idx; i<nums.Length;i++){
            if(i > idx && nums[i] == nums[i-1]) continue;
            if(nums[i] > target) break;
            else{
                ds.Add(nums[i]);
                findCombinations(ref nums, target - nums[i] , i + 1, ds);
                ds.RemoveAt(ds.Count - 1);
            }
        }
    }
}