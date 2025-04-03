public class Solution {
    public bool IsSubsequence(string s, string t) {
        int sLen = s.Length, tLen = t.Length;
        int right = 0;
        for(int i = 0;i<s.Length;i++){
            while(i <= right && right < tLen && t[right] != s[i]){
                right++;
            }
            if(i <= right && right < tLen && t[right] == s[i]){
                right++;
            }else{
                return false;
            }
        }
        return true;
        
    }
}