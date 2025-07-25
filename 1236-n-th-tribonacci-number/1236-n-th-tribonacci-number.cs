public class Solution {
    int[] dp = new int[38];
    public int Tribonacci(int n) {
        if(n <= 1) return n;
        if(n == 2) return 1;
        if(dp[n] != 0) return dp[n];
        return dp[n] = Tribonacci(n-1) + Tribonacci(n-2) + Tribonacci(n -3);
    }
}