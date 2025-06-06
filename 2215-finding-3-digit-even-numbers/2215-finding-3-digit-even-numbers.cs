public class Solution {
    public int[] FindEvenNumbers(int[] digits) {
        HashSet<int> nums = new HashSet<int>();
        int n = digits.Length;
        // Traverse the indices of three digits
        for (int i = 0; i < n; ++i) {
            for (int j = 0; j < n; ++j) {
                for (int k = 0; k < n; ++k) {
                    // Determine whether it meets the condition of the target
                    // even number
                    if (i == j || j == k || i == k) {
                        continue;
                    }
                    int num = digits[i] * 100 + digits[j] * 10 + digits[k];
                    if (num >= 100 && num % 2 == 0) {
                        nums.Add(num);
                    }
                }
            }
        }
        // Converted to an array sorted in ascending order
        List<int> res = nums.ToList();
        res.Sort();
        return res.ToArray();
    }
}