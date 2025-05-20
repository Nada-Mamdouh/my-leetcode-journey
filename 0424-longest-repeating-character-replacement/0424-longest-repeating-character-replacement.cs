public class Solution {
    public int CharacterReplacement(string s, int k) {
        int l = 0,r = 0, maxLen = 0, maxFreq = 0;
        int[] hash = new int[26];
        while(r < s.Length){
            hash[s[r] - 'A']++;
            maxFreq = Math.Max(maxFreq, hash[s[r] - 'A']);
            if( (r-l+1) - maxFreq > k){
                hash[s[l] - 'A']--; 
                l++;
            }
            maxLen = Math.Max(maxLen, r - l + 1);
            r++;
        }
        return maxLen;

    }
}