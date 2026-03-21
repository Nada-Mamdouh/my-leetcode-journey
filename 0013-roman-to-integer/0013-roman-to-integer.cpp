class Solution {
public:
    unordered_map<char, int> mpp = {
            {'I',1},
            {'V',5},
            {'X',10},
            {'L',50},
            {'C',100},
            {'D',500},
            {'M',1000}
        };
    unordered_map<string, int> min_mpp = {
        {"IV",4},
        {"IX",9},
        {"XL",40},
        {"XC",90},
        {"CD",400},
        {"CM",900}
    };
    int romanToInt(string s) {
        int n = s.size(), ans = 0;
        for(int i = 0;i<n;i++){
            if(i != n-1 && getMinusOp(s[i], s[i+1]) != -1){
                ans += getMinusOp(s[i],s[i+1]);
                i++;
            }else{
                ans += mpp[s[i]];
            }
        }
        return ans;
    }
    int getMinusOp(char c1, char c2){
        string conc = "";
        conc += c1;
        conc += c2;
        if(min_mpp.count(conc) == 1)return min_mpp[conc];
        return -1;
    }
};