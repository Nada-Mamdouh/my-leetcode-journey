public class Solution {
    public int LongestOnes(int[] nums, int k) {
        //Better solution
        //Sliding window
        //TC: O(2n) - SC: O(1)
        int n = nums.Length, maxLen = 0, l = 0, r = 0, zeros = 0;
        while(r < n){
            if(nums[r] == 0) zeros++;
            while(zeros > k){
                if(nums[l] == 0) {
                    zeros--;
                }
                l++;
            }
            if(zeros <= k){
                int len = r - l + 1;
                maxLen = Math.Max(len, maxLen);
            }
            r++;
        }
        return maxLen;
    }
}