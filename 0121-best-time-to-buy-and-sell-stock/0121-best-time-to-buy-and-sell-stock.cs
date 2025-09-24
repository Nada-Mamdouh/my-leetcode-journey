public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0, buyingPrice = prices[0];
        for(int i =0;i<prices.Length;i++){
            maxProfit = Math.Max(maxProfit , prices[i] - buyingPrice);

            buyingPrice = Math.Min(buyingPrice, prices[i]);
        }
        return maxProfit;
    }
}