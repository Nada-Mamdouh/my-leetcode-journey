public class Solution {
    public int FindLHS(int[] nums) {
        Dictionary<int, int> freq = new();

    foreach (int num in nums) {
        if (!freq.ContainsKey(num))
            freq[num] = 0;
        freq[num]++;
    }

    int maxLength = 0;
    foreach (var kvp in freq) {
        int key = kvp.Key;
        if (freq.ContainsKey(key + 1)) {
            int length = freq[key] + freq[key + 1];
            maxLength = Math.Max(maxLength, length);
        }
    }

    return maxLength;
    }
}