public class Solution {
    public int ArithmeticTriplets(int[] nums, int diff) {
        int ans = 0;
        for(int i = 0;i<nums.Length - 2;i++){
            for(int j = i + 1;j<nums.Length -1;j++){
                for(int k = j + 1;k<nums.Length;k++){
                    if(k > j && j > i && nums[k] - nums[j] == diff && nums[j] - nums[i] == diff) ans++;
                }
            }
        }
        return ans;
    }
}