public class Solution {
    public string ReverseVowels(string s) {
        int n = s.Length;
        int j = 0, k = n-1;
        var sArr = s.ToCharArray();
        while( j < k){
            if(IsVowel(s[j]) && IsVowel(s[k])){
                sArr[j] = s[k];
                sArr[k] = s[j];
                j++;
                k--;
            }else if(IsVowel(s[j])) k--;
            else j++;
        }
        return new String(sArr);
    }
    bool IsVowel(char c)=> c == 'a' || c == 'e' || c == 'i' || c == 'o' || c== 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U';
}