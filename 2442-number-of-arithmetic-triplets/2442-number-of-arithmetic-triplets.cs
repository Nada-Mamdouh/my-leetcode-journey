public class Solution {
    public int ArithmeticTriplets(int[] nums, int diff) {
        int ans = 0;
        HashSet<int> sett = new HashSet<int>();
        for(int i = 0;i<nums.Length;i++){
            int dif1 = nums[i] - diff;
            int dif2 = nums[i] - 2 * diff;
            if(sett.Contains(dif1) && sett.Contains(dif2)){
                ans++;
            }
            sett.Add(nums[i]);
        }
        return ans;
    }
}