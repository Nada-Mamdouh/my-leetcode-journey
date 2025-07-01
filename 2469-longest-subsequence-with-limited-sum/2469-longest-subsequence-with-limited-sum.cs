public class Solution {
    public int[] AnswerQueries(int[] nums, int[] queries) {
        Array.Sort(nums); // Step 1: Sort nums to pick smallest values first

        // Step 2: Build prefix sum array
        int n = nums.Length;
        int[] prefix = new int[n];
        prefix[0] = nums[0];
        for (int i = 1; i < n; i++) {
            prefix[i] = prefix[i - 1] + nums[i];
        }

        // Step 3: Answer each query using binary search
        int[] result = new int[queries.Length];
        for (int i = 0; i < queries.Length; i++) {
            result[i] = UpperBound(prefix, queries[i]);
        }

        return result;
    }
    // Binary search to find the number of elements whose prefix sum <= query
    private int UpperBound(int[] prefix, int target) {
        int left = 0, right = prefix.Length - 1, ans = 0;
        while (left <= right) {
            int mid = left + (right - left) / 2;
            if (prefix[mid] <= target) {
                ans = mid + 1; // +1 because count is index + 1
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }
        return ans;
    }
}