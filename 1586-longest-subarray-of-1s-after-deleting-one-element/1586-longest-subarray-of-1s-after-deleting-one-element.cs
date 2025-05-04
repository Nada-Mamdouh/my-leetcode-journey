public class Solution {
    public int LongestSubarray(int[] nums) {
        int longestSub = 0, n = nums.Length, windowSize = 0;
        int l = 0, r = 0, zeroesCnt = 0;
        while(r < n){
            if(nums[r] == 1) windowSize = r - l + 1;
            else if(nums[r] == 0 && zeroesCnt <= 1){
                zeroesCnt++;
                if(zeroesCnt == 1) windowSize = r - l + 1;
            }
            while(zeroesCnt > 1){
                if(nums[l] == 0) zeroesCnt--;
                l++;
                windowSize = r - l + 1;
            }
            longestSub = Math.Max(longestSub, windowSize);
            r++;
        }
        return longestSub - 1;
    }
}