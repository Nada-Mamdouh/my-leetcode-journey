public class Solution {
    public int[] BuildArray(int[] nums) {
        //TC: O(n) 
        //SC: O(n) for returning 
        int n = nums.Length;
        int[] ans = new int[n];
        for(int i = 0;i<n;i++){
            int idx = nums[i];
            ans[i] = nums[idx];
        }
        return ans;
    }
}