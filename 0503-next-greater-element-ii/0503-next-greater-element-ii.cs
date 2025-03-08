public class Solution {
    public int[] NextGreaterElements(int[] nums) {
        //Brute force:
        //TC: O(n^2) + O(n) - SC: O(n) for returning the result
        int n = nums.Length;
        int[] ans = new int[n];
        for(int i = 0; i<n;i++){
            ans[i] = -1;
        }
        for(int i = 0;i < n;i++){
            for(int j = i + 1; j <= (i + n - 1);j++){
                int idx = j % n;
                if(nums[i] < nums[idx]){
                    ans[i] = nums[idx];
                    break;
                }
            }
        }
        return ans;
    }
}