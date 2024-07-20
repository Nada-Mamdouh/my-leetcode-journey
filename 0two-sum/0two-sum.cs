public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        int[] res = new int[2];
        for(int i = 0;i<nums.Length;i++){
            int complement = target - nums[i];
            if(dict.ContainsKey(complement)){
                res[0] = dict[complement];
                res[1] = i;
                break;
            }
            
            
            
            if(!dict.ContainsKey(nums[i])){
                dict.Add(nums[i],i);
            }
        }
        return res;
    }
}