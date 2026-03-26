class Solution {
public:
    int lengthOfLastWord(string s) {
        int space1 = -1, space2 = -1;
        for(int i = s.size() - 1;i >= 0;i--){
            if(space1 == -1){
                if(s[i] != ' ') space1 = i;
            }else{
                if(s[i] == ' '){
                    space2 = i;
                    break;
                } 
            }
            
        }
        return space1 - space2;
    }
};