class Solution {
public:
    string addStrings(string num1, string num2) {
        int n = num1.size() - 1, m = num2.size() - 1;
        int carry = 0;
        string ans = "";
        while(n >= 0 || m >= 0){
            int n1 = n >= 0 ? num1[n] - '0' : 0;
            int n2 = m >= 0 ? num2[m] - '0' : 0;

            int total = n1 + n2 + carry;

            if(total <= 9){
                ans += total + '0';
                carry = 0;
            }else{
                int ones = total % 10, tens = total / 10;
                ans += ones + '0';
                carry = tens;
            }
            n--; m--;
        }
        if(carry > 0) ans += carry + '0';
        reverse(ans.begin(),ans.end());
        return ans;
    }
};