public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        int n = nums.Length, windowSum = 0;
        int maxSum = int.MinValue;
        for(int i = 0;i<k;i++){
            windowSum += nums[i];
        }
        maxSum = windowSum;
        for(int i = k;i<n;i++){
            windowSum += nums[i] - nums[i-k];
            maxSum = Math.Max(maxSum, windowSum);
        }
        return (double) maxSum / (double) k;
    }
}