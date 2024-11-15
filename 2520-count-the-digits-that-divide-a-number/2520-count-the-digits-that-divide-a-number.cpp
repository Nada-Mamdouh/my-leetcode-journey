class Solution {
public:
    int countDigits(int num) {
        int val = 0, numClone = num;
        string numStr = to_string(num);
        for(int i = 0;i<numStr.size();i++){
            auto numVal = num % 10;
            num /= 10;            
            if(numClone % numVal == 0){
                val++;
            }
        }
        return val;
    }
};