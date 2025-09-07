public class Solution {
    public int ArithmeticTriplets(int[] nums, int diff) {
        int ans = 0;
        HashSet<int> sett = new HashSet<int>();
        for(int i = 0;i<nums.Length;i++){
            if(sett.Contains(nums[i] - diff) && sett.Contains(nums[i] - 2 * diff))
            ans++;
            sett.Add(nums[i]);
        }
        return ans;
    }
}