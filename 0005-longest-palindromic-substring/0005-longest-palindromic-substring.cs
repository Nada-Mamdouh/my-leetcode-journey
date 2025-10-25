public class Solution {
    int start = 0, maxLength = 0;
    public string LongestPalindrome(string s) {
        if(s == null || s.Length < 2) return s;
        for(int i = 0;i<s.Length;i++){
            ExpandAroundCenters(s, i, i);
            ExpandAroundCenters(s, i, i+1);
        }
        return s.Substring(start, maxLength);
    }
    void ExpandAroundCenters(string s, int left, int right){
        while(left >= 0 && right < s.Length && s[left] == s[right]){
            left--;
            right++;
        }
        int currLength = right - left - 1;
        if(currLength > maxLength){
            maxLength = currLength;
            start = left + 1;
        }
    }
}