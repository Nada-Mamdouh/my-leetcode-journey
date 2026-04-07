class Solution {
public:
    vector<int> finalPrices(vector<int>& prices) {
        stack<pair<int,int>> st;
        vector<int> ans(prices.size());
        for(int i = 0;i < prices.size() ;i++){
            while(!st.empty() &&  prices[i] <= st.top().second){
                int price = st.top().second - prices[i];
                ans[st.top().first] = price;
                st.pop();
            }
            st.push({i,prices[i]});
        }
        while(!st.empty()){
            ans[st.top().first] = st.top().second;
            st.pop();
        }
        return ans;

    }
};