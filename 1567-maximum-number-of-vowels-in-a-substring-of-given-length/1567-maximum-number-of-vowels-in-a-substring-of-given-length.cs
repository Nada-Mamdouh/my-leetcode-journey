public class Solution {
    public int MaxVowels(string s, int k) {
        //TC:O(n/k) - SC:O(1)
        int vowlCnt = 0, maxCnt = 0;
        for(int i = 0;i<k;i++){
            if(IsVowel(s[i])) vowlCnt++;
        }
        maxCnt = vowlCnt;
        for(int i = k;i<s.Length;i++){
            if(IsVowel(s[i-k])) vowlCnt--;
            if(IsVowel(s[i])) vowlCnt++;
            maxCnt = Math.Max(maxCnt,vowlCnt);
        }
        return maxCnt;
    }
    public bool IsVowel(char c) => c == 'a' || c == 'e' ||c== 'i' || c == 'o' || c == 'u';
}