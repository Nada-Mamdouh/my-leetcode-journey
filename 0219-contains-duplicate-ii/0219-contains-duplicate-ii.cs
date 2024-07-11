public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        for(int i = 0;i<nums.Length;i++){
            if(dict.ContainsKey(nums[i])){
                int diff = Math.Abs(dict[nums[i]] - i);
                if(diff <= k){
                    return true;
                }else{
                    dict.Remove(nums[i]);
                }
            }
            dict.Add(nums[i],i);
        }
        return false;
    }
}