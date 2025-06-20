public class Solution {
    public int SumOddLengthSubarrays(int[] arr) {
        int n = arr.Length;
        int[] prefix = new int[n + 1];
        prefix[0] = 0;

        // Build prefix sum array
        for (int i = 0; i < n; i++) {
            prefix[i + 1] = prefix[i] + arr[i];
        }

        int total = 0;

        // Iterate over all possible odd lengths
        for (int length = 1; length <= n; length += 2) {
            for (int start = 0; start + length <= n; start++) {
                int end = start + length;
                total += prefix[end] - prefix[start];
            }
        }

        return total;
    }
}
