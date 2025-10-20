public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int n = s.Length, maxLen = 0, l = 0, r = 0;
        int[] hash = new int[256];
        while(r < n && l < n && l <= r){
            while(hash[s[r]] >= 1){
                if(hash[s[l]] >= 1){
                    hash[s[l]]--;
                }
                l++;
                maxLen = Math.Max(maxLen, r - l + 1);
            }
            hash[s[r]]++;
            maxLen = Math.Max(maxLen, r - l + 1);
            r++;
        }
        return maxLen;
    }
}