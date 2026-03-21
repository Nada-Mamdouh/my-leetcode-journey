class Solution {
public:
    string addBinary(string a, string b) {
        int n = a.size() - 1, m = b.size() - 1;
        string ans = "";
        int carry = 0;


        while(n >= 0 || m >= 0){
            int num1 = n >= 0 ? a[n] - '0' : 0;
            int num2 = m >= 0 ? b[m] - '0' : 0;

            int total = num1 + num2 + carry;
            if(total < 2){
                ans += total + '0';
                carry = 0;
            }else{
                ans += (total == 2)? '0':'1';
                carry = 1;
            }
            n--;m--;
        }
        if(carry == 1) ans += '1';
        reverse(ans.begin(),ans.end());
        return ans;
    }
};