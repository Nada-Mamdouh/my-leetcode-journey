public class Solution {
    public int SingleNumber(int[] nums) {
        Array.Sort(nums);
        int ans = 0;
        bool isUnique = true;
        for(int i = 0;i<nums.Length;i++){
            ans ^= nums[i];
        }
        return ans;
    }
}