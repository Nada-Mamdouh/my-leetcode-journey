public class Solution {
    public long CountSubarrays(int[] nums, int k) {
        long ans = 0, maxele = 0, n = nums.Length, maxelecount = 0;
        int l = 0, r = 0;
        for(int i = 0;i<n;i++){
            maxele = Math.Max(maxele, nums[i]);
        }
        while(r < n){
            if(nums[r] == maxele){
                maxelecount++;
            }
            while(maxelecount >= k){
                ans+=(n-r);
                if(nums[l] == maxele) {
                    maxelecount--;
                }
                l++;
            }
            r++;
        }
        return ans;
        
    }
}