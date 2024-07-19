public class Solution {
    public int SingleNumber(int[] nums) {
        HashSet<int> data = new HashSet<int>();
        for(int i = 0;i<nums.Length;i++){
            if(data.Contains(nums[i])) data.Remove(nums[i]);
            else{
                data.Add(nums[i]);
            }
        }
        return data.ToList()[0];
    }
}