public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        //TC:O(2n) - SC: O(1)
        //Trying the follow-up - cheating from top beats 
        int n = nums.Length;
        int[] ans = new int[n];
        int prod = 1;
        //1- Going from right to left - right sum/mult
        for(int i = 0;i<n;i++){
            ans[i] = prod;
            prod *= nums[i];
        }
        //2- Going from left to right - left sum/mult
        prod = 1;
        for(int i = n-1;i>=0;i--){
            ans[i] = ans[i] * prod;
            prod *= nums[i];
        }
        return ans;
        
    }
}