public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int n = nums.Length;
        List<int> ans = new List<int>();
        for(int i = 0;i<2 * n;i++) ans.Add(0);
        for(int i = 0;i<n;i++){
            ans[i] = nums[i];
            ans[i + n] = nums[i];
        }
        return ans.ToArray();
    }
}