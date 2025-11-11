public class Solution {
    IList<IList<int>> ans = new List<IList<int>>();
    public IList<IList<int>> Subsets(int[] nums) {
        BackTrack(ref nums, 0, new List<int>());
        return ans;
    }
    void BackTrack(ref int[] nums,int idx, List<int> lst){
        ans.Add(new List<int>(lst));
        for(int i = idx;i<nums.Length;i++){
            lst.Add(nums[i]);
            BackTrack(ref nums, i + 1, lst);
            lst.RemoveAt(lst.Count - 1);
        }
    }
}