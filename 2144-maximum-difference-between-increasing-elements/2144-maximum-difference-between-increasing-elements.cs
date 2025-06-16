public class Solution {
    public int MaximumDifference(int[] nums) {
        int minSoFar = nums[0];
        int diff = -1;
        for(int i = 1;i<nums.Length;i++){
            if(nums[i] > minSoFar){
                diff = Math.Max(diff, nums[i] - minSoFar);
            }
            if(nums[i] < minSoFar){
                minSoFar = nums[i];
            }
        }
        return diff;
    }
}