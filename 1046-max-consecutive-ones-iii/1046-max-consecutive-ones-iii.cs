public class Solution {
    public int LongestOnes(int[] nums, int k) {
        int n = nums.Length, zeroesCnt = 0;
        int l = 0, r = 0, maxCons = 0, windowMax = 0;
        while(r < n){
            if(nums[r] == 1) windowMax = r - l + 1;
            if(nums[r] == 0 && zeroesCnt <= k){
                zeroesCnt++;
                windowMax = r - l + 1;
            }
            while(zeroesCnt > k){
                if(nums[l] == 0) zeroesCnt--;
                l++;
                windowMax = r - l + 1;
            }

            maxCons = Math.Max(maxCons, windowMax);
            r++;
        }
        return maxCons;
    }
}