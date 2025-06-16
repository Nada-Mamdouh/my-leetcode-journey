public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int min = prices[0];
        for(int i = 1;i<prices.Length;i++){
            if(prices[i] - min > maxProfit){
                maxProfit = Math.Max(maxProfit, prices[i] - min);
            }
            if(prices[i] < min){
                min = prices[i];
            }
        }
        return maxProfit;
    }
}