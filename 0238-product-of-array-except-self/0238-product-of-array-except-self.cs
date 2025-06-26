public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        //TC: O(3n) - SC: O(n2)

        // This problem using prefix & suffix algorithm but instead of prefix sum it's prefix
        // multiplication
        // If we used division that would be easy one 
        // ---------------------------
        // 1- Create Prefix array:
        int n = nums.Length;
        int[] prefix = new int[n];
        prefix[0] = nums[0];
        for(int i = 1;i<n;i++) prefix[i] = prefix[i-1] * nums[i];

        //2- Create suffix array:
        int[] suffix = new int[n];
        suffix[n-1] = nums[n-1];
        for(int i = n-2;i>=0;i--) suffix[i] = suffix[i+1] * nums[i];

        //3- Getting / populating the answer
        int[] ans = new int[n];
        for(int i = 0;i<n;i++){
            if(i == 0) ans[i] = suffix[i+1];
            else if(i == n-1) ans[i] = prefix[i-1];
            else ans[i] = prefix[i-1] * suffix[i+1];
        }
        return ans;
    }
}