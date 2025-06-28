public class Solution {
    public int MaxProfit(int[] prices) {
        int profit = 0, n = prices.Length;
        int buyingPrice = prices[0];
        for(int i = 0;i<n;i++){
            if(prices[i] > buyingPrice) profit = Math.Max(profit, prices[i] - buyingPrice);
            else buyingPrice = prices[i];
        }
        return profit;
    }
}