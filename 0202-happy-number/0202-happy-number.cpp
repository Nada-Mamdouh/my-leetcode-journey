class Solution {
public:
    bool isHappy(int n) {
        //if(n > 1 && n < 10) return false;
        unordered_set<int> hashset;
        long ans = n, tmp = 0;
        while(tmp != 1){
            while(n > 0){
                tmp += (n % 10) * (n % 10);
                n /= 10;
            }
            if(tmp == 1) return true;
            if(hashset.find(tmp) != hashset.end()) return false;
            else hashset.insert(tmp);
            n = tmp;
            tmp = 0;
        }
        return true;
    }
};