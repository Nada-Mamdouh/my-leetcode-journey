public class Solution {
    public int FindPeakElement(int[] nums) {
        int n = nums.Length;
        int peak = 0;
        for(int i = 1;i<n-1;i++){
            if(nums[i] > nums[i-1] && nums[i] > nums[i+1]){
                peak = i;
                break;
            }
        }
        if((peak == n - 2 || peak == 0 ) && nums[n-1] > nums[peak]) peak = n - 1;
        return peak;
    }
}