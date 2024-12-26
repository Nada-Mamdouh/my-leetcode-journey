class Solution {
public:
    int maxProfit(vector<int>& prices) {
        //dp or might be a greedy algorithm:
        //TC: O(n) , SC: O(1)
        int n = prices.size(), mini = prices[0], maxProfit = 0;
        for(int i = 1;i<n;i++){
            int profit = prices[i] - mini;
            maxProfit = max(profit, maxProfit);
            mini = min(mini, prices[i]);
        }
        return maxProfit;
    }
};