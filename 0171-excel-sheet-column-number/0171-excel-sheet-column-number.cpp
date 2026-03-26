class Solution {
public:
    int titleToNumber(string columnTitle) {
        int ans = 0;
        while(!columnTitle.empty()){
            char first = columnTitle.front();
            cout<<first<<endl;
            ans = ans * 26 + (first - 64);
            columnTitle.erase(0,1);
        }
        return ans;
    }
    int getCurrentCharValue(char c) {
        return c - 64;
    }
};