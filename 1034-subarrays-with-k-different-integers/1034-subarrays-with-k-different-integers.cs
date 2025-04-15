public class Solution {
    public int SubarraysWithKDistinct(int[] nums, int k) {
        return GetCount(nums, k) - GetCount(nums, k - 1);
    }
    int GetCount(int[] nums, int k) {
    int l = 0, r = 0, res = 0;
    Dictionary<int, int> freq = new Dictionary<int, int>();

    for (r = 0; r < nums.Length; r++) {
        if (!freq.ContainsKey(nums[r])) freq[nums[r]] = 0;
        if (freq[nums[r]] == 0) k--;  // new distinct number
        freq[nums[r]]++;

        while (k < 0) {
            freq[nums[l]]--;
            if (freq[nums[l]] == 0) k++;  // we removed a distinct number
            l++;
        }

        res += (r - l + 1); // all subarrays ending at r with at most k distinct
    }

    return res;
}
}