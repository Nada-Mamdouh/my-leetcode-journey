public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int prefixSum = 0, cnt = 0, n = nums.Length;
        Dictionary<int, int> dict = new();
        for(int i = 0;i<n;i++){
            if(!dict.ContainsKey(prefixSum)){
                dict.Add(prefixSum, 0);
            }
            dict[prefixSum]++;
            prefixSum += nums[i];
            int remove = prefixSum - k;
            if(dict.ContainsKey(remove)){
                cnt += dict[remove];
            }
        }

        return cnt;
    }
}