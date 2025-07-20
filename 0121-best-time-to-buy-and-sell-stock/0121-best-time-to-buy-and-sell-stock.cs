public class Solution {
    public int MaxProfit(int[] prices) {
        int minPrice = int.MaxValue;
        int profit = 0;
        for(int i = 0;i<prices.Length;i++){
            minPrice = Math.Min(minPrice, prices[i]);
            profit = Math.Max(profit, prices[i] - minPrice);
        }
        return profit;
    }
}