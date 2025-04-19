public class Solution {
    public bool CanJump(int[] nums) {
        int maxIndex = 0;
        for(int i = 0;i<nums.Length;i++){
            if(i > maxIndex) return false;
            maxIndex = Math.Max(maxIndex, i+nums[i]);
        }
        return true;
    }
}