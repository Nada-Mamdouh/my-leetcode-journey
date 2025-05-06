public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        int n = nums.Length;
        double maxAvg = double.MinValue;
        double windowAvg = 0; int windowSum = 0;
        for(int i = 0;i<k;i++){
            windowSum += nums[i];
        }
        windowAvg = (windowSum*1.0) / (k*1.0);
        maxAvg = windowAvg;
        for(int i = k;i<n;i++){
            windowSum -= nums[i-k];
            windowSum += nums[i];
            windowAvg = (windowSum*1.0) / (k*1.0);
            maxAvg = Math.Max(maxAvg, windowAvg);
        }
        return maxAvg;
    }
}