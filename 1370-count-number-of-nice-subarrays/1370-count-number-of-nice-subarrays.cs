public class Solution {
    public int NumberOfSubarrays(int[] nums, int k) {
        return findCnt(nums, k) - findCnt(nums, k-1);
    }
    int findCnt(int[] nums, int k){
        if(k < 0) return 0;
        int n = nums.Length, l = 0, r = 0, numOfOdds = 0, niceSubCnt = 0;
        while(r < n){
            if((nums[r] & 1) == 1)numOfOdds++;
            while(numOfOdds > k){
                if((nums[l] & 1) == 1) numOfOdds--;
                l++;
            }
            if(numOfOdds <= k) niceSubCnt += (r - l + 1);
            r++;
        }
        return niceSubCnt;
    }

}