public class Solution {
    IList<IList<int>> result = new List<IList<int>>();
    public IList<IList<int>> Subsets(int[] nums) {
       BackTrack(ref nums, 0, new List<int>());
       return result;
    }
    void BackTrack(ref int[] nums, int idx, List<int> ds){
        if(idx == nums.Length){
            result.Add(new List<int>(ds));
            return;
        }
        //pick
        ds.Add(nums[idx]);
        BackTrack(ref nums, idx + 1, ds);
        ds.RemoveAt(ds.Count - 1);

        //not pick
        BackTrack(ref nums, idx + 1, ds);
    }
   
    
}