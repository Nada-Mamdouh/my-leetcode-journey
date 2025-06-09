public class Solution {
    public int NumSubarraysWithSum(int[] nums, int goal) {
        return findCnt(nums, goal) - findCnt(nums, goal - 1);
    }
    int findCnt(int[] nums, int goal){
        int n = nums.Length, l = 0, r = 0, sum = 0, cnt = 0;
        if(goal < 0) return 0;
        while(r < n){
            sum += nums[r];
            while(sum > goal){
                sum -= nums[l];
                l++;
            }
            if(sum <= goal) cnt += (r - l + 1);
            r++;
        }
        return cnt;
    }
}