public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0, low = prices[0];
        for(int i = 1; i < prices.Length ;i++){
            low = Math.Min(low,prices[i]);
            
            maxProfit = Math.Max(maxProfit, prices[i] - low);
        }
        return maxProfit;
    }
}