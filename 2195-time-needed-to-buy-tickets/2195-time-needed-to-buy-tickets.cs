public class Solution {
    public int TimeRequiredToBuy(int[] tickets, int k) {
        int ans = 0;
        for(int i = 0;i<tickets.Length;i++){
            if(i <= k) ans += Math.Min(tickets[i],tickets[k]);
            if(i > k) ans += Math.Min(tickets[i], tickets[k]-1);
        }
        return ans;
    }
}