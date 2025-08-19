public class Solution {
    IList<IList<int>> res = new List<IList<int>>();
    public IList<IList<int>> Permute(int[] nums) {
        GeneratePermutations(ref nums, new List<int>(), new bool[nums.Length]);
        return res;
    }
    void GeneratePermutations(ref int[] nums, List<int> ds, bool[] freq){
        if(ds.Count == nums.Length){
            res.Add(new List<int>(ds));
            return;
        }
        for(int i = 0; i<nums.Length;i++){
            if(!freq[i]){
                freq[i] = true;
                ds.Add(nums[i]);

                GeneratePermutations(ref nums, ds, freq);
                ds.RemoveAt(ds.Count - 1);
                freq[i] = false;
            }
        }
        
        
    }
}