public class Solution {
    public int MaxScore(int[] cardPoints, int k) {
        int n = cardPoints.Length;
        int totalSum = cardPoints.Sum();
        
        // Edge case: If we need to take all cards
        if (n == k) return totalSum;

        // Find the minimum sum of a subarray of length (n-k)
        int windowSize = n - k;
        int windowSum = 0, minWindowSum;

        // Compute the initial window sum
        for (int i = 0; i < windowSize; i++) {
            windowSum += cardPoints[i];
        }
        minWindowSum = windowSum;

        // Slide the window across the array
        for (int i = windowSize; i < n; i++) {
            windowSum += cardPoints[i] - cardPoints[i - windowSize];
            minWindowSum = Math.Min(minWindowSum, windowSum);
        }

        // Maximum score is total sum minus the minimum window sum
        return totalSum - minWindowSum;
    }
}