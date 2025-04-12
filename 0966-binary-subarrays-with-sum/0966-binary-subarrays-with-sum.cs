public class Solution {
    public int NumSubarraysWithSum(int[] nums, int goal) {
        return CountAtMost(nums, goal) - CountAtMost(nums, goal - 1);
    }
    int CountAtMost(int[] nums, int goal){
        if(goal < 0) return 0;
        int l = 0, r = 0, cnt = 0, sum = 0;
        while(r < nums.Length){
            sum += nums[r];
            while(sum > goal){
                sum -= nums[l];
                l++;
            }
            cnt = cnt + (r-l+1);
            r++;
        }
        return cnt;
    }
}