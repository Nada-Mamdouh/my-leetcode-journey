public class Solution {
    public int NumberOfSubarrays(int[] nums, int k) {
        return NumberOfSub(nums, k) - NumberOfSub(nums, k-1);
    }
    int NumberOfSub(int[] nums, int k){
        if(k < 0) return 0;
        int l = 0, r = 0, sum = 0,cnt = 0;
        while(r < nums.Length){
            sum += (nums[r] % 2);
            while(sum > k){
                sum -= (nums[l] % 2);
                l++;
            }
            cnt = cnt + (r - l + 1);
            r++;
        }
        return cnt;
    }
}