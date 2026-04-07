class Solution {
public:
    int timeRequiredToBuy(vector<int>& tickets, int k) {
        queue<pair<int,int>> q;
        int ans = 0;
        for(int i = 0;i<tickets.size();i++){
            q.push({i,tickets[i]});
        }
        while(!q.empty()){
            q.front().second -= 1;
            auto val = q.front();
            ans++;
            q.pop();
            if(val.second != 0){
                q.push(val);
            }
            if(val.first == k && val.second == 0) break;
        }
        return ans;
    }
};