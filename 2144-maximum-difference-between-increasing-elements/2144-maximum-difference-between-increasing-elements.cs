public class Solution {
    public int MaximumDifference(int[] nums) {
        int n = nums.Length, maxDiff = -1;
        for(int i = 0;i<n;i++){
            for(int j = i + 1;j<n;j++){
                if(j > i && nums[j] > nums[i]){
                    maxDiff = Math.Max(maxDiff, (nums[j] - nums[i]));
                }
            }
        }
        return maxDiff;

    }
}