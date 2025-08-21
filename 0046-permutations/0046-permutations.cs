public class Solution {
    //Another solution - no extra map
    IList<IList<int>> res = new List<IList<int>>();
    public IList<IList<int>> Permute(int[] nums) {
        GeneratePermutations(ref nums, 0);
        return res;
    }
    void GeneratePermutations(ref int[] nums, int idx){
        if(idx == nums.Length){
            res.Add(new List<int>(nums.ToList()));
            return;
        }
        for(int i = idx;i<nums.Length;i++){
            swap(ref nums, i, idx);
            GeneratePermutations(ref nums, idx + 1);
            swap(ref nums , i , idx);
        }
    }
    void swap(ref int[] nums, int i , int j){
        int tmp = nums[i];
        nums[i] = nums[j];
        nums[j] = tmp;
    }
}