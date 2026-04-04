class Solution {
public:
    int balancedStringSplit(string s) {
        //since they're balanced with 2 characters, then they cancel each other out!
        int balance = 0, ans = 0;
        for(int i = 0;i<s.size();i++){
            if(s[i] == 'L'){
                balance++;
            }else{
                balance--;
            }
            if(balance == 0) ans++;
        }
        return ans;
    }
};